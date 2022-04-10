
namespace _02
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.creationPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.personalizationPanel = new System.Windows.Forms.Panel();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.creationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.personalizationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.button4 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.creationPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.personalizationPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// creationPanel
			// 
			this.creationPanel.BackColor = System.Drawing.Color.Transparent;
			this.creationPanel.Controls.Add(this.panel1);
			this.creationPanel.Controls.Add(this.listBox1);
			this.creationPanel.Controls.Add(this.panel2);
			this.creationPanel.Location = new System.Drawing.Point(3, 30);
			this.creationPanel.Name = "creationPanel";
			this.creationPanel.Size = new System.Drawing.Size(626, 324);
			this.creationPanel.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Location = new System.Drawing.Point(7, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(197, 316);
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create account";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton3);
			this.groupBox1.Location = new System.Drawing.Point(3, 137);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(191, 132);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Position";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(6, 28);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(87, 28);
			this.radioButton1.TabIndex = 1;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Loader";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(6, 62);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(71, 28);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Clerk";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(6, 96);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(103, 28);
			this.radioButton3.TabIndex = 6;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Manager";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(7, 71);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(172, 29);
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "Password";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(7, 36);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(172, 29);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Name";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(31, 269);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(133, 37);
			this.button1.TabIndex = 3;
			this.button1.Text = "Create";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(7, 106);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(84, 28);
			this.checkBox1.TabIndex = 2;
			this.checkBox1.Text = "Admin";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.PaleTurquoise;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 24;
			this.listBox1.Location = new System.Drawing.Point(416, 3);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(201, 316);
			this.listBox1.TabIndex = 5;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.checkedListBox1);
			this.panel2.Location = new System.Drawing.Point(210, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 316);
			this.panel2.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 137);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 33);
			this.button2.TabIndex = 4;
			this.button2.Text = "Submit";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Select position";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
            "Loader",
            "Clerk",
            "Manager"});
			this.checkedListBox1.Location = new System.Drawing.Point(3, 33);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(132, 100);
			this.checkedListBox1.TabIndex = 2;
			// 
			// personalizationPanel
			// 
			this.personalizationPanel.BackColor = System.Drawing.Color.Transparent;
			this.personalizationPanel.Controls.Add(this.numericUpDown1);
			this.personalizationPanel.Controls.Add(this.label5);
			this.personalizationPanel.Controls.Add(this.trackBar1);
			this.personalizationPanel.Controls.Add(this.label4);
			this.personalizationPanel.Controls.Add(this.progressBar1);
			this.personalizationPanel.Controls.Add(this.button3);
			this.personalizationPanel.Controls.Add(this.label3);
			this.personalizationPanel.Controls.Add(this.comboBox1);
			this.personalizationPanel.Location = new System.Drawing.Point(6, 27);
			this.personalizationPanel.Name = "personalizationPanel";
			this.personalizationPanel.Size = new System.Drawing.Size(499, 327);
			this.personalizationPanel.TabIndex = 6;
			this.personalizationPanel.Visible = false;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.numericUpDown1.Enabled = false;
			this.numericUpDown1.Location = new System.Drawing.Point(136, 204);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(47, 25);
			this.numericUpDown1.TabIndex = 16;
			this.numericUpDown1.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 284);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 24);
			this.label5.TabIndex = 15;
			this.label5.Text = "Download limit";
			this.label5.Visible = false;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 236);
			this.trackBar1.Maximum = 1000;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(403, 45);
			this.trackBar1.TabIndex = 7;
			this.trackBar1.Value = 1000;
			this.trackBar1.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 203);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(0, 24);
			this.label4.TabIndex = 14;
			this.label4.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(12, 168);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(197, 23);
			this.progressBar1.TabIndex = 13;
			this.progressBar1.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(12, 73);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(197, 89);
			this.button3.TabIndex = 12;
			this.button3.Text = "Choose folder to dowload to cloud";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Visible = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(148, 24);
			this.label3.TabIndex = 11;
			this.label3.Text = "Choose account";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(197, 32);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Aquamarine;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creationToolStripMenuItem,
            this.personalizationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(3, 3);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(903, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// creationToolStripMenuItem
			// 
			this.creationToolStripMenuItem.Name = "creationToolStripMenuItem";
			this.creationToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.creationToolStripMenuItem.Text = "Creation";
			this.creationToolStripMenuItem.Click += new System.EventHandler(this.creationToolStripMenuItem_Click);
			// 
			// personalizationToolStripMenuItem
			// 
			this.personalizationToolStripMenuItem.Name = "personalizationToolStripMenuItem";
			this.personalizationToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
			this.personalizationToolStripMenuItem.Text = "Personalization";
			this.personalizationToolStripMenuItem.Click += new System.EventHandler(this.personalizationToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(4, 397);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(87, 65);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(97, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "Lombard corporated";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Location = new System.Drawing.Point(666, 429);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(119, 24);
			this.label7.TabIndex = 9;
			this.label7.Text = "session_time";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(917, 391);
			this.tabControl1.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Aquamarine;
			this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tabPage1.Controls.Add(this.creationPanel);
			this.tabPage1.Controls.Add(this.menuStrip1);
			this.tabPage1.Controls.Add(this.personalizationPanel);
			this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tabPage1.Location = new System.Drawing.Point(4, 33);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(909, 354);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Account";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Aquamarine;
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.dateTimePicker2);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.dateTimePicker1);
			this.tabPage2.ForeColor = System.Drawing.SystemColors.WindowText;
			this.tabPage2.Location = new System.Drawing.Point(4, 33);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(909, 354);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Operations";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
			this.dateTimePicker1.Checked = false;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(200, 3);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(109, 29);
			this.dateTimePicker1.TabIndex = 7;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 7);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(188, 24);
			this.label8.TabIndex = 8;
			this.label8.Text = "Find operations from:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(315, 7);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(33, 24);
			this.label9.TabIndex = 9;
			this.label9.Text = "To";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
			this.dateTimePicker2.Checked = false;
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(354, 3);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(109, 29);
			this.dateTimePicker2.TabIndex = 11;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(469, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(153, 29);
			this.button4.TabIndex = 12;
			this.button4.Text = "Find matches";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(8, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 24);
			this.label10.TabIndex = 13;
			this.label10.Text = "label10";
			this.label10.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(917, 462);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PopShop v2.0";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.creationPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.personalizationPanel.ResumeLayout(false);
			this.personalizationPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel creationPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Panel personalizationPanel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem creationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem personalizationToolStripMenuItem;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button button4;
	}
}

