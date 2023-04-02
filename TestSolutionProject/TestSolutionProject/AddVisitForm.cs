using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSolutionProject
{
    public partial class AddVisitForm : Form
    {
        private static String connectionString = "Data Source=DESKTOP-NLJCIT1;Initial Catalog=testbase;" +
                "Integrated Security=true;";
        private SqlConnection connection = new SqlConnection(connectionString);
        private string selectMKBQuery = "SELECT [id],[code],[name] FROM [dbo].[СправочникМКБ]";
        private Form1 formList;
        private List<Patient> patientList;
        private List<MKBItem> MKBItemList;

        public AddVisitForm(String conn, Form1 formList, List<Patient> list)
        {
            InitializeComponent();
            this.formList = formList;
            this.patientList = list;
            this.MKBItemList = getMKBList();

            foreach (Patient pat in patientList)
            {
                comboBox1.Items.Add(pat.getName() + " " + pat.getFamilyName());
            }

            foreach (MKBItem item in MKBItemList)
            {
                comboBox2.Items.Add(item.getCode() + " " + item.getName());
            }
        }

        private void saveVisit_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1) {
                String patientId = patientList.ElementAt(comboBox1.SelectedIndex).getId();
                String diagnosId = MKBItemList.ElementAt(comboBox2.SelectedIndex).getId();


                DateTime visitDateValue = visitDate.Value.Date;

                if (patientId != null && diagnosId != null)
                {

                    string sqlExpression = "INSERT INTO [dbo].[Посещения] ([Ид посещения],[Дата посещения],[Диагноз], [Ид пациента]) VALUES (NEWID(), @visitDate, @diagnos, @patientId)";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sqlExpression, connection);
                        SqlParameter visitDateValueParam = new SqlParameter("@visitDate", visitDateValue);
                        command.Parameters.Add(visitDateValueParam);
                        SqlParameter diagnosParam = new SqlParameter("@diagnos", diagnosId);
                        command.Parameters.Add(diagnosParam);
                        SqlParameter patientParam = new SqlParameter("@patientId", patientId);
                        command.Parameters.Add(patientParam);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Добавлено посещение");
                    }
                    Console.Read();
                    formList.LoadPatientsList();
                    formList.LoadVisitList();
                    this.Close();
                } else {
                MessageBox.Show("Не выбран пациент или диагноз");
                }
            } else
            {
                MessageBox.Show("Не выбран пациент или диагноз");
            }
            

        }
        private List<MKBItem> getMKBList()
        {
            connection.Open();
            SqlCommand command = new SqlCommand(selectMKBQuery, connection);

            SqlDataReader reader = command.ExecuteReader();

            List<MKBItem> data = new List<MKBItem>();

            while (reader.Read())
            {
                MKBItem MKBItemObject = new MKBItem(
                    (String)reader[0],
                    (String)reader[1],
                    (String)reader[2]
                    );
                data.Add(MKBItemObject);
            }

            return data;
        }

        private void AddVisitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
