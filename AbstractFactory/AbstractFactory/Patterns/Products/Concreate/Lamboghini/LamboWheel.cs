using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    class LamboWheel: Wheel
    {
        public LamboWheel()
        {
            Image = Properties.Resources.Lambowheel;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
