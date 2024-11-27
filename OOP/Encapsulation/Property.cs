using System;

namespace Encapsulation
{
    public class Property
    {
        //C#’ta property’ler (get ve set) getter ve setter metodlarının daha kullanışlı bir yoludur.
        //Encapsulation’da property’ler, veri saklama alanlarını (field) doğrudan kullanmak yerine
        //özellikler aracılığıyla kontrollü bir şekilde verilere erişmeyi sağlar.
    }
    
    public class Employee
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age must be a positive value.");
                }
            }
        }
    }

    public class ReadOnlyWriteOnly
    {
        //Encapsulation, salt okunur veya salt yazılır property’lerin oluşturulmasına izin verir.
        //Bu property’ler, sınıf dışından yalnızca okunabilir veya yalnızca yazılabilir olacak şekilde tanımlanır.
        //Salt okunur property’ler, değer atamaya izin vermezken; salt yazılır property’ler, dışarıdan okunamaz.
    }
    
    public class Sensor
    {
        private int _sensorData;

        // Salt okunur property
        public int SensorData
        {
            get { return _sensorData; }
        }

        // Salt yazılır property
        public int WriteOnlyData
        {
            set { _sensorData = value; }
        }
    }
}