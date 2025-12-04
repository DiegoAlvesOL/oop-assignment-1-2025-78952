using oop_assignment_1_2025_78952.Abstracts;
using oop_assignment_1_2025_78952.Interfaces;
using System;

namespace oop_assignment_1_2025_78952.Models
{
    public class RentalCar : Vehicle, IValidatable
    {
        public string RegistrationNumber { get; set; }
        public double Price { get; set; }
        public bool Borrowed { get; private set; }

        public RentalCar(string manufacturer, string model, string bodyType,
            string registrationNumber, double price, bool borrowed)
            : base(manufacturer, model, bodyType)
        {
            RegistrationNumber = registrationNumber;
            Price = price;
            Borrowed = borrowed;
        }

        public RentalCar(string manufacturer, string model, string bodyType,
            string registrationNumber, double price)
            : this(manufacturer, model, bodyType, registrationNumber, price, false) { }

        public RentalCar(string manufacturer, string model, string bodyType)
            : this(manufacturer, model, bodyType, "Null", 0.0, false) { }

        public void Borrow()
        {
            if (!Borrowed) Borrowed = true;
            else Console.WriteLine("Error: This car is already on loan.");
        }

        public void ReturnRentalCar() => Borrowed = false;

        public void ChangePrice(double price) => Price = price;

        public double CheckPrice() => Price;

        public bool CheckBorrowed() => Borrowed;

        public bool IsValid() =>
            Price >= 0 &&
            !string.IsNullOrWhiteSpace(Manufacturer) &&
            !string.IsNullOrWhiteSpace(Model) &&
            !string.IsNullOrWhiteSpace(Type);
        
        public override void Display()
        {
            DisplayCarInfo.ShowRentalCar(this);
        }
    }
}