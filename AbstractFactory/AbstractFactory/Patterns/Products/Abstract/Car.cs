using System.Drawing;
using System.Collections.Generic;


namespace AbstractFactory
{
    public abstract class Car
    {
        public string ModelCarName { get; protected set; }
        public Bitmap ModelCarBitmap { get; protected set; }

        public int DoorNumber { get; protected set; }
        public int WheelNumber { get; protected set; }
        public int SeatNumber { get; protected set; }

        public int DoorProduceTime { get; protected set; }
        public int WheelProduceTime { get; protected set; }
        public int SeatProduceTime { get; protected set; }
        public int FrameProduceTime { get; protected set; }
        public int EngineProduceTime { get; protected set; }


        public Bitmap DoorBitmap { get; protected set; }
        public Bitmap WheelBitmap { get; protected set; }
        public Bitmap SeatBitmap { get; protected set; }
        public Bitmap FrameBitmap { get; protected set; }
        public Bitmap EngineBitmap { get; protected set; }

        public List<Bitmap> AssemblingBitmaps { get; protected set; }
    }
}
