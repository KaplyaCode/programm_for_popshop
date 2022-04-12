using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _02
{
	public partial class Form1 : Form
	{
		public class Account 
		{
			public string name { get; }
			public string password { get; }
			public bool isAdmin { get; }
			public string position { get; }

			public Account(string Name, string Password, bool IsAdmin, string Position) 
			{
				name = Name;
				password = Password;
				isAdmin = IsAdmin;
				position = Position;
			}
		}

		public class Operation
		{
			public int identifier { get;}
			public string type { get;}
			public float summ { get;}
			public string fio { get;}
			public DateTime date { get;}

			public Operation(int Identifier, string Type, float Summ, string Fio, DateTime Date)
			{
				identifier = Identifier;
				type = Type;
				summ = Summ;
				fio = Fio;
				date = Date;
			}
		}


		List<Account> accounts = new List<Account>();
		List<Operation> operations = new List<Operation>();
		int timer = 0;
		int image_index = 0;

		


		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = Image.FromFile("D:\\Programing\\C# Forms\\02\\av.gif");

			checkedListBox1.SetItemChecked(0, true);
			checkedListBox1.SetItemChecked(1, true);
			checkedListBox1.SetItemChecked(2, true);

			pictureBox2.Image = imageList1.Images[image_index];
			
			operations.Add(new Operation(1, "Ring", 250.00f, "Illya", new DateTime(2020,2,12)));
			operations.Add(new Operation(2, "Engagement_ring", 350.00f, "Gregory", new DateTime(2020, 6, 14)));
			operations.Add(new Operation(3, "Signet_ring", 200.00f, "Albert", new DateTime(2021, 6, 30)));
			operations.Add(new Operation(4, "Earrings", 150.00f, "Nikolai", new DateTime(2022, 4, 21)));
			operations.Add(new Operation(5, "Hoop_earrings", 100.00f, "Jason", new DateTime(2022, 3, 12)));
			operations.Add(new Operation(6, "Necklace", 300.00f, "Tifany", new DateTime(2021, 8, 28)));
			operations.Add(new Operation(7, "Pearl_necklace", 400.00f, "Olga", new DateTime(2020, 6, 12)));
			operations.Add(new Operation(8, "Bracelet", 50.00f, "Margarita", new DateTime(2022, 12, 25)));
			operations.Add(new Operation(9, "Chain", 200.00f, "Vadim", new DateTime(2020, 3, 19)));
			operations.Add(new Operation(10, "Beads", 150.00f, "Dmytro", new DateTime(2021, 6, 17)));
			operations.Add(new Operation(11, "Cuff_links", 150.00f, "Igor", new DateTime(2020, 1, 7)));
			operations.Add(new Operation(12, "Locket", 300.00f, "Oleg", new DateTime(2021, 9, 1)));
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string position;

			foreach (var account in accounts)
				if (textBox1.Text == account.name)
				{
					MessageBox.Show("This name is engaged!");
					return;
				}

			if (radioButton1.Checked)
				position = radioButton1.Text;
			else if (radioButton2.Checked)
				position = radioButton2.Text;
			else 
				position = radioButton3.Text;

			Account newAccount = new Account(textBox1.Text, textBox2.Text, checkBox1.Checked, position);


			accounts.Add(newAccount);

			listBox1.Items.Add(textBox1.Text);
			comboBox1.Items.Add(newAccount.name);

			treeView1.Nodes.Add(textBox1.Text);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			foreach (string item in checkedListBox1.CheckedItems)
			{
				if (item == "Loader")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[0].ToString() == account.position)
							listBox1.Items.Add(account.name);

				} 
				if (item == "Clerk")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[1].ToString() == account.position)
							listBox1.Items.Add(account.name);

				}
				if (item == "Manager")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[2].ToString() == account.position)
							listBox1.Items.Add(account.name);

				}
			}
		}

		async private void button3_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
				int qt = files.Length;
				label4.Visible = true;
				progressBar1.Visible = true;
				trackBar1.Visible = true;
				label5.Visible = true;
				numericUpDown1.Visible = true;
				progressBar1.Maximum = qt;
				progressBar1.Value = 0;

				if (qt == 0)
				{
					MessageBox.Show("Files not found!");
					return;
				}

				label4.Text = "Count of files:";

				while (qt > 0)
				{
					numericUpDown1.Value = qt -1;
					progressBar1.Value++;
					qt--;

					foreach (TreeNode node in treeView1.Nodes)
					{
						if (comboBox1.SelectedItem.ToString() == node.Text)
						{
							node.Nodes.Add(files[qt].Split('\\').Last());
						}

					}

					await Task.Delay(trackBar1.Value);
				}

				MessageBox.Show("All files downloaded to cloud");
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			button3.Visible = true;
		}

		private void creationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			personalizationPanel.Visible = false;
			creationPanel.Visible = true;
		}

		private void personalizationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			creationPanel.Visible = false;
			personalizationPanel.Visible = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			timer++;
			label7.Text = $"Session time: {(timer / 3600)%60}:{(timer / 60)%60}:{timer%60}         ";

		}

		private void button4_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			foreach (Operation operation in operations)
			{
				if (checkBox2.Checked)
				{
					if (operation.date > dateTimePicker1.Value && operation.date < dateTimePicker2.Value && imageList1.Images.Keys[image_index] == operation.type)
					{
						dataGridView1.Rows.Add(operation.identifier, operation.type, operation.summ, operation.fio, operation.date);
					}
				}
				else if (operation.date > dateTimePicker1.Value && operation.date < dateTimePicker2.Value)
				{
					dataGridView1.Rows.Add(operation.identifier, operation.type, operation.summ, operation.fio, operation.date);
				}
			}

			if (dataGridView1.Rows.Count == 0)
				label10.Visible = true;
			else
				label10.Visible = false;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (image_index <= 0)
				image_index = imageList1.Images.Count - 1;
			pictureBox2.Image = imageList1.Images[--image_index];
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (image_index >= imageList1.Images.Count - 1)
				image_index = 0;
			pictureBox2.Image = imageList1.Images[++image_index];
		}

		public void GrayTheme(Control.ControlCollection controls)
		{
			foreach (Control elem in controls)
			{
				if (elem.HasChildren)
					GrayTheme(elem.Controls);

				if (elem.BackColor.Equals(Color.DodgerBlue))
					elem.BackColor = Color.FromArgb(48, 48, 48);

				if (elem.BackColor.Equals(Color.Aquamarine))
					elem.BackColor = Color.FromArgb(64, 64, 64);

				if (elem.BackColor.Equals(Color.PaleTurquoise))
					elem.BackColor = Color.Gray;

				if (elem.BackColor.Equals(Color.SpringGreen))
					elem.BackColor = Color.DimGray;

				elem.ForeColor = Color.FromArgb(200,200,200);
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			GrayTheme(this.Controls);

			this.BackColor = Color.FromArgb(48, 48, 48);
			dataGridView1.ForeColor = Color.Black;
		}

		public void BlueTheme(Control.ControlCollection controls)
		{
			foreach (Control elem in controls)
			{
				if (elem.HasChildren)
					BlueTheme(elem.Controls);

				if (elem.BackColor.Equals(Color.FromArgb(48, 48, 48)))
					elem.BackColor = Color.DodgerBlue;

				if (elem.BackColor.Equals(Color.FromArgb(64, 64, 64)))
					elem.BackColor = Color.Aquamarine;

				if (elem.BackColor.Equals(Color.Gray))
					elem.BackColor = Color.PaleTurquoise;

				if (elem.BackColor.Equals(Color.DimGray))
					elem.BackColor = Color.SpringGreen;

				elem.ForeColor = Color.Black;
			}
		}

		private void toolStripButton2_Click(object sender, EventArgs e)
		{
			this.BackColor = Color.DodgerBlue;

			BlueTheme(this.Controls);
		}

	}
}
