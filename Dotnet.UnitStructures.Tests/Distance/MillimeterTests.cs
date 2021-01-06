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
		public void SumTest()
		{
			Millimeter a = 20;
			Millimeter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void SumMillimeterTest()
		{
			Millimeter a = 200;
			Meter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(30200);
		}

		[Fact]
		public void SumCentimeterTest()
		{
			Centimeter a = 20;
			Meter b = 300;

			var sum = a + b;

			sum.Value.Should().Be(30020);
		}

		[Fact]
		public void SumKilometerTest()
		{
			Centimeter a = 20;
			Kilometer b = 3;

			var sum = a + b;

			sum.Value.Should().Be(300020);
		}
	}
}
