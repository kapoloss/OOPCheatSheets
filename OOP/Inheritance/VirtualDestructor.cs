using System;

namespace Inheritance
{
    public class VirtualDestructor
    {
        //C#’ta yıkıcılar (destructors) sanal (virtual) olarak tanımlanmaz,
        //ancak IDisposable arayüzü ile birlikte kullanılabilir.
        //Bir sınıf yıkıcıya sahipse ve bir alt sınıf tarafından kalıtılmışsa,
        //kaynakların doğru yönetimi için Dispose metodu override edilmelidir.
        
        
        //Bu yapı, kalıtım hiyerarşisinde kaynak yönetimini sağlamak için önemlidir
        //ve IDisposable kalıbının doğru kullanımı ile hatasız bir yönetim sağlar.
    }
    
    public class BaseClass : IDisposable
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Serbest bırakılması gereken managed kaynaklar
            }
        }
    }

    public class DerivedClass : BaseClass
    {
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // DerivedClass'a özgü kaynakları serbest bırak
            }
            base.Dispose(disposing);
        }
    }
}