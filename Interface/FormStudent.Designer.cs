namespace Interface
{
	partial class FormStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
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
			TextBoxSurname = new TextBox();
			TextBoxName = new TextBox();
			TextBoxPatronim = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			ButtonOK = new Button();
			ButtonClose = new Button();
			AddressBox = new GroupBox();
			label9 = new Label();
			TextBoxBuilding = new TextBox();
			label8 = new Label();
			TextBoxHouse = new TextBox();
			label7 = new Label();
			TextBoxStreet = new TextBox();
			label6 = new Label();
			TextBoxCity = new TextBox();
			label4 = new Label();
			TextBoxRegion = new TextBox();
			MaskedTextBoxPhone = new MaskedTextBox();
			AddressBox.SuspendLayout();
			SuspendLayout();
			// 
			// TextBoxSurname
			// 
			TextBoxSurname.Location = new Point(12, 35);
			TextBoxSurname.MaxLength = 40;
			TextBoxSurname.Name = "TextBoxSurname";
			TextBoxSurname.Size = new Size(178, 23);
			TextBoxSurname.TabIndex = 0;
			TextBoxSurname.LostFocus += TextBoxTrimAll;
			// 
			// TextBoxName
			// 
			TextBoxName.Location = new Point(12, 82);
			TextBoxName.MaxLength = 28;
			TextBoxName.Name = "TextBoxName";
			TextBoxName.Size = new Size(178, 23);
			TextBoxName.TabIndex = 1;
			TextBoxName.LostFocus += TextBoxTrimAll;
			// 
			// TextBoxPatronim
			// 
			TextBoxPatronim.Location = new Point(12, 132);
			TextBoxPatronim.MaxLength = 28;
			TextBoxPatronim.Name = "TextBoxPatronim";
			TextBoxPatronim.Size = new Size(178, 23);
			TextBoxPatronim.TabIndex = 2;
			TextBoxPatronim.LostFocus += TextBoxTrimAll;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 5;
			label1.Text = "&Фамилия";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 64);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 6;
			label2.Text = "&Имя";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 114);
			label3.Name = "label3";
			label3.Size = new Size(151, 15);
			label3.TabIndex = 7;
			label3.Text = "&Отчество (необязательно)";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 167);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 9;
			label5.Text = "&Телефон";
			// 
			// ButtonOK
			// 
			ButtonOK.DialogResult = DialogResult.OK;
			ButtonOK.Location = new Point(280, 243);
			ButtonOK.Name = "ButtonOK";
			ButtonOK.Size = new Size(75, 23);
			ButtonOK.TabIndex = 11;
			ButtonOK.Text = "OK";
			ButtonOK.UseVisualStyleBackColor = true;
			ButtonOK.Click += ok_button_Click;
			// 
			// ButtonClose
			// 
			ButtonClose.DialogResult = DialogResult.Cancel;
			ButtonClose.Location = new Point(361, 243);
			ButtonClose.Name = "ButtonClose";
			ButtonClose.Size = new Size(75, 23);
			ButtonClose.TabIndex = 12;
			ButtonClose.Text = "Закрыть";
			ButtonClose.UseVisualStyleBackColor = true;
			// 
			// AddressBox
			// 
			AddressBox.Controls.Add(label9);
			AddressBox.Controls.Add(TextBoxBuilding);
			AddressBox.Controls.Add(label8);
			AddressBox.Controls.Add(TextBoxHouse);
			AddressBox.Controls.Add(label7);
			AddressBox.Controls.Add(TextBoxStreet);
			AddressBox.Controls.Add(label6);
			AddressBox.Controls.Add(TextBoxCity);
			AddressBox.Controls.Add(label4);
			AddressBox.Controls.Add(TextBoxRegion);
			AddressBox.Location = new Point(205, 0);
			AddressBox.Name = "AddressBox";
			AddressBox.Size = new Size(250, 226);
			AddressBox.TabIndex = 10;
			AddressBox.TabStop = false;
			AddressBox.Text = "Адрес студента";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(88, 168);
			label9.Name = "label9";
			label9.Size = new Size(153, 15);
			label9.TabIndex = 21;
			label9.Text = "&Строение (необязательно)";
			// 
			// TextBoxBuilding
			// 
			TextBoxBuilding.Location = new Point(88, 186);
			TextBoxBuilding.MaxLength = 5;
			TextBoxBuilding.Name = "TextBoxBuilding";
			TextBoxBuilding.Size = new Size(146, 23);
			TextBoxBuilding.TabIndex = 20;
			TextBoxBuilding.LostFocus += TextBoxTrimAll;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 168);
			label8.Name = "label8";
			label8.Size = new Size(76, 15);
			label8.TabIndex = 19;
			label8.Text = "&Номер дома";
			// 
			// TextBoxHouse
			// 
			TextBoxHouse.Location = new Point(6, 186);
			TextBoxHouse.MaxLength = 5;
			TextBoxHouse.Name = "TextBoxHouse";
			TextBoxHouse.Size = new Size(76, 23);
			TextBoxHouse.TabIndex = 18;
			TextBoxHouse.LostFocus += TextBoxTrimAll;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 115);
			label7.Name = "label7";
			label7.Size = new Size(41, 15);
			label7.TabIndex = 17;
			label7.Text = "&Улица";
			// 
			// TextBoxStreet
			// 
			TextBoxStreet.Location = new Point(6, 133);
			TextBoxStreet.MaxLength = 40;
			TextBoxStreet.Name = "TextBoxStreet";
			TextBoxStreet.Size = new Size(228, 23);
			TextBoxStreet.TabIndex = 16;
			TextBoxStreet.LostFocus += TextBoxTrimAll;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 65);
			label6.Name = "label6";
			label6.Size = new Size(40, 15);
			label6.TabIndex = 15;
			label6.Text = "&Город";
			// 
			// TextBoxCity
			// 
			TextBoxCity.Location = new Point(6, 83);
			TextBoxCity.MaxLength = 40;
			TextBoxCity.Name = "TextBoxCity";
			TextBoxCity.Size = new Size(228, 23);
			TextBoxCity.TabIndex = 14;
			TextBoxCity.LostFocus += TextBoxTrimAll;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 18);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 13;
			label4.Text = "&Регион";
			// 
			// TextBoxRegion
			// 
			TextBoxRegion.Location = new Point(6, 36);
			TextBoxRegion.MaxLength = 40;
			TextBoxRegion.Name = "TextBoxRegion";
			TextBoxRegion.Size = new Size(228, 23);
			TextBoxRegion.TabIndex = 0;
			TextBoxRegion.LostFocus += TextBoxTrimAll;
			// 
			// MaskedTextBoxPhone
			// 
			MaskedTextBoxPhone.Location = new Point(12, 185);
			MaskedTextBoxPhone.Mask = "(999) 000-0000";
			MaskedTextBoxPhone.Name = "MaskedTextBoxPhone";
			MaskedTextBoxPhone.Size = new Size(178, 23);
			MaskedTextBoxPhone.TabIndex = 3;
			// 
			// FormStudent
			// 
			AcceptButton = ButtonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = ButtonClose;
			ClientSize = new Size(458, 278);
			Controls.Add(MaskedTextBoxPhone);
			Controls.Add(AddressBox);
			Controls.Add(ButtonClose);
			Controls.Add(ButtonOK);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(TextBoxPatronim);
			Controls.Add(TextBoxName);
			Controls.Add(TextBoxSurname);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FormStudent";
			ShowIcon = false;
			Text = "Информация о студенте";
			Load += SetBoxes;
			AddressBox.ResumeLayout(false);
			AddressBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TextBoxSurname;
		private TextBox TextBoxName;
		private TextBox TextBoxPatronim;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Button ButtonOK;
		private Button ButtonClose;
		private GroupBox AddressBox;
		private Label label6;
		private TextBox TextBoxCity;
		private Label label4;
		private TextBox TextBoxRegion;
		private Label label9;
		private TextBox TextBoxBuilding;
		private Label label8;
		private TextBox TextBoxHouse;
		private Label label7;
		private TextBox TextBoxStreet;
		private MaskedTextBox MaskedTextBoxPhone;
	}
}