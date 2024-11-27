namespace Encapsulation
{
    public class LazyInitialization
    {
        //Lazy Initialization, bir değişkenin veya nesnenin ilk kez ihtiyaç duyulana kadar başlatılmaması anlamına gelir.
        //Bu yöntem, özellikle bellekte fazla yer kaplayan nesnelerin gerektiğinde oluşturulması için kullanılır.
        //Encapsulation sayesinde, bu tür nesneler sınıf içinde gizli tutularak sadece gerektiğinde yüklenir.
    }
    
    public class ExpensiveResourceHandler
    {
        private ExpensiveResource _resource = null;

        public ExpensiveResource Resource
        {
            get
            {
                if (_resource == null)
                {
                    _resource = new ExpensiveResource();
                }
                return _resource;
            }
        }
    }

    public class ExpensiveResource
    {
    }
}