using System.Linq;
class Program 
{
    static void Main(string[] args)
    {
        Array array = new Array();
        array.Array1();
    }
}
class People 
{
public void People1()
    {
        string[] people = { "Анна", "Мария", "Сергей", "Алексей", "Дмитрий", "Ян" };


        var selectedPeople = from p in people where p.StartsWith("А") orderby p select p;

        foreach (string s in selectedPeople)
            Console.WriteLine(s);
    }
}
class Obj
{
    public void Obj1()
    {
        var objects = new List<object>()
        {
             1,
             "Сергей ",
             "Андрей ",
             300,
        };

        foreach (var stringObject in objects.Where(o => o is string).OrderBy(o => o))
            Console.WriteLine(stringObject);
    }

}
public class City
{
    public City(string name, long population)
    {
        Name = name;
        Population = population;
    }

    public string Name { get; set; }
    public long Population { get; set; }

    public void City1()
    {
        var russianCities = new List<City>();
        russianCities.Add(new City("Москва", 11900000));
        russianCities.Add(new City("Санкт-Петербург", 4991000));
        russianCities.Add(new City("Волгоград", 1099000));
        russianCities.Add(new City("Казань", 1169000));
        russianCities.Add(new City("Севастополь", 449138));

        var CityLenght = russianCities.Where(c => c.Name.Length > 10).OrderBy(c => c.Name);
        foreach (var city in CityLenght)
            Console.WriteLine(city);
    }
}
class Numbers
{
    public void Numbers1()
    {
        string[] text = { "Раз два три",
   "четыре пять шесть",
   "семь восемь девять" };
        var text2 = from num in text from word in num.Split(' ') select word;

        foreach (var word in text2)
            Console.WriteLine(word);
    }
}
class Array
{
    public void Array1()
    {
        var numsList = new List<int[]>()
{
   new[] {2, 3, 7, 1},
   new[] {45, 17, 88, 0},
   new[] {23, 32, 44, -6},
};
        var num = from str in numsList from nu in str orderby nu select nu;

        foreach (var q in num) 
            Console.WriteLine(q);
    }
}