public class Place
{
    public int Id { get; set; } = Faker.RandomNumber.Next(10000, 20000);
    public string City { get; set; } = Faker.Address.City();

    public string State { get; set; } = Faker.Address.UsState();

    public string Country { get; set; } = "US";

    public DateTime EnteredAt { get; set; } = DateTime.UtcNow;
}