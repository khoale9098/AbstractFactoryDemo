using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{ 
    class LamboEngine:Engine
    {
        public LamboEngine()
        {
            Image = Properties.Resources.LamboEngine;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
