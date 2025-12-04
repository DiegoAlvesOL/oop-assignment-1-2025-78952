using System;
using oop_assignment_1_2025_78952.Models;

public static class DisplayCarInfo 
{ 
    public static void ShowRentalCar(RentalCar car) 
    { 
        Console.WriteLine("********************************"); 
        Console.WriteLine($"Manufacturer: {car.Manufacturer}"); 
        Console.WriteLine($"Model: {car.Model}"); 
        Console.WriteLine($"Body Type: {car.Type}"); 
        Console.WriteLine($"Registration: {car.RegistrationNumber}"); 
        Console.WriteLine($"Price: {car.Price}"); 
        Console.WriteLine($"Borrowed: {car.Borrowed}"); 
        Console.WriteLine("********************************\n");
        
    }
}
