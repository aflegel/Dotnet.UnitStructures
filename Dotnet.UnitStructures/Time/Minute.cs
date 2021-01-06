namespace Dotnet.UnitStructures.Time
{
	public struct Minute
	{
		public Minute(double value) => Value = value;

		public double Value { get; private set; }

		public static Minute operator +(Minute term, Millisecond addend) => term + (Minute)addend;
		public static Minute operator +(Minute term, Second addend) => term + (Minute)addend;
		public static Minute operator +(Minute term, Hour addend) => term + (Minute)addend;
		public static Minute operator +(Minute term, Day addend) => term + (Minute)addend;
		public static Minute operator +(Minute term, Minute addend) => new Minute(term.Value + addend.Value);

		public static Minute operator -(Minute term, Millisecond subend) => term - (Minute)subend;
		public static Minute operator -(Minute term, Second subend) => term - (Minute)subend;
		public static Minute operator -(Minute term, Hour subend) => term - (Minute)subend;
		public static Minute operator -(Minute term, Day subend) => term - (Minute)subend;
		public static Minute operator -(Minute term, Minute subend) => new Minute(term.Value - subend.Value);

		public static implicit operator Minute(double v) => new Minute(v);
		public static implicit operator Minute(Millisecond v) => (Second)v;
		public static implicit operator Minute(Second v) => new Minute(v.Value / 60.0);
		public static implicit operator Minute(Hour v) => (Second)v;
		public static implicit operator Minute(Day v) => (Second)v;
	}
}
