using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactory
{ 
    public abstract class Seat
    {
        public Bitmap Image { get; protected set; }
        public abstract void show(PictureBox picbox);
    }
}
