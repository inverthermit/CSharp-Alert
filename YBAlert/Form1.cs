using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YBAlert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        public int i = 0;
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i % 2 == 0)
            {
                this.BackColor = Color.Red;
                label1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                label1.ForeColor = Color.Black;
            }
            i++;
        }
    }
}
