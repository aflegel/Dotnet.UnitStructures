namespace Dotnet.UnitStructures.Distance
{
	public struct Millimeter
	{
		public Millimeter(double value) => Value = value;

		public double Value { get; private set; }

		public static Millimeter operator +(Millimeter term, Centimeter addend) => term + (Millimeter)addend;
		public static Millimeter operator +(Millimeter term, Meter addend) => term + (Millimeter)addend;
		public static Millimeter operator +(Millimeter term, Kilometer addend) => term + (Millimeter)addend;
		public static Millimeter operator +(Millimeter term, Millimeter addend) => new Millimeter(term.Value + addend.Value);

		public static implicit operator Millimeter(double v) => new Millimeter(v);
		public static implicit operator Millimeter(Meter v) => new Millimeter(v.Value * 1000.0);
		public static implicit operator Millimeter(Centimeter v) => (Meter)v;
		public static implicit operator Millimeter(Kilometer v) => (Meter)v;
	}
}
