namespace Dotnet.UnitStructures.Time
{
	public struct Millisecond
	{
		public Millisecond(double value) => Value = value;

		public double Value { get; private set; }

		public static Millisecond operator +(Millisecond term, Second addend) => term + (Millisecond)addend;
		public static Millisecond operator +(Millisecond term, Minute addend) => term + (Millisecond)addend;
		public static Millisecond operator +(Millisecond term, Hour addend) => term + (Millisecond)addend;
		public static Millisecond operator +(Millisecond term, Day addend) => term + (Millisecond)addend;
		public static Millisecond operator +(Millisecond term, Millisecond addend) => new Millisecond(term.Value + addend.Value);

		public static Millisecond operator -(Millisecond term, Second subend) => term - (Millisecond)subend;
		public static Millisecond operator -(Millisecond term, Minute subend) => term - (Millisecond)subend;
		public static Millisecond operator -(Millisecond term, Hour subend) => term - (Millisecond)subend;
		public static Millisecond operator -(Millisecond term, Day subend) => term - (Millisecond)subend;
		public static Millisecond operator -(Millisecond term, Millisecond subend) => new Millisecond(term.Value - subend.Value);

		public static implicit operator Millisecond(double v) => new Millisecond(v);
		public static implicit operator Millisecond(Second v) => new Millisecond(v.Value * 1000.0);
		public static implicit operator Millisecond(Minute v) => (Second)v;
		public static implicit operator Millisecond(Hour v) => (Second)v;
		public static implicit operator Millisecond(Day v) => (Second)v;
	}
}
