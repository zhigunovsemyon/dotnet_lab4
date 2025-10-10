using Electives;

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
			var form = new StudentEditForm(new Student());
			if (DialogResult.OK == form.ShowDialog()) {
				student_ = form.student;
			}
		}

		private void StudentEditToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var form = new StudentEditForm(student_.clone());
			if (DialogResult.OK == form.ShowDialog()) {
				student_ = form.student;
			}
		}
	}
}
