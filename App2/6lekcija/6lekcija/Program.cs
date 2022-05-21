using _6lekcija;

List<string> guesableNames = new List<string>();

guesableNames.Add("māja");
guesableNames.Add("skola");
guesableNames.Add("iela");


foreach (var gueableName in guesableNames)
{
    Console.WriteLine($"Names {gueableName}");
}

guesableNames.Remove("iela");

foreach (var gueableName in guesableNames)
{
    Console.WriteLine($"Names 2 {gueableName}");
}

string firstElement = guesableNames[0];
Console.WriteLine($"First name {firstElement}");

int elementsCount = guesableNames.Count;
Console.WriteLine($"Count {elementsCount}");

List<int> nums = new List<int>();

nums.Add(150);
nums.Add(25);
nums.Add(48);

foreach (int num in nums)
{
    Console.WriteLine($"num: {num}");
}

List<Person> persons = new List<Person>();

var artis = new Person
{
    Name = "Artis",
    Surname = "Vilciņš"
};

persons.Add(artis);

foreach (Person person in persons)
{
    Console.WriteLine($"Hello {person.Name} {person.Surname}");
}

Console.WriteLine("===================");


Dictionary<string, Person> personsDictionary = new Dictionary<string, Person>();

Person otherPerson = new Person
{
    Name = "Jānis",
    Surname = "Stabule"

};

personsDictionary.Add("a", artis);
personsDictionary.Add("b", artis);
personsDictionary.Add("c", artis);

personsDictionary.Add("d", otherPerson);
personsDictionary.Add("e", otherPerson);
personsDictionary.Add("f", otherPerson);

foreach (KeyValuePair<string, Person> item in personsDictionary)
{
    string key = item.Key;
    var person = item.Value;

    Console.WriteLine($"Key: {key} person name {person.Name} {person.Surname}");
}

var artis2 = personsDictionary["a"];

Console.WriteLine($"Retriueved Artis {artis2.Name} {artis2.Surname}");

bool hasKeyA = personsDictionary.ContainsKey("a");
Console.WriteLine($"Has key {hasKeyA}");


Console.WriteLine("===================");

foreach (string key in personsDictionary.Keys)
{
    Console.WriteLine($"Key from dic {key}");
}
