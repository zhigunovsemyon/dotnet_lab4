namespace Electives
{
	internal class Address : IValidatable
	{
		string region_ = "";
		string city_ = "";
		string street_ = "";
		string house_ = "";
		string building_ = "";

		/// <summary>
		/// Адрес 
		/// </summary>
		/// <param name="region">Административный субъект</param>
		/// <param name="city">Город</param>
		/// <param name="street">Улица</param>
		/// <param name="house">Дом</param>
		/// <param name="building">Номер строения</param>
		public Address(string region, string city, string street,
			string house, string building = "")
		{
			this.region_ = region;
			this.city_ = city;
			this.street_ = street;
			this.house_ = house;
			this.building_ = building;
		}

		/// <summary>
		/// Конструктор пустого адреса
		/// </summary>
		public Address() { }

		public string region
		{
			get => region_;
			set => region_ = value;
		}

		public string city
		{
			get => city_;
			set => city_ = value;
		}

		public string street
		{
			get => street_;
			set => street_ = value;
		}

		public string house
		{
			get => house_;
			set => house_ = value;
		}

		public string building
		{
			get => building_;
			set => building_ = value;
		}

		private bool strings_not_null => building != null
			&& house != null && street != null && region != null;
		
		private bool strings_not_empty => house != ""
			&& street != "" && region != "";

		public bool IsValid => this.strings_not_null && this.strings_not_empty;
	}
}
