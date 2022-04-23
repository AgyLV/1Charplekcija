namespace _3MajasDarbs
{
    public class Telefons
    {
        public Telefons(string name)
        {
            Brand = name;
        }

        public string Brand { get; set; }

        public double Scale1 { get; set; }

        public int Modelis { get; set; }

        public bool Zvana { get; set; }


        public bool SMS { get; set; }

       

        public void Informacija()
        {
            Console.WriteLine($"Labdien! Telefons {Brand} {Modelis} ir {Scale1} cm liels.");
        }
    }

        
}

