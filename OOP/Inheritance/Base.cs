using System;

namespace Inheritance
{
    public class Base
    {
         //base anahtar kelimesi, alt sınıftan üst sınıfın üyelerine erişmek için kullanılır.
         //Özellikle override edilmiş bir metodu çağırırken ya da yapıcı metotlarda kullanılır.
    }
    
    public class Vehicle3
    {
        public int Speed { get; set; }
        public Vehicle3(int speed)
        {
            Speed = speed;
        }
    }

    public class Car3 : Vehicle3
    {
        public Car3(int speed) : base(speed) // Üst sınıfın yapıcı metodunu çağırır
        {
            Console.WriteLine("Car created with speed: " + Speed);
        }
    }
}