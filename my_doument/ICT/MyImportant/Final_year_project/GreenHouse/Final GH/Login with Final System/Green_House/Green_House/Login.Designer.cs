namespace Green_House
{
    partial class Login
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
            this.pwtextBox2 = new System.Windows.Forms.TextBox();
            this.untextBox1 = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.Label();
            this.un = new System.Windows.Forms.Label();
            this.lg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwtextBox2
            // 
            this.pwtextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pwtextBox2.Location = new System.Drawing.Point(273, 88);
            this.pwtextBox2.MaximumSize = new System.Drawing.Size(200, 20);
            this.pwtextBox2.Name = "pwtextBox2";
            this.pwtextBox2.PasswordChar = '*';
            this.pwtextBox2.Size = new System.Drawing.Size(122, 20);
            this.pwtextBox2.TabIndex = 9;
            // 
            // untextBox1
            // 
            this.untextBox1.Location = new System.Drawing.Point(273, 37);
            this.untextBox1.Name = "untextBox1";
            this.untextBox1.Size = new System.Drawing.Size(122, 20);
            this.untextBox1.TabIndex = 8;
            // 
            // pw
            // 
            this.pw.AutoSize = true;
            this.pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(170, 88);
            this.pw.MaximumSize = new System.Drawing.Size(100, 20);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(83, 18);
            this.pw.TabIndex = 7;
            this.pw.Text = "Password";
            // 
            // un
            // 
            this.un.AutoSize = true;
            this.un.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.Location = new System.Drawing.Point(169, 39);
            this.un.MaximumSize = new System.Drawing.Size(100, 200);
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(88, 18);
            this.un.TabIndex = 6;
            this.un.Text = "UserName";
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lg.BackgroundImage = global::Green_House.Properties.Resources.lgggg;
            this.lg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lg.Location = new System.Drawing.Point(383, 127);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(115, 34);
            this.lg.TabIndex = 5;
            this.lg.Text = "Login";
            this.lg.UseVisualStyleBackColor = false;
            this.lg.Click += new System.EventHandler(this.lg_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Green_House.Properties.Resources.taskit_gpio_net_example_greenhouse4;
            this.ClientSize = new System.Drawing.Size(644, 341);
            this.Controls.Add(this.pwtextBox2);
            this.Controls.Add(this.untextBox1);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.un);
            this.Controls.Add(this.lg);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwtextBox2;
        private System.Windows.Forms.TextBox untextBox1;
        private System.Windows.Forms.Label pw;
        private System.Windows.Forms.Label un;
        private System.Windows.Forms.Button lg;
    }
}