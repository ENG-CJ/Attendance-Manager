namespace Atttendance
{
    partial class Attendances
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.saaButton3 = new SaaUI.SaaButton();
            this.viewAttendace = new SaaUI.SaaButton();
            this.saaButton1 = new SaaUI.SaaButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.className = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatePicking = new Bunifu.Framework.UI.BunifuDatepicker();
            this.saaButton4 = new SaaUI.SaaButton();
            this.classes = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.studentData = new System.Windows.Forms.DataGridView();
            this.State = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.views = new Atttendance.Views();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 54);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Atttendance.Properties.Resources.icons8_Close_48px;
            this.pictureBox1.Location = new System.Drawing.Point(851, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 47);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Take Attendance ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.saaButton3);
            this.panel2.Controls.Add(this.viewAttendace);
            this.panel2.Controls.Add(this.saaButton1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 620);
            this.panel2.TabIndex = 1;
            // 
            // saaButton3
            // 
            this.saaButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.BackColorAngle = 90F;
            this.saaButton3.Border = 1;
            this.saaButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.BorderColorAngle = 0;
            this.saaButton3.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton3.EnableDoubleBuffering = true;
            this.saaButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.saaButton3.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton3.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton3.Icon = null;
            this.saaButton3.IconOffsetX = 5F;
            this.saaButton3.IconOffsetY = 5F;
            this.saaButton3.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton3.Location = new System.Drawing.Point(10, 264);
            this.saaButton3.Name = "saaButton3";
            this.saaButton3.Radius.BottomLeft = 2;
            this.saaButton3.Radius.BottomRight = 2;
            this.saaButton3.Radius.TopLeft = 2;
            this.saaButton3.Radius.TopRight = 2;
            this.saaButton3.Size = new System.Drawing.Size(130, 39);
            this.saaButton3.TabIndex = 2;
            this.saaButton3.TextOffsetX = 0F;
            this.saaButton3.TextOffsetY = 0F;
            this.saaButton3.Value = "SignOut";
            this.saaButton3.Click += new System.EventHandler(this.saaButton3_Click);
            // 
            // viewAttendace
            // 
            this.viewAttendace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.BackColorAngle = 90F;
            this.viewAttendace.Border = 1;
            this.viewAttendace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.BorderColorAngle = 0;
            this.viewAttendace.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.viewAttendace.EnableDoubleBuffering = true;
            this.viewAttendace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.viewAttendace.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.viewAttendace.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.viewAttendace.Icon = null;
            this.viewAttendace.IconOffsetX = 5F;
            this.viewAttendace.IconOffsetY = 5F;
            this.viewAttendace.IconSize = new System.Drawing.Size(20, 20);
            this.viewAttendace.Location = new System.Drawing.Point(8, 203);
            this.viewAttendace.Name = "viewAttendace";
            this.viewAttendace.Radius.BottomLeft = 2;
            this.viewAttendace.Radius.BottomRight = 2;
            this.viewAttendace.Radius.TopLeft = 2;
            this.viewAttendace.Radius.TopRight = 2;
            this.viewAttendace.Size = new System.Drawing.Size(130, 39);
            this.viewAttendace.TabIndex = 2;
            this.viewAttendace.TextOffsetX = 0F;
            this.viewAttendace.TextOffsetY = 0F;
            this.viewAttendace.Value = "View";
            this.viewAttendace.Click += new System.EventHandler(this.viewAttendace_Click);
            // 
            // saaButton1
            // 
            this.saaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.BackColorAngle = 90F;
            this.saaButton1.Border = 1;
            this.saaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.BorderColorAngle = 0;
            this.saaButton1.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.EnableDoubleBuffering = true;
            this.saaButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.saaButton1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.saaButton1.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.Icon = null;
            this.saaButton1.IconOffsetX = 5F;
            this.saaButton1.IconOffsetY = 5F;
            this.saaButton1.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton1.Location = new System.Drawing.Point(10, 143);
            this.saaButton1.Name = "saaButton1";
            this.saaButton1.Radius.BottomLeft = 2;
            this.saaButton1.Radius.BottomRight = 2;
            this.saaButton1.Radius.TopLeft = 2;
            this.saaButton1.Radius.TopRight = 2;
            this.saaButton1.Size = new System.Drawing.Size(130, 39);
            this.saaButton1.TabIndex = 2;
            this.saaButton1.TextOffsetX = 0F;
            this.saaButton1.TextOffsetY = 0F;
            this.saaButton1.Value = "Attendance";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Atttendance.Properties.Resources.unknown;
            this.pictureBox2.Location = new System.Drawing.Point(18, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // className
            // 
            this.className.AutoSize = true;
            this.className.Font = new System.Drawing.Font("Poppins SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.className.ForeColor = System.Drawing.Color.Black;
            this.className.Location = new System.Drawing.Point(229, 63);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(114, 50);
            this.className.TabIndex = 0;
            this.className.Text = "CA202";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(234, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Active Class";
            // 
            // DatePicking
            // 
            this.DatePicking.BackColor = System.Drawing.Color.SeaGreen;
            this.DatePicking.BorderRadius = 0;
            this.DatePicking.ForeColor = System.Drawing.Color.White;
            this.DatePicking.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicking.FormatCustom = null;
            this.DatePicking.Location = new System.Drawing.Point(686, 137);
            this.DatePicking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DatePicking.Name = "DatePicking";
            this.DatePicking.Size = new System.Drawing.Size(225, 44);
            this.DatePicking.TabIndex = 3;
            this.DatePicking.Value = new System.DateTime(2022, 5, 30, 19, 33, 27, 837);
            // 
            // saaButton4
            // 
            this.saaButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton4.BackColorAngle = 90F;
            this.saaButton4.Border = 1;
            this.saaButton4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton4.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton4.BorderColorAngle = 0;
            this.saaButton4.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton4.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton4.EnableDoubleBuffering = true;
            this.saaButton4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saaButton4.ForeColor = System.Drawing.Color.White;
            this.saaButton4.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton4.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton4.Icon = null;
            this.saaButton4.IconOffsetX = 5F;
            this.saaButton4.IconOffsetY = 5F;
            this.saaButton4.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton4.Location = new System.Drawing.Point(152, 138);
            this.saaButton4.Name = "saaButton4";
            this.saaButton4.Radius.BottomLeft = 2;
            this.saaButton4.Radius.BottomRight = 2;
            this.saaButton4.Radius.TopLeft = 2;
            this.saaButton4.Radius.TopRight = 2;
            this.saaButton4.Size = new System.Drawing.Size(134, 43);
            this.saaButton4.TabIndex = 5;
            this.saaButton4.TextOffsetX = 0F;
            this.saaButton4.TextOffsetY = 0F;
            this.saaButton4.Value = "SAVE";
            this.saaButton4.Click += new System.EventHandler(this.button1_Click);
            // 
            // classes
            // 
            this.classes.BackColor = System.Drawing.Color.White;
            this.classes.BorderColor = System.Drawing.Color.Gray;
            this.classes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classes.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.classes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.classes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.classes.ItemHeight = 30;
            this.classes.Items.AddRange(new object[] {
            "CA201",
            "CA202",
            "CA203",
            "CA204",
            "CA205",
            "CA206",
            "CA207",
            "CA208",
            "CA209"});
            this.classes.Location = new System.Drawing.Point(293, 134);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(152, 36);
            this.classes.StartIndex = 1;
            this.classes.TabIndex = 6;
            this.classes.SelectedIndexChanged += new System.EventHandler(this.classes_SelectedIndexChanged);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Atttendance.Properties.Resources.IMG_20220518_WA0011;
            this.pictureBox3.Location = new System.Drawing.Point(152, 59);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // studentData
            // 
            this.studentData.AllowUserToAddRows = false;
            this.studentData.AllowUserToDeleteRows = false;
            this.studentData.BackgroundColor = System.Drawing.Color.White;
            this.studentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.State});
            this.studentData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.studentData.Location = new System.Drawing.Point(141, 197);
            this.studentData.Name = "studentData";
            this.studentData.RowHeadersWidth = 51;
            this.studentData.RowTemplate.Height = 24;
            this.studentData.Size = new System.Drawing.Size(764, 477);
            this.studentData.TabIndex = 7;
            this.studentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getData);
            this.studentData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.getData);
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.Width = 125;
            // 
            // views
            // 
            this.views.BackColor = System.Drawing.Color.White;
            this.views.Location = new System.Drawing.Point(141, 54);
            this.views.Name = "views";
            this.views.Size = new System.Drawing.Size(799, 638);
            this.views.TabIndex = 8;
            this.views.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 674);
            this.Controls.Add(this.views);
            this.Controls.Add(this.classes);
            this.Controls.Add(this.saaButton4);
            this.Controls.Add(this.DatePicking);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.className);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.studentData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private SaaUI.SaaButton saaButton1;
        private SaaUI.SaaButton saaButton3;
        private SaaUI.SaaButton viewAttendace;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label className;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker DatePicking;
        private SaaUI.SaaButton saaButton4;
        private Guna.UI2.WinForms.Guna2ComboBox classes;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DataGridView studentData;
        private Views views;
        private System.Windows.Forms.DataGridViewCheckBoxColumn State;
    }
}

