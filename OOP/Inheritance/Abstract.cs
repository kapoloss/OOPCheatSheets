using System;

namespace Inheritance
{
    public class Abstract
    {
        //Bir sınıfın direkt olarak örneği oluşturulamayacak şekilde soyutlanması gerektiğinde abstract sınıflar devreye girer.
        //Soyut sınıflar, yalnızca alt sınıflar tarafından türetilir ve
        //bu sınıflarda belirli bir davranışın tanımlanmasını zorunlu kılar.
        
        //Soyut Metotlar (Abstract Methods): Soyut bir sınıfta tanımlanan metotlar,
        //alt sınıflarda mutlaka yeniden tanımlanmalıdır. Alt sınıf bu metodun gövdesini kendisi sağlar.
    }
    
    public abstract class Animal
    {
        public abstract void Speak();
    }

    public class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
    
}