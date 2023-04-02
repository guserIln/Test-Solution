namespace TestSolutionProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.viewVisit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addPatient = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addVisit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 607);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.viewVisit);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.addPatient);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пациент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // viewVisit
            // 
            this.viewVisit.Location = new System.Drawing.Point(105, 26);
            this.viewVisit.Name = "viewVisit";
            this.viewVisit.Size = new System.Drawing.Size(162, 23);
            this.viewVisit.TabIndex = 6;
            this.viewVisit.Text = "Просмотр посещения";
            this.viewVisit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(590, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "по полю";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фильтрация";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Телефон"});
            this.comboBox1.Location = new System.Drawing.Point(577, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(283, 23);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.familyName,
            this.MainName,
            this.Patr,
            this.birthDate,
            this.phone});
            this.dataGridView1.Location = new System.Drawing.Point(0, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(778, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.HeaderText = "Ид пациента";
            this.Id.Name = "Id";
            this.Id.Width = 93;
            // 
            // familyName
            // 
            this.familyName.HeaderText = "Фамилия";
            this.familyName.Name = "familyName";
            this.familyName.Width = 83;
            // 
            // MainName
            // 
            this.MainName.HeaderText = "Имя";
            this.MainName.Name = "MainName";
            this.MainName.Width = 56;
            // 
            // Patr
            // 
            this.Patr.HeaderText = "Отчество";
            this.Patr.Name = "Patr";
            this.Patr.Width = 83;
            // 
            // birthDate
            // 
            this.birthDate.HeaderText = "Дата рождения";
            this.birthDate.Name = "birthDate";
            this.birthDate.Width = 106;
            // 
            // phone
            // 
            this.phone.HeaderText = "Телефон";
            this.phone.Name = "phone";
            this.phone.Width = 80;
            // 
            // addPatient
            // 
            this.addPatient.Location = new System.Drawing.Point(23, 26);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(75, 23);
            this.addPatient.TabIndex = 0;
            this.addPatient.Text = "Добавить";
            this.addPatient.UseVisualStyleBackColor = true;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.addVisit);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Посещения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(778, 521);
            this.dataGridView2.TabIndex = 1;
            // 
            // addVisit
            // 
            this.addVisit.Location = new System.Drawing.Point(23, 29);
            this.addVisit.Name = "addVisit";
            this.addVisit.Size = new System.Drawing.Size(75, 23);
            this.addVisit.TabIndex = 0;
            this.addVisit.Text = "Добавить";
            this.addVisit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 631);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Тестовый проект";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button addPatient;
        private TabPage tabPage2;
        private Button addVisit;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button viewVisit;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn familyName;
        private DataGridViewTextBoxColumn MainName;
        private DataGridViewTextBoxColumn Patr;
        private DataGridViewTextBoxColumn birthDate;
        private DataGridViewTextBoxColumn phone;
    }
}