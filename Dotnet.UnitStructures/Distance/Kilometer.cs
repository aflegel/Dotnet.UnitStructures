namespace Dotnet.UnitStructures.Distance
{
	public struct Kilometer
	{
		public Kilometer(double value) => Value = value;

		public double Value { get; private set; }

		public static Kilometer operator +(Kilometer term, Millimeter addend) => term + (Kilometer)addend;
		public static Kilometer operator +(Kilometer term, Centimeter addend) => term + (Kilometer)addend;
		public static Kilometer operator +(Kilometer term, Meter addend) => term + (Kilometer)addend;
		public static Kilometer operator +(Kilometer term, Kilometer addend) => new Kilometer(term.Value + addend.Value);

		public static implicit operator Kilometer(double v) => new Kilometer(v);
		public static implicit operator Kilometer(Millimeter v) => (Meter)v;
		public static implicit operator Kilometer(Centimeter v) => (Meter)v;
		public static implicit operator Kilometer(Meter v) => new Kilometer(v.Value / 1000.0);
	}
}
