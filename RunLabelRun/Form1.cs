using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunLabelRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Runer[] runer = new Runer[3];

        private void ToggleRun(int index, Label labelRuner)
        {
            if (runer[index]==null)
            {
                runer[index] = new Runer();
                runer[index].MyLabel = labelRuner;
            }
            else
            {
                runer[index] = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ToggleRun(0, label1);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ToggleRun(1, label2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ToggleRun(2, label3);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (runer[i]!=null)
                {
                    runer[i].Move();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }
    }
}
