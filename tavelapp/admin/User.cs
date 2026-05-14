using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace tavelapp.admin
{
    public partial class User: Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-OG7DERJ\\SQLEXPRESS;Initial Catalog=Booking;Integrated Security=True;Trust Server Certificate=True");
        public User()
        {
            InitializeComponent();
            loadData();
        }
        void loadData()
        {
            SqlCommand cmd = new SqlCommand("select * from Users", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            guna2DataGridView1.DataSource = dt;
            guna2DataGridView1.AutoGenerateColumns = true;

        }

        private void hotel_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadData();
            

        }
    }
}
