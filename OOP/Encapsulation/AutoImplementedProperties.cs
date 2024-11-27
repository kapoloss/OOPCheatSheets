namespace Encapsulation
{
    public class AutoImplementedProperties
    {
        // Field (alan) ve property kullanımı arasında encapsulation açısından bazı ince farklar vardır:
        //
        // •	Field kullanımı, daha çok sınıf içi kullanım için uygunken,
        // dış dünyaya açılması gerektiğinde property kullanımı tercih edilir.
        // Bu nedenle private değişkenler genellikle field olarak tanımlanır,
        // dışarıya açılacaksa property aracılığıyla açılır.
        
        // •	Auto-Implemented Properties: C# dilinde, auto-implemented properties (otomatik özellikler)
        // sınıf içi bir değişken tanımlamadan encapsulation sağlamanın hızlı bir yoludur.
        // Ancak bu yapı, belirli kontroller yapılması gereken durumlarda yetersiz kalabilir.
        // Yani sadece veri okuma ve yazma yapılacaksa uygun, ancak ekstra iş mantığı gerekiyorsa yetersizdir.
        
        public string Name { get; set; } // Auto-implemented property, direkt okuma-yazma
    }
}