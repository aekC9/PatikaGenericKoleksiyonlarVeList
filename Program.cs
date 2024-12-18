using System;
using System.Collections.Generic;

namespace PatikaGenericKoleksiyonlariVeList;

class Program
{
    static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic;
        //T -> object türündendir

        List<int> sayiListesi = new List<int>();
        sayiListesi.Add(23);
        sayiListesi.Add(21);
        sayiListesi.Add(11);
        sayiListesi.Add(13);
        sayiListesi.Add(6);

        List<string> renkListesi  = new List<string>();
        renkListesi.Add("Beyaz");
        renkListesi.Add("Siyah");
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Mavi");

        //Count
        System.Console.WriteLine(sayiListesi.Count());
        System.Console.WriteLine(renkListesi.Count());

        //Foreach & List.Foreach
        foreach(var sayi in sayiListesi)
        {
            System.Console.WriteLine(sayi);
        }
        foreach(var renk in renkListesi)
        {
            System.Console.WriteLine(renk);
        }
        sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
        renkListesi.ForEach(renk => System.Console.WriteLine(renk));

        //Liste içerisinde arama
        if(sayiListesi.Contains(10))
        {
            System.Console.WriteLine("Eleman bulundu");
        }

        //Diziyi List'e çervirme
        string[] hayvanlar = {"Aslan","Kedi","At","Leopar","Kurt"};
        List<string> hayvanListesi = new List<string>(hayvanlar);

        //List içerisinde nesne tutmak
        List<Customer> customerList = new List<Customer>();
        Customer customer =  new Customer();
        customer.FirstName = "Ali";
        customer.LastName = "Kabil";
        customer.Age = 23;

        Customer customer2 =  new Customer();
        customer.FirstName = "Ayşe";
        customer.LastName = "Pınar";
        customer.Age = 27;

        customerList.Add(customer);
        customerList.Add(customer2);

        List<Customer> newCustomerList = new List<Customer>();
        newCustomerList.Add(new Customer(){
            FirstName = "Zeynep",
            LastName = "Balkan",
            Age = 23
        });
        foreach(var cust in newCustomerList)
        {
            System.Console.WriteLine($"İsim: {cust.FirstName}");
            System.Console.WriteLine($"Soyisim: {cust.LastName}");
            System.Console.WriteLine($"Yaş: {cust.Age}");
            System.Console.WriteLine("---------------------------------");
        }
        newCustomerList.Clear();


    }
}
public class Customer
{
    private string firstName;
    private string lastName;
    private int age;

    public int Age { get => age; set => age = value; }
    public string FirstName { get => firstName; set => firstName = value; }
    public string LastName { get => lastName; set => lastName = value; }
}
