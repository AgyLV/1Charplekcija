namespace _3MajasDarbs
{
    public class Car
    {
        public Car(string name)
        {
            Marka = name;
        }
        public string Marka { get; set; }

        public string NumZim { get; set; }

        public int Speed { get; set; }

       


        public void BeepBeep()
        {
            Console.WriteLine($"Auto {Marka} ar numurzīmi {NumZim}, kas brauc ar ātrumu {Speed} saka: beep beep");
        }
    }


}

   

