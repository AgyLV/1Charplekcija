//1. uzdevums

using _3MajasDarbs;

string Brand = "IPhone";
Telefons telefons = new Telefons(Brand);

telefons.Modelis = 23;
telefons.Scale1 = 45.6;
telefons.Zvana = true;
telefons.SMS = true;

bool VaiZvana = telefons.Zvana;
bool VaiSMS = telefons.SMS;

telefons.Informacija();
Console.WriteLine($"Telefona zvanu fukcija: {VaiZvana}");
Console.WriteLine($"Telefona SMS fukcija: {VaiSMS}");


Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine();
//2. uzdevums

string Marka = "BMW";
Car car = new Car(Marka);

car.NumZim = BK7790;
car.Speed = 50;


car.BeepBeep();