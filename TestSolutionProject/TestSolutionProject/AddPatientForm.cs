using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestSolutionProject
{
    public partial class AddPatientForm : Form
    {
        String conn;
        Form1 formListPatients;
        public AddPatientForm(String conn, Form1 formListPatients)
        {
            InitializeComponent();
            this.conn = conn;
            this.formListPatients = formListPatients;
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            string regExp = "[^a-zA-ZА-Яа-я]";
            String family = Regex.Replace(familyName.Text, regExp, ""); 
            String name = Regex.Replace(MainName.Text, regExp, ""); 
            String patr = Regex.Replace(patronymic.Text, regExp, ""); 
            DateTime birth = birthDate.Value.Date;
            String phoneText = phone.Text;
            bool isValidPhone = false;
            if (phoneText.Length == 12)
            {
                if (phoneText[0].Equals('+') && phoneText[1].Equals('7'))
                {
                    isValidPhone = true;
                } 
            }
            if (phoneText.Length == 11)
            {
                if (phoneText[0].Equals('8') && phoneText[1].Equals('9'))
                {
                    isValidPhone = true;
                }
            }
           
            if (String.IsNullOrEmpty(family))
            {
                MessageBox.Show("Не введена фамилия");
                return;
            }
            if (String.IsNullOrEmpty(name))
            {
                MessageBox.Show("Не введено Имя");
                return;
            }
            if (String.IsNullOrEmpty(patr))
            {
                MessageBox.Show("Не введено отчество");
                return;
            }
            if (String.IsNullOrEmpty(phoneText))
            {
                MessageBox.Show("Не введен номер");
                return;
            }
            if (!isValidPhone)
            {
                MessageBox.Show("Неверный формат номера телефона");
                return;
            }
            string sqlExpression = "INSERT INTO [dbo].[Пациенты] ([Ид пациента],[Фамилия],[Имя], [Отчество], [Дата рождения], [Телефон]) VALUES (NEWID(), @familyName, @name, @patr, @birthdate, @phone)";
            using (SqlConnection connection = new SqlConnection(conn))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlParameter familyNameParam = new SqlParameter("@familyName", family);
                command.Parameters.Add(familyNameParam);
                SqlParameter nameParam = new SqlParameter("@name", name);
                command.Parameters.Add(nameParam);
                SqlParameter patrParam = new SqlParameter("@patr", patr);
                command.Parameters.Add(patrParam);
                SqlParameter birthDateParam = new SqlParameter("@birthdate", birth);
                command.Parameters.Add(birthDateParam);
                SqlParameter phoneTextParam = new SqlParameter("@phone", phoneText);
                command.Parameters.Add(phoneTextParam);
                command.ExecuteNonQuery();
                MessageBox.Show("Пациент добавлен");
            }
            Console.Read();
            formListPatients.LoadPatientsList();
            this.Close();     
        }
    }
}
