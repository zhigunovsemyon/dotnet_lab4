namespace Interface
{
	public partial class ClassEditForm : Form
	{
		public ClassEditForm (Electives.Class @class)
		{
			InitializeComponent();
			this.@class = @class;
		}
		public Electives.Class @class { get; set; }
	}
}
