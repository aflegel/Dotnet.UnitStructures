namespace Dotnet.UnitStructures.Distance
{
	public struct Centimeter
	{
		public Centimeter(double value) => Value = value;

		public double Value { get; private set; }

		public static Centimeter operator +(Centimeter term, Millimeter addend) => term + (Centimeter)addend;
		public static Centimeter operator +(Centimeter term, Meter addend) => term + (Centimeter)addend;
		public static Centimeter operator +(Centimeter term, Kilometer addend) => term + (Centimeter)addend;
		public static Centimeter operator +(Centimeter term, Centimeter addend) => new Centimeter(term.Value + addend.Value);

		public static Centimeter operator -(Centimeter term, Millimeter subend) => term - (Centimeter)subend;
		public static Centimeter operator -(Centimeter term, Meter subend) => term - (Centimeter)subend;
		public static Centimeter operator -(Centimeter term, Kilometer subend) => term - (Centimeter)subend;
		public static Centimeter operator -(Centimeter term, Centimeter subend) => new Centimeter(term.Value - subend.Value);

		public static implicit operator Centimeter(double v) => new Centimeter(v);
		public static implicit operator Centimeter(Millimeter v) => (Meter)v;
		public static implicit operator Centimeter(Meter v) => new Centimeter(v.Value * 100.0);
		public static implicit operator Centimeter(Kilometer v) => (Meter)v;
	}
}
