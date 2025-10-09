namespace Electives
{
	/// <summary>
	/// Учебный план для студента по предмету
	/// </summary>
	internal class Plan : IValidatable
	{
		/// <summary> Студент </summary>
		public Student Student { get; set; } = new Student();

		/// <summary> Предмет </summary>
		public Class Class { get; set; } = new Class();

		/// <summary> Оценка </summary>
		public Mark Mark { get; set; } = new Mark();

		public override string ToString ()
		{
			return $"{Student}, предмет: {Class.name}, оценка {Mark}";
		}

		public Plan () { }

		/// <summary>Конструктор с уже заданной оценкой</summary>
		/// <param name="st">Студент</param>
		/// <param name="cl">Предмет</param>
		/// <param name="mark">Оценка</param>
		public Plan (Student student, Class cl, Mark mark) 
		{ 
			this.Student = student; 
			this.Class = cl; 
			this.Mark = mark; 
		}

		/// <summary>Конструктор без оценки оценкой</summary>
		/// <param name="st">Студент</param>
		/// <param name="cl">Предмет</param>
		public Plan (Student student, Class cl) 
		{ 
			this.Student = student; 
			this.Class = cl; 
			this.Mark = new Mark(); 
		}

		public bool IsValid => Student.IsValid && Class.IsValid;
	}
}
