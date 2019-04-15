using System.Windows.Forms;

namespace AbstractFactory
{
    class AudiEngine : Engine
    {
        public AudiEngine()
        {
            Image = Properties.Resources.AudiEngine;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
