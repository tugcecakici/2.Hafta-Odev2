// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Customer customer1 = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };
//Yukarıda default constructor çalıştırmış oluyoruz. Parametresi olmayan constructor = default constructor.
Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");
Method(2, "Tuğçe", "Çakıcı", "Manisa");

Console.WriteLine(customer2.Id + " " + customer2.FirstName +" "+ customer2.LastName +" "+ customer2.City);
//Yazdırabilmek için constructorda tanımladık, dikkat!!


Console.ReadLine();

static void Method(int id, string firstName, string lastName, string city)
{

}

class Customer
{
    //overload constructor yaparak iki şekilde de kullanabildik.
    public Customer()
    {
        
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        FirstName = firstName;
        LastName = lastName;
        City = city;
        Id = id;
    }
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }

}