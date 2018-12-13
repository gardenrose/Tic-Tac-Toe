using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic
{
	public partial class Form1 : Form
	{
		bool x = true;
		public Form1()
		{
			InitializeComponent();
		}

		private void on_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (x == true)
			{
				button.Text = "X";
			}
			else
			{
				button.Text = "O";
			}
			x = !(x);
			button.Enabled = false;
			checkWinner();
		}

		private void checkWinner()
		{
			bool winner = false;

			if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Enabled == false))
			{
				winner = true;
			}
			else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Enabled == false))
			{
				winner = true;
			}
			else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Enabled == false))
			{
				winner = true;
			}
			else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button1.Enabled == false))
			{
				winner = true;
			}
			else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button2.Enabled == false))
			{
				winner = true;
			}
			else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button3.Enabled == false))
			{
				winner = true;
			}
			else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button1.Enabled == false))
			{
				winner = true;
			}
			else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Enabled == false))
			{
				winner = true;
			}

			

			if (winner == true)
			{
				button1.Enabled = false;
				button2.Enabled = false;
				button3.Enabled = false;
				button4.Enabled = false;
				button5.Enabled = false;
				button6.Enabled = false;
				button7.Enabled = false;
				button8.Enabled = false;
				button9.Enabled = false;
				if (x == true)
				{
					textBox1.Text = "O is the winner !";
				}
				else
				{
					textBox1.Text = "X is the winner !";
				}
			}
		}

		private void NewGameClick(object sender, EventArgs e)
		{
			x = true;
			
			button1.Enabled = true; button1.Text = "";
			button2.Enabled = true; button2.Text = "";
			button3.Enabled = true; button3.Text = "";
			button4.Enabled = true; button4.Text = "";
			button5.Enabled = true; button5.Text = "";
			button6.Enabled = true; button6.Text = "";
			button7.Enabled = true; button7.Text = "";
			button8.Enabled = true; button8.Text = "";
			button9.Enabled = true; button9.Text = "";
			textBox1.Text = "";
		}
	}
}
