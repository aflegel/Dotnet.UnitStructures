namespace Dotnet.UnitStructures.Time
{
	public struct Hour
	{
		public Hour(double value) => Value = value;

		public double Value { get; private set; }

		public static Hour operator +(Hour term, Millisecond addend) => term + (Hour)addend;
		public static Hour operator +(Hour term, Second addend) => term + (Hour)addend;
		public static Hour operator +(Hour term, Minute addend) => term + (Hour)addend;
		public static Hour operator +(Hour term, Day addend) => term + (Hour)addend;
		public static Hour operator +(Hour term, Hour addend) => new Hour(term.Value + addend.Value);

		public static Hour operator -(Hour term, Millisecond subend) => term - (Hour)subend;
		public static Hour operator -(Hour term, Second subend) => term - (Hour)subend;
		public static Hour operator -(Hour term, Minute subend) => term - (Hour)subend;
		public static Hour operator -(Hour term, Day subend) => term - (Hour)subend;
		public static Hour operator -(Hour term, Hour subend) => new Hour(term.Value - subend.Value);

		public static implicit operator Hour(double v) => new Hour(v);
		public static implicit operator Hour(Millisecond v) => (Second)v;
		public static implicit operator Hour(Second v) => new Hour(v.Value / 3600.0);
		public static implicit operator Hour(Minute v) => (Second)v;
		public static implicit operator Hour(Day v) => (Second)v;
	}
}
