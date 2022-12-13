namespace eventmanagement
{
    partial class bookevent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookevent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbevnttype = new System.Windows.Forms.ComboBox();
            this.evntBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventmngmntDataSet6 = new eventmanagement.eventmngmntDataSet6();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbcname = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventmngmntDataSet1 = new eventmanagement.eventmngmntDataSet1();
            this.txttheme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtbasecharge = new System.Windows.Forms.TextBox();
            this.txtextracharge = new System.Windows.Forms.TextBox();
            this.txtgst = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkphotography = new System.Windows.Forms.CheckBox();
            this.chkanchor = new System.Windows.Forms.CheckBox();
            this.chkdjfloor = new System.Windows.Forms.CheckBox();
            this.chkdj = new System.Windows.Forms.CheckBox();
            this.chkled = new System.Windows.Forms.CheckBox();
            this.chktent = new System.Windows.Forms.CheckBox();
            this.chklighting = new System.Windows.Forms.CheckBox();
            this.chkflower = new System.Windows.Forms.CheckBox();
            this.chkballon = new System.Windows.Forms.CheckBox();
            this.evntTableAdapter = new eventmanagement.eventmngmntDataSet6TableAdapters.evntTableAdapter();
            this.customerTableAdapter = new eventmanagement.eventmngmntDataSet1TableAdapters.customerTableAdapter();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evntBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmngmntDataSet6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmngmntDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.cbevnttype);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtbid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1357, 268);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.lOGOUTToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1357, 24);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // lOGOUTToolStripMenuItem
            // 
            this.lOGOUTToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOGOUTToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            this.lOGOUTToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.lOGOUTToolStripMenuItem.Text = "LOGOUT";
            this.lOGOUTToolStripMenuItem.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXITToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // cbevnttype
            // 
            this.cbevnttype.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.evntBindingSource, "evnttype", true));
            this.cbevnttype.FormattingEnabled = true;
            this.cbevnttype.Location = new System.Drawing.Point(199, 132);
            this.cbevnttype.Name = "cbevnttype";
            this.cbevnttype.Size = new System.Drawing.Size(207, 21);
            this.cbevnttype.TabIndex = 37;
            this.cbevnttype.SelectedIndexChanged += new System.EventHandler(this.cbevnttype_SelectedIndexChanged);
            this.cbevnttype.TextChanged += new System.EventHandler(this.cbevnttype_TextChanged);
            // 
            // evntBindingSource
            // 
            this.evntBindingSource.DataMember = "evnt";
            this.evntBindingSource.DataSource = this.eventmngmntDataSet6;
            // 
            // eventmngmntDataSet6
            // 
            this.eventmngmntDataSet6.DataSetName = "eventmngmntDataSet6";
            this.eventmngmntDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 36;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtbid
            // 
            this.txtbid.Enabled = false;
            this.txtbid.Location = new System.Drawing.Point(199, 53);
            this.txtbid.Name = "txtbid";
            this.txtbid.Size = new System.Drawing.Size(207, 20);
            this.txtbid.TabIndex = 34;
            this.txtbid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "EventType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "EventDate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "BookingId";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.richTextBox1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.cbcname);
            this.panel2.Controls.Add(this.txttheme);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(2, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 459);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(245, 117);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 73);
            this.richTextBox1.TabIndex = 43;
            this.richTextBox1.Text = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(245, 213);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(161, 20);
            this.numericUpDown1.TabIndex = 42;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbcname
            // 
            this.cbcname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "cname", true));
            this.cbcname.FormattingEnabled = true;
            this.cbcname.Location = new System.Drawing.Point(245, 71);
            this.cbcname.Name = "cbcname";
            this.cbcname.Size = new System.Drawing.Size(161, 21);
            this.cbcname.TabIndex = 41;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.eventmngmntDataSet1;
            // 
            // eventmngmntDataSet1
            // 
            this.eventmngmntDataSet1.DataSetName = "eventmngmntDataSet1";
            this.eventmngmntDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txttheme
            // 
            this.txttheme.Location = new System.Drawing.Point(245, 270);
            this.txttheme.Name = "txttheme";
            this.txttheme.Size = new System.Drawing.Size(161, 20);
            this.txttheme.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(99, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 35;
            this.label7.Text = "Theme";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 34;
            this.label6.Text = "NoOfGuest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "Venue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Customer Name";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txtsubtotal);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.txtbasecharge);
            this.panel3.Controls.Add(this.txtextracharge);
            this.panel3.Controls.Add(this.txtgst);
            this.panel3.Controls.Add(this.txttotal);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.chkphotography);
            this.panel3.Controls.Add(this.chkanchor);
            this.panel3.Controls.Add(this.chkdjfloor);
            this.panel3.Controls.Add(this.chkdj);
            this.panel3.Controls.Add(this.chkled);
            this.panel3.Controls.Add(this.chktent);
            this.panel3.Controls.Add(this.chklighting);
            this.panel3.Controls.Add(this.chkflower);
            this.panel3.Controls.Add(this.chkballon);
            this.panel3.Location = new System.Drawing.Point(485, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 462);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(701, 158);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(97, 20);
            this.txtsubtotal.TabIndex = 51;
            this.txtsubtotal.TextChanged += new System.EventHandler(this.txtsubtotal_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(548, 155);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 19);
            this.label21.TabIndex = 50;
            this.label21.Text = "Sub Total";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(544, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 19);
            this.label20.TabIndex = 49;
            this.label20.Text = "Base Charges";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(544, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 19);
            this.label19.TabIndex = 48;
            this.label19.Text = "Extra charges";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(548, 185);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 19);
            this.label18.TabIndex = 47;
            this.label18.Text = "GST(18%)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(548, 221);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 19);
            this.label17.TabIndex = 46;
            this.label17.Text = "Grand Total";
            // 
            // txtbasecharge
            // 
            this.txtbasecharge.Location = new System.Drawing.Point(701, 78);
            this.txtbasecharge.Name = "txtbasecharge";
            this.txtbasecharge.Size = new System.Drawing.Size(97, 20);
            this.txtbasecharge.TabIndex = 45;
            // 
            // txtextracharge
            // 
            this.txtextracharge.Location = new System.Drawing.Point(701, 118);
            this.txtextracharge.Name = "txtextracharge";
            this.txtextracharge.Size = new System.Drawing.Size(97, 20);
            this.txtextracharge.TabIndex = 44;
            this.txtextracharge.Click += new System.EventHandler(this.txtextracharge_Click);
            // 
            // txtgst
            // 
            this.txtgst.Location = new System.Drawing.Point(701, 187);
            this.txtgst.Name = "txtgst";
            this.txtgst.Size = new System.Drawing.Size(97, 20);
            this.txtgst.TabIndex = 43;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(701, 224);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(97, 20);
            this.txttotal.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(240, 306);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 19);
            this.label16.TabIndex = 41;
            this.label16.Text = "80000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(239, 276);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 40;
            this.label15.Text = "25000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(239, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 39;
            this.label14.Text = "10000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(239, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 38;
            this.label13.Text = "30000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(239, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 37;
            this.label12.Text = "12000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "15000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 19);
            this.label10.TabIndex = 35;
            this.label10.Text = "20000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 119);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "35000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(239, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 19);
            this.label8.TabIndex = 33;
            this.label8.Text = "10000";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSalmon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(581, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 34);
            this.button3.TabIndex = 31;
            this.button3.Text = "Billing";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(712, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 34);
            this.button2.TabIndex = 30;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkphotography
            // 
            this.chkphotography.AutoSize = true;
            this.chkphotography.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkphotography.Location = new System.Drawing.Point(75, 214);
            this.chkphotography.Name = "chkphotography";
            this.chkphotography.Size = new System.Drawing.Size(114, 23);
            this.chkphotography.TabIndex = 8;
            this.chkphotography.Text = "Photography";
            this.chkphotography.UseVisualStyleBackColor = true;
            // 
            // chkanchor
            // 
            this.chkanchor.AutoSize = true;
            this.chkanchor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkanchor.Location = new System.Drawing.Point(76, 185);
            this.chkanchor.Name = "chkanchor";
            this.chkanchor.Size = new System.Drawing.Size(78, 23);
            this.chkanchor.TabIndex = 7;
            this.chkanchor.Text = "Anchor";
            this.chkanchor.UseVisualStyleBackColor = true;
            // 
            // chkdjfloor
            // 
            this.chkdjfloor.AutoSize = true;
            this.chkdjfloor.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdjfloor.Location = new System.Drawing.Point(75, 150);
            this.chkdjfloor.Name = "chkdjfloor";
            this.chkdjfloor.Size = new System.Drawing.Size(86, 23);
            this.chkdjfloor.TabIndex = 6;
            this.chkdjfloor.Text = "DJFloor";
            this.chkdjfloor.UseVisualStyleBackColor = true;
            // 
            // chkdj
            // 
            this.chkdj.AutoSize = true;
            this.chkdj.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdj.Location = new System.Drawing.Point(79, 272);
            this.chkdj.Name = "chkdj";
            this.chkdj.Size = new System.Drawing.Size(48, 23);
            this.chkdj.TabIndex = 5;
            this.chkdj.Text = "DJ";
            this.chkdj.UseVisualStyleBackColor = true;
            // 
            // chkled
            // 
            this.chkled.AutoSize = true;
            this.chkled.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkled.Location = new System.Drawing.Point(79, 243);
            this.chkled.Name = "chkled";
            this.chkled.Size = new System.Drawing.Size(61, 23);
            this.chkled.TabIndex = 4;
            this.chkled.Text = "LED";
            this.chkled.UseVisualStyleBackColor = true;
            // 
            // chktent
            // 
            this.chktent.AutoSize = true;
            this.chktent.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktent.Location = new System.Drawing.Point(79, 302);
            this.chktent.Name = "chktent";
            this.chktent.Size = new System.Drawing.Size(58, 23);
            this.chktent.TabIndex = 3;
            this.chktent.Text = "Tent";
            this.chktent.UseVisualStyleBackColor = true;
            // 
            // chklighting
            // 
            this.chklighting.AutoSize = true;
            this.chklighting.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklighting.Location = new System.Drawing.Point(78, 121);
            this.chklighting.Name = "chklighting";
            this.chklighting.Size = new System.Drawing.Size(87, 23);
            this.chklighting.TabIndex = 2;
            this.chklighting.Text = "Lighting";
            this.chklighting.UseVisualStyleBackColor = true;
            // 
            // chkflower
            // 
            this.chkflower.AutoSize = true;
            this.chkflower.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkflower.Location = new System.Drawing.Point(79, 83);
            this.chkflower.Name = "chkflower";
            this.chkflower.Size = new System.Drawing.Size(80, 23);
            this.chkflower.TabIndex = 1;
            this.chkflower.Text = " Flower";
            this.chkflower.UseVisualStyleBackColor = true;
            this.chkflower.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // chkballon
            // 
            this.chkballon.AutoSize = true;
            this.chkballon.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkballon.Location = new System.Drawing.Point(79, 52);
            this.chkballon.Name = "chkballon";
            this.chkballon.Size = new System.Drawing.Size(82, 23);
            this.chkballon.TabIndex = 0;
            this.chkballon.Text = "Balloon";
            this.chkballon.UseVisualStyleBackColor = true;
            this.chkballon.CheckedChanged += new System.EventHandler(this.chkballon_CheckedChanged);
            // 
            // evntTableAdapter
            // 
            this.evntTableAdapter.ClearBeforeFill = true;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // bookevent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 713);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "bookevent";
            this.Text = "bookevent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.bookevent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evntBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmngmntDataSet6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventmngmntDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbevnttype;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttheme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox chkphotography;
        private System.Windows.Forms.CheckBox chkanchor;
        private System.Windows.Forms.CheckBox chkdjfloor;
        private System.Windows.Forms.CheckBox chkdj;
        private System.Windows.Forms.CheckBox chkled;
        private System.Windows.Forms.CheckBox chktent;
        private System.Windows.Forms.CheckBox chklighting;
        private System.Windows.Forms.CheckBox chkflower;
        private System.Windows.Forms.CheckBox chkballon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtbasecharge;
        private System.Windows.Forms.TextBox txtextracharge;
        private System.Windows.Forms.TextBox txtgst;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private eventmngmntDataSet6 eventmngmntDataSet6;
        private System.Windows.Forms.BindingSource evntBindingSource;
        private eventmngmntDataSet6TableAdapters.evntTableAdapter evntTableAdapter;
        private System.Windows.Forms.ComboBox cbcname;
        private eventmngmntDataSet1 eventmngmntDataSet1;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private eventmngmntDataSet1TableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}