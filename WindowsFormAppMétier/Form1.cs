using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace WindowsFormAppMétier
{
    public partial class Form1 : Form,IView
    {
        Controller c;
        public Form1()
        {
            InitializeComponent();
            this.c = new Controller();
            c.setIView(this);
        }

        private void Uppercase_Click(object sender, EventArgs e)
        {
            c.checkMajusculator(this.textBox1.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
        public void displayResponse(string response)
        {
            this.lb_result.Text = response;
        }

        public void displayError(string response)
        {
            this.lb_result.Text = response;
            this.lb_result.ForeColor = Color.Red; 

        }

        public void getString()
        {
            Show();
        }
    }
}
