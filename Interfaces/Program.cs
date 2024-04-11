// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//IPersonManager employeeManager = new EmployeeManager(); bu şekilde de yazılabilir.
IPersonManager employeeManager = new EmployeeManager();
employeeManager.Add();
employeeManager.Update();

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

//ProjectManager projectManager = new ProjectManager();
//projectManager.AddCustomer(customerManager);
//projectManager.AddEmployee(employeeManager);

ProjectManager projectManager = new ProjectManager();
projectManager.Add(customerManager);
projectManager.Add(employeeManager);
projectManager.Add(new InternManager());
projectManager.Update(customerManager);
projectManager.Update(employeeManager);
projectManager.Update(new InternManager());


interface IPersonManager
{
    //unimplemented operation - içi doldurulmamış.
    void Add(); //ekleme işlemi yapılacağı belirtiliyor ama hepsi için aynı kodlama olmuyor.
    void Update();
}

class CustomerManager : IPersonManager
{
    public void Add()
    {
        //müşteri ekleme ile ilgili kodlar yazılır.
        Console.WriteLine("Müşteri Eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri Güncellendi.");
    }
}

class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //personel ekleme ile ilgili kodlar yazılır.
        Console.WriteLine("Personel Eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Personel Güncellendi.");
    }
}

class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer Eklendi.");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer Güncellendi.");
    }
}

class ProjectManager
{
    //public void AddCustomer(CustomerManager customerManager)
    //{
    //    customerManager.Add();
    //}

    //public void AddEmployee(EmployeeManager employeeManager)
    //{
    //    employeeManager.Add();
    //}

    //ayrı ayrı method oluşturmak yerine personManager ile tek method oluşturduk.
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }

    public void Update(IPersonManager personManager)
    {
        personManager.Update();
    }
}





//INHERITANCE:

//class PersonManager
//{
//    //implemented operation (aşağıda yazdığımız void kısmı tamamlanmış operasyon oluyor yani içi doldurulmuş.)
//    public void Add()
//    {
//        Console.WriteLine("Eklendi!");
//    }
//}

//class CustomerManager : PersonManager //Inheritance - kalıtım
//{

//}