using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        GroupBox frameModel;
        Label lblCarName;
        PictureBox picModelCar;
        CheckBox chkDoor, chkWheel, chkFrame, chkSeat, chkEngine;

        GroupBox frameAssembling;
        Label lblAssembling;
        PictureBox picAssembling;
        ProgressBar pgrAssembling;

        private List<ProgressBar> pgrs = new List<ProgressBar>();
        private List<Label> lbls = new List<Label>();

        private Car currCar = null;
        public Form1()
        {
            InitializeComponent();
            //initialize View
            initializeView();
            //initialize combobox auto types
            initializeCarTypes();
        }
        private void BtnProduce_Click(object sender, EventArgs e)
        {
            frameModel.Visible = false;
            frameCreate.Visible = true;
            frameAssembling.Visible = false;

            showSelectedEquipments();

            //show all equipment models
            showAllEquipmentModels();

            //create all equipments
            produceCar();
        }
        private void showAllEquipmentModels()
        {
            showModel(lblDoor, picDoor, pgrDoor, currCar.DoorBitmap, chkDoor.Checked);
            showModel(lblWheel, picWheel, pgrWheel, currCar.WheelBitmap, chkWheel.Checked);
            showModel(lblFrame, picFrame, pgrFrame, currCar.FrameBitmap, chkFrame.Checked);
            showModel(lblSeat, picSeat, pgrSeat, currCar.SeatBitmap, chkSeat.Checked);
            showModel(lblEngine, picEngine, pgrEngine, currCar.EngineBitmap, chkEngine.Checked);
        }
        private void showSelectedEquipments()
        {
            if (chkDoor.Checked)
            {
                lblPgrDoor.Text = "0 %";
                pgrDoor.Visible = true;
            }
            else
            {
                lblPgrDoor.Text = "Không chế tạo";
                pgrDoor.Visible = false;
            }

            if (chkWheel.Checked)
            {
                lblPgrWheel.Text = "0 %";
                pgrWheel.Visible = true;
            }
            else
            {
                lblPgrWheel.Text = "Không chế tạo";
                pgrWheel.Visible = false;
            }

            if (chkFrame.Checked)
            {
                lblPgrFrame.Text = "0 %";
                pgrFrame.Visible = true;
            }
            else
            {
                lblPgrFrame.Text = "Không chế tạo";
                pgrFrame.Visible = false;
            }

            if (chkSeat.Checked)
            {
                lblPgrSeat.Text = "0 %";
                pgrSeat.Visible = true;
            }
            else
            {
                lblPgrSeat.Text = "Không chế tạo";
                pgrSeat.Visible = false;
            }

           
            if (chkEngine.Checked)
            {
                lblPgrEngine.Text = "0 %";
                pgrEngine.Visible = true;
            }
            else
            {
                lblPgrEngine.Text = "Không chế tạo";
                pgrEngine.Visible = false;
            }
        }
        private void showModel(Label lbl, PictureBox picbox, ProgressBar pgress, Bitmap bitmap, bool isChecked)
        {
            picbox.Image = bitmap;

            if (isChecked)
            {
                lbl.Visible = true;
                pgress.Visible = true;
            }
            else
            {
                lbl.Visible = false;
                pgress.Visible = false;
            }
        }
        private void produceCar()
        {
            AbstractFactory factory;

            if (currCar is Audi)
            {
                factory = new AudiFactory(pgrs, lbls, currCar);
            }
            else if (currCar is Lamboghini)
            {
                factory = new LamboghiniFactory(pgrs, lbls, currCar);
            }
            else
                return;

            factory.FinishProduction += new AbstractFactory.CompletingProduction(finishProduceCar);

            Door door;
            Wheel wheel;
            Frame frame;
            Seat seat;
            Engine engine;

            if (chkDoor.Checked)
                door = factory.createDoor();

            if (chkWheel.Checked)
                wheel = factory.createWheel();

            if (chkSeat.Checked)
                seat = factory.createSeat();
            if (chkFrame.Checked)
                frame = factory.createFrame();
            if (chkEngine.Checked)
                engine = factory.createEngine();
        }
        private void finishProduceCar(object sender, EventArgs e)
        {
            if (checkAllEquipments())
            {
                if (MessageBox.Show("Đã chế tạo xong. Bạn có muốn lắp ráp hay không?","BÁO CÁO", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    frameCreate.Visible = false;
                    frameModel.Visible = false;
                    frameAssembling.Visible = true;
                    assemble();
                }
            }
        }
        private bool checkAllEquipments()
        {
            if (chkDoor.Checked && chkWheel.Checked && chkFrame.Checked && chkSeat.Checked && chkEngine.Checked)
                return true;

            return false;
        }

        private void assemble()
        {
            if (frameAssembling.Visible == true && currCar != null)
            {
                lblAssembling.Text = "Loading ";
                picAssembling.Image = currCar.AssemblingBitmaps[0];

                BackgroundWorker assemblingWorker = new BackgroundWorker() { WorkerReportsProgress = true };
                //assemblingWorker.DoWork += new DoWorkEventHandler(assembleCarEquipments);
                assemblingWorker.DoWork += (sender, e)
                    => assembleCarEquipments(sender, e);

                assemblingWorker.ProgressChanged += (sender, e)
                    => reportAssemblingProgress(sender, e);

                assemblingWorker.RunWorkerCompleted += (sender, e)
                    => finishAssembling(sender, e);

                assemblingWorker.RunWorkerAsync();
            }
        }

        private void assembleCarEquipments(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            for (int i = 0; i < 100; i += 3)
            {
                //do something
                System.Threading.Thread.Sleep(400);

                //report progress percentage
                worker.ReportProgress(i);
            }
        }


        private void reportAssemblingProgress(object sender, ProgressChangedEventArgs e)
        {
            lblAssembling.Text = "Loading  " + e.ProgressPercentage + " %";
            pgrAssembling.Value = e.ProgressPercentage;
            if (e.ProgressPercentage >= 67)
                picAssembling.Image = currCar.AssemblingBitmaps[2];
            else if (e.ProgressPercentage >= 33)
                picAssembling.Image = currCar.AssemblingBitmaps[1];
        }

        private void cmbCarTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            currCar = (Car)cmbCarTypes.SelectedItem;

            frameModel.Visible = true;
            frameCreate.Visible = false;
            frameAssembling.Visible = false;

            lblCarName.Text = currCar.ModelCarName;
            picModelCar.Image = currCar.ModelCarBitmap;

            chkDoor.Checked = false;
            chkWheel.Checked = false;
            chkFrame.Checked = false;
            chkSeat.Checked = false;

            chkEngine.Checked = false;
            pgrDoor.Value = 0;
            pgrWheel.Value = 0;
            pgrFrame.Value = 0;
            pgrSeat.Value = 0;
        }

        private void finishAssembling(object sender, RunWorkerCompletedEventArgs e)
        {
            lblAssembling.Text = "Finish " + currCar.ModelCarName;
            picAssembling.Image = currCar.AssemblingBitmaps[2];
            pgrAssembling.Value = 100;

        }
      
        private void initializeView()
        {
            int WIDTH_FRAME = frameCreate.Width;
            int HEIGHT_FRAME = frameCreate.Height;

            //frame show when selecting combobox
            frameModel = new GroupBox();
            frameModel.Size = new Size(WIDTH_FRAME, HEIGHT_FRAME);
            frameModel.Location = new Point(2, 65);
            //frameModel.Text = "Mẫu xe";

            //show model car name
            lblCarName = new Label();
            lblCarName.Size = new Size(200, 27);
            lblCarName.Location = new Point((WIDTH_FRAME - lblCarName.Width) / 2, 29);
            lblCarName.Text = "";
            lblCarName.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCarName.ForeColor = System.Drawing.Color.DarkGreen;
            lblCarName.TextAlign = ContentAlignment.MiddleCenter;

            //show model car image
            picModelCar = new PictureBox();
            picModelCar.Size = new Size(600, 450);
            picModelCar.Location = new Point(
                20, 60
            );
            picModelCar.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lblEquipments = new Label();
            lblEquipments.Size = new Size(WIDTH_FRAME - picModelCar.Location.X - picModelCar.Width - 60, 30);
            lblEquipments.Location = new Point(picModelCar.Location.X + picModelCar.Width + 60, picModelCar.Location.Y);
            //lblEquipments.Text = "Danh sách các bộ phận cần chế tạo";
            lblEquipments.TextAlign = ContentAlignment.MiddleCenter;

            chkDoor = new CheckBox();
            chkDoor.AutoSize = false;
            chkDoor.Size = new Size(100, 30);
            chkDoor.Location = new Point(lblEquipments.Location.X, lblEquipments.Location.Y + lblEquipments.Height);
            chkDoor.TextAlign = ContentAlignment.MiddleLeft;
            
            chkDoor.Text = "Door";

            chkWheel = new CheckBox();
            chkWheel.AutoSize = false;
            chkWheel.Size = new Size(100, 30);
            chkWheel.Location = new Point(lblEquipments.Location.X, chkDoor.Location.Y + chkDoor.Height);
            chkWheel.TextAlign = ContentAlignment.MiddleLeft;
            chkWheel.Text = "Wheel";

            chkFrame = new CheckBox();
            chkFrame.AutoSize = false;
            chkFrame.Size = new Size(100, 30);
            chkFrame.Location = new Point(lblEquipments.Location.X, chkWheel.Location.Y + chkWheel.Height);
            chkFrame.TextAlign = ContentAlignment.MiddleLeft;
            chkFrame.Text = "Frame";

            chkSeat = new CheckBox();
            chkSeat.AutoSize = false;
            chkSeat.Size = new Size(100, 30);
            chkSeat.Location = new Point(lblEquipments.Location.X, chkFrame.Location.Y + chkFrame.Height);
            chkSeat.TextAlign = ContentAlignment.MiddleLeft;
            chkSeat.Text = "Seat";

      
            chkEngine = new CheckBox();
            chkEngine.AutoSize = false;
            chkEngine.Size = new Size(100, 30);
            chkEngine.Location = new Point(lblEquipments.Location.X, chkSeat.Location.Y + chkSeat.Height);
            chkEngine.TextAlign = ContentAlignment.MiddleLeft;
            chkEngine.Text = "Engine";

            frameModel.Controls.Add(lblCarName);
            frameModel.Controls.Add(picModelCar);
            frameModel.Controls.Add(lblEquipments);
            frameModel.Controls.Add(chkDoor);
            frameModel.Controls.Add(chkWheel);
            frameModel.Controls.Add(chkFrame);
            frameModel.Controls.Add(chkSeat);

            frameModel.Controls.Add(chkEngine);
            Controls.Add(frameModel);

            //Frame show assembling progress
            frameAssembling = new GroupBox();
            frameAssembling.Size = new Size(WIDTH_FRAME, HEIGHT_FRAME);
            frameAssembling.Location = new Point(2, 65);
       

            //show assembling progress
            lblAssembling = new Label();
            lblAssembling.Size = new Size(200, 27);
            lblAssembling.Location = new Point((WIDTH_FRAME - lblCarName.Width) / 2, 29);
            lblAssembling.Text = "";
            lblAssembling.TextAlign = ContentAlignment.MiddleCenter;

            //show model car image
            picAssembling = new PictureBox();
            picAssembling.Size = new Size(560, 420);
            picAssembling.Location = new Point(
                (WIDTH_FRAME - picModelCar.Width) / 2, lblAssembling.Location.Y + lblAssembling.Height + 10
            );
            picAssembling.SizeMode = PictureBoxSizeMode.StretchImage;

            pgrAssembling = new ProgressBar();
            pgrAssembling.Size = new Size(200, 23);
            pgrAssembling.Location = new Point((WIDTH_FRAME - pgrAssembling.Width) / 2, picAssembling.Location.Y + picAssembling.Height + 10);
            pgrAssembling.Step = 1;
            pgrAssembling.Maximum = 100;

            frameAssembling.Controls.Add(lblAssembling);
            frameAssembling.Controls.Add(picAssembling);
            frameAssembling.Controls.Add(pgrAssembling);
            frameAssembling.Visible = false;
            Controls.Add(frameAssembling);

            frameCreate.Visible = false;

            pgrs.Add(pgrDoor);
            pgrs.Add(pgrWheel);
            pgrs.Add(pgrSeat);
            pgrs.Add(pgrFrame);
         
            pgrs.Add(pgrEngine);

            lbls.Add(lblPgrDoor);
            lbls.Add(lblPgrWheel);
            lbls.Add(lblPgrSeat);
            lbls.Add(lblPgrFrame);

            lbls.Add(lblPgrEngine);
        }

        private void initializeCarTypes()
        {
            BindingList<Car> carsList = new BindingList<Car>();
            Audi audi = new Audi();
            Lamboghini lambo = new Lamboghini();
           

            carsList.Add(audi);
            carsList.Add(lambo);
    

            cmbCarTypes.DataSource = carsList;
            cmbCarTypes.DisplayMember = "ModelCarName";
            cmbCarTypes.ValueMember = "ModelCarName";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
