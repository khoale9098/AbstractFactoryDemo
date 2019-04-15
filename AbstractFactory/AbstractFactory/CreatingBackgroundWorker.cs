using System;
using System.ComponentModel;
using System.Windows.Forms;
namespace AbstractFactory
{
    class CreatingBackgroundWorker
    {
        public delegate void CompleteCreatingEquipmentHandler(object sender, EventArgs e);

        public event CompleteCreatingEquipmentHandler FinishWork;

        BackgroundWorker worker;
        ProgressBar progressBar;
        Label lbl;
        int workStepTime;


        public CreatingBackgroundWorker(ProgressBar progressBar, Label lbl, int produceTime)
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(doWorkDoor);
            worker.ProgressChanged += new ProgressChangedEventHandler(progressChangedDoor);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(runWorkerCompletedDoor);

            this.lbl = lbl;
            this.progressBar = progressBar;
            this.workStepTime = produceTime / 100;
        }

        private void doWorkDoor(object sender, DoWorkEventArgs e)
        {
            int maximum = progressBar.Maximum + 10;
            for (int i = 1; i < maximum; i++)
            {
                //do something
                System.Threading.Thread.Sleep(workStepTime);

                //report progress percentage
                if (i <= 100)
                    worker.ReportProgress(i);
                else
                    worker.ReportProgress(100);
            }
        }

        private void progressChangedDoor(object sender, ProgressChangedEventArgs e)
        {
            lbl.Text = e.ProgressPercentage + " %";
            progressBar.PerformStep();
        }

        private void runWorkerCompletedDoor(object sender, RunWorkerCompletedEventArgs e)
        {
            FinishWork(this, new EventArgs());
        }

        public void run()
        {
            worker.RunWorkerAsync();
        }

        public void cancel()
        {
            worker.CancelAsync();
            worker = null;
        }

        public bool isRunning()
        {
            if (worker == null)
                return false;

            return worker.IsBusy;
        }
    }
}
