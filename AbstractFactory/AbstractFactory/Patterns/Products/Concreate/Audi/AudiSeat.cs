using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    class AudiSeat:Seat
    {
        public AudiSeat()
        {
            Image = Properties.Resources.AudiSeat;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
