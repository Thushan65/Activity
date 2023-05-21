namespace ActivityC
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.textBoxdob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxnic = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxdob
            // 
            this.textBoxdob.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxdob.Location = new System.Drawing.Point(1203, 175);
            this.textBoxdob.Multiline = true;
            this.textBoxdob.Name = "textBoxdob";
            this.textBoxdob.Size = new System.Drawing.Size(249, 40);
            this.textBoxdob.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1107, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOB:";
            // 
            // textBoxnic
            // 
            this.textBoxnic.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxnic.Location = new System.Drawing.Point(695, 175);
            this.textBoxnic.Multiline = true;
            this.textBoxnic.Name = "textBoxnic";
            this.textBoxnic.Size = new System.Drawing.Size(249, 40);
            this.textBoxnic.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(597, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "NIC:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxname
            // 
            this.textBoxname.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxname.Location = new System.Drawing.Point(126, 175);
            this.textBoxname.Multiline = true;
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(249, 40);
            this.textBoxname.TabIndex = 9;
            this.textBoxname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(11, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 41);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(541, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(471, 58);
            this.label4.TabIndex = 10;
            this.label4.Text = "REGISTER A NEW ACCONT";
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Location = new System.Drawing.Point(501, 312);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(150, 50);
            this.buttonsubmit.TabIndex = 11;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(723, 312);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(150, 50);
            this.buttonedit.TabIndex = 12;
            this.buttonedit.Text = "Edit";
            this.buttonedit.UseVisualStyleBackColor = true;
            // 
            // buttoncancel
            // 
            this.buttoncancel.Location = new System.Drawing.Point(958, 312);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(150, 50);
            this.buttoncancel.TabIndex = 13;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = true;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 402);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 384);
            this.dataGridView1.TabIndex = 14;
            // 
            // textBoxusername
            // 
            this.textBoxusername.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxusername.Location = new System.Drawing.Point(541, 249);
            this.textBoxusername.Multiline = true;
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(249, 40);
            this.textBoxusername.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(329, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 41);
            this.label5.TabIndex = 15;
            this.label5.Text = "UserName:";
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxpassword.Location = new System.Drawing.Point(1070, 245);
            this.textBoxpassword.Multiline = true;
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(249, 40);
            this.textBoxpassword.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(858, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1107, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 41);
            this.label7.TabIndex = 19;
            this.label7.Text = "Type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Savings",
            "Current"});
            this.comboBox1.Location = new System.Drawing.Point(1203, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 20;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1484, 798);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttoncancel);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxnic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxdob);
            this.Controls.Add(this.label2);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC Bank";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxdob;
        private Label label2;
        private TextBox textBoxnic;
        private Label label1;
        private TextBox textBoxname;
        private Label label3;
        private Label label4;
        private Button buttonsubmit;
        private Button buttonedit;
        private Button buttoncancel;
        private DataGridView dataGridView1;
        private TextBox textBoxusername;
        private Label label5;
        private TextBox textBoxpassword;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
    }
}