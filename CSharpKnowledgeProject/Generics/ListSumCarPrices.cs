using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpKnowledgeProject.Generics
{
    //In this class I'll show a use case of generics
    //In this case we will just use a List but we add a Sum method to it
    //this class is specificly used for class Car in another example I'll show a better use case of generics
    //so lets add the generic characters to this class <> with type T
    //inheriting from List<T>
    //also add a where T: Car so where T is typeof the class Car
    public class ListSumCarPrices
    {
        public void Main()
        {
            //Now lets create an instance of the new class
            ListCar<Car> cars = new ListCar<Car>();
            cars.Add(new Car() { LicencePlate = "AB-12C-DE", Price = 32000M });
            cars.Add(new Car() { LicencePlate = "FG-34J-KL", Price = 54000M });
            var sum = cars.Sum();
            //-> 86000M
        }
    }

    internal class ListCar<T> : List<T> where T : Car
    {
        public decimal Sum()
        {
            decimal total = 0M;
            foreach (Car car in this)
            {
                total += car.Price;
            }
            return total;
        }
    }

    internal class Car
    {
        public string LicencePlate { get; set; }
        public decimal Price { get; set; }
    }
}