// See https://aka.ms/new-console-template for more information
using object_cloning_ways;

Console.WriteLine("Cloning Ways");

Console.WriteLine("With Constructor---");
Team t = new Team() { Name="team1", Id = 1 };
Team tClone = new Team(t);
Console.WriteLine(tClone.Name);

Console.WriteLine("With Clonable Interface---");
Category cat = new Category() { Id=1, Name="cat1" };
Category catClone = (Category)cat.Clone();
Console.WriteLine(catClone.Name);


Console.WriteLine("With Custom Clonable Interface---");
Country country = new Country() { Id = 1, Name = "country1" };
Country countryClone = (Country)country.Clone();
Console.WriteLine(countryClone.Name);

Console.WriteLine("With Serializers---");
Automobile carSerializer = new Automobile() { Id = 1, Name = "car1" };

var xmlCar= Serializers.CreateCloneByXmlSerializer(carSerializer);
var jsonCar = Serializers.CreateCloneByJsonSerializer(carSerializer);
var binaryCar = Serializers.CreateCloneByBinaryFormatter(carSerializer);

Console.WriteLine(xmlCar.Name);
Console.WriteLine(jsonCar.Name);
Console.WriteLine(binaryCar.Name);