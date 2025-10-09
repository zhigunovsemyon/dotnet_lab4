namespace Electives
{
	internal class Class : IValidatable
	{
		/// <summary>
		/// Конструктор пустого предмета
		/// </summary>
		public Class () { }

		/// <summary>
		/// Конструктор предмета
		/// </summary>
		/// <param name="name">Название предмета</param>
		/// <param name="lections">Объём лекционных занятий</param>
		/// <param name="practices">Объём практик</param>
		/// <param name="lab_works">Объём лабораторных работ</param>
		public Class (string name, int lections, int practices, int lab_works)
		{
			this.name = name;
			this.lections = lections;
			this.practices = practices;
			this.lab_works = lab_works;
		}

		/// <summary>
		/// Должно быть имя и хотя бы одно занятие любого типа
		/// </summary>
		public bool IsValid => !(string.IsNullOrWhiteSpace(this.name) ||
					(this.lections + this.lab_works + this.practices) == 0);

		/// <summary>
		/// Название предмета
		/// </summary>
		public string name { get; set; } = "";

		/// <summary>
		/// Количество лекций
		/// </summary>
		public int lections { get; set; } = 0;

		/// <summary>
		/// Количество практик
		/// </summary>
		public int practices { get; set; } = 0;

		/// <summary>
		/// Количество лабораторных работ
		/// </summary>
		public int lab_works { get; set; } = 0;

		public override string ToString ()
		{
			return $"{name}: лекций:{lections}, " +
				$"практик {practices}, " +
				$"лабораторных работ {lab_works}";
		}
	}
}
