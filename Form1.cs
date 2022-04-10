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
			string name;
			string password;
			bool isAdmin;
			string position;
			//string path;

			public Account(string Name, string Password, bool IsAdmin, string Position, string Path = "") 
			{
				name = Name;
				password = Password;
				isAdmin = IsAdmin;
				position = Position;
			}

			/*public void SetPicture(string Path)
			{
				this.path = Path;
			}*/
			public string GetName() 
			{
				return this.name;
			}
			public string GetPosition()
			{
				return this.position;
			}
		}

		List<Account> accounts = new List<Account>();
		int timer = 0;

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
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string position;

			foreach (var account in accounts)
				if (textBox1.Text == account.GetName())
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
			comboBox1.Items.Add(newAccount.GetName());
		}

		private void button2_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			foreach (string item in checkedListBox1.CheckedItems)
			{
				if (item == "Loader")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[0].ToString() == account.GetPosition())
							listBox1.Items.Add(account.GetName());

				} 
				if (item == "Clerk")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[1].ToString() == account.GetPosition())
							listBox1.Items.Add(account.GetName());

				}
				if (item == "Manager")
				{
					foreach (var account in accounts)
						if (checkedListBox1.Items[2].ToString() == account.GetPosition())
							listBox1.Items.Add(account.GetName());

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
			label10.Text = "Matches are not found"; 
			label10.Visible = true;
		}
	}
}
