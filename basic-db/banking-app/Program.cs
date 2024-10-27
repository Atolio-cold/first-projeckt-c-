using banking_app.Services;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var numericOperations = new NumericOperations();
int dupa = numericOperations.AddTwoNumbers();

Console.WriteLine(dupa);

var carRent = new CarRenting();
string rent = carRent.RentCar();
string startEngine = carRent.StartEngine();

Console.WriteLine(rent);
Console.WriteLine(startEngine);

    
