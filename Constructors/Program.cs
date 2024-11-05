using Constructors;

Console.WriteLine("Hello, World!");

Car car1 = new Car("Scorpio", "Mahindra", 2011);

Car copyCar = new Car(car1);

Car.print();

// Instance of Car #Parameter-less
Car car = new Car();

Console.WriteLine("Please enter your Car Name");
var make = Console.ReadLine();

Console.WriteLine("Please enter your Car Model");
var model = Console.ReadLine();

Console.WriteLine("Please enter year");
var year = Convert.ToInt32(Console.Read());

// Instance of Car #Parameterised
//Car car1 = new Car(make,model,year);

Console.WriteLine($"Car name is {make} Car model is {model} Car year is {year}");

Console.Read();