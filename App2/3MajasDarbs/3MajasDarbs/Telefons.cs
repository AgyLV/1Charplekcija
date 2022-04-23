
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

        public string Modelis { get; set; }

        public string Zvana { get; set; }

        public string SMS { get; set; }

        public void Informacija()
        {
            Console.WriteLine($"Labdien! Telefons {Marka} {Modelis} ir {Scale1} liels.");
        }
    }

        public void VaiZvans()
        {
        Console.WriteLine("telefonam ir zvana funkcija.");
        }

        public void VaiZina()
        {
        Console.WriteLine("Telefonam ir SMS fukcija.");
        }
    
}