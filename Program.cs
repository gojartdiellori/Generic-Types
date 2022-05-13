
// Simple example of using Generics in C# 

// create list of Persons (autofill with Faker.NET(Fake data)) 
List <Person>  listOfPerson= CreateList.Make<Person>();

// create list of Log (autofill with Faker.NET(Fake data)) 
List <Place>  listOfPlace= CreateList.Make<Place>();


// save data to file named "people.csv"
GenericReadFromFile.SaveDataToFile<Person>(Path.Combine(Directory.GetCurrentDirectory(),"people.csv"),listOfPerson);


// save data to file named "places.csv"
GenericReadFromFile.SaveDataToFile<Place>(Path.Combine(Directory.GetCurrentDirectory(),"places.csv"),listOfPlace);