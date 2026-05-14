using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace tavelapp.admin
{
    public partial class Car: Form
    {
        public Car()
        {
            InitializeComponent();
            loadData();
            loadcompny();
        }
        void loadData()
        {
            SqlCommand cmd = new SqlCommand("select * from Cars", Program.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Datagridview.DataSource = dt;

        }
        void loadcompny()
        {
            SqlCommand cmd = new SqlCommand("select * from Companies", Program.con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DDlcompany.DataSource = dt;
            DDlcompany.DisplayMember = dt.Columns[1].ToString();
            DDlcompany.ValueMember = dt.Columns[0].ToString();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Width = 150;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Menu.Start();
        }

        private void Car_Load(object sender, EventArgs e)
        {

        }

        private void btnBus_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = false;
        private void Menu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == true)
            {
                
                flowLayoutPanel2.Width -= 3;
                if (flowLayoutPanel2.Width <= 0)
                {
                    panel1.Location = new Point(33, 49);
                    sidebarExpand = false;
                    Menu.Stop();
                }
            }
            else
            {
                panel1.Location = new Point(130, 49);
                flowLayoutPanel2.Width += 3;
                if (flowLayoutPanel2.Width >= 129)
                {
                    sidebarExpand = true;
                    Menu.Stop();
                }

            }
        }
        bool mexpand = false;
        private void Tikettran_Tick(object sender, EventArgs e)
        {
            if (mexpand == true)
            {
                PlnTicket.Height -= 1;
                if (PlnTicket.Height <= 40)
                {
                    mexpand = false;
                    TiketExpand.Stop();
                }
            }
            else
            {
                PlnTicket.Height += 1;
                if (PlnTicket.Height >= 156)
                {
                    mexpand = true;
                    TiketExpand.Stop();
                }

            }
        }

        private void btnticket_Click(object sender, EventArgs e)
        {
            
        }

        private void btnticket_Click_1(object sender, EventArgs e)
        {
            TiketExpand.Start();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand cmd = new SqlCommand($"INSERT INTO Cars VALUES ('{txtName.Text}','{DDLType.SelectedItem.ToString()}','{txtrent.Text}','{txtDescription.Text}','{DDlcompany.SelectedValue.ToString()}')", Program.con);
                Program.con.Open();
                cmd.ExecuteNonQuery();
                Program.con.Close();
                MessageBox.Show("added", "Message");
                loadData();
        }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong", "Error");
            }
}

        private void btndel_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand($"Delete from Cars where CarID =' {txtid.Text}'", Program.con);
            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("DELETED", "Message");
            loadData();
        }

        private void DDLType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DDlcompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // need to change
            SqlCommand cmd = new SqlCommand($"UPDATE Cars SET Name = '{txtName.Text}', Type = '{DDLType.SelectedItem.ToString()}', Rent = '{txtrent.Text}', Description = '{txtDescription.Text}', CompanyID = '{DDlcompany.SelectedValue.ToString()}' WHERE CarID = '{txtid.Text}'", Program.con);
            Program.con.Open();
            cmd.ExecuteNonQuery();
            Program.con.Close();
            MessageBox.Show("updated", "Message");

        }
    }
}
