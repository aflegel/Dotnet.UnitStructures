using Dotnet.UnitStructures.Time;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Time
{
	public class HourTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Hour test = 10;
			test.Value.Should().Be(10);
		}

		[Fact]
		public void MillimeterConversion()
		{
			Millisecond test = 200;
			Hour value = test;

			value.Value.Should().Be(0.2);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Second test = 200;
			Hour value = test;

			value.Value.Should().Be(2);
		}

		[Fact]
		public void KilometerConversion()
		{
			Minute test = 2;
			Hour value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void AdditionTest()
		{
			Hour a = 20;
			Hour b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Hour a = 20;
			Millisecond b = 300;

			var sum = a + b;

			sum.Value.Should().Be(20.3);
		}

		[Fact]
		public void AdditionCentimeterTest()
		{
			Hour a = 20;
			Second b = 300;

			var sum = a + b;

			sum.Value.Should().Be(23);
		}

		[Fact]
		public void SubtractionTest()
		{
			Hour a = 20;
			Hour b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionCentimeterTest()
		{
			Hour a = 20;
			Minute b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.7);
		}

		[Fact]
		public void SubtractionMilliimeterTest()
		{
			Hour a = 20;
			Day b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.97);
		}
	}
}
