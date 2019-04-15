using System.Windows.Forms;

namespace AbstractFactory
{
    class AudiWheel:Wheel
    {
        public AudiWheel()
        {
            Image = Properties.Resources.AudiWheel;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
