namespace Inheritance
{
    public class DowncastingCheck
    {
        // Kalıtımda downcasting yaparken ((AltSınıf) üstSınıf) işleminde nesnenin gerçekten o türe
        // ait olduğundan emin olunmalıdır. Aksi halde, InvalidCastException hatası oluşabilir.
        // Bu durumda is veya as anahtar kelimeleri kullanılarak daha güvenli bir tip kontrolü yapılabilir.
        
        
        // •	is Kullanımı: Nesnenin belirli bir türe ait olup olmadığını kontrol eder.
        // •	as Kullanımı: Nesneyi belirli bir türe dönüştürür; eğer dönüştürülemezse null döner.
    }
    
    Vehicle vehicle = new Car();
    if (vehicle is Car car)
    {
        //car.StartEngine();
    }

// veya

    Car car = vehicle as Car;
    if (car != null)
    {
        //car.StartEngine();
    }
}