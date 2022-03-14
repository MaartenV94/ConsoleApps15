//using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppTest
{
   // [TestClass]

    public class App01Test
    {

        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.toDistance);

        }

        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.FEET;
            converter.toUnit = DistanceConverter.MILES;

            converter.fromDistance = 5280;
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

        public void TestMilesToMeters()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.MILES;
            converter.toUnit = DistanceConverter.METERS;

            converter.fromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, converter.toDistance);
        }

        public void TestMetersToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.METERS;
            converter.toUnit = DistanceConverter.MILES;

            converter.fromDistance = 1609.34;
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.toDistance);

        }

        public void TestMetersToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.METERS;
            converter.toUnit = DistanceConverter.FEET;

            converter.fromDistance = 1.0;
            converter.CalculateDistance();

            double expectedDistance = 3.28084;

            Assert.AreEqual(expectedDistance, converter.toDistance);

        }

        public void TestFeetToMeters()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.fromUnit = DistanceConverter.FEET;
            converter.toUnit = DistanceConverter.METERS;

            converter.fromDistance = 3.28084;
            converter.CalculateDistance();

            double expectedDistance = 1.0;

            Assert.AreEqual(expectedDistance, converter.toDistance);

        }
    }
}