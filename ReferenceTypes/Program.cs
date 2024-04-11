// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int, decimal, float, enum, bool bunlar value types

int sayi1 = 10;
int sayi2 = 20;

sayi1 = sayi2; //Sayı 1'in değeri eşittir sayı 2'nin değeri.
sayi2 = 100; //İlk olarak sayı 1 eşittir sayı 2 yani 20 dedik. Sonrasında atanan referans değer sayı1'i etkilemez.

Console.WriteLine("Sayı 1: " + sayi1);

//arrays, class, interfaces reference types

int[] sayilar1 = new int [] { 1,2,3 };
int[] sayilar2 = new int[] { 10, 20, 30 };

sayilar1 = sayilar2;
sayilar2[0] = 100;
Console.WriteLine("Sayılar 1(0): " + sayilar1[0]);


Person person1 = new Person ();
Person person2 = new Person ();
person1.FirstName = "Engin";
person2 = person1;
person1.FirstName = "Derin"; //Bu şekilde değiştirdiğimizde person2'nin ismi de değişir.

//Referans tiplerde değer eşitlemesi değil adres eşitlemesi yapılır.

Console.WriteLine(person2.FirstName);
    
Customer customer = new Customer ();
customer.FirstName = "Salih";
customer.LastName = "Yılmaz";
customer.CreditCardNumber = "12354664";

Customer customer1 = new Customer ();
customer1.FirstName = "Mehmet";
customer1.LastName = "Can";

Employee employee = new Employee ();


Person person3 = customer; 
Console.WriteLine(person3.FirstName);
Console.WriteLine (((Customer)person3).CreditCardNumber); //Boxing yaparak customer özelliğini de yazdırabiliriz.

PersonManager personManager = new PersonManager (); 
personManager.Add (customer); 
personManager.Add (customer1);

Console.ReadLine ();


class Person
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class Customer:Person
{
    public string CreditCardNumber { get; set; }
}

class Employee:Person
{
    public int EmployeeNumber { get; set; }
}

class PersonManager
{
    public void Add(Person person)
    {
        Console.WriteLine(person.FirstName + " " + person.LastName);
       
    }
}