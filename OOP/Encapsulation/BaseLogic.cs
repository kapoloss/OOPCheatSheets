namespace Encapsulation
{
    public class BaseLogic
    {
        // Encapsulation, bir sınıf içerisindeki verilerin ve fonksiyonların dışarıdan doğrudan erişimini engeller, 
        // verilerin nasıl işlendiğini gizler ve kontrollü bir erişim sağlar.
        // Bu kontrol, sınıfın metodları aracılığıyla sağlanır.
        // Sınıfın dışındaki kodlar, yalnızca o sınıfın sağladığı yöntemleri kullanarak verilere erişebilir
        // veya onları değiştirebilir.
    }
    
    
    public class Person
    {
        private string name; // dışarıdan doğrudan erişime kapalı

        public string GetName()
        {
            return name; // kontrollü bir okuma işlemi
        }

        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                name = value; // kontrollü bir yazma işlemi
            }
        }
    }
}