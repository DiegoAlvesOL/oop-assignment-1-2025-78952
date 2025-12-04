namespace oop_assignment_1_2025_78952.Models;

public class CarManager
{
    
    private List<RentalCar> cars = new List<RentalCar>();
    
    
    public void AddCar(RentalCar car)
    {
        if (car != null && car.IsValid())
        {
            cars.Add(car);
            Console.WriteLine($"Carro {car.Model} cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Erro: carro inválido ou nulo.");
        }
    }


    public void ShowAllCars()
    {
        foreach (var car in cars)
        {
            car.Display();
        }
    }
    
    public RentalCar GetCar(int index)
    {
        if (index >= 0 && index < cars.Count)
            return cars[index];
        return null;
    }
}