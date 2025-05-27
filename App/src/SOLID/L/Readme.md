## O Princípio da Substituição de Liskov (LSP) é o "L" do SOLID e diz o seguinte:
> "Classes derivadas devem poder ser substituídas por 
suas classes base sem alterar o comportamento esperado
do programa."

<p>
 Ou seja, se você tiver uma classe base e substituí-la por uma subclasse, o programa deve continuar funcionando corretamente.
 Esse princípio é importante para garantir que o código seja modular e reutilizável.
<p/>

## 🧩 Cenário: Repositórios para Usuários
### 🧱 1. Interface Base
```csharp

public interface IUsuarioRepositorio
{
    Usuario ObterPorId(int id);
    void Adicionar(Usuario usuario);
}

```

## 🧍 2. Classe Usuario

```csharp
public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
}
```

## ✅ Implementações que seguem LSP
 
### 📦 Repositório padrão usando banco de dados
```csharp

public class UsuarioRepositorioSql : IUsuarioRepositorio
{
    public void Adicionar(Usuario usuario)
    {
        Console.WriteLine($"Usuário {usuario.Nome} adicionado no banco SQL.");
    }

    public Usuario ObterPorId(int id)
    {
        // Simulação
        return new Usuario { Id = id, Nome = "João (SQL)" };
    }
}
```
##  📦 Repositório mock para testes
```csharp
public class UsuarioRepositorioMock : IUsuarioRepositorio
{
    private List<Usuario> _usuarios = new List<Usuario>();

    public void Adicionar(Usuario usuario)
    {
        _usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} adicionado no mock.");
    }

    public Usuario ObterPorId(int id)
    {
        return _usuarios.FirstOrDefault(u => u.Id == id);
    }
}

```
## ✅ Uso comum (Substituição sem quebrar o sistema)

```csharp
public class ServicoDeCadastro
{
    private readonly IUsuarioRepositorio _repositorio;

    public ServicoDeCadastro(IUsuarioRepositorio repositorio)
    {
        _repositorio = repositorio;
    }

    public void CadastrarUsuario(string nome)
    {
        var usuario = new Usuario { Nome = nome };
        _repositorio.Adicionar(usuario);
    }
}

```

## 📌 Agora, podemos usar qualquer repositório:

```csharp

class Program
{
    static void Main()
    {
        IUsuarioRepositorio repositorioSql = new UsuarioRepositorioSql();
        IUsuarioRepositorio repositorioMock = new UsuarioRepositorioMock();

        var servico1 = new ServicoDeCadastro(repositorioSql);
        var servico2 = new ServicoDeCadastro(repositorioMock);

        servico1.CadastrarUsuario("Ana");
        servico2.CadastrarUsuario("Carlos");
    }
}

```


## ✅ Por que isso respeita o LSP?

- Qualquer implementação de IUsuarioRepositorio pode substituir outra sem quebrar o código.

- O ServicoDeCadastro não precisa saber se está lidando com SQL, mock, NoSQL, etc.

- Isso promove baixo acoplamento e flexibilidade.


a

