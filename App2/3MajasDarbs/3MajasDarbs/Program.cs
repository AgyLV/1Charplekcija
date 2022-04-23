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

car.NumZimSer = "BK";
car.NumZim = 7790;
car.Speed = 50;


car.BeepBeep();

Console.WriteLine();
Console.WriteLine("=================================");
Console.WriteLine();
//3. uzdevums

string name1 = "Termo krūze";
Prece prece1 = new Prece(name1);

prece1.Garums = 15.8;
prece1.Platums = 7.9;
prece1.Dimensija = 7.9;
prece1.Svars = 0.2;
prece1.Cena = 9.99;

prece1.Precesinfo();

string name2 = "Ūens pudele";
Prece prece2 = new Prece(name2);

prece2.Garums = 20.9;
prece2.Platums = 12.2;
prece2.Dimensija = 12.2;
prece2.Svars = 0.5;
prece2.Cena = 12.45;

Console.WriteLine();
prece2.Precesinfo();

string name3 = "Alumīnija krūze ovāla";
Prece prece3 = new Prece(name3);

prece3.Garums = 12.6;
prece3.Platums = 6.0;
prece3.Dimensija = 4.0;
prece3.Svars = 0.3;
prece3.Cena = 4.55;

Console.WriteLine();
prece3.Precesinfo();