using Electives;

namespace Interface
{
	public partial class MainForm : Form
	{
		private Electives.Student student_ = new();
		//private Electives.Class class_;

		public MainForm ()
		{
			InitializeComponent();
		}

		private void CloseButton_Click (object sender, EventArgs e)
		{
			Close();
		}

		private void AddOrEditStudent(Electives.Student student)
		{
			var form = new StudentEditForm(student);
			if (DialogResult.OK != form.ShowDialog()) {
				return;
			}

			if (form.student == null) {
				MessageBox.Show(
					"StudentEditForm вернула null",
					"Внутренняя ошибка"
				);
				return;
			}
			if (!form.student.IsValid) {
				MessageBox.Show("Неправильно указаны данные!");
				return;
			}

			this.student_ = form.student;
		}

		private void StudentAddtoolStripMenuItem_Click (object sender, EventArgs e)
		{	
			//Вызов формы на чистом студенте
			AddOrEditStudent(new Student());
		}

		private void StudentEditToolStripMenuItem_Click (object sender, EventArgs e)
		{
			//Вызов формы на копии исходного студента
			AddOrEditStudent(student_.clone());
		}
	}
}
