using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    class LamboSeat:Seat
    {
        public LamboSeat()
        {
            Image = Properties.Resources.LamboSeat;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
