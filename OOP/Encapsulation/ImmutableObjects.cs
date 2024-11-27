namespace Encapsulation
{
    public class ImmutableObjects
    {
        //Encapsulation, değişkenlerin yalnızca belirli durumlarda değiştirilebilir hale getirilmesi için kullanılır.
        //Ancak bazı durumlarda nesnelerin tamamen sabit kalması gerekebilir.
        //Bu durumlarda “immutable” nesneler yaratılır.
        //Immutable nesneler, oluşturulduktan sonra değerleri değiştirilemez ve encapsulation burada çok önemli bir rol oynar.
        //Immutable nesneler oluşturmak için, sınıfın tüm alanlarını private readonly yaparız ve
        //dışarıdan erişim sağlayacak metodlar veya property’ler sadece getter içerir, setter içermez.
    }
    
    public class ImmutablePerson
    {
        private readonly string name;
        private readonly int age;

        public ImmutablePerson(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => name;
        public int Age => age;
    }
}