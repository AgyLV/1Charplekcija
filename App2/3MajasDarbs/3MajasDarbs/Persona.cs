namespace _3MajasDarbs
{
    internal class Persona
    {
        private string[] args;

        public Persona(string name)
        {
            Vards = name;
        }

        public Persona(string[] args)
        {
            this.args = args;
        }

        public string Vards { get; set; }

        public string Uzvards { get; set; }

        public DateTime Dzimis { get; set; }

        public string Hobijs { get; set; }

        public string Dzimums { get; set; }

        public int Vecums()
        {
            return DateTime.Now.Year - Dzimis.Year;
        }
       

        public void DatiParPersonu()
        {
            Console.WriteLine($"Sveiks! Man vārds ir {Vards} {Uzvards} un es esmu {Vecums}.");
            Console.WriteLine($"Mans hobijs ir {Hobijs} un mans dzimums ir {Dzimums}.");
        }
    }


}
