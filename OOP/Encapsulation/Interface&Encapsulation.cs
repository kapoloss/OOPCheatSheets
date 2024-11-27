using System;

namespace Encapsulation
{
    public class Interface_Encapsulation
    {
        //Encapsulation prensibi, interface’ler ile de uyumlu bir şekilde çalışır.
        //Interface’ler, bir sınıfın dış dünyaya hangi metodları sunduğunu belirtir ancak iç detaylar gizlenir.
        //Bu sayede, sınıfın dışarıya nasıl bir yapı sunduğu net bir şekilde görülürken,
        //iç detayları encapsulation ile korunmuş olur.
    }
    
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }

    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}