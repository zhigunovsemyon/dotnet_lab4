namespace Electives
{
	/// <summary>Оценка</summary>
	public class Mark
	{
		public enum Type : byte
		{
			/// <summary>Пустая ячейка</summary>
			None,
			/// <summary>Пропуск</summary>
			Skip,
			/// <summary>Два</summary>
			Two,
			/// <summary>Три</summary>
			Three,
			/// <summary>Четыре</summary>
			Four,
			/// <summary>Пять</summary>
			Five,
			/// <summary>Особое отличие</summary>
			Extra
		}

		public Type value { get; set; } = Type.None;

		public override string ToString()
		{
			return value switch
			{
				Type.None => " ",
				Type.Skip => "н",
				Type.Two => "2",
				Type.Three => "3",
				Type.Four => "4",
				Type.Five => "5",
				Type.Extra => "5*",
				_ => throw new NotImplementedException()
			};
		}

	};
}
