namespace Polymorphism
{
    public class Compile_Time
    {
        //Bu tür polymorphism, derleme zamanında belirlenir.
        //Aynı ada sahip metodların, farklı parametrelerle tanımlanması ile elde edilir.
        //Method Overloading (Metod Aşırı Yükleme) ve Operator Overloading (Operatör Aşırı Yükleme),
        //compile-time polymorphism örnekleridir.

    }
    
    //Method Overloading:
    //Aynı isimdeki metodları, farklı parametre sayısı veya türleriyle yeniden tanımlamaktır.
    //Bu sayede, metodun adı aynı kalırken, parametre türüne göre farklı davranışlar gösterir.
    
    public class MathOperations
    {
        public int Add(int a, int b) => a + b;
        public double Add(double a, double b) => a + b;
    }
    
    //Operator Overloading:
    //Operatörleri, kullanıcı tanımlı türlerde farklı işlevsellik gösterecek şekilde yeniden tanımlamaktır.
    //Örneğin, + operatörünü bir Vector sınıfında iki vektörün toplamı olarak işlevlendirebiliriz.
    
    public class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        
        // burada + operatörünü özelleştiriyoruz. vectorler toplandığında bu işlem yapılacak
    }
}