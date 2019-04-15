using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    class LamboFrame:Frame
    {
        public LamboFrame()
        {
            Image = Properties.Resources.LamboFrame;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
