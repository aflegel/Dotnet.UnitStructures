using Dotnet.UnitStructures.Distance;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Distance
{
	public class MeterTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Meter test = 10;
			test.Value.Should().Be(10);
		}

		[Fact]
		public void MillimeterConversion()
		{
			Millimeter test = 200;
			Meter value = test;

			value.Value.Should().Be(0.2);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Centimeter test = 200;
			Meter value = test;

			value.Value.Should().Be(2);
		}

		[Fact]
		public void KilometerConversion()
		{
			Kilometer test = 2;
			Meter value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void AdditionTest()
		{
			Meter a = 20;
			Meter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Meter a = 20;
			Millimeter b = 300;

			var sum = a + b;

			sum.Value.Should().Be(20.3);
		}

		[Fact]
		public void AdditionCentimeterTest()
		{
			Meter a = 20;
			Centimeter b = 300;

			var sum = a + b;

			sum.Value.Should().Be(23);
		}

		[Fact]
		public void SubtractionTest()
		{
			Meter a = 20;
			Meter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionCentimeterTest()
		{
			Meter a = 20;
			Centimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.7);
		}

		[Fact]
		public void SubtractionMilliimeterTest()
		{
			Meter a = 20;
			Millimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.97);
		}
	}
}
