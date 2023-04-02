namespace TestSolutionProject
{
    partial class AddPatientForm
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
            if (disposing && (components != null))
            {
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
            familyName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            MainName = new TextBox();
            label3 = new Label();
            patronymic = new TextBox();
            label4 = new Label();
            phone = new TextBox();
            birthDate = new DateTimePicker();
            label5 = new Label();
            addPatient = new Button();
            SuspendLayout();
            // 
            // familyName
            // 
            familyName.Location = new Point(34, 33);
            familyName.Name = "familyName";
            familyName.Size = new Size(196, 23);
            familyName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 15);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 1;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 76);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "Имя";
            // 
            // MainName
            // 
            MainName.Location = new Point(34, 94);
            MainName.Name = "MainName";
            MainName.Size = new Size(196, 23);
            MainName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "Отчество";
            // 
            // patronymic
            // 
            patronymic.Location = new Point(34, 154);
            patronymic.Name = "patronymic";
            patronymic.Size = new Size(196, 23);
            patronymic.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата рождения";
            // 
            // phone
            // 
            phone.Location = new Point(34, 284);
            phone.Name = "phone";
            phone.Size = new Size(196, 23);
            phone.TabIndex = 6;
            // 
            // birthDate
            // 
            birthDate.Location = new Point(30, 216);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(200, 23);
            birthDate.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 266);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 9;
            label5.Text = "Телефон";
            // 
            // addPatient
            // 
            addPatient.Location = new Point(46, 330);
            addPatient.Name = "addPatient";
            addPatient.Size = new Size(75, 23);
            addPatient.TabIndex = 10;
            addPatient.Text = "Добавить";
            addPatient.UseVisualStyleBackColor = true;
            addPatient.Click += addPatient_Click;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 365);
            Controls.Add(addPatient);
            Controls.Add(label5);
            Controls.Add(birthDate);
            Controls.Add(label4);
            Controls.Add(phone);
            Controls.Add(label3);
            Controls.Add(patronymic);
            Controls.Add(label2);
            Controls.Add(MainName);
            Controls.Add(label1);
            Controls.Add(familyName);
            Name = "AddPatientForm";
            Text = "Добавить пациента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox familyName;
        private Label label1;
        private Label label2;
        private TextBox MainName;
        private Label label3;
        private TextBox patronymic;
        private Label label4;
        private TextBox phone;
        private DateTimePicker birthDate;
        private Label label5;
        private Button addPatient;
    }
}