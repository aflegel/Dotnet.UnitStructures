using Dotnet.UnitStructures.Distance;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Distance
{
	public class KilometerTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Kilometer test = 10;

			test.Value.Should().Be(10);
		}
		[Fact]
		public void MillimeterConversion()
		{
			Millimeter a = 200;
			Kilometer kilo = a;
			kilo.Value.Should().Be(0.0002);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Centimeter a = 200;
			Kilometer kilo = a;
			kilo.Value.Should().Be(0.002);
		}

		[Fact]
		public void MeterConversion()
		{
			Meter a = 200;
			Kilometer kilo = a;
			kilo.Value.Should().Be(0.2);
		}

		[Fact]
		public void AdditionTest()
		{
			Kilometer a = 20;
			Kilometer b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50.0);
		}

		[Fact]
		public void AdditionMeterTest()
		{
			Kilometer a = 20;
			Meter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(20.03);
		}

		[Fact]
		public void SubtractionTest()
		{
			Kilometer a = 20;
			Kilometer b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionMeterTest()
		{
			Kilometer a = 20;
			Meter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.97);
		}
	}
}
