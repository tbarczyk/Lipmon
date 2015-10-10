using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lipmon
{
    public partial class MainWindow : Form
    {
        public LeapListener leapListener;
        private RobotController robotController;
        private CoordinatesVisualizer coordinatesVisualizer;
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            var device = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
            leapListener = new LeapListener();

            robotController = new RobotController(leapListener, device != null ? (Device)device.Tag : Device.Platform);
            coordinatesVisualizer = new CoordinatesVisualizer(leapListener, coordinatesTextBox, this);
            ConnectedLabel.Visible = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            try
            {
                robotController.Dispose();
                coordinatesVisualizer.Dispose();
                leapListener.Dispose();
                ConnectedLabel.Visible = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stop error");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Stop_Click(this.Stop, EventArgs.Empty);
            Application.Exit();
        }

    }
}
