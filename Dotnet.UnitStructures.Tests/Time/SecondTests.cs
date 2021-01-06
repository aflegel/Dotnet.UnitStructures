using Dotnet.UnitStructures.Time;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Time
{
	public class SecondTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Second test = 10;

			test.Value.Should().Be(10);
		}

		[Fact]
		public void MillimeterConversion()
		{
			Millisecond a = 200;
			Second kilo = a;
			kilo.Value.Should().Be(20);
		}

		[Fact]
		public void MeterConversion()
		{
			Minute a = 200;
			Second kilo = a;
			kilo.Value.Should().Be(20000);
		}

		[Fact]
		public void KilometerConversion()
		{
			Hour a = 2;
			Second kilo = a;
			kilo.Value.Should().Be(200000);
		}

		[Fact]
		public void AdditionTest()
		{
			Second a = 20;
			Second b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Second a = 20;
			Millisecond b = 30;

			var sum = a + b;

			sum.Value.Should().Be(23);
		}

		[Fact]
		public void AdditionMeterTest()
		{
			Second a = 20;
			Minute b = 1;

			var sum = a + b;

			sum.Value.Should().Be(120);
		}

		[Fact]
		public void SubtractionTest()
		{
			Second a = 20;
			Second b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionMillimeterTest()
		{
			Second a = 20;
			Millisecond b = 30;

			var sum = a - b;

			sum.Value.Should().Be(17);
		}
	}
}
