namespace Electives
{
	internal class Class
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
	}
}
