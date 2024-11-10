using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Gallery
    {
        public int Id { get; set; }

        public string Name { get; set; }
        private Car[] Cars;
        private int carCount;

        public Gallery(int id, string name, int capacity=8) 
        {
            Id = id;
            Name = name;
            Cars = new Car[capacity];
            carCount = 0;

        }

        public void AddCar(Car car)
        {
            if(carCount<Cars.Length)
                Cars[carCount++] = car;

            else
                Console.WriteLine("Gallery is full!");
        }

        public void ShowAllCars()
        {
            if (carCount == 0) 
            {
                Console.WriteLine("No cars in the gallery");
                return;
            }

            for (int i = 0; i < carCount; i++)
            {
                var car = Cars[i];
                Console.WriteLine($"Id: {car.Id}, Name: {car.Name}, Speed: {car.Speed}, CarCode: {car.CarCode}");
            }

        }

        public Car FindCarById(int id)
        {
            for (int i = 0; i < carCount; i++)
            {
                if(Cars[i].Id == id)
                    return Cars[i];
            }
            return null;
        }

        public Car FindCarByCarCode(string carCode)
        {
            for (int i = 0; i < carCount; i++)
            {
                if (Cars[i].CarCode == carCode)
                    return Cars[i];  
            }
            return null;  
        }

        public Car[] FindCarsBySpeedInterval(int minSpeed, int maxSpeed)
        {
            Car[] result = new Car[carCount];
            int count = 0;

            for (int i = 0; i < carCount; i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                    result[count++] = Cars[i];
            }

            if (count == 0)
                return null;

            Car[] finalResult = new Car[count];
            Array.Copy(result, finalResult, count);
            return finalResult;
        }


    }
}
