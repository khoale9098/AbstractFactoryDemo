
using System.Windows.Forms;

namespace AbstractFactory
{
    class AudiDoor : Door
    {
        public AudiDoor()
        {
            Image = Properties.Resources.AudiDoor;
        }
        public override void show(PictureBox picbox)
        {
            picbox.Image = Image;
        }
    }
}
