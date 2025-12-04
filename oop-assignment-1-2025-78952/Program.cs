using oop_assignment_1_2025_78952.Models;

class Program
{
    static void Main()
    {
        
        CarManager manager = new CarManager();
        
        
        manager.AddCar(new RentalCar("Ford", "Ranger", "Pickup", "FDS9876", 85.00, false));
        manager.AddCar(new RentalCar("Toyota", "Corolla", "Sedan", "ABC1234", 70.00, false));
        manager.AddCar(new RentalCar("Honda", "Civic", "Sedan", "XYZ5678", 75.00, false));
        
        
        Console.WriteLine("\nList of all Cars:");
        manager.ShowAllCars();
        
        
        var car1 = manager.GetCar(0);
        if (car1 != null)
        {
            
            Console.WriteLine("\nRenting a car...");
            car1.Borrow();
            
            
            Console.WriteLine($"Car borrowed? {car1.CheckBorrowed()}");
            
            
            Console.WriteLine($"Current price: {car1.CheckPrice()}");

            
            Console.WriteLine("\nChanging the price of the car to 95.00...");
            car1.ChangePrice(95.00);
            Console.WriteLine($"New price: {car1.CheckPrice()}");

            
            Console.WriteLine("\nList of cars after renting:");
            manager.ShowAllCars();
            
            
            Console.WriteLine("\nTrying to rent the same car again:");
            car1.Borrow();
            
            
            Console.WriteLine("\nReturning the car...");
            car1.ReturnRentalCar();
            Console.WriteLine($"Car borrowed? {car1.CheckBorrowed()}");

            
            Console.WriteLine("\nList of cars after returning:");
            manager.ShowAllCars();
        }

        Console.WriteLine("\nFim do programa. Pressione Enter para sair...");
        Console.ReadLine();
    }
}
