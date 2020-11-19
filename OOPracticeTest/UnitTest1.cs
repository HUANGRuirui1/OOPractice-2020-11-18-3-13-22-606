namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_Car_Speedup_With_Name_Speed_ElectricEngine()
        {
            // given
            var car = new Car("Cool Car", new ElectricEngine());
            // when
            string expected = "Cool Car: speed up 25 km/h";
            string actual = car.SpeedUp();
            // then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Truck_Speedup_With_Name_Speed_ElectricEngine()
        {
            // given
            var truck = new Truck("Big Truck", new ElectricEngine());
            // when
            string expected = "Big Truck: speed up 25 km/h";
            string actual = truck.SpeedUp();
            // then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Driver_When_Speedup_Drive_Car_ElectricEngine()
        {
            // given
            var car = new Car("Cool Car", new ElectricEngine());
            var driver = new Driver(car);
            // when
            string expected = "Cool Car: speed up 25 km/h";
            string actual = driver.SpeedUp();
            // then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Should_Driver_When_Speedup_Drive_Truck_GasolineEngine()
        {
            // given
            var car = new Car("Big Truck", new GasolineEngine());
            var driver = new Driver(car);
            // when
            string expected = "Big Truck: speed up 30 km/h";
            string actual = driver.SpeedUp();
            // then
            Assert.Equal(expected, actual);
        }
    }
}
