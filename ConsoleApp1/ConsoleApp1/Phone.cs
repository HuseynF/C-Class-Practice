namespace ConsoleApp1
{
    class Phone
    {
        public Phone(string Color, string Name,string Country)
        {
            color = Color;
            name = Name;
            country = Country;
        }
        public string color;
        public string name;
        public string country;
        private long _Imei;

        public void SetImei(long Number)
        {
            if (Number.ToString().Length >15 || Number < 0)
            {
                System.Console.WriteLine("Please write correctly"); 
            }
            else
            {
                _Imei = Number;
            }

    
        }   
        public long GetImei()
        {
            return _Imei;
        }
        public void Call(long num)
        {
            if(num.ToString().Length<9 || num > 0)
            {
                System.Console.WriteLine(num +" "+ " now calling");
            
            }
            else {
                System.Console.WriteLine("Wrong");
            }
            
        }
    }
}
