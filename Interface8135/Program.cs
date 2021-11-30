using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface8135
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
            FirstName = "Çağıl",
                Surname = "Alsaç",
                Department ="Yazılım"
            };
            string department = student.Department;
           
            Person ogrenci = new Student()
            {
                Id = 2,
                FirstName = "Mert",
                Surname="Unal",
                Department="Yazılım"
            };
            Console.WriteLine(ogrenci.Id +" " + ogrenci.FirstName + " " + ogrenci.Surname + " " + ((Student)ogrenci).Department );
            Student std = ogrenci as Student;
            Console.WriteLine(std.Id + " " + std.FirstName + " " + std.Surname + " " + std.Department);

            Customer customer = new Customer()
            {
                Id=3,
                FirstName="Ali",
                Surname="Can",
                Adress="Ankara",
            };
            Console.WriteLine($"{customer.Id}, {customer.FirstName}, {customer.Surname}, {customer.Adress}");

            Musteri musteri = new Musteri()
            {
                CardNo = "1234",
                FirstName = "Cem",
                Surname= "Tan",
                Id = 99,
                Sehir =new City()
                {
                    Id=6,
                    Name="Ankara"
                }
            };
            Console.WriteLine($"{musteri.Id}, {musteri.CardNo}, {musteri.FirstName}, {musteri.Surname}, {musteri.Sehir}");

            Musteri velinimet = new Musteri();
            velinimet.Id = 100;
            velinimet.FirstName = "Veli";
            velinimet.Surname = "Nimet";
            velinimet.CardNo = "9876";
            City sehir = new City()
            {
                Id = 34,
                Name = "İstanbul"
            };
            velinimet.Sehir = sehir;

            Console.ReadLine();
        }
    }

    class Person // : Object
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
    }

    interface IAge
    {
        int Age { get; set; }
    }
    class Student : Person, IAge
    {
        public string Department { get; set; }
        public int Age { get; set; }
    }


    interface ICreditCard
    {
        string CardNo { get; set; }
    }

    class Customer :Person, ICreditCard, IAge
    {
        public string Adress { get; set; }

        public string CardNo { get; set; }

        public int Age { get; set; }
    }

    // Is a relationship : inheritance, interface

    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Musteri
    {
        public City Sehir { get; set; }
        public string CardNo { get; set; }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string Surname { get; set; }
    }
}
