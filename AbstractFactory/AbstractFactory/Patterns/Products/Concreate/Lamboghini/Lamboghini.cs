using System.Drawing;
namespace AbstractFactory
{
    class Lamboghini:Car

    {
        public Lamboghini()
        {
            ModelCarName = "Lamboghini";
            ModelCarBitmap = Properties.Resources.lamborghini;

            DoorNumber = 2;
            WheelNumber = 4;
            SeatNumber = 2;

            DoorProduceTime = 1000;
            WheelProduceTime = 1000;
            SeatProduceTime = 1000;
            FrameProduceTime = 5000;
            EngineProduceTime = 4000;

            DoorBitmap = Properties.Resources.LamboDoor;
            WheelBitmap = Properties.Resources.Lambowheel;
            SeatBitmap = Properties.Resources.LamboSeat;
            FrameBitmap = Properties.Resources.LamboFrame;
            EngineBitmap = Properties.Resources.LamboEngine;

            AssemblingBitmaps = new System.Collections.Generic.List<Bitmap>
            {
                Properties.Resources.assemble_lamboghini1,
                Properties.Resources.assemble_lamboghini2,
                Properties.Resources.assemble_lamboghini3,
            };
        }
    }
}
