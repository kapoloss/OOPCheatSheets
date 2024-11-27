using System;

namespace Inheritance
{
    public class BaseLogic
    {
        //Kalıtım, bir “ana” veya “üst” sınıftan (“base” veya “parent class”) özellik ve davranışları (“fields” ve “methods”)
        //alan yeni bir sınıf (“child” veya “subclass”) tanımlamak için kullanılır.
        //Örneğin, bir Vehicle sınıfı,Car ve Bike gibi alt sınıflar tarafından kalıtılabilir.
        //Böylece Car ve Bike, Vehicle sınıfının özelliklerini ve davranışlarını devralır.
    }
    
    public class Vehicle
    {
        public int Speed { get; set; }
        public void Move()
        {
            Console.WriteLine("Moving at speed: " + Speed);
        }
    }

    public class Car : Vehicle
    {
        public int Wheels { get; set; }
    }
}