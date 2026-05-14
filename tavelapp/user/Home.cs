using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tavelapp
{
    public partial class Home: Form
    {
        public Home()
        {
            InitializeComponent();
            flowLayoutPanel.Width = 50;
        }
        
        private void Home_Load(object sender, EventArgs e)
        {
            

        }
        bool sidebarExpand = false;
        private void transition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand==true)
            {
                flowLayoutPanel.Width -= 5;
                if (flowLayoutPanel.Width <= 50)
                {
                    sidebarExpand = false;
                    transition.Stop();
                }
            }
            else
            {
                flowLayoutPanel.Width += 5;
                if (flowLayoutPanel.Width >= 140)
                {
                    sidebarExpand = true;
                    transition.Stop();
                }

            }

            }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            transition.Start();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }
