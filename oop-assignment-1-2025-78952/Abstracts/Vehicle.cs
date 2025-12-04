namespace oop_assignment_1_2025_78952.Abstracts;

public abstract class Vehicle
{
    public string Manufacturer { get; set; }
    public string Model { get; set; }
    public string Type { get; set; }

    public Vehicle(string manufacture, string model, string type)
    {
        Manufacturer = manufacture;
        Model = model;
        Type = type;
    }

    public abstract void Display();
}