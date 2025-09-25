/*    
    1. Работодатели (название, вид деятельности, адрес, телефон).
    2. Соискатели (фамилия, имя, отчество, квалификация, вид деятельности, иные данные, предполагаемый размер заработной платы).
    3. Сделки (работодатель, соискатель, должность, комиссионные).
*/

namespace EmploymentBureau
{
	interface IValidatable
	{
		bool IsValid { get; }
	}

	public class Address
	{
		string region_;
		string city_;
		string street_;
		string house_;
		string building_;

		/// <summary>
		/// Адрес 
		/// </summary>
		/// <param name="region">Административный субъект</param>
		/// <param name="city">Город</param>
		/// <param name="street">Улица</param>
		/// <param name="house">Дом</param>
		/// <param name="building">Номер строения</param>
		Address (string region, string city, string street, 
			string house, string building = "")
		{
			this.region_ = region;
			this.city_ = city;
			this.street_ = street;
			this.house_ = house;
			this.building_ = building;
		}
		
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

		public override string ToString() 
		{
			var building_str = (building != "") ? $" Строение {building}" : "";
			return region + ' ' + city + ' ' + street + " " + house + building_str );
		}
	}

	public class Employee : IValidatable
	{
		Employee() { }
	}

	public class Applicant : IValidatable
	{
		Applicant() { }
	}

	public class Deal : IValidatable
	{
		Deal() { }
	}
}
