namespace Encapsulation
{
    public class FluentInterface
    {
        //Fluent Interface, metod zincirleme (method chaining) tekniğini kullanarak nesnelerle daha okunabilir
        //ve akıcı bir şekilde çalışmayı sağlar.
        //Encapsulation ile fluent interface birleştiğinde, sınıfın işlevleri belirli bir sırada çalıştırılabilir
        //ve dış dünyaya yalnızca ihtiyaç duyulan metodlar sunulabilir.
        
        Car2 myCar = new CarBuilder()
            .SetColor("Red")
            .SetEngineType("V8")
            .SetSeats(2)
            .Build();
    }
    
    public class Car2
    {
        public string Color { get; set; }
        public string EngineType { get; set; }
        public int Seats { get; set; }
    }

    public class CarBuilder
    {
        private Car2 car = new Car2();

        public CarBuilder SetColor(string color)
        {
            car.Color = color;
            return this;
        }

        public CarBuilder SetEngineType(string engineType)
        {
            car.EngineType = engineType;
            return this;
        }

        public CarBuilder SetSeats(int seats)
        {
            car.Seats = seats;
            return this;
        }

        public Car2 Build()
        {
            return car;
        }
    }
}