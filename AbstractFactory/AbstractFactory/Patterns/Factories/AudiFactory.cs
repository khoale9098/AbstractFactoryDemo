using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AbstractFactory
{ 
    class AudiFactory:AbstractFactory
    {
        CreatingBackgroundWorker doorWorker, wheelWorker, seatWorker,
               frameWorker, controlSystemWorker, engineWorker;

        public AudiFactory(List<ProgressBar> pgrs, List<Label> lbls, Car car) : base(pgrs, lbls, car)
        {
            doorWorker =
                new CreatingBackgroundWorker(pgrs[0], lbls[0], car.DoorProduceTime * car.DoorNumber);
            doorWorker.FinishWork += (sender, e) => completeCreating(sender, e, WORKER_CODE.DOOR);

            wheelWorker =
                new CreatingBackgroundWorker(pgrs[1], lbls[1], car.WheelProduceTime * car.WheelNumber);
            wheelWorker.FinishWork += (sender, e) => completeCreating(sender, e, WORKER_CODE.WHEEL);

            seatWorker =
                new CreatingBackgroundWorker(pgrs[2], lbls[2], car.SeatProduceTime * car.SeatNumber);

            seatWorker.FinishWork += (sender, e) => completeCreating(sender, e, WORKER_CODE.SEAT);

            frameWorker =
               new CreatingBackgroundWorker(pgrs[3], lbls[3], car.FrameProduceTime);

            frameWorker.FinishWork += (sender, e) => completeCreating(sender, e, WORKER_CODE.FRAME);

            engineWorker =
                new CreatingBackgroundWorker(pgrs[4], lbls[4], car.EngineProduceTime);

            engineWorker.FinishWork += (sender, e)
                => completeCreating(sender, e, WORKER_CODE.ENGINE);

            for (int i = 0; i < pgrs.Count; i++)
            {
                pgrs[i].Value = 0;
            }
        }


        public override Door createDoor()
        {
            doorWorker.run();

            return new AudiDoor();
        }

        public override Wheel createWheel()
        {
            wheelWorker.run();

            return new AudiWheel();
        }

        public override Seat createSeat()
        {
            seatWorker.run();

            return new AudiSeat();
        }

        public override Frame createFrame()
        {
            frameWorker.run();

            return new AudiFrame();
        }

        
        public override Engine createEngine()
        {
            engineWorker.run();

            return new AudiEngine();
        }

        private void completeCreating(object sender, EventArgs e, WORKER_CODE workerCode)
        {
            switch (workerCode)
            {
                case WORKER_CODE.DOOR:
                    completedDoor = true;
                    break;

                case WORKER_CODE.WHEEL:
                    completedWheel = true;
                    break;

                case WORKER_CODE.SEAT:
                    completedSeat = true;
                    break;

                case WORKER_CODE.FRAME:
                    completedFrame = true;
                    break;

               
                case WORKER_CODE.ENGINE:
                    completedEngine = true;
                    break;

                default:
                    return;
            }


            if (completedDoor && completedWheel && completedSeat && completedFrame && completedEngine)
            {
                for (int i = 0; i < pgrs.Count; i++)
                {
                    pgrs[i].Value = 100;
                }

                System.Threading.Thread.Sleep(1000);
                
                FinishProduction(this, new EventArgs());
            }
        }

        public override bool isProducting()
        {
            if (doorWorker == null && wheelWorker == null && seatWorker == null && frameWorker == null
                && controlSystemWorker == null && engineWorker == null)
                return false;

            if (doorWorker.isRunning() || wheelWorker.isRunning() || seatWorker.isRunning() || frameWorker.isRunning() || engineWorker.isRunning())
                return true;

            return false;
        }

        public override void cancelProduction()
        {
            if (doorWorker.isRunning())
                doorWorker.cancel();

            if (wheelWorker.isRunning())
                wheelWorker.cancel();

            if (seatWorker.isRunning())
                seatWorker.cancel();

            if (frameWorker.isRunning())
                frameWorker.cancel();

    
            if (engineWorker.isRunning())
                engineWorker.cancel();
        }
    }
    }
}
