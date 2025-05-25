

namespace design_patterns.src.implicit_operators
{
    public class Phone
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string NumberPhone { get; set; } 


        public static implicit operator string(Phone phone) =>
              $"+{phone.CountryCode} ({phone.AreaCode}) {phone.NumberPhone}";
        

        public static implicit operator Phone(string phone)
        {
            string[] result =  phone.Split(" ");

            return new Phone { 
                CountryCode = result[0] , 
                AreaCode = result[1],
                NumberPhone = result[2] 
            };
        }

    }
}
