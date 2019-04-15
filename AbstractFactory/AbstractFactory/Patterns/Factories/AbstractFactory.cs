using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public abstract class AbstractFactory
    {
        protected enum WORKER_CODE { DOOR, WHEEL, SEAT, FRAME, ENGINE }

        protected bool completedDoor, completedWheel, completedSeat, completedFrame, completedEngine;
        public delegate void CompletingProduction(object sender, EventArgs e);
        public CompletingProduction FinishProduction;

        protected List<ProgressBar> pgrs;
        protected List<Label> lbls;
        protected Car car;

        public AbstractFactory(List<ProgressBar> pgrs, List<Label> lbls, Car car)
        {
            this.pgrs = pgrs;
            this.lbls = lbls;
            this.car = car;
        }

        public abstract Door createDoor();

        public abstract Wheel createWheel();

        public abstract Seat createSeat();

        public abstract Frame createFrame();

        public abstract Engine createEngine();

        public abstract bool isProducting();

        public abstract void cancelProduction();
    }
}
