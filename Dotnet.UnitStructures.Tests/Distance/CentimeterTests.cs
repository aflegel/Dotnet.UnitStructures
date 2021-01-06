using Dotnet.UnitStructures.Distance;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Distance
{
	public class CentimeterTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Centimeter test = 10;

			test.Value.Should().Be(10);
		}

		[Fact]
		public void MillimeterConversion()
		{
			Millimeter a = 200;
			Centimeter kilo = a;
			kilo.Value.Should().Be(20);
		}

		[Fact]
		public void MeterConversion()
		{
			Meter a = 200;
			Centimeter kilo = a;
			kilo.Value.Should().Be(20000);
		}

		[Fact]
		public void KilometerConversion()
		{
			Kilometer a = 2;
			Centimeter kilo = a;
			kilo.Value.Should().Be(200000);
		}

		[Fact]
		public void AdditionTest()
		{
			Centimeter a = 20;
			Centimeter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Centimeter a = 20;
			Millimeter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(23);
		}

		[Fact]
		public void AdditionMeterTest()
		{
			Centimeter a = 20;
			Meter b = 1;

			var sum = a + b;

			sum.Value.Should().Be(120);
		}

		[Fact]
		public void SubtractionTest()
		{
			Centimeter a = 20;
			Centimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionMillimeterTest()
		{
			Centimeter a = 20;
			Millimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(17);
		}
	}
}
