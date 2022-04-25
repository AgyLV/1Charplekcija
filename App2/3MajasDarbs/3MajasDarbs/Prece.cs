namespace _3MajasDarbs
{
    internal class Prece
    {
       
        public Prece(string name)
        {
            Nosaukums = name;
            
        }

        public string Nosaukums { get; set; }

        public double Garums { get; set;  }

        public double Platums { get; set; }

        public double Dimensija { get; set; }

        public double Svars { get; set; }

        public double Cena { get; set; } 




        public void Precesinfo()
        {
            Console.WriteLine($"Prece {Nosaukums}");
            Console.WriteLine($"Preces garums: {Garums} cm");
            Console.WriteLine($"Preces platums: {Platums} cm");
            Console.WriteLine($"Preces dziļums: {Dimensija} cm");
            Console.WriteLine($"Preces svars: {Svars} kg");
            Console.WriteLine($"Preces cena: {Cena} Eur");
        }
    }


}
