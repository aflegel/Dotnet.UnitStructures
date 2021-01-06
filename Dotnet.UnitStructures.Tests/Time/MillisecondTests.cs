using Dotnet.UnitStructures.Time;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Time
{
	public class MillisecondTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Millisecond test = 10;

			test.Value.Should().Be(10);
		}
		[Fact]
		public void MillimeterConversion()
		{
			Second a = 200;
			Millisecond kilo = a;
			kilo.Value.Should().Be(0.0002);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Minute a = 200;
			Millisecond kilo = a;
			kilo.Value.Should().Be(0.002);
		}

		[Fact]
		public void MeterConversion()
		{
			Hour a = 200;
			Millisecond kilo = a;
			kilo.Value.Should().Be(0.2);
		}

		[Fact]
		public void AdditionTest()
		{
			Millisecond a = 20;
			Millisecond b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50.0);
		}

		[Fact]
		public void AdditionMeterTest()
		{
			Millisecond a = 20;
			Second b = 30;

			var sum = a + b;

			sum.Value.Should().Be(20.03);
		}

		[Fact]
		public void SubtractionTest()
		{
			Millisecond a = 20;
			Millisecond b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionMeterTest()
		{
			Millisecond a = 20;
			Second b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.97);
		}
	}
}
