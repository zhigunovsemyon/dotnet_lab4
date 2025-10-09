namespace Electives
{
	internal class Class : IValidatable
	{
		string name_ = "";
		int lections_ = 0;
		int practices_ = 0;
		int lab_works_ = 0;

		/// <summary>
		/// Конструктор пустого предмета
		/// </summary>
		public Class() { }

		/// <summary>
		/// Конструктор предмета
		/// </summary>
		/// <param name="name">Название предмета</param>
		/// <param name="lections">Объём лекционных занятий</param>
		/// <param name="practices">Объём практик</param>
		/// <param name="lab_works">Объём лабораторных работ</param>
		public Class(string name, int lections, int practices, int lab_works)
		{
			this.name_ = name;
			this.lections_ = lections;
			this.practices_ = practices;
			this.lab_works_ = lab_works;
		}

		/// <summary>
		/// Должно быть имя и хотя бы одно занятие любого типа
		/// </summary>
		public bool IsValid => !(string.IsNullOrWhiteSpace(this.name) ||
					(this.lections + this.lab_works + this.practices) == 0);

		/// <summary>
		/// Название предмета
		/// </summary>
		public string name { get => name_; set => name_ = value; }

		/// <summary>
		/// Количество лекций
		/// </summary>
		public int lections { get => lections_; set => lections_ = value; }

		/// <summary>
		/// Количество практик
		/// </summary>
		public int practices { get => practices_; set => practices_ = value; }

		/// <summary>
		/// Количество лабораторных работ
		/// </summary>
		public int lab_works { get => lab_works_; set => lab_works_ = value; }

		public override string ToString()
		{
			return $"{name}: лекций:{lections}, " +
				$"практик {practices}, " +
				$"лабораторных работ {lab_works}";
		}
	}
}
