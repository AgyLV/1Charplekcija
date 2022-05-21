Console.WriteLine("Starts");
//string userAge = Console.ReadLine();
//int age = int.Parse(userAge);



//if (age >= 18)
//{
//    Console.WriteLine("Tu esi pieaudzis!");
//}
//else if (age >= 13)
//{
//    Console.WriteLine("Tu esi pusaudzis!");
//}
//else
//{
//    Console.WriteLine("Tu vēl esi bērns!");
//}



//Console.WriteLine("Ievadi savu vārdu?");

//string name = Console.ReadLine();

//if (string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("Tu neievadīji savu vārdu!");

//}
//else
//{
//    Console.WriteLine($"Tavs vārds ir {name}");
//}

int age = 3;

switch (age)
{
    case 1:
        Console.WriteLine("Case1");
        break;
    case 2:
        Console.WriteLine("Case2");
        break;
    case -1:
        Console.WriteLine("Negative age");
        break;
    case 0:
        Console.WriteLine("Baby");
        break;
    default:
        Console.WriteLine("Nesapratu");
        break;
}


Console.WriteLine("End");
