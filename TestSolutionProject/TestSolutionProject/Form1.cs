using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestSolutionProject
{
    public partial class Form1 : Form
    {
        private static string connectionString = "Data Source=DESKTOP-NLJCIT1;Initial Catalog=testbase;" +
                "Integrated Security=true;";
        private SqlConnection connection = new SqlConnection(connectionString);
        private string selectPatientsQuery = "SELECT [�� ��������],[�������],[���], [��������], [���� ��������], [�������] FROM [dbo].[��������] ";

        private string selectVisitQuery = "SELECT [�� ���������],[���� ���������]," +
            "[�������] = pd.[name], [�������] = pc.[�������] + ' ' + pc.[���] FROM [dbo].[���������] p " +
            " LEFT JOIN [dbo].[�������������] pd on p.[�������]=pd.[id]" +
            " LEFT JOIN [dbo].[��������] pc on p.[�� ��������]=pc.[�� ��������]";

        public Form1()
        {
            InitializeComponent();
            LoadPatientsList();
            LoadVisitList();
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            AddPatientForm form = new AddPatientForm(connectionString, this);
            form.Show();
        }

        private void addVisit_Click(object sender, EventArgs e)
        {
            List<Patient> patients = getPatientList();
            AddVisitForm form = new AddVisitForm(connectionString, this, patients);
            form.Show();
        }
        public void LoadPatientsList()
        {
            dataGridView1.Rows.Clear();
            List<string?[]> dataPatient = getDataPatient(selectPatientsQuery);
            foreach (String?[] s in dataPatient)
            {
                dataGridView1.Rows.Add(s);
            }
            dataGridView1.Columns[0].Visible = false;
        }

        private List<string?[]> getDataPatient(String query, String? param = null)
        {
            List<string?[]> dataPatient = new List<string?[]>();
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    dataPatient.Add(new string[6]);
                    object Id = reader["�� ��������"];
                    object familyName = reader["�������"];
                    object name = reader["���"];
                    object patr = reader["��������"];
                    object birthDate = reader["���� ��������"];
                    object phone = reader["�������"];

                    String? dateBirth = (String?)birthDate.ToString();
                    dataPatient[dataPatient.Count - 1][0] = (String)Id;
                    dataPatient[dataPatient.Count - 1][1] = (String)familyName;
                    dataPatient[dataPatient.Count - 1][2] = (String)name;
                    dataPatient[dataPatient.Count - 1][3] = (String)patr;
                    dataPatient[dataPatient.Count - 1][4] = dateBirth;
                    dataPatient[dataPatient.Count - 1][5] = (String)phone;
                }

                reader.Close();
                connection.Close();
            } catch (SqlException ex)
            {
               MessageBox.Show("�� ������� ������������ � ����");
            }

            return dataPatient;
        }

        public void LoadVisitList()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand(selectVisitQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                List<Visit> dataVisit = new List<Visit>();
                while (reader.Read())
                {
                    Visit visit = new Visit();
                    visit.Id = (String)reader["�� ���������"];
                    visit.date = (DateTime)reader[1];
                    visit.diagnos = (String)reader["�������"];
                    visit.patientId = (String)reader["�������"];
                    dataVisit.Add(visit);
                }
                reader.Close();
                connection.Close();
                var bindingList = new BindingList<Visit>(dataVisit);
                var source = new BindingSource(bindingList, null);

                dataGridView2.DataSource = source;
                dataGridView2.Columns[0].HeaderText = "�� ���������";
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].HeaderText = "���� ���������";
                dataGridView2.Columns[2].HeaderText = "�������";
                dataGridView2.Columns[3].HeaderText = "�������";
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<Patient> getPatientList()
        {
            List<string?[]> dataPatient = getDataPatient(selectPatientsQuery);
            List<Patient> data = new List<Patient>();
            foreach (string?[] s in dataPatient)
            {
                string? s1 = s[4];
                DateTime date = DateTime.Parse(s1);
                Patient patient = new Patient(
                    s[0].ToString(),
                    s[1].ToString(),
                    s[2].ToString(),
                    s[3].ToString(),
                    date,
                    s[5].ToString()
                    );
                data.Add(patient);
            }
            return data;
        }
        public String getSelectedParam()
        {
            return (String)comboBox1.SelectedItem;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String searchText = textBox1.Text;
            if (comboBox1.SelectedIndex != -1)
            {
                dataGridView1.Rows.Clear();
                String? selected = (String)comboBox1.SelectedItem;
                if (selected.Equals("�������")
                    || selected.Equals("���")
                    || selected.Equals("��������"))
                {
                    String regExp = "[^a-zA-Z�-��-�]";
                    searchText = Regex.Replace(textBox1.Text, regExp, "");
                }
                if (selected.Equals("�������"))
                {
                    String regExp = "[^+-[0-9]]";
                    searchText = Regex.Replace(textBox1.Text, regExp, "");
                }
                string selectPatientsQueryByParam = "SELECT [�� ��������],[�������],[���], [��������], [���� ��������], [�������] FROM [dbo].[��������] " +
                    "where [" + getSelectedParam() + "] like '" + searchText + "%'";
                List<string?[]> dataString = getDataPatient(selectPatientsQueryByParam);

                foreach (String?[] s in dataString)
                {
                    dataGridView1.Rows.Add(s);
                }
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void viewVisit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("�� ������� ������ ��� ��������� �� ������ ���������");
                return;
            }
            if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show("�������� ���� ������ ��� ��������� �� ������ ���������");
                return;
            }
            String Id = "";
            DataGridViewSelectedRowCollection collection = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in collection)
            {
                Id = (String)row.Cells[0].Value;
            }
            viewVisit form = new viewVisit(Id);
            form.Show();
        }

        private void addPatient_Click_1(object sender, EventArgs e)
        {

        }
    }
}
