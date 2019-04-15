using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void initializeView()
        {
            int WIDTH_FRAME = frameCreate.Width;
            int HEIGHT_FRAME = frameCreate.Height;

            //frame show when selecting combobox
            frameModel = new GroupBox();
            frameModel.Size = new Size(WIDTH_FRAME, HEIGHT_FRAME);
            frameModel.Location = new Point(2, 65);
            frameModel.Text = "Mẫu xe";

            //show model car name
            lblCarName = new Label();
            lblCarName.Size = new Size(200, 27);
            lblCarName.Location = new Point((WIDTH_FRAME - lblCarName.Width) / 2, 29);
            lblCarName.Text = "";
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
            lblEquipments.Text = "Danh sách các bộ phận cần chế tạo";
            lblEquipments.TextAlign = ContentAlignment.MiddleCenter;

            chkDoor = new CheckBox();
            chkDoor.AutoSize = false;
            chkDoor.Size = new Size(100, 30);
            chkDoor.Location = new Point(lblEquipments.Location.X, lblEquipments.Location.Y + lblEquipments.Height);
            chkDoor.TextAlign = ContentAlignment.MiddleLeft;
            chkDoor.Text = "Cửa xe";

            chkWheel = new CheckBox();
            chkWheel.AutoSize = false;
            chkWheel.Size = new Size(100, 30);
            chkWheel.Location = new Point(lblEquipments.Location.X, chkDoor.Location.Y + chkDoor.Height);
            chkWheel.TextAlign = ContentAlignment.MiddleLeft;
            chkWheel.Text = "Bánh xe";

            chkFrame = new CheckBox();
            chkFrame.AutoSize = false;
            chkFrame.Size = new Size(100, 30);
            chkFrame.Location = new Point(lblEquipments.Location.X, chkWheel.Location.Y + chkWheel.Height);
            chkFrame.TextAlign = ContentAlignment.MiddleLeft;
            chkFrame.Text = "Khung xe";

            chkSeat = new CheckBox();
            chkSeat.AutoSize = false;
            chkSeat.Size = new Size(100, 30);
            chkSeat.Location = new Point(lblEquipments.Location.X, chkFrame.Location.Y + chkFrame.Height);
            chkSeat.TextAlign = ContentAlignment.MiddleLeft;
            chkSeat.Text = "Ghế";

            //chkControlSystem = new CheckBox();
            //chkControlSystem.AutoSize = false;
            //chkControlSystem.Size = new Size(100, 30);
            //chkControlSystem.Location = new Point(lblEquipments.Location.X, chkSeat.Location.Y + chkSeat.Height);
            //chkControlSystem.TextAlign = ContentAlignment.MiddleLeft;
            //chkControlSystem.Text = "Hệ thống điều khiển";

            chkEngine = new CheckBox();
            chkEngine.AutoSize = false;
            chkEngine.Size = new Size(100, 30);
            //chkEngine.Location = new Point(lblEquipments.Location.X, chkControlSystem.Location.Y + chkControlSystem.Height);
            chkEngine.TextAlign = ContentAlignment.MiddleLeft;
            chkEngine.Text = "Động cơ";

            frameModel.Controls.Add(lblCarName);
            frameModel.Controls.Add(picModelCar);
            frameModel.Controls.Add(lblEquipments);
            frameModel.Controls.Add(chkDoor);
            frameModel.Controls.Add(chkWheel);
            frameModel.Controls.Add(chkFrame);
            frameModel.Controls.Add(chkSeat);
            //frameModel.Controls.Add(chkControlSystem);
            frameModel.Controls.Add(chkEngine);
            Controls.Add(frameModel);

            //Frame show assembling progress
            frameAssembling = new GroupBox();
            frameAssembling.Size = new Size(WIDTH_FRAME, HEIGHT_FRAME);
            frameAssembling.Location = new Point(2, 65);
            frameAssembling.Text = "Lắp ráp";

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
            //pgrs.Add(pgrControlSystem);
            pgrs.Add(pgrEngine);

            lbls.Add(lblPgrDoor);
            lbls.Add(lblPgrWheel);
            lbls.Add(lblPgrSeat);
            lbls.Add(lblPgrFrame);
            //lbls.Add(lblPgrControlSystem);
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
