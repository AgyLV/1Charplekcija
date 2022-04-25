namespace _3MajasDarbs
{
    public class Car
    {
        public Car(string name)
        {
            Marka = name;
        }
        public string Marka { get; set; }

        public string NumZimSer { get; set; }

        public int NumZim { get; set; }

        public int Speed { get; set; }



        public void Uzsak()
        {
            Console.WriteLine($"Auto {Marka} ar numurzīmi {NumZimSer}{NumZim} sāk braukt.");
        }

        public void BeepBeep()


        {
            Console.WriteLine($"Auto {Marka} ar numurzīmi {NumZimSer}{NumZim}, kas brauc ar ātrumu {Speed} km/h saka: beep beep!");
        }

        public void Beidz()
        {
            Console.WriteLine($"Auto {Marka} ar numurzīmi {NumZimSer}{NumZim} apstājas.");
        }

    }
}

   

