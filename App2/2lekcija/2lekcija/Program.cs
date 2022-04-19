//// See https://aka.ms/new-console-template for more information

//string myGreeting = "Hello my name is Agnese";
//int age = 35;
//double money = 1600.95;
//char favoriteSimbol = '%';
//bool female = true;


//Console.WriteLine(myGreeting);
//Console.WriteLine(age);
//Console.WriteLine(money);
//Console.WriteLine(favoriteSimbol);
//Console.WriteLine(female);

//Console.WriteLine("================================");
//Console.WriteLine();

//int a = 5;
//int b = 2;

//double sum = a + b;
//double difference = a - b;
//double multiplication = b * a;
//double divides = (double)a / b;
//int divisionLeft = a % b;

//Console.WriteLine(sum);
//Console.WriteLine(difference);
//Console.WriteLine(multiplication);
//Console.WriteLine(divides);
//Console.WriteLine(divisionLeft);

//Console.WriteLine("================================");
//Console.WriteLine();

//int num1 = 10;
//int num2 = 15;

//bool isEqual = num1 == num2;
//bool isNot = num1 != num2;
//bool isLarger = num1 > num2;
//bool isSmaller = num1 < num2;

//Console.WriteLine(isEqual);
//Console.WriteLine(isNot);
//Console.WriteLine(isLarger);
//Console.WriteLine(isSmaller);

//Console.WriteLine("================================");
//Console.WriteLine();

//bool isTrue = true;
//bool isFalse = false;

//bool andAction = isTrue && isFalse;
//bool orAction = isTrue || isFalse;
//bool convertTrue = !isTrue;

//Console.WriteLine(andAction);
//Console.WriteLine(orAction);
//Console.WriteLine(convertTrue);

//Console.WriteLine("================================");
//Console.WriteLine();

//int x = 4;
//int y = 8;

//x += 2; // x = x + 2

//Console.WriteLine(x);

//x -= 3; // x = x - 2

//Console.WriteLine(x);

//x /= 3; // x = x - 2

//Console.WriteLine(x);

//Console.WriteLine("================================");
//Console.WriteLine();

////1. parapsam lietotajam ievadit vina vardu
////2. sagaidam lietotaja ievadi
////3. sasveicinamies ar lietotaju izmantojot viņa vardu paterns :"Sveiks {vards}"

//Console.WriteLine("Lūdzu ievadi savu vārdu ?");
//string username = Console.ReadLine();
//Console.WriteLine("Sveiks: " + username);


//Console.WriteLine("================================");
//Console.WriteLine();

//Console.Write("Lūdzu ievadi skaitli ?");

//string userNumberStrg = Console.ReadLine();
//int userNumber = int.Parse(userNumberStrg);

//int byThenlarger = userNumber + 10;
//Console.WriteLine("Tavs skaitlis palielinās par 10: " + byThenlarger);


int positiveNumbr = 15;
int negativeNumber = -15;

int positiveABS = Math.Abs(positiveNumbr);
int negativeABS = Math.Abs(negativeNumber);

Console.WriteLine("Default negative: " + negativeNumber);
Console.WriteLine(positiveABS);
Console.WriteLine(negativeABS);


Console.WriteLine("================================");
Console.WriteLine();

int maxNumberHigh = 40;
int maxNumberLow = 39;

int largerNumber = Math.Max(maxNumberHigh, maxNumberLow);

Console.WriteLine("Larger number: " + largerNumber);

Console.WriteLine("================================");
Console.WriteLine();

int minNumberHigh = 40;
int minNumberLow = 39;

int smalestNumber = Math.Min(maxNumberHigh, maxNumberLow);

Console.WriteLine("Smalest number: " + smalestNumber);

Console.WriteLine("================================");
Console.WriteLine();

double roundableNumber = 167.87594733223;

double rounded = Math.Round(roundableNumber, 2);

Console.WriteLine("Number rounded: " + rounded);

Console.WriteLine("================================");
Console.WriteLine();

string name = "Agy";
int age2 = 40;

string formattedMessage = $"Hello {name} it is very nice to see you at your {age2} you look good";
string formattedMessage2 = "Hello " + name + " it is very nice to see you at your " + age2 + " you look good";

Console.WriteLine(formattedMessage);
Console.WriteLine(formattedMessage2);
