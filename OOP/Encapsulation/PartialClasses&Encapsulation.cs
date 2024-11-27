namespace Encapsulation
{
    public class PartialClasses_Encapsulation
    {
        //Büyük projelerde sınıf kodlarını birden fazla dosyada yönetmek için partial sınıflar kullanılabilir.
        //Partial sınıflar, tek bir sınıfı birden fazla dosyaya bölerek yazılımcılara kodu daha modüler
        //bir şekilde yönetme imkanı sunar. Encapsulation ile birleştiğinde,
        //bu sınıf parçalarını belirli iş mantıklarına göre ayrı dosyalarda organize edebiliriz.

    }
    
    // File1.cs
    public partial class Car
    {
        private int speed;

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

// File2.cs
    public partial class Car
    {
        public void Accelerate()
        {
            speed += 10;
        }
    }
}