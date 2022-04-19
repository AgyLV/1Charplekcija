Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("1. uzdevums");

Console.Write("Kā tevi sauc?: ");  // noskaidro vārdu
string username = Console.ReadLine();

Console.WriteLine("Sveiks " + username); //sasveicinās

Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("2. uzdevums");

Console.Write("Kāds ir tavs vecums?: "); // noskaidro vecumu
string userage = Console.ReadLine();
int userageint = int.Parse(userage);

int nextyear = userageint + 1; //veic vecumu aprēķinus
bool FullAge = userageint >= 18;

Console.Write("Nākamgad tev paliks: " + nextyear + ",Tu esi pilngadīgs"); //iepazīstina ar rezultātu

Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("3 - 5. uzdevums");

Console.Write("Iedod skaitli: "); //palūgt skaitli
var userinput1 = Console.ReadLine();
int num1 = int.Parse(userinput1);
Console.Write("Iedod vēlvienu skaitli: "); //lai var kaut ko izdarīt palūdz otru skaitli
var userinput2 = Console.ReadLine();
int num2 = int.Parse(userinput2);

int hight = Math.Max(num1, num2); //darbība lai noskaidrotu lielāko no iedotajiem
Console.WriteLine("lielākais skaitlis ir: " + hight);

int low = Math.Min(num1, num2); //darbība lai noskaidrotu mazāko no iedotajiem
Console.WriteLine("Mazākais skaitlis ir: " + low);

int dev = num1 % num2; //darbība lai noskaidrotu dalījuma atlikumu
Console.WriteLine("Abu skaitļu dalījumu atlikums ir: " + dev);

Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("6. uzdevums");

Console.Write("Ievadi jebkādu skaitli, lai pārbaudītu vai tas ir pāra vai nepāra: "); // palūgt skaitli
var userinput3 = Console.ReadLine();
int num3 = int.Parse(userinput3);

bool even = num3 % 2 == 0; //pārbauda vai ir pāra

Console.Write("Skaitlis ir: " + even); //pāra ture, nepāra false


Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("7. uzdevums");


Console.Write("Ievadīt taisnstūra garāko malu cm: "); // paprasa malu garumu 
double num4 = double.Parse(Console.ReadLine()); // pielāgo decimālzīmi
Console.Write("Ievadīt taisnstūra īsāko malu cm: ");  //paprasa malu garumu 
double num5 = double.Parse(Console.ReadLine()); // pielāgo decimālzīmi


double laukums = num4 * num5; //veic aprēķinu ar dotajiem malu garumiem

double area = Math.Round(laukums, 2); //noapaļo divas zīmes aiz komata

Console.WriteLine("Taisnstūra laukums ir: " + area + " kv.cm"); //dod rezultātu


Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("8. uzdevums");

Console.Write("Lūdzu ievadiet taisnleņķa vienādsāna trijsūra malu garumu cm: "); //prasa figūras malu garumu
string userinput6 = Console.ReadLine();
int num6 = int.Parse(userinput6);

int area2 = ((num6 * num6) / 2); //veic darbības ar dotajiem lielumiem


Console.WriteLine("Trijstūra laukums ir : " + area2 + "  kv.cm"); //dod rezultātu


Console.WriteLine();
Console.WriteLine("===========================");
Console.WriteLine("9. uzdevums");


Console.Write("Kāds ir tavs vārds?: "); //jautā pēc vārda
string vards = Console.ReadLine();

Console.Write("kāds ir tavs vecums?: "); //jautā pēc vecuma
string userAge2 = Console.ReadLine();
int userAgeInt2 = int.Parse(userAge2); 


string formattedMessage = $"Sveiks {vards}, tavs vecums ir {userAgeInt2}"; //interpolē dotos lielumus tekstā

Console.WriteLine(formattedMessage); //asveicinās izmantojot dotos lielumus