using Dotnet.UnitStructures.Time;
using FluentAssertions;
using Xunit;

namespace Dotnet.UnitStructures.Tests.Time
{
	public class MinuteTests
	{
		[Fact]
		public void DecimalConversion()
		{
			Minute test = 10;
			test.Value.Should().Be(10);
		}

		[Fact]
		public void CentimeterConversion()
		{
			Second test = 200;
			Minute value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void MeterConversion()
		{
			Hour test = 2;
			Minute value = test;

			value.Value.Should().Be(2000);
		}

		[Fact]
		public void KilometerConversion()
		{
			Day test = 2;
			Minute value = test;

			value.Value.Should().Be(2000000);
		}

		[Fact]
		public void AdditionTest()
		{
			Minute a = 20;
			Minute b = 30;

			var sum = a + b;

			sum.Value.Should().Be(50);
		}

		[Fact]
		public void AdditionMinuteTest()
		{
			Minute a = 200;
			Second b = 30;

			var sum = a + b;

			sum.Value.Should().Be(30200);
		}

		[Fact]
		public void AdditionCentimeterTest()
		{
			Minute a = 20;
			Hour b = 300;

			var sum = a + b;

			sum.Value.Should().Be(30020);
		}

		[Fact]
		public void AdditionKilometerTest()
		{
			Minute a = 20;
			Day b = 3;

			var sum = a + b;

			sum.Value.Should().Be(300020);
		}

		[Fact]
		public void SubtractionTest()
		{
			Minute a = 20;
			Minute b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-10);
		}

		[Fact]
		public void SubtractionCentimeterTest()
		{
			Minute a = 200;
			Millisecond b = 30;

			var sum = a - b;

			sum.Value.Should().Be(-100);
		}

		[Fact]
		public void SubtractionMeterTest()
		{
			Minute a = 200;
			Second b = 3;

			var sum = a - b;

			sum.Value.Should().Be(-2800);
		}
	}
}
