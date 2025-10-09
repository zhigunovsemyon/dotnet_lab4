namespace Interface
{
	public partial class MainForm : Form
	{
		private Electives.Student student_ = new();
		//private Electives.Class class_;

		public MainForm()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void StudentAddtoolStripMenuItem_Click(object sender, EventArgs e)
		{
			student_ = new();
			var form = new StudentEditForm(student_);
			if (DialogResult.OK == form.ShowDialog()) {
				student_ = form.student;
			}
		}

		private void StudentEditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new StudentEditForm(student_);
			if (DialogResult.OK == form.ShowDialog()) {
				student_ = form.student;
			}
		}
	}
}
