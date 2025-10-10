namespace Electives
{
	public class Address : IValidatable
	{
		/// <summary>
		/// Адрес 
		/// </summary>
		/// <param name="region">Административный субъект</param>
		/// <param name="city">Город</param>
		/// <param name="street">Улица</param>
		/// <param name="house">Дом</param>
		/// <param name="building">Номер строения</param>
		public Address (string region, string city, string street,
			string house, string building = "")
		{
			this.region = region;
			this.city = city;
			this.street = street;
			this.house = house;
			this.building = building;
		}

		/// <summary>
		/// Конструктор пустого адреса
		/// </summary>
		public Address () { }

		public string region { get; set; } = "";

		public string city { get; set; } = "";

		public string street { get; set; } = "";

		public string house { get; set; } = "";

		public string building { get; set; } = "";

		public bool IsValid => !(string.IsNullOrWhiteSpace(region) ||
			string.IsNullOrWhiteSpace(city) ||
			string.IsNullOrWhiteSpace(street) ||
			string.IsNullOrWhiteSpace(house) ||
			(building == null));

		/// <summary>Создание копии данного адреса</summary>
		/// <returns>Копия исходного адреса</returns>
		public Address clone ()
		{
			return new Address
			{
				region = this.region,
				city = this.city,
				street = this.street,
				house = this.house,
				building = this.building
			};
		}
	}
}
