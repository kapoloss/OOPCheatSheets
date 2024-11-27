using System;

namespace Inheritance
{
    public class MethodHiding
    {
        //•	Override: Alt sınıf, üst sınıftaki metodu geçersiz kılar ve kendi özel implementasyonunu sağlar.
        //Üst sınıfta virtual veya abstract olarak tanımlanmış bir metodu alt sınıfta override edebilirsiniz.
        //•	New: Eğer üst sınıfta virtual olarak tanımlanmamış bir metodu aynı isimle alt sınıfta tanımlamak istiyorsanız,
        //new anahtar kelimesiyle gizleme işlemi yaparsınız. Bu, alt sınıfın üst sınıftaki metodu gizlediği anlamına gelir.
    }
}

public class BaseClass
{
    public void Display()
    {
        Console.WriteLine("Base Display");
    }
}

public class DerivedClass : BaseClass
{
    public new void Display() // Method hiding
    {
        Console.WriteLine("Derived Display");
    }
}