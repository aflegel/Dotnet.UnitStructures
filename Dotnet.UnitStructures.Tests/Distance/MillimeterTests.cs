using Dotnet.UnitStructures.Distance;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Distance
{
	public class MillimeterTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Millimeter test = 10;
			test.Value.Should().Be(10);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Centimeter test = 200;
			Millimeter value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void MeterConversion()
		{
			Meter test = 2;
			Millimeter value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void KilometerConversion()
		{
			Kilometer test = 2;
			Millimeter value = test;

			value.Value.Should().Be(2000000);
		}

		[Fact]
		public void AdditionTest()
		{
			Millimeter a = 20;
			Millimeter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Millimeter a = 200;
			Meter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(30200);
		}

		[Fact]
		public void AdditionCentimeterTest()
		{
			Centimeter a = 20;
			Meter b = 300;

			var sum = a + b;

			sum.Value.Should().Be(30020);
		}

		[Fact]
		public void AdditionKilometerTest()
		{
			Centimeter a = 20;
			Kilometer b = 3;

			var sum = a + b;

			sum.Value.Should().Be(300020);
		}

		[Fact]
		public void SubtractionTest()
		{
			Millimeter a = 20;
			Millimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionCentimeterTest()
		{
			Millimeter a = 200;
			Centimeter b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-100);
		}

		[Fact]
		public void SubtractionMeterTest()
		{
			Millimeter a = 200;
			Meter b = 3;

			var sum = a - b;

			sum.Value.Should().Be(-2800);
		}
	}
}
