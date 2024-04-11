// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> sehirler = new List<string>();  //Generic type listlerde hangi tip verilirse parametreler o tipte çalışır. String ise string, int ise int.
sehirler.Add("Ankara");
sehirler.Add("Antalya");
sehirler.Add("İzmir");
Console.WriteLine(sehirler.Count);


//MyList sehirler2 = new MyList();   //MyList<sehirler2> = new Mylist<string>(); şeklinde yazamıyoruz. Non-generic type olduğu uyarısı gelir.
//Generic Class dönüştürüldüğünde;
MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ankara");
sehirler2.Add("Antalya");
sehirler2.Add("İzmir");
sehirler2.Add("Bursa");
Console.WriteLine(sehirler2.Count);

Console.ReadLine();

class MyList<T> //Type kelimesinden geliyor T. //Generic Class
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)  //kullanırken hangi tipi verirsek T ona dönüşüyor.
    {
        _tempArray = _array; //ilk array elemanlarını yedeklemek için. _array adresini tutar.
        
        //Her eleman eklediğimizde array'i newlememiz gerekir.
        _array = new T[_array.Length + 1];
        
        for (int i=0 ; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i]; //tempArray i. elemanını array i. elemanı olarak aktarır.
        }

        _array[_array.Length - 1] = item;

    }

    public int Count
    {
        get { return _array.Length; }
    }

}