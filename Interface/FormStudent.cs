namespace Interface
{
	/// <summary> Форма изменения данных о студенте </summary>
	public partial class FormStudent : Form
	{
		/// <summary> Конструктор формы </summary>
		/// <param name="student">Обрабатываемый студент</param>
		public FormStudent(Electives.Student student)
		{
			InitializeComponent();
			this.Student = student;		
		}

		/// <summary>
		/// Метод, наполняющий все поля формы данными из переданного студента.
		/// Вызывается автоматически при запуске формы
		/// </summary>
		private void SetBoxes(object sender, EventArgs e)
		{
			this.TextBoxSurname.Text = this.Student.Surname;
			this.TextBoxName.Text = this.Student.Name;
			this.TextBoxPatronim.Text = this.Student.Patronim;
			this.TextBoxPhone.Text = this.Student.Phone;

			this.TextBoxRegion.Text = this.Student.Address.region;
			this.TextBoxCity.Text = this.Student.Address.city;
			this.TextBoxStreet.Text = this.Student.Address.street;
			this.TextBoxHouse.Text = this.Student.Address.house;
			this.TextBoxBuilding.Text = this.Student.Address.building;
		}

		/// <summary>
		/// Метод, заполняющий свойства студента данными из полей формы.
		/// Вызывается при нажатии пользователем кнопки "ОК"
		/// </summary>
		private void GetFromBoxes()
		{
			this.Student.Surname = this.TextBoxSurname.Text;
			this.Student.Name = this.TextBoxName.Text;
			this.Student.Patronim = this.TextBoxPatronim.Text;
			this.Student.Phone = this.TextBoxPhone.Text;

			this.Student.Address.region = this.TextBoxRegion.Text;
			this.Student.Address.city = this.TextBoxCity.Text;
			this.Student.Address.street = this.TextBoxStreet.Text;
			this.Student.Address.house = this.TextBoxHouse.Text;
			this.Student.Address.building = this.TextBoxBuilding.Text;
		}

		/// <summary> Обрабатываемый формой студент </summary>
		public Electives.Student Student { get; private set; }

		/// <summary> Обработчик нажатия на кнопку "ОК" </summary>
		private void ok_button_Click(object sender, EventArgs e)
		{
			GetFromBoxes();
			Close();
		}

		/// <summary>
		/// Обработчик по завершению изменения поля формы.
		/// Убирает в каждом текстовом поле пробелы перед и после содержимым.
		/// </summary>
		private void TextBoxTrimAll(object sender, EventArgs e)
		{
			this.TextBoxSurname.Text = this.TextBoxSurname.Text.Trim();
			this.TextBoxName.Text = this.TextBoxName.Text.Trim();
			this.TextBoxPatronim.Text = this.TextBoxPatronim.Text.Trim();
			this.TextBoxPhone.Text = this.TextBoxPhone.Text.Trim();

			this.TextBoxRegion.Text = this.TextBoxRegion.Text.Trim();
			this.TextBoxCity.Text = this.TextBoxCity.Text.Trim();
			this.TextBoxStreet.Text = this.TextBoxStreet.Text.Trim();
			this.TextBoxHouse.Text = this.TextBoxHouse.Text.Trim();
			this.TextBoxBuilding.Text = this.TextBoxBuilding.Text.Trim();
		}
	}

}
