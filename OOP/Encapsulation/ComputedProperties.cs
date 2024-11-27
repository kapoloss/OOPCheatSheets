using System;

namespace Encapsulation
{
    public class ComputedProperties
    {
        //Encapsulation, yalnızca verileri okumak ve yazmak için değil,
        //aynı zamanda veriler üzerinde hesaplamalar yapmak için de kullanılır.
        //Özellikle getter metodları, sınıf içindeki farklı alanlardan hesaplanan bilgileri dışarıya sunmak için idealdir.
    }
    
    public class Person2
    {
        private int birthYear;

        public Person2(int birthYear)
        {
            this.birthYear = birthYear;
        }

        public int Age
        {
            get
            {
                int currentYear = DateTime.Now.Year;
                return currentYear - birthYear;
            }
        }
    }
}