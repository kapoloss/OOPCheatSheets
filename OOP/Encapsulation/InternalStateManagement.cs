namespace Encapsulation
{
    public class InternalStateManagement
    {
        //Encapsulation, sınıf içindeki “durum” yönetimini kolaylaştırır.
        //Sınıfın durumu, içindeki alanların değerleriyle belirlenir.
        //Bu durumları yalnızca sınıfın kendisi değiştirebilir veya güncelleyebilir.
        //Bu, özellikle karmaşık sınıflar için önemlidir çünkü belirli işlemler yapılmadan sınıfın durumunun değiştirilmesi,
        //mantıksal hatalara neden olabilir.

        //Örneğin, bir oyun karakterinin “can” (health) ve “zırh” (armor) gibi özellikleri olduğunu düşünelim.
        //Bu özelliklerin birbirine bağımlı olduğunu varsayarsak, encapsulation sayesinde bu durumu kontrollü
        //bir şekilde yönetebiliriz:
    }
    
    public class Character
    {
        private int health;
        private int armor;

        public int Health
        {
            get { return health; }
            private set
            {
                if (value < 0) value = 0;
                health = value;
            }
        }

        public int Armor
        {
            get { return armor; }
            set
            {
                armor = value;
                if (armor < 0) health += armor; // Zırh düşerse can düşer
            }
        }

        public void TakeDamage(int damage)
        {
            if (armor > 0)
            {
                Armor -= damage;
            }
            else
            {
                Health -= damage;
            }
        }
    }
}