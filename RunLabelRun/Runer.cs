using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunLabelRun
{
    class Runer
    {
        public Label MyLabel;
        public bool GoingToForward = true;

        public void Move()
        {
            if (MyLabel!=null)
            {
                if (GoingToForward)
                {
                    MyLabel.Left += 5;
                    if (MyLabel.Left>=MyLabel.Parent.Width-MyLabel.Width)
                    {
                        GoingToForward = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;
                    if (MyLabel.Left<=0)
                    {
                        GoingToForward = true;
                    }
                }
            }
        }
    }
}
