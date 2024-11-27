using System;

namespace Encapsulation
{
    public class NestedClass
    {
        //Encapsulation, sınıfları iç içe yerleştirerek de sağlanabilir.
        //Bu yöntem, özellikle sınıfın detaylarını sadece ana sınıfın erişebileceği şekilde gizlemek için kullanılır.
        //İç içe sınıflar, kapsüllemeyi artırmak için kullanılan bir başka ileri tekniktir.
    }
    
    public class OuterClass
    {
        private class InnerClass
        {
            public void Display()
            {
                Console.WriteLine("Inner class method.");
            }
        }

        public void ShowInnerClassMethod()
        {
            InnerClass inner = new InnerClass();
            inner.Display();
        }
    }
    
    //Bu örnekte InnerClass, OuterClass içinde private olarak tanımlanmıştır.
    //InnerClass dışarıdan erişilemez, sadece OuterClass içerisinden kullanılabilir.
    //Bu yöntem, özellikle belirli iş mantığını dış dünyadan tamamen izole etmek istediğinizde faydalıdır.
}