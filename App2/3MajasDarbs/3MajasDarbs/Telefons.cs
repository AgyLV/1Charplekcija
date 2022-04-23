namespace _3MajasDarbs
{
    public class Telefons
    {
        public Telefons(string name)
        {
            Marka = name;
        }

        public string Marka { get; set; }

        public double Scale1 { get; set; }

        public int Modelis { get; set; }

        public bool Zvana { get; set; }


        public bool SMS { get; set; }

       

        public void Informacija()
        {
            Console.WriteLine($"Labdien! Telefons {Marka} {Modelis} ir {Scale1} cm liels.");
        }
    }

        
}

//2. uzdevums