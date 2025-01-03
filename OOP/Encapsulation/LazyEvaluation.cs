using System;

namespace Encapsulation
{
    //Lazy Evaluation (Geç Yükleme), bir alanın değeri yalnızca gerektiğinde hesaplanarak
    //bellekte fazla yer kaplamadan iş yapılmasını sağlar. Bu durum encapsulation ile birlikte,
    //yalnızca kullanılması gerektiğinde değer hesaplaması yaparak verimlilik sağlar.
    
    //Bu yapıda result, yalnızca Result property’sine ilk erişim yapıldığında hesaplanır.
    //Encapsulation, HeavyCalculation metodunu gizleyerek bu hesaplamayı sınıf içinde kontrol altında tutar.
        
    public class LazyCalculator
    {
        private Lazy<int> result = new Lazy<int>(()=> HeavyCalculation());

        public int Result => result.Value;

        private static int HeavyCalculation()
        {
            // Yoğun hesaplama
            return 42;
        }
    }
}