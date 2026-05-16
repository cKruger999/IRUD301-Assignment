using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Command Pattern Client
namespace IRUD301_Assignment
{
    public partial class MainForm : Form
    {
        // 1. Core System Components
        private CorporateHQ _hq;
        private CarAssemblyLine _carLine;
        private MinibusAssemblyLine _minibusLine;

        // 2. Queue and Completion Counters
        private int _carQueueCount = 0;
        private int _minibusQueueCount = 0;
        private int _carsCompleted = 0;
        private int _minibusesCompleted = 0;

        public MainForm()
        {
            InitializeComponent();

            // Initialize the background system when the form loads
            _hq = new CorporateHQ();
            _carLine = new CarAssemblyLine(new CarPartsFactory());
            _minibusLine = new MinibusAssemblyLine(new MinibusPartsFactory());
        }

        // 3. The Order Button Click Event
        private void btnOrder_Click(object sender, EventArgs e)
        {
            // --- CAR ORDERS ---
            if (rbBlackLUX1000.Checked || rbWhiteLUX1000.Checked)
            {
                string selectedColour = rbBlackLUX1000.Checked ? "Black" : "White";

                CommandBase newCarOrder = new BuildCarCommand(_carLine, selectedColour);
                _hq.PlaceCarOrder(newCarOrder);

                // Update Counters & UI
                _carQueueCount++;
                UpdateUIThreadSafe(lblCarQueue, _carQueueCount.ToString());
            }
            // --- MINIBUS ORDERS ---
            else if (rbBlackMV500.Checked || rbWhiteMV500.Checked)
            {
                string selectedColour = rbBlackMV500.Checked ? "Black" : "White";

                CommandBase newMinibusOrder = new BuildMinibusCommand(_minibusLine, selectedColour);
                _hq.PlaceMinibusOrder(newMinibusOrder);

                // Update Counters & UI
                _minibusQueueCount++;
                UpdateUIThreadSafe(lblMinibusQueue, _minibusQueueCount.ToString());
            }
            else
            {
                MessageBox.Show("Please select an automobile to order!");
            }
        }

        // 4. Method for Teammates to call when Spraybooth finishes
        public void VehicleCompleted(string type)
        {
            if (type == "Car")
            {
                _carQueueCount--;
                _carsCompleted++;

                UpdateUIThreadSafe(lblCarQueue, _carQueueCount.ToString());
                UpdateUIThreadSafe(lblCarsCompleted, _carsCompleted.ToString());
            }
            else if (type == "Minibus")
            {
                _minibusQueueCount--;
                _minibusesCompleted++;

                UpdateUIThreadSafe(lblMinibusQueue, _minibusQueueCount.ToString());
                UpdateUIThreadSafe(lblMinibusesCompleted, _minibusesCompleted.ToString());
            }
        }

        // 5. Thread-Safe UI Update Helper
        public void UpdateUIThreadSafe(Label labelToUpdate, string text)
        {
            if (labelToUpdate.InvokeRequired)
            {
                labelToUpdate.Invoke(new Action(() => labelToUpdate.Text = text));
            }
            else
            {
                labelToUpdate.Text = text;
            }
        }
    }
}