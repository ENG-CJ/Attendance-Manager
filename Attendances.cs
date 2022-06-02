using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Atttendance
{
    public partial class Attendances : Form
    {
        public static bool IsChecked { get; set; }
        public Attendances()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize CheckBox Data when Form Loaded
            getStudnts(studentData);
            DatePicking.Value = DateTime.Now;


            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                studentData.Rows[i].Cells[0].Value = false;
            }

        }


        // Adding Data To the Attendance DB
        private void button1_Click(object sender, EventArgs e)
        {
            string status = "";
            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                if ((bool)studentData.Rows[i].Cells[0].Value)
                    status = "Present";
                else
                    status = "Absent";
                addAttendance(
                    (int)studentData.Rows[i].Cells[1].Value,
                    (string)studentData.Rows[i].Cells[2].Value,
                    studentData.Rows[i].Cells[3].Value.ToString(),
                    studentData.Rows[i].Cells[4].Value.ToString(),
                    DatePicking.Value,
                    status

                    );
            }
            MessageBox.Show("Sucessfully Saved....");
            Clear(studentData);
        }




        // reading Students From Database
        void getStudnts(DataGridView data)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=ATT_SCHOOL;Integrated Security=True");
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("allStudents", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            System.Data.DataTable dat = new System.Data.DataTable();
            adapter.Fill(dat);
            data.DataSource = dat;
            cmd.ExecuteNonQuery();

            conn.Close();

        }


        // Appending Data Into attendance DB
        void addAttendance(int AttenNumbrr, string id, string name, string Class, DateTime date, string status)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=ATT_SCHOOL;Integrated Security=True");
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddAtt", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@number", AttenNumbrr);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@class", Class);
            cmd.Parameters.AddWithValue("@date", date.ToShortDateString());
            cmd.Parameters.AddWithValue("@Status", status);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        // Switching Form to User Control
        private void viewAttendace_Click(object sender, EventArgs e)
        {
            views.Show();
        }

        private void saaButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Updating Class Name
        private void classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            className.Text = classes.Text;
        }

        private void getData(object sender, DataGridViewCellEventArgs e)
        {

        }


        // Clearing Data into Default value
        public static void Clear(DataGridView data)
        {


            for (int i = 0; i < data.Rows.Count; i++)
            {
                data.Rows[i].Cells[0].Value = false;
            }

        }
    }
}
