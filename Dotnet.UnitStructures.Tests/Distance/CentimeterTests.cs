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
		public void SumTest()
		{
			Centimeter a = 20;
			Centimeter b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50.0);
		}
	}
}
