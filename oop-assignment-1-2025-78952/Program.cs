using oop_assignment_1_2025_78952.Models;

class Program
{
    static void Main()
    {
        // Chamando meu método de cadastrar os carros
        CarManager manager = new CarManager();
        
        manager.AddCar(new RentalCar("Ford", "Ranger", "Pickup", "FDS9876", 85.00, false));
        manager.AddCar(new RentalCar("Toyota", "Corolla", "Sedan", "ABC1234", 70.00, false));
        manager.AddCar(new RentalCar("Honda", "Civic", "Sedan", "XYZ5678", 75.00, false));
        
        
        Console.WriteLine("List of all Cars");
        manager.ShowAllCars();
        
        var car1 = manager.GetCar(0);
        if (car1 != null)
        {
            Console.WriteLine("Renting a car");
            car1.Borrow();
            
            
            Console.WriteLine("Print a list of cars");
            manager.ShowAllCars();

            
            Console.WriteLine("Tring to rent the same car");
            car1.Borrow();
        }

        Console.WriteLine("\nFim do programa. Pressione Enter para sair...");
        Console.ReadLine();
    }
}