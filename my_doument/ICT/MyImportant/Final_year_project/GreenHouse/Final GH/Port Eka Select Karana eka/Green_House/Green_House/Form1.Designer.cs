namespace Green_House
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.temp_val = new System.Windows.Forms.NumericUpDown();
            this.hu_val = new System.Windows.Forms.NumericUpDown();
            this.lux_val = new System.Windows.Forms.NumericUpDown();
            this.auto = new System.Windows.Forms.RadioButton();
            this.manual = new System.Windows.Forms.RadioButton();
            this.lion = new System.Windows.Forms.Button();
            this.lioff = new System.Windows.Forms.Button();
            this.c_off = new System.Windows.Forms.Button();
            this.c_on = new System.Windows.Forms.Button();
            this.e_of = new System.Windows.Forms.Button();
            this.e_on = new System.Windows.Forms.Button();
            this.hz1 = new System.Windows.Forms.Timer(this.components);
            this.tmplb = new System.Windows.Forms.Label();
            this.hlbl = new System.Windows.Forms.Label();
            this.luxlbl = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.con_lbl = new System.Windows.Forms.Label();
            this.updtbtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.li_bar = new System.Windows.Forms.TrackBar();
            this.c_fan_bar = new System.Windows.Forms.TrackBar();
            this.e_fan_bar = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.temp_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hu_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lux_val)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.li_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fan_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_fan_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // temp_val
            // 
            this.temp_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.temp_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.temp_val.Location = new System.Drawing.Point(339, 46);
            this.temp_val.Name = "temp_val";
            this.temp_val.Size = new System.Drawing.Size(54, 20);
            this.temp_val.TabIndex = 5;
            // 
            // hu_val
            // 
            this.hu_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.hu_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.hu_val.Location = new System.Drawing.Point(447, 43);
            this.hu_val.Name = "hu_val";
            this.hu_val.Size = new System.Drawing.Size(54, 20);
            this.hu_val.TabIndex = 6;
            // 
            // lux_val
            // 
            this.lux_val.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lux_val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lux_val.Location = new System.Drawing.Point(579, 43);
            this.lux_val.Name = "lux_val";
            this.lux_val.Size = new System.Drawing.Size(53, 20);
            this.lux_val.TabIndex = 7;
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.auto.Checked = true;
            this.auto.ForeColor = System.Drawing.Color.Navy;
            this.auto.Location = new System.Drawing.Point(832, 154);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(47, 17);
            this.auto.TabIndex = 15;
            this.auto.TabStop = true;
            this.auto.Text = "Auto";
            this.auto.UseVisualStyleBackColor = false;
            this.auto.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // manual
            // 
            this.manual.AutoSize = true;
            this.manual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.manual.ForeColor = System.Drawing.Color.Navy;
            this.manual.Location = new System.Drawing.Point(895, 154);
            this.manual.Name = "manual";
            this.manual.Size = new System.Drawing.Size(54, 17);
            this.manual.TabIndex = 16;
            this.manual.Text = "Manul";
            this.manual.UseVisualStyleBackColor = false;
            this.manual.CheckedChanged += new System.EventHandler(this.manual_CheckedChanged);
            // 
            // lion
            // 
            this.lion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lion.ForeColor = System.Drawing.Color.Navy;
            this.lion.Location = new System.Drawing.Point(832, 191);
            this.lion.Name = "lion";
            this.lion.Size = new System.Drawing.Size(75, 23);
            this.lion.TabIndex = 17;
            this.lion.Text = "Light On";
            this.lion.UseVisualStyleBackColor = false;
            this.lion.Click += new System.EventHandler(this.lion_Click);
            // 
            // lioff
            // 
            this.lioff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lioff.ForeColor = System.Drawing.Color.Navy;
            this.lioff.Location = new System.Drawing.Point(909, 191);
            this.lioff.Name = "lioff";
            this.lioff.Size = new System.Drawing.Size(75, 23);
            this.lioff.TabIndex = 18;
            this.lioff.Text = "Light Off";
            this.lioff.UseVisualStyleBackColor = false;
            this.lioff.Click += new System.EventHandler(this.lioff_Click);
            // 
            // c_off
            // 
            this.c_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.c_off.ForeColor = System.Drawing.Color.Navy;
            this.c_off.Location = new System.Drawing.Point(909, 271);
            this.c_off.Name = "c_off";
            this.c_off.Size = new System.Drawing.Size(75, 23);
            this.c_off.TabIndex = 20;
            this.c_off.Text = "C fan Off";
            this.c_off.UseVisualStyleBackColor = false;
            this.c_off.Click += new System.EventHandler(this.c_off_Click);
            // 
            // c_on
            // 
            this.c_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.c_on.ForeColor = System.Drawing.Color.Navy;
            this.c_on.Location = new System.Drawing.Point(832, 271);
            this.c_on.Name = "c_on";
            this.c_on.Size = new System.Drawing.Size(75, 23);
            this.c_on.TabIndex = 19;
            this.c_on.Text = "C Fan On";
            this.c_on.UseVisualStyleBackColor = false;
            this.c_on.Click += new System.EventHandler(this.c_on_Click);
            // 
            // e_of
            // 
            this.e_of.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.e_of.ForeColor = System.Drawing.Color.Navy;
            this.e_of.Location = new System.Drawing.Point(909, 351);
            this.e_of.Name = "e_of";
            this.e_of.Size = new System.Drawing.Size(75, 23);
            this.e_of.TabIndex = 22;
            this.e_of.Text = "E fan Off";
            this.e_of.UseVisualStyleBackColor = false;
            this.e_of.Click += new System.EventHandler(this.e_of_Click);
            // 
            // e_on
            // 
            this.e_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.e_on.ForeColor = System.Drawing.Color.Navy;
            this.e_on.Location = new System.Drawing.Point(832, 351);
            this.e_on.Name = "e_on";
            this.e_on.Size = new System.Drawing.Size(75, 23);
            this.e_on.TabIndex = 21;
            this.e_on.Text = "E Fan On";
            this.e_on.UseVisualStyleBackColor = false;
            this.e_on.Click += new System.EventHandler(this.e_on_Click);
            // 
            // hz1
            // 
            this.hz1.Interval = 500;
            this.hz1.Tick += new System.EventHandler(this.hz1_Tick);
            // 
            // tmplb
            // 
            this.tmplb.AutoSize = true;
            this.tmplb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmplb.ForeColor = System.Drawing.Color.Blue;
            this.tmplb.Location = new System.Drawing.Point(12, 49);
            this.tmplb.Name = "tmplb";
            this.tmplb.Size = new System.Drawing.Size(40, 17);
            this.tmplb.TabIndex = 26;
            this.tmplb.Text = "Temp";
            // 
            // hlbl
            // 
            this.hlbl.AutoSize = true;
            this.hlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hlbl.ForeColor = System.Drawing.Color.Blue;
            this.hlbl.Location = new System.Drawing.Point(12, 9);
            this.hlbl.Name = "hlbl";
            this.hlbl.Size = new System.Drawing.Size(59, 17);
            this.hlbl.TabIndex = 27;
            this.hlbl.Text = "Humidity";
            // 
            // luxlbl
            // 
            this.luxlbl.AutoSize = true;
            this.luxlbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luxlbl.ForeColor = System.Drawing.Color.Blue;
            this.luxlbl.Location = new System.Drawing.Point(12, 29);
            this.luxlbl.Name = "luxlbl";
            this.luxlbl.Size = new System.Drawing.Size(63, 17);
            this.luxlbl.TabIndex = 28;
            this.luxlbl.Text = "Lux Level";
            // 
            // tim
            // 
            this.tim.AutoSize = true;
            this.tim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tim.Location = new System.Drawing.Point(804, 16);
            this.tim.Name = "tim";
            this.tim.Size = new System.Drawing.Size(49, 13);
            this.tim.TabIndex = 29;
            this.tim.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(336, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Set Temp ( C )%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(444, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Set Humidity( % )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(576, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Set Lux ( % )";
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // con_lbl
            // 
            this.con_lbl.AutoSize = true;
            this.con_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.con_lbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con_lbl.ForeColor = System.Drawing.Color.Navy;
            this.con_lbl.Location = new System.Drawing.Point(804, 43);
            this.con_lbl.Name = "con_lbl";
            this.con_lbl.Size = new System.Drawing.Size(87, 16);
            this.con_lbl.TabIndex = 33;
            this.con_lbl.Text = "Conncected";
            // 
            // updtbtn
            // 
            this.updtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.updtbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updtbtn.BackgroundImage")));
            this.updtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updtbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updtbtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.updtbtn.Location = new System.Drawing.Point(688, 16);
            this.updtbtn.Name = "updtbtn";
            this.updtbtn.Size = new System.Drawing.Size(75, 50);
            this.updtbtn.TabIndex = 53;
            this.updtbtn.UseVisualStyleBackColor = false;
            this.updtbtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chart1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.DashedHorizontal;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 61);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Temp";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Humidity";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.Name = "LuxLevel";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(974, 436);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // PictureBox2
            // 
            this.PictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PictureBox2.Location = new System.Drawing.Point(990, -3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(39, 517);
            this.PictureBox2.TabIndex = 55;
            this.PictureBox2.TabStop = false;
            // 
            // li_bar
            // 
            this.li_bar.Location = new System.Drawing.Point(832, 220);
            this.li_bar.Maximum = 3;
            this.li_bar.Name = "li_bar";
            this.li_bar.Size = new System.Drawing.Size(152, 45);
            this.li_bar.TabIndex = 56;
            this.li_bar.Scroll += new System.EventHandler(this.li_bar_Scroll);
            // 
            // c_fan_bar
            // 
            this.c_fan_bar.Location = new System.Drawing.Point(832, 300);
            this.c_fan_bar.Maximum = 3;
            this.c_fan_bar.Name = "c_fan_bar";
            this.c_fan_bar.Size = new System.Drawing.Size(152, 45);
            this.c_fan_bar.TabIndex = 57;
            this.c_fan_bar.Scroll += new System.EventHandler(this.c_fan_bar_Scroll);
            // 
            // e_fan_bar
            // 
            this.e_fan_bar.Location = new System.Drawing.Point(832, 380);
            this.e_fan_bar.Maximum = 3;
            this.e_fan_bar.Name = "e_fan_bar";
            this.e_fan_bar.Size = new System.Drawing.Size(152, 45);
            this.e_fan_bar.TabIndex = 57;
            this.e_fan_bar.Scroll += new System.EventHandler(this.e_fan_bar_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(851, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Select Port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(832, 431);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 59;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(990, 492);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.e_fan_bar);
            this.Controls.Add(this.c_fan_bar);
            this.Controls.Add(this.li_bar);
            this.Controls.Add(this.updtbtn);
            this.Controls.Add(this.con_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tim);
            this.Controls.Add(this.luxlbl);
            this.Controls.Add(this.hlbl);
            this.Controls.Add(this.tmplb);
            this.Controls.Add(this.e_of);
            this.Controls.Add(this.e_on);
            this.Controls.Add(this.c_off);
            this.Controls.Add(this.c_on);
            this.Controls.Add(this.lioff);
            this.Controls.Add(this.lion);
            this.Controls.Add(this.manual);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.lux_val);
            this.Controls.Add(this.hu_val);
            this.Controls.Add(this.temp_val);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.PictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temp_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hu_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lux_val)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.li_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c_fan_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.e_fan_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.NumericUpDown temp_val;
        private System.Windows.Forms.NumericUpDown hu_val;
        private System.Windows.Forms.NumericUpDown lux_val;
        private System.Windows.Forms.RadioButton auto;
        private System.Windows.Forms.RadioButton manual;
        private System.Windows.Forms.Button lion;
        private System.Windows.Forms.Button lioff;
        private System.Windows.Forms.Button c_off;
        private System.Windows.Forms.Button c_on;
        private System.Windows.Forms.Button e_of;
        private System.Windows.Forms.Button e_on;
        private System.Windows.Forms.Timer hz1;
        private System.Windows.Forms.Label tmplb;
        private System.Windows.Forms.Label hlbl;
        private System.Windows.Forms.Label luxlbl;
        private System.Windows.Forms.Label tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label con_lbl;
        internal System.Windows.Forms.Button updtbtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.TrackBar li_bar;
        private System.Windows.Forms.TrackBar c_fan_bar;
        private System.Windows.Forms.TrackBar e_fan_bar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

