using System;

namespace Inheritance
{
    public class Sealed
    {
    //     Sealed anahtar kelimesi, bir sınıfın veya metodun daha fazla kalıtılmasını engeller.
    // Bu, özellikle bir sınıfın son bir sürüm olarak tasarlandığı ve
    // daha fazla değiştirilmemesi gerektiği durumlarda kullanılır.
    //
    //     •	Sealed Sınıf: sealed ile işaretlenmiş bir sınıf, başka bir sınıf tarafından kalıtılamaz.
    //     •	Sealed Metot: Bir sınıftaki metodun daha fazla override edilmesini istemediğinizde kullanılır.
    // Genellikle inheritance hiyerarşisinde son adımı işaretlemek için kullanılır.
    }
    
    public sealed class FinalClass
    {
        public void PrintMessage()
        {
            Console.WriteLine("This is a final class.");
        }
    }

// Bu sınıf kalıtılamaz:
// public class AttemptedInheritance : FinalClass // Hata verir


}