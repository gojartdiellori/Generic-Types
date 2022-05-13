public class Person
{
    public string Name { get; set; } = Faker.Name.First();

    public string Lastname { get; set; }= Faker.Name.Last();

    public DateTime EntryDate { get; set; } = DateTime.UtcNow;
}