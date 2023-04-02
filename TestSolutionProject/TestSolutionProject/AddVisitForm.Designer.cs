namespace TestSolutionProject
{
    partial class AddVisitForm
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
            saveVisit = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            visitDate = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // saveVisit
            // 
            saveVisit.Location = new Point(30, 212);
            saveVisit.Name = "saveVisit";
            saveVisit.Size = new Size(75, 23);
            saveVisit.TabIndex = 0;
            saveVisit.Text = "Сохранить";
            saveVisit.UseVisualStyleBackColor = true;
            saveVisit.Click += saveVisit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 84);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Дата посещения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 21);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Пациент";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(354, 23);
            comboBox1.TabIndex = 4;
            // 
            // visitDate
            // 
            visitDate.Location = new Point(24, 102);
            visitDate.Name = "visitDate";
            visitDate.Size = new Size(121, 23);
            visitDate.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 145);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Диагноз";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(24, 163);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(682, 23);
            comboBox2.TabIndex = 7;
            // 
            // AddVisitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 260);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(visitDate);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveVisit);
            Name = "AddVisitForm";
            Text = "Добавить посещение";
            Load += AddVisitForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveVisit;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private DateTimePicker visitDate;
        private Label label3;
        private ComboBox comboBox2;
    }
}