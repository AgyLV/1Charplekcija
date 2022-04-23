using _3MajasDarbs;

string Marka = "Ihone";
Telefons telefons = new Telefons(Marka);

telefons.Modelis = 23;
telefons.Scale1 = 45.6;
telefons.Zvana = true;
telefons.SMS = true;

bool VaiZvana = telefons.Zvana;
bool VaiSMS = telefons.SMS;

Console.WriteLine(VaiZvana);
Console.WriteLine(VaiSMS);