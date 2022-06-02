using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Atttendance
{
    public partial class Views : UserControl
    {
        static bool HasData { get; set; }
        public Views()
        {
            InitializeComponent();
            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                studentData.Rows[i].Cells[0].Value = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Views_Load(object sender, EventArgs e)
        {

            DatePicking.Value = DateTime.Now;
            getAttendance(studentData, DatePicking);

            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                studentData.Rows[i].Cells[0].Value = false;
            }
        }




        void getAttendance(Guna.UI2.WinForms.Guna2DataGridView data, Bunifu.Framework.UI.BunifuDatepicker date)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=ATT_SCHOOL;Integrated Security=True");
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("ReadAttendance", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@date", date.Value.ToShortDateString());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            SqlDataReader r = cmd.ExecuteReader();

            System.Data.DataTable dat = new System.Data.DataTable();
            dat.Load(r);
            //adapter.Fill(dat);
            if (dat.Rows.Count > 0)
            {


                data.DataSource = dat;
                HasData = true;
            }
            else
                HasData = false;

            cmd.ExecuteNonQuery();

            //conn.Close();

        }






        private void DatePicking_onValueChanged(object sender, EventArgs e)
        {
            getAttendance(studentData, DatePicking);
            if (!HasData)
                return;
        }

        private void saaFlatTextBox1_Click(object sender, EventArgs e)
        {

            if (saaFlatTextBox1.Text == "")
            {
                setError.Text = "";
                getAttendance(studentData, DatePicking);
            }

            else
            {


                SearchData(saaFlatTextBox1.Text, studentData);
                setError.Text = "";
                if (!HasData)
                {
                    setError.Text = "This ID Is Not exist";
                    getAttendance(studentData, DatePicking);
                }

            }

        }



        static void SearchData(string id, Guna.UI2.WinForms.Guna2DataGridView data)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=ATT_SCHOOL;Integrated Security=True");
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            System.Data.DataTable dat = new System.Data.DataTable();
            adapter.Fill(dat);
            if (dat.Rows.Count > 0)
            {
                data.DataSource = dat;
                HasData = true;
            }
            else
                HasData = false;

            cmd.ExecuteNonQuery();

            conn.Close();
        }




        static void UpdateData(string status, int NumebrStd)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-N9PT8FH\SQLEXPRESS;Initial Catalog=ATT_SCHOOL;Integrated Security=True");
            ;
            conn.Open();
            SqlCommand cmd = new SqlCommand("SearchID", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@RollNumber", NumebrStd);
            cmd.ExecuteNonQuery();

            conn.Close();
        }










        static bool SearchingWithIn(SaaUI.SaaFlatTextBox textBox)
        {
            bool isCheck;
            if (textBox.Text[0] == 'c' || textBox.Text[0] == 'C' || textBox.Text[1] == '1' || textBox.Text[2] == '2' || textBox.Text[3] == '0')
                isCheck = true;
            else
                isCheck = false;
            return isCheck;
        }

        private void saaButton1_Click(object sender, EventArgs e)
        {
            string status = "";

            for (int i = 0; i < studentData.Rows.Count; i++)
            {
                if ((bool)studentData.Rows[i].Cells[0].Value == false)
                    status = "Absent";
                else
                    status = "Present";

                UpdateData(status, (int)studentData.Rows[i].Cells[1].Value);
            }

            MessageBox.Show("Updated Sucessfully...");
            getAttendance(studentData, DatePicking);
        }
    }
}
