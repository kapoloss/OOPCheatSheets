using System;

namespace Inheritance
{
    public class AbstractVsInterface
    {
    // 1. Temel Tanım ve Kullanım Amaçları
    //
    // Abstract Class (Soyut Sınıf):
    // •	Soyut sınıflar, ortak özelliklere sahip nesneler arasında bir soyutlama sunar.
    // •	Bir temel sınıf olarak işlev görür; diğer sınıflar bu soyut sınıfı miras alarak temel özellik
    // ve davranışları paylaşır.
    // •	Sınıflar arasındaki benzerliği belirlemek için kullanılır ve bazen temel davranışlar sağlar.
    // Hem tamamlanmış hem de tamamlanmamış (soyut) metotlar içerebilir.
    // Interface (Arayüz):
    // •	Arayüzler, bir sınıfın uygulaması gereken bir dizi işleve işaret eder, ancak bu işlevlerin nasıl
    // gerçekleşeceği hakkında bilgi vermez.
    // •	Davranışların tanımlandığı fakat bu davranışların nasıl uygulanacağına dair bir şablon sunan yapılardır.
    // •	Farklı sınıflara bir standart sunar. Uygulama içeriği tamamen sınıfa bırakılır.
    
    // 2. Tanımlama ve Üyeler
    //
    // Abstract Class:
    // •	abstract anahtar kelimesiyle tanımlanır.
    // •	Hem soyut (abstract) hem de somut (non-abstract) metotlar içerebilir.
    // •	Metotlar, alanlar, sabitler ve özellikler (property) gibi birçok öğe tanımlanabilir.
    
    // Interface:
    // •	interface anahtar kelimesiyle tanımlanır.
    // •	Yalnızca metod, özellik, olay ve indeksleyici bildirimi yapabilir.
    // •	Metotların gövdesi yoktur; sadece imzaları bulunur (C# 8.0 ve sonrasında varsayılan uygulama ile
    // gövde tanımlanabilir).
    
    
    // 3. Miras Alma ve Çoklu Kalıtım
    //
    // Abstract Class:
    // •	Bir sınıf sadece bir soyut sınıfı miras alabilir (tekli kalıtım).
    // •	Soyut sınıflar, diğer soyut sınıflardan miras alabilir, yani çoklu seviyelerde soyut sınıf oluşturulabilir.
    // •	Bir sınıf bir abstract sınıf ve birkaç interface implement edebilir.
    // Interface:
    // •	Bir sınıf, birden fazla arayüzden (interface) türeyebilir (çoklu kalıtım).
    // •	C#’ta çoklu kalıtım desteği yoktur, ancak interface ile bu mümkün olur.
    
    // 4. Erişim Belirleyiciler ve Üyeler
    //
    // Abstract Class:
    // •	Soyut sınıf içerisindeki üyeler erişim belirleyicileri (public, protected, private) ile tanımlanabilir.
    // •	Yani, soyut sınıfın alanları veya metotları sınıfa özel veya korumalı olabilir.
    // Interface:
    // •	Arayüz içerisindeki üyeler varsayılan olarak public olur; erişim belirleyici tanımlanamaz.
    // •	Interface’lerde tanımlanan her şey, uygulandığı sınıfta public olmak zorundadır.
    //
    // 5. Kullanım Amaçları
    //
    // Abstract Class:
    // •	Diğer sınıflar için ortak bir temel sağlamak ve bu temel sınıfların varsayılan bir işleyişi barındırması gerektiğinde kullanılır.
    // •	Alt sınıflara miras olarak geçecek bazı işlevler ve somut metotlar içeriyorsa soyut sınıf daha uygun olur.
    // Interface:
    // •	Farklı sınıflara aynı davranışları tanımlamak, yani farklı sınıflara belli bir işlevi zorunlu kılmak istendiğinde kullanılır.
    // •	Çok farklı sınıfların bir standartta uyumlu olmaları için, örneğin IComparable, IEnumerable gibi arayüzler.
    }
    
    // Abstract Class
    public abstract class Animal3
    {
        public string Name { get; set; }

        public abstract void MakeSound(); // Soyut metod, her hayvan kendi sesiyle ses çıkarır.
        public virtual void Move()        // Sanal metod, varsayılan hareket şekli verilebilir.
        {
            Console.WriteLine("Animal is moving.");
        }
    }

// Interface
    public interface IFlyable
    {
        void Fly(); // Sadece uçabilen hayvanlar için geçerli bir metod.
    }

    public class Dog2 : Animal3
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }

    public class Bird : Animal3, IFlyable
    {
        public override void MakeSound()
        {
            Console.WriteLine("Tweet!");
        }

        public void Fly()
        {
            Console.WriteLine("Bird is flying.");
        }
    }
}