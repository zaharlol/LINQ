using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Phone phone = new Phone();
        phone.Phone1();
    }
}

class Animal
{
    public void Animal1()
    {
        string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
        var ann = words.Select(x => new
        {
            Name = x,
            Lenght = x.Length
        })
            .OrderBy(word => word.Lenght);

        foreach (var word in ann) 
        Console.WriteLine(word.Name + " " + word.Lenght);
    }
}
public class Application
{
    public string Name { get; set; }
    public int YearOfBirth { get; set; }
}
public class Student
{
    public string Name { get;  set; }
    public int Age { get; set; }
    public List<string> Languages { get; set; }
}
public class Coarse
{
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
}
public class Stud
{
    public void Stud1()
    {
        List<Student> students = new List<Student>
{
   new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
   new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
   new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
   new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
};
        var Mol = from s in students where s.Age < 27 
                  let birdthay = DateTime.Now.Year - s.Age 
                  select new Application
                  {
                      Name = s.Name,
                      YearOfBirth = birdthay,
                  };

        foreach (var a in Mol) 
            Console.WriteLine(a.Name + " " + a.YearOfBirth);
    }
}
public class Studen
{
    public void Studen1()
    {
        var students = new List<Student>
        {
            new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
            new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
            new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
        };
        var coarses = new List<Coarse>
        {
             new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
             new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
        };

        var Mol = from s in students
                  where s.Age < 29
                  where s.Languages.Contains("английский")
                  from a in coarses
                  where a.Name.Contains("C#")
                  let birdthay = DateTime.Now.Year - s.Age
                  select new 
                  {
                      Name = s.Name,
                      YearOfBirth = birdthay,
                      NameCoarse = a.Name,
                  };

        foreach (var a in Mol)
            Console.WriteLine(a.Name + " " + a.YearOfBirth + " " + a.NameCoarse);
    }
}
public class Contact
{
    public string Name { get; set; }
    public int Phone { get; set; }
}
class Cont
{
    public void Cont1()
    {
        var contacts = new List<Contact>()
{
   new Contact() { Name = "Андрей", Phone = 799994500 },
   new Contact() { Name = "Сергей", Phone = 799990455 },
   new Contact() { Name = "Иван", Phone = 79999675 },
   new Contact() { Name = "Игорь", Phone = 8884994 },
   new Contact() { Name = "Анна", Phone = 665565656 },
   new Contact() { Name = "Василий", Phone = 3434 }
};

        while (true)
        {
            var keyChar = Console.ReadKey().KeyChar;
            IEnumerable<Contact> page = null;
            switch (keyChar)
            {
                case ('1'):
                    page = contacts.Take(2);
                    break;
                case ('2'):
                    page = contacts.Skip(2).Take(2);
                    break;
                case ('3'):
                    page = contacts.Skip(4).Take(2);
                    break;
            }
            foreach (var s in page)
            {
                Console.WriteLine(s.Name + " " + s.Phone);
            }
        }
    }
}
public class Contact1 // модель класса
{
    public Contact1(string name, string lastName, long phoneNumber, String email) // метод-конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}
class Phone
{
    public void Phone1()
    {
        var phoneBook = new List<Contact1>();

        // добавляем контакты
        phoneBook.Add(new Contact1("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact1("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact1("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact1("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact1("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact1("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

        while (true)
        {
            var keyChar = Console.ReadKey().KeyChar;
            IEnumerable<Contact1> page = null;
            switch (keyChar)
            {
                case ('1'):
                    page = phoneBook.Take(2);
                    break;
                case ('2'):
                    page = phoneBook.Skip(2).Take(2);
                    break;
                case ('3'):
                    page = phoneBook.Skip(4).Take(2);
                    break;
            }
            foreach (var s in page)
            {
                Console.WriteLine(s.Name + " " + s.LastName + " " + s.PhoneNumber + " " + s.Email);
            }
        }
    }
}