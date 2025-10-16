namespace Interface
{
	/// <summary> Форма изменения информации о занятии </summary>
	public partial class ClassEditForm : Form
	{
		/// <summary> Конструктор формы </summary>
		/// <param name="class">Обрабатываемое занятие</param>
		public ClassEditForm(Electives.Class @class)
		{
			InitializeComponent();
			this.Class = @class;
		}

		/// <summary>
		/// Обработчик по запуске формы. 
		/// Наполняет поля формы данными из предмета, переданного в конструкторе
		/// </summary>
		private void SetBoxes(object sender, EventArgs e)
		{
			this.TextBoxName.Text = this.Class.Name;
			this.NumericUpDownLectionsInput.Value = this.Class.Lections;
			this.NumericUpDownPracticeInput.Value = this.Class.Practices;
			this.NumericUpDownLabsInput.Value = this.Class.LabWorks;
		}

		/// <summary>
		/// Метод, заполняющий свойства предмета данными из полей формы.
		/// Вызывается при нажатии пользователем кнопки "ОК"
		/// </summary>
		private void GetFromBoxes()
		{
			this.Class.Name = this.TextBoxName.Text;
			this.Class.Lections = ((int)this.NumericUpDownLectionsInput.Value);
			this.Class.Practices = ((int)this.NumericUpDownPracticeInput.Value);
			this.Class.LabWorks = ((int)this.NumericUpDownLabsInput.Value);
		}

		/// <summary> Свойство с занятием, обрабатываемым данной формой </summary>
		public Electives.Class Class { get; set; }

		/// <summary> Обработчик нажатия пользователем клавиши "ОК" </summary>
		private void OkButton_Click(object sender, EventArgs e)
		{
			GetFromBoxes();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// Очистка поля названия предмета от пробелов в начале и конце.
		/// Вызывается при завершении работы с полем
		/// </summary>
		private void ClassNameBox_LostFocus(object sender, EventArgs e)
		{
			this.TextBoxName.Text = this.TextBoxName.Text.Trim();
		}
	}
}
