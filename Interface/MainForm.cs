namespace Interface
{
	public partial class MainForm : Form
	{
		public MainForm ()
		{
			InitializeComponent();
		}

		private void CloseButton_Click (object sender, EventArgs e)
		{
			Close();
		}
	}
}
