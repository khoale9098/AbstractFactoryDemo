using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    class LamboDoor:Door
    {
        public LamboDoor()
        {
            Image = Properties.Resources.LamboDoor;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
