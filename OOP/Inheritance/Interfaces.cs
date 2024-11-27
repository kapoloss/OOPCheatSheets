using System;

namespace Inheritance
{
    public class Interfaces
    {
        //Kalıtım, bir sınıfın yalnızca bir başka sınıftan türemesine izin verirken (C#’ta çoklu kalıtımı desteklemez),
        //birden fazla arayüzü (interface) uygulayabilir.
        //Bu, çoklu kalıtıma olanak tanıyarak sınıfların birden fazla davranışı devralmasına yardımcı olur.
    }
    
    public interface IMoveable
    {
        void Move();
    }

    public interface IJumpable
    {
        void Jump();
    }

    public class Animal2 : IMoveable, IJumpable
    {
        public void Move() { Console.WriteLine("Moving"); }
        public void Jump() { Console.WriteLine("Jumping"); }
    }
}