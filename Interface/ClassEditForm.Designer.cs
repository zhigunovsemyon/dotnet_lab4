namespace Interface
{
	partial class ClassEditForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			TextBoxName = new TextBox();
			NumericUpDownLectionsInput = new NumericUpDown();
			NumericUpDownPracticeInput = new NumericUpDown();
			NumericUpDownLabsInput = new NumericUpDown();
			ButtonOK = new Button();
			ButtonClose = new Button();
			((System.ComponentModel.ISupportInitialize)NumericUpDownLectionsInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)NumericUpDownPracticeInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)NumericUpDownLabsInput).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 9);
			label1.Name = "label1";
			label1.Size = new Size(114, 15);
			label1.TabIndex = 0;
			label1.Text = "Название предмета";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 53);
			label2.Name = "label2";
			label2.Size = new Size(190, 15);
			label2.TabIndex = 1;
			label2.Text = "Количество лекционных занятий";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(223, 9);
			label3.Name = "label3";
			label3.Size = new Size(186, 15);
			label3.TabIndex = 2;
			label3.Text = "Количество практических работ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(222, 51);
			label4.Name = "label4";
			label4.Size = new Size(191, 15);
			label4.TabIndex = 3;
			label4.Text = "Количество лабораторных работ";
			// 
			// TextBoxName
			// 
			TextBoxName.Location = new Point(17, 27);
			TextBoxName.MaxLength = 60;
			TextBoxName.Name = "TextBoxName";
			TextBoxName.Size = new Size(189, 23);
			TextBoxName.TabIndex = 4;
			TextBoxName.LostFocus += ClassNameBox_LostFocus;
			// 
			// NumericUpDownLectionsInput
			// 
			NumericUpDownLectionsInput.Location = new Point(17, 71);
			NumericUpDownLectionsInput.Name = "NumericUpDownLectionsInput";
			NumericUpDownLectionsInput.Size = new Size(190, 23);
			NumericUpDownLectionsInput.TabIndex = 5;
			// 
			// NumericUpDownPracticeInput
			// 
			NumericUpDownPracticeInput.Location = new Point(223, 27);
			NumericUpDownPracticeInput.Name = "NumericUpDownPracticeInput";
			NumericUpDownPracticeInput.Size = new Size(190, 23);
			NumericUpDownPracticeInput.TabIndex = 6;
			// 
			// NumericUpDownLabsInput
			// 
			NumericUpDownLabsInput.Location = new Point(222, 71);
			NumericUpDownLabsInput.Name = "NumericUpDownLabsInput";
			NumericUpDownLabsInput.Size = new Size(190, 23);
			NumericUpDownLabsInput.TabIndex = 7;
			// 
			// ButtonOK
			// 
			ButtonOK.Location = new Point(222, 115);
			ButtonOK.Name = "ButtonOK";
			ButtonOK.Size = new Size(95, 23);
			ButtonOK.TabIndex = 8;
			ButtonOK.Text = "ОК";
			ButtonOK.UseVisualStyleBackColor = true;
			ButtonOK.Click += OkButton_Click;
			// 
			// ButtonClose
			// 
			ButtonClose.Location = new Point(323, 115);
			ButtonClose.Name = "ButtonClose";
			ButtonClose.Size = new Size(89, 23);
			ButtonClose.TabIndex = 9;
			ButtonClose.Text = "Закрыть";
			ButtonClose.UseVisualStyleBackColor = true;
			// 
			// ClassEditForm
			// 
			AcceptButton = ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = ButtonClose;
			ClientSize = new Size(433, 162);
			Controls.Add(ButtonClose);
			Controls.Add(ButtonOK);
			Controls.Add(NumericUpDownLabsInput);
			Controls.Add(NumericUpDownPracticeInput);
			Controls.Add(NumericUpDownLectionsInput);
			Controls.Add(TextBoxName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "ClassEditForm";
			ShowIcon = false;
			Text = "Информация о предмете";
			Load += SetBoxes;
			((System.ComponentModel.ISupportInitialize)NumericUpDownLectionsInput).EndInit();
			((System.ComponentModel.ISupportInitialize)NumericUpDownPracticeInput).EndInit();
			((System.ComponentModel.ISupportInitialize)NumericUpDownLabsInput).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox TextBoxName;
		private NumericUpDown NumericUpDownLectionsInput;
		private NumericUpDown NumericUpDownPracticeInput;
		private NumericUpDown NumericUpDownLabsInput;
		private Button ButtonOK;
		private Button ButtonClose;
	}
}