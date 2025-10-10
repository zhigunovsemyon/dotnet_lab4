namespace Interface
{
	public partial class ClassEditForm : Form
	{
		public ClassEditForm(Electives.Class @class)
		{
			InitializeComponent();
			this.@class = @class;
		}

		private void set_boxes(object sender, EventArgs e)
		{
			this.ClassNameBox.Text = this.@class.name;
			this.LectionsInput.Value = this.@class.lections;
			this.PracticeInput.Value = this.@class.practices;
			this.LabsInput.Value = this.@class.lab_works;
		}

		private void get_from_boxes()
		{
			this.@class.name = this.ClassNameBox.Text;
			this.@class.lections = ((int)this.LectionsInput.Value);
			this.@class.practices = ((int)this.PracticeInput.Value);
			this.@class.lab_works = ((int)this.LabsInput.Value);
		}

		public Electives.Class @class { get; set; }

		private void OkButton_Click(object sender, EventArgs e)
		{
			get_from_boxes();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void ClassNameBox_LostFocus(object sender, EventArgs e)
		{
			this.ClassNameBox.Text = this.ClassNameBox.Text.Trim();
		}
	}
}
