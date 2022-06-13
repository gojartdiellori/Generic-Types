
// Simple example of using Generics in C# 

// create list of Persons (autofill with Faker.NET(Fake data)) 
List<Person> listOfPerson = CreateList.Make<Person>();

// create list of Log (autofill with Faker.NET(Fake data)) 
List<Place> listOfPlace = CreateList.Make<Place>();
Console.Write("Please type your char:");
string input = Console.ReadLine();
switch (input)
{
    case "R":
        GenericSaveAndReadFromFile.ReadDataFromFile<Person>(Path.Combine(Directory.GetCurrentDirectory(), "people.csv"));
        Console.WriteLine("-----------------------------------------------");
        GenericSaveAndReadFromFile.ReadDataFromFile<Place>(Path.Combine(Directory.GetCurrentDirectory(), "places.csv"));

        break;
    case "S":
        // save data to file named "people.csv"
        GenericSaveAndReadFromFile.SaveDataToFile<Person>(Path.Combine(Directory.GetCurrentDirectory(), "people.csv"), listOfPerson);
        // save data to file named "places.csv"
        GenericSaveAndReadFromFile.SaveDataToFile<Place>(Path.Combine(Directory.GetCurrentDirectory(), "places.csv"), listOfPlace);
        break;
    default:
        Console.WriteLine("Nothing was selected");
        break;
}
