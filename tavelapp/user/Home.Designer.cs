namespace tavelapp
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.transition = new System.Windows.Forms.Timer(this.components);
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel = new System.Windows.Forms.Panel();
            this.btnprofile = new Guna.UI2.WinForms.Guna2Button();
            this.btncar = new Guna.UI2.WinForms.Guna2Button();
            this.btnHotel = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(755, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // transition
            // 
            this.transition.Interval = 10;
            this.transition.Tick += new System.EventHandler(this.transition_Tick);
            // 
            // btnmenu
            // 
            this.btnmenu.BackColor = System.Drawing.Color.SkyBlue;
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.FillColor = System.Drawing.Color.SkyBlue;
            this.btnmenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btnmenu.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenu.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnmenu.ImageSize = new System.Drawing.Size(30, 30);
            this.btnmenu.Location = new System.Drawing.Point(0, 50);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(157, 45);
            this.btnmenu.TabIndex = 2;
            this.btnmenu.Text = "Menue";
            this.btnmenu.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.BackColor = System.Drawing.Color.SkyBlue;
            this.flowLayoutPanel.Controls.Add(this.btnprofile);
            this.flowLayoutPanel.Controls.Add(this.btncar);
            this.flowLayoutPanel.Controls.Add(this.btnmenu);
            this.flowLayoutPanel.Controls.Add(this.btnHotel);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(143, 450);
            this.flowLayoutPanel.TabIndex = 4;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // btnprofile
            // 
            this.btnprofile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprofile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprofile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprofile.FillColor = System.Drawing.Color.SkyBlue;
            this.btnprofile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnprofile.ForeColor = System.Drawing.Color.White;
            this.btnprofile.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btnprofile.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnprofile.Image = ((System.Drawing.Image)(resources.GetObject("btnprofile.Image")));
            this.btnprofile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprofile.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnprofile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnprofile.Location = new System.Drawing.Point(1, 264);
            this.btnprofile.Name = "btnprofile";
            this.btnprofile.Size = new System.Drawing.Size(173, 45);
            this.btnprofile.TabIndex = 2;
            this.btnprofile.Text = "Profile";
            this.btnprofile.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btncar
            // 
            this.btncar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncar.FillColor = System.Drawing.Color.SkyBlue;
            this.btncar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btncar.ForeColor = System.Drawing.Color.White;
            this.btncar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btncar.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btncar.Image = ((System.Drawing.Image)(resources.GetObject("btncar.Image")));
            this.btncar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncar.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btncar.ImageSize = new System.Drawing.Size(30, 30);
            this.btncar.Location = new System.Drawing.Point(0, 199);
            this.btncar.Name = "btncar";
            this.btncar.Size = new System.Drawing.Size(174, 45);
            this.btncar.TabIndex = 2;
            this.btncar.Text = "cars";
            this.btncar.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHotel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHotel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHotel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHotel.FillColor = System.Drawing.Color.SkyBlue;
            this.btnHotel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHotel.ForeColor = System.Drawing.Color.White;
            this.btnHotel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.btnHotel.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnHotel.Image = ((System.Drawing.Image)(resources.GetObject("btnHotel.Image")));
            this.btnHotel.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHotel.ImageOffset = new System.Drawing.Point(-1, 0);
            this.btnHotel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHotel.Location = new System.Drawing.Point(1, 133);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(173, 45);
            this.btnHotel.TabIndex = 2;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Timer transition;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private System.Windows.Forms.Panel flowLayoutPanel;
        private Guna.UI2.WinForms.Guna2Button btnprofile;
        private Guna.UI2.WinForms.Guna2Button btncar;
        private Guna.UI2.WinForms.Guna2Button btnHotel;
    }
}