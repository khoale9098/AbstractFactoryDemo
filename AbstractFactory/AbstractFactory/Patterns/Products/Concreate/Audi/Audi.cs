using System.Drawing;

namespace AbstractFactory
{
    class Audi:Car
    {
        public Audi()
        {
            ModelCarName = "Audi";
            ModelCarBitmap = Properties.Resources.audi;
            DoorNumber = 2;
            WheelNumber = 4;
            SeatNumber = 2;
            //
            DoorProduceTime = 1000;
            WheelProduceTime = 1000;
            SeatProduceTime = 1000;
            FrameProduceTime = 6500;
            EngineProduceTime = 6000;

            DoorBitmap = Properties.Resources.AudiDoor;
            WheelBitmap = Properties.Resources.AudiWheel;
            SeatBitmap = Properties.Resources.AudiSeat;
            FrameBitmap = Properties.Resources.AudiFrame;
            EngineBitmap = Properties.Resources.AudiEngine;
            AssemblingBitmaps = new System.Collections.Generic.List<Bitmap>
            {
                Properties.Resources.assemble_audi1,
                Properties.Resources.assemble_audi2,
                Properties.Resources.assemble_audi3,

            };
        }
    }
}
