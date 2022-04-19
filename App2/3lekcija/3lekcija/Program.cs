using _3lekcija;


//Person person = new Person("Artis");

//person.Name = "Artis";
//person.Age = 59;
//person.IsMale = true;

//person.Greeting();

//Person artis = new Person("Artis 2");

//artis.Name = "Artis 2";
//artis.Age = 59;
//artis.IsMale = true;

//artis.Greeting();

//bool IsArtisAdult = artis.IsAdult;
//bool IsArtisAdult2 = artis.GetIsAdult();

//Console.WriteLine(IsArtisAdult);
//Console.WriteLine(IsArtisAdult2);

Console.WriteLine();
Console.WriteLine("+++++++++++++++");
Console.WriteLine();

string name = "Artis";
string nameToChange = name;

nameToChange = "Agnese";

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Name to change: {nameToChange}");

Person person = new Person();
person.Name = "Artis";

Person personToChange = person;
personToChange.Name = "Agnese";

Console.WriteLine($"Name: {person.Name}");
Console.WriteLine($"Name to change: {personToChange.Name}");