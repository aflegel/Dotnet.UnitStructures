namespace Dotnet.UnitStructures.Time
{
	public struct Day
	{
		public Day(double value) => Value = value;

		public double Value { get; private set; }

		public static Day operator +(Day term, Millisecond addend) => term + (Day)addend;
		public static Day operator +(Day term, Second addend) => term + (Day)addend;
		public static Day operator +(Day term, Minute addend) => term + (Day)addend;
		public static Day operator +(Day term, Hour addend) => term + (Day)addend;
		public static Day operator +(Day term, Day addend) => new Day(term.Value + addend.Value);

		public static Day operator -(Day term, Millisecond subend) => term - (Day)subend;
		public static Day operator -(Day term, Second subend) => term - (Day)subend;
		public static Day operator -(Day term, Minute subend) => term - (Day)subend;
		public static Day operator -(Day term, Hour subend) => term - (Day)subend;
		public static Day operator -(Day term, Day subend) => new Day(term.Value - subend.Value);

		public static implicit operator Day(double v) => new Day(v);
		public static implicit operator Day(Millisecond v) => (Second)v;
		public static implicit operator Day(Minute v) => (Second)v;
		public static implicit operator Day(Hour v) => (Second)v;
		public static implicit operator Day(Second v) => new Day(v.Value / 86400.0);
	}
}
