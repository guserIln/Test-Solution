using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TestSolutionProject
{
    public partial class viewVisit : Form
    {
        private String Id;
        private static string connectionString = "Data Source=DESKTOP-NLJCIT1;Initial Catalog=testbase;" +
            "Integrated Security=true;";
        private SqlConnection connection = new SqlConnection(connectionString);
        private string selectVisitByParamQuery = "SELECT [Ид посещения],[Дата посещения],[Диагноз] = pd.[name],[Пациент] = pc.[Фамилия]   FROM [dbo].[Посещения] p " +
            " LEFT JOIN [dbo].[СправочникМКБ] pd on p.[Диагноз]=pd.[id]" +
            " LEFT JOIN [dbo].[Пациенты] pc on p.[Ид пациента]=pc.[Ид пациента]" + " where p.[Ид пациента] = @Id ";
        private List<Visit> dataVisit;
        public viewVisit(String id)
        {
            InitializeComponent();
            this.Id = id;
            LoadVisitByParam();
        }

        private void LoadVisitByParam()
        {
            dataGridView1.Rows.Clear();
            connection.Open();
            SqlCommand command = new SqlCommand(selectVisitByParamQuery, connection);
            SqlParameter IdParam = new SqlParameter("@Id", Id);
            command.Parameters.Add(IdParam);

            SqlDataReader reader = command.ExecuteReader();
            dataVisit = new List<Visit>();
            while (reader.Read())
            {
                Visit visit = new Visit();
                visit.Id = (String)reader[0];
                visit.date = (DateTime)reader[1];
                visit.diagnos = (String)reader[2];
                visit.patientId = (String)reader[3];
                dataVisit.Add(visit);
            }
            reader.Close();
            connection.Close();
            var bindingList = new BindingList<Visit>(dataVisit);
            var source = new BindingSource(bindingList, null);

            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].HeaderText = "Ид посещения";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата посещения";
            dataGridView1.Columns[2].HeaderText = "Диагноз";
            dataGridView1.Columns[3].HeaderText = "Пациент";

        }



        private void formXML_Click(object sender, EventArgs e)
        {
            XDocument xdoc = new XDocument();

            XElement visits = new XElement("visits");

            foreach (Visit v in dataVisit)
            {
                XElement visit = new XElement("visit");
                XAttribute date = new XAttribute("date", v.date.ToShortDateString());
                XElement diagnos = new XElement("diagnos", v.diagnos.ToString());
                XElement patient = new XElement("patientName", v.patientId.ToString());
                visit.Add(date);
                visit.Add(diagnos);
                visit.Add(patient);

                visits.Add(visit);
            }


            xdoc.Add(visits);
            saveFileDialog1.FileName = "XMLLoad.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xdoc.Save(saveFileDialog1.FileName);
                MessageBox.Show("XML файл выгружен!");
            }

        }
    }
}
