using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        private ArrayList newArray = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            foreach (string letters in newArray)
            {
                lblMessage.Text += letters + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newArray.Add("I");
            newArray.Add("Love");
            newArray.Add("Programming");
            newArray.Add("So");
            newArray.Add("Much");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            newArray.Reverse();
            //foreach (string letters in newArray)
            //{
            //    lblMessage.Text += letters + " ";
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            newArray.Insert(1, txtSecondPos.Text);
            txtSecondPos.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            newArray.RemoveAt(1);
        }
    }
}
