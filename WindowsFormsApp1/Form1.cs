using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //view의 details -> 원소 목록이 화면에 출력
            resultListView.View = View.Details;
            resultListView.Columns.Add("record", 240);
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(variable1.Text) + Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + "+" + variable2.Text + "=" + result);
                resultListView.Items.Add(item);
            }
             catch (Exception)
            {
                resultLabel.Text = "Input Error";
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(variable1.Text) - Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + "+" + variable2.Text + "=" + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "Input Error";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(variable1.Text) * Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + "+" + variable2.Text + "=" + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "Input Error";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            try
            {
                int result = Convert.ToInt32(variable1.Text) / Convert.ToInt32(variable2.Text);
                resultLabel.Text = Convert.ToString(result);
                ListViewItem item = new ListViewItem(variable1.Text + "+" + variable2.Text + "=" + result);
                resultListView.Items.Add(item);
            }
            catch (Exception)
            {
                resultLabel.Text = "Input Error";
            }
        }
    }
}
