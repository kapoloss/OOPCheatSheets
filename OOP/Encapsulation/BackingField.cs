namespace Encapsulation
{
    public class BackingField
    {
        // Property’lerde değerleri korumak ve ek kontroller yapmak için “backing field” adı verilen özel alanlar kullanılır.
        // Backing field, property tarafından kullanılan özel bir değişkendir.
        // Bu alan genellikle property’nin değerini saklar,
        // fakat aynı zamanda property’e değer atanırken veya okunurken özel işlemler yapmak için de kullanılır.
        
        private int _temperature;

        public int Temperature
        {
            get { return _temperature; }
            set
            {
                if (value >= -273) // Minimum sıcaklık değeri
                {
                    _temperature = value;
                }
            }
        }
    }
}