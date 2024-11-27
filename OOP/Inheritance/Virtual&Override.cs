using System;

namespace Inheritance
{
    public class Virtual_Override
    {
        //•	Virtual: Üst sınıfta bir metodu “değiştirilebilir” olarak işaretler.
        //•	Override: Alt sınıfta, üst sınıftaki metodun üzerine yazarak kendi özel işleyişini tanımlar.
    }
    
    public class Vehicle2
    {
        public virtual void Move()
        {
            Console.WriteLine("Vehicle is moving");
        }
    }

    public class Car2 : Vehicle2
    {
        public override void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }
}