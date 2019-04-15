using System.Windows.Forms;

namespace AbstractFactory
{ 
    class AudiFrame: Frame
    {
        public AudiFrame()
        {
            Image = Properties.Resources.AudiFrame;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
