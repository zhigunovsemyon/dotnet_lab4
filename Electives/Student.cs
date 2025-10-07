namespace Electives
{
	internal class Student : IValidatable
	{
		string name_ = "";
		string surname_ = "";
		string patronim_ = "";
		string phone_ = "";
		Address address_ = new();

		/// <summary>
		/// Пустой конструтор студента
		/// </summary>
		public Student() { }

		/// <summary>
		/// Конструктор студента с параметрами
		/// </summary>
		/// <param name="address">Адрес</param>
		/// <param name="phone">Телефон</param>
		/// <param name="name">Имя</param>
		/// <param name="surname">Фамилия</param>
		/// <param name="patronim">Отчество (опционально)</param>
		public Student(Address address, string phone, string name,
			string surname, string patronim = "")
		{
			this.name_ = name;
			this.surname_ = surname;
			this.patronim_ = patronim;
			this.phone_ = phone;
			this.address_ = address;
		}
		private bool null_valid => name_ != null && surname_ != null
			&& phone_ != null && patronim_ != null;

		private bool empty_valid => name_ != "" && surname_ != "" && phone_ != "";

		public bool IsValid
		{
			get
			{
				if (this.null_valid)
					return this.empty_valid && address_.IsValid;
				else 
					return false;
			}
		}

		/// <summary>
		/// Имя студента
		/// </summary>
		public string Name { get => name_; set => name_ = value; }

		/// <summary>
		/// Фамилия студента
		/// </summary>
		public string Surname { get => surname_; set => surname_ = value; }

		/// <summary>
		/// Отчество студента
		/// </summary>
		public string Patronim { get => patronim_; set => patronim_ = value; }

		/// <summary>
		/// Адрес студента
		/// </summary>
		public Address Address { get => address_; set => address_ = value; }

		/// <summary>
		/// Телефон студента
		/// </summary>
		public string Phone { get => phone_; set => phone_ = value; }

		public override string ToString()
			=> $"{Surname} {Name} {Patronim} {Phone} {Address}";
	}
}
