namespace ArduinoSerialTest
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.speed1 = new System.Windows.Forms.Label();
            this.speed2 = new System.Windows.Forms.Label();
            this.speed3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.speedk1 = new System.Windows.Forms.Label();
            this.speedk2 = new System.Windows.Forms.Label();
            this.speedk3 = new System.Windows.Forms.Label();
            this.speedk4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.speed4 = new System.Windows.Forms.Label();
            this.acc3 = new System.Windows.Forms.Label();
            this.acc2 = new System.Windows.Forms.Label();
            this.acc1 = new System.Windows.Forms.Label();
            this.timel1 = new System.Windows.Forms.Label();
            this.timel2 = new System.Windows.Forms.Label();
            this.timel3 = new System.Windows.Forms.Label();
            this.timel4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(574, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(517, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Run Test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 1137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1117, 251);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "ID: Speed1, Speed2, Speed3, Speed4, Time1, Time2, Time3, Time4, Acceleration1, Ac" +
    "celeration2, Acceleration3\r\n";
            this.textBox1.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusConnection,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1141, 48);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusConnection
            // 
            this.statusConnection.Name = "statusConnection";
            this.statusConnection.Size = new System.Drawing.Size(199, 41);
            this.statusConnection.Text = "Disconnected";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(234, 43);
            this.toolStripStatusLabel1.Text = "ConorWalsh.Net";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // speed1
            // 
            this.speed1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speed1.AutoSize = true;
            this.speed1.Location = new System.Drawing.Point(3, 162);
            this.speed1.Name = "speed1";
            this.speed1.Size = new System.Drawing.Size(156, 54);
            this.speed1.TabIndex = 5;
            this.speed1.Text = "0m/s";
            this.speed1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed2
            // 
            this.speed2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speed2.AutoSize = true;
            this.speed2.Location = new System.Drawing.Point(328, 162);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(157, 54);
            this.speed2.TabIndex = 6;
            this.speed2.Text = "0m/s";
            this.speed2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed3
            // 
            this.speed3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speed3.AutoSize = true;
            this.speed3.Location = new System.Drawing.Point(654, 162);
            this.speed3.Name = "speed3";
            this.speed3.Size = new System.Drawing.Size(157, 54);
            this.speed3.TabIndex = 7;
            this.speed3.Text = "0m/s";
            this.speed3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(517, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(314, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 58);
            this.button4.TabIndex = 10;
            this.button4.Text = "Show Readout";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.tableLayoutPanel1.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.speedk1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.speed1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.speedk2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.speed2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.speedk3, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.speed3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.speedk4, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.speed4, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.acc3, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.acc2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.acc1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.timel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timel2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.timel3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.timel4, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 152);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1141, 270);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(817, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 54);
            this.label7.TabIndex = 30;
            this.label7.Text = "Acceleration 3";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(491, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 54);
            this.label6.TabIndex = 29;
            this.label6.Text = "Acceleration 2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 54);
            this.label5.TabIndex = 28;
            this.label5.Text = "Acceleration 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 54);
            this.label1.TabIndex = 17;
            this.label1.Text = "Speed 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedk1
            // 
            this.speedk1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedk1.AutoSize = true;
            this.speedk1.Location = new System.Drawing.Point(3, 216);
            this.speedk1.Name = "speedk1";
            this.speedk1.Size = new System.Drawing.Size(156, 54);
            this.speedk1.TabIndex = 13;
            this.speedk1.Text = "0km/h";
            this.speedk1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedk2
            // 
            this.speedk2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedk2.AutoSize = true;
            this.speedk2.Location = new System.Drawing.Point(328, 216);
            this.speedk2.Name = "speedk2";
            this.speedk2.Size = new System.Drawing.Size(157, 54);
            this.speedk2.TabIndex = 14;
            this.speedk2.Text = "0km/h";
            this.speedk2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedk3
            // 
            this.speedk3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedk3.AutoSize = true;
            this.speedk3.Location = new System.Drawing.Point(654, 216);
            this.speedk3.Name = "speedk3";
            this.speedk3.Size = new System.Drawing.Size(157, 54);
            this.speedk3.TabIndex = 15;
            this.speedk3.Text = "0km/h";
            this.speedk3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedk4
            // 
            this.speedk4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedk4.AutoSize = true;
            this.speedk4.Location = new System.Drawing.Point(980, 216);
            this.speedk4.Name = "speedk4";
            this.speedk4.Size = new System.Drawing.Size(158, 54);
            this.speedk4.TabIndex = 16;
            this.speedk4.Text = "0km/h";
            this.speedk4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 54);
            this.label2.TabIndex = 18;
            this.label2.Text = "Speed 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(654, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 54);
            this.label3.TabIndex = 19;
            this.label3.Text = "Speed 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(980, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 54);
            this.label4.TabIndex = 20;
            this.label4.Text = "Speed 4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speed4
            // 
            this.speed4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speed4.AutoSize = true;
            this.speed4.Location = new System.Drawing.Point(980, 162);
            this.speed4.Name = "speed4";
            this.speed4.Size = new System.Drawing.Size(158, 54);
            this.speed4.TabIndex = 21;
            this.speed4.Text = "0m/s";
            this.speed4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc3
            // 
            this.acc3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acc3.AutoSize = true;
            this.acc3.Location = new System.Drawing.Point(817, 108);
            this.acc3.Name = "acc3";
            this.acc3.Size = new System.Drawing.Size(157, 54);
            this.acc3.TabIndex = 25;
            this.acc3.Text = "0m/s²";
            this.acc3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc2
            // 
            this.acc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acc2.AutoSize = true;
            this.acc2.Location = new System.Drawing.Point(491, 108);
            this.acc2.Name = "acc2";
            this.acc2.Size = new System.Drawing.Size(157, 54);
            this.acc2.TabIndex = 24;
            this.acc2.Text = "0m/s²";
            this.acc2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc1
            // 
            this.acc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.acc1.AutoSize = true;
            this.acc1.Location = new System.Drawing.Point(165, 108);
            this.acc1.Name = "acc1";
            this.acc1.Size = new System.Drawing.Size(157, 54);
            this.acc1.TabIndex = 22;
            this.acc1.Text = "0m/s²";
            this.acc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timel1
            // 
            this.timel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timel1.AutoSize = true;
            this.timel1.Location = new System.Drawing.Point(3, 54);
            this.timel1.Name = "timel1";
            this.timel1.Size = new System.Drawing.Size(156, 54);
            this.timel1.TabIndex = 31;
            this.timel1.Text = "0s";
            this.timel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timel2
            // 
            this.timel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timel2.AutoSize = true;
            this.timel2.Location = new System.Drawing.Point(328, 54);
            this.timel2.Name = "timel2";
            this.timel2.Size = new System.Drawing.Size(157, 54);
            this.timel2.TabIndex = 32;
            this.timel2.Text = "0s";
            this.timel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timel3
            // 
            this.timel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timel3.AutoSize = true;
            this.timel3.Location = new System.Drawing.Point(654, 54);
            this.timel3.Name = "timel3";
            this.timel3.Size = new System.Drawing.Size(157, 54);
            this.timel3.TabIndex = 33;
            this.timel3.Text = "0s";
            this.timel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timel4
            // 
            this.timel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timel4.AutoSize = true;
            this.timel4.Location = new System.Drawing.Point(980, 54);
            this.timel4.Name = "timel4";
            this.timel4.Size = new System.Drawing.Size(158, 54);
            this.timel4.TabIndex = 34;
            this.timel4.Text = "0s";
            this.timel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisX.Title = "Time";
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Speed";
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(9, 437);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(1120, 691);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "Car Track Speed Time Graph";
            this.chart1.Titles.Add(title3);
            this.chart1.Visible = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(51, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 58);
            this.button5.TabIndex = 14;
            this.button5.Text = "Save Graph as Image";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(837, 76);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(254, 58);
            this.button6.TabIndex = 15;
            this.button6.Text = "Copy Readout to ClipBoard";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(574, 76);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(254, 58);
            this.button7.TabIndex = 16;
            this.button7.Text = "Save Readout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(168, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(184, 1134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 18;
            this.panel2.Visible = false;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(615, 43);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1141, 1437);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Car Track - ConorWalsh.Net";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusConnection;
        private System.Windows.Forms.Label speed1;
        private System.Windows.Forms.Label speed2;
        private System.Windows.Forms.Label speed3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label speedk1;
        private System.Windows.Forms.Label speedk2;
        private System.Windows.Forms.Label speedk3;
        private System.Windows.Forms.Label speedk4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label speed4;
        private System.Windows.Forms.Label acc1;
        private System.Windows.Forms.Label acc2;
        private System.Windows.Forms.Label acc3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label timel1;
        private System.Windows.Forms.Label timel2;
        private System.Windows.Forms.Label timel3;
        private System.Windows.Forms.Label timel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

