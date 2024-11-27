using System;
using UnityEngine;

namespace Polymorphism
{
    public class Run_Time
    {
        //Bu tür polymorphism, çalışma zamanında belirlenir.
        //Method Overriding (Metod Ezme) ile sağlanır ve temel sınıftan türeyen sınıfların,
        //temel sınıftaki metodları yeniden tanımlaması ile elde edilir.
        //Bu tür polymorphism için kalıtım (inheritance) ve virtual/override anahtar kelimeleri gereklidir.
    }
    
    //Virtual Methods (Sanal Metodlar):
    //Temel sınıfta virtual olarak işaretlenen metodlar,
    //türetilmiş sınıflarda override edilerek farklı davranışlar gösterebilir.
    
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    public class Program : MonoBehaviour
    {
        Animal myAnimal;

        public void Method()
        {
            myAnimal = new Dog();
            myAnimal.Speak();  // Dog barks.

            myAnimal = new Cat();
            myAnimal.Speak();  // Cat meows.
        }
       
    }
}