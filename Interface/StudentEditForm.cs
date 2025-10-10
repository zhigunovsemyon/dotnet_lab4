namespace Interface
{
	public partial class StudentEditForm : Form
	{
		public StudentEditForm(Electives.Student student)
		{
			InitializeComponent();
			this.student = student;		
			set_boxes();			
		}

		private void set_boxes()
		{
			this.SurnameBox.Text = this.student.Surname;
			this.NameBox.Text = this.student.Name;
			this.PatronimBox.Text = this.student.Patronim;
			this.PhoneBox.Text = this.student.Phone;

			this.RegionBox.Text = this.student.Address.region;
			this.CityBox.Text = this.student.Address.city;
			this.StreetBox.Text = this.student.Address.street;
			this.HouseBox.Text = this.student.Address.house;
			this.BuildingBox.Text = this.student.Address.building;
		}
		private void get_from_boxes()
		{
			this.student.Surname = this.SurnameBox.Text;
			this.student.Name = this.NameBox.Text;
			this.student.Patronim = this.PatronimBox.Text;
			this.student.Phone = this.PhoneBox.Text;

			this.student.Address.region = this.RegionBox.Text;
			this.student.Address.city = this.CityBox.Text;
			this.student.Address.street = this.StreetBox.Text;
			this.student.Address.house = this.HouseBox.Text;
			this.student.Address.building = this.BuildingBox.Text;
		}

		public Electives.Student student { get; private set; }

		private void StudentEditForm_Load(object sender, EventArgs e)
		{

		}

		private void ok_button_Click(object sender, EventArgs e)
		{
			get_from_boxes();
			Close();
		}

		private void trim_all_textbox(object sender, EventArgs e)
		{
			this.SurnameBox.Text = this.SurnameBox.Text.Trim();
			this.NameBox.Text = this.NameBox.Text.Trim();
			this.PatronimBox.Text = this.PatronimBox.Text.Trim();
			this.PhoneBox.Text = this.PhoneBox.Text.Trim();

			this.RegionBox.Text = this.RegionBox.Text.Trim();
			this.CityBox.Text = this.CityBox.Text.Trim();
			this.StreetBox.Text = this.StreetBox.Text.Trim();
			this.HouseBox.Text = this.HouseBox.Text.Trim();
			this.BuildingBox.Text = this.BuildingBox.Text.Trim();
		}
	}

}
