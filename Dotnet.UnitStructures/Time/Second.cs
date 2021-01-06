namespace Dotnet.UnitStructures.Time
{
	public struct Second
	{
		public Second(double value) => Value = value;

		public double Value { get; private set; }

		public static Second operator +(Second term, Millisecond addend) => term + (Second)addend;
		public static Second operator +(Second term, Minute addend) => term + (Second)addend;
		public static Second operator +(Second term, Hour addend) => term + (Second)addend;
		public static Second operator +(Second term, Day addend) => term + (Second)addend;
		public static Second operator +(Second term, Second addend) => new Second(term.Value + addend.Value);

		public static Second operator -(Second term, Millisecond subend) => term - (Second)subend;
		public static Second operator -(Second term, Minute subend) => term - (Second)subend;
		public static Second operator -(Second term, Hour subend) => term - (Second)subend;
		public static Second operator -(Second term, Day subend) => term - (Second)subend;
		public static Second operator -(Second term, Second subend) => new Second(term.Value - subend.Value);

		public static implicit operator Second(double v) => new Second(v);
		public static implicit operator Second(Millisecond v) => new Second(v.Value / 1000.0);
		public static implicit operator Second(Minute v) => new Second(v.Value * 60.0);
		public static implicit operator Second(Hour v) => new Second(v.Value * 3600.0);
		public static implicit operator Second(Day v) => new Second(v.Value * 86400.0);
	}
}
