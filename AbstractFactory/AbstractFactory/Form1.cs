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
