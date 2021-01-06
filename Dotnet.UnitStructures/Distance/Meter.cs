namespace Dotnet.UnitStructures.Distance
{
	public struct Meter
	{
		public Meter(double value) => Value = value;

		public double Value { get; private set; }

		public static Meter operator +(Meter term, Meter addend) => new Meter(term.Value + addend.Value);
		public static Meter operator +(Meter term, Millimeter addend) => term + (Meter)addend;
		public static Meter operator +(Meter term, Centimeter addend) => term + (Meter)addend;
		public static Meter operator +(Meter term, Kilometer addend) => term + (Meter)addend;

		public static implicit operator Meter(double v) => new Meter(v);
		public static implicit operator Meter(Millimeter v) => new Meter(v.Value / 1000.0);
		public static implicit operator Meter(Centimeter v) => new Meter(v.Value / 100.0);
		public static implicit operator Meter(Kilometer v) => new Meter(v.Value * 1000.0);
	}
}
