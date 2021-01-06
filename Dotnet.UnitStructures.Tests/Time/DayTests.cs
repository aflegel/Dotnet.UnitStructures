using Dotnet.UnitStructures.Time;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Time
{
	public class DayTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Day test = 10;
			test.Value.Should().Be(10);
		}

		[Fact]
		public void MillimeterConversion()
		{
			Second test = 2000;
			Day value = test;

			value.Value.Should().BeApproximately(0.02314815, 8);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Minute test = 200;
			Day value = test;

			value.Value.Should().Be(0.138889);
		}

		[Fact]
		public void KilometerConversion()
		{
			Hour test = 24;
			Day value = test;

			value.Value.Should().Be(1);
		}

		[Fact]
		public void AdditionTest()
		{
			Day a = 20;
			Day b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMillimeterTest()
		{
			Day a = 20;
			Millisecond b = 300;

			var sum = a + b;

			sum.Value.Should().Be(20.3);
		}

		[Fact]
		public void AdditionCentimeterTest()
		{
			Day a = 20;
			Second b = 300;

			var sum = a + b;

			sum.Value.Should().Be(23);
		}

		[Fact]
		public void SubtractionTest()
		{
			Day a = 20;
			Day b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionCentimeterTest()
		{
			Day a = 20;
			Hour b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.7);
		}

		[Fact]
		public void SubtractionMilliimeterTest()
		{
			Day a = 20;
			Second b = 30;

			var sum = a - b;

			sum.Value.Should().Be(19.97);
		}
	}
}
