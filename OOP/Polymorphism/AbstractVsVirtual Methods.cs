using System;

namespace Polymorphism
{
    public class AbstractVsVirtualMethods
    {
        
    }
    
    //Abstract Methods:
    //Bir metodun temel sınıfta sadece adı tanımlanıp türetilmiş sınıflarda zorunlu olarak implement
    //edilmesi durumunda abstract metodlar kullanılır.
    //abstract metodlar, polymorphism’in daha “katı” bir şeklidir çünkü türetilmiş sınıf,
    //metodun davranışını kesinlikle belirlemelidir.
    
    //Bu örnekte, Shape sınıfı soyut (abstract) bir sınıf olduğu için Draw metodunun içeriği yoktur;
    //sadece adı ve imzası vardır. Türetilmiş sınıflar bu metodu ezmek ve kendi davranışlarını tanımlamak zorundadır.
    
    public abstract class Shape
    {
        public abstract void Draw();
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Square.");
        }
    }
    
    //Virtual Methods:
    //Eğer temel sınıf, bir metodun varsayılan bir davranışını sağlar ve türetilmiş sınıfların
    //bu metodu opsiyonel olarak ezmesini (override etmesini) istiyorsak virtual metodları kullanırız.
    
    //Bu durumda, Dog sınıfı Eat metodunu ezebilir, ancak Animal sınıfının metodunu da kullanabilir.

    public class Animal2
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Dog2 : Animal2
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating kibble.");
        }
    }
}