using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKIRobot;

namespace NET_RobotController
{
    public partial class Form1 : Form
    {
        private Robot_Interface ohandle; // Declare a handle to the LabVIEW app as private data

        public Form1(Robot_Interface handle) // Form constructor (called on creation)
        {
            Robot__Position rposition;  // Create variable of data type robot position for future use
            ohandle = handle;           // Cache the LabVIEW app handle in private data
            InitializeComponent();      
            Robot_Interface.GetRobotPosition(handle, out rposition); // Get the current position from the app
            
            // Initialize all the controls on the UI
            GrabberCtrl.Value = (int)rposition.claw*100;
            ShoulderCtrl.Value = (int)(((rposition.jointA + 90.0) % 360) / 1.8);
            ElbowCtrl.Value = (int)(((rposition.jointB + 90.0) % 360) / 1.8);
            WristCtrl.Value = (int)(((rposition.jointC + 90.0) % 360) / 1.8);
        }

        private void Grabber_Scroll(object sender, EventArgs e)
        {
            // Event handler for the grabber position change
            float scaled = (float)GrabberCtrl.Value / 100; // Do some scaling
            this.ActiveControl = GrabberLabel;
            Robot_Interface.SetGrabberPosition(ohandle, scaled); // Set the position
        }
        private void ShoulderCtrl_Scroll(object sender, EventArgs e)
        {
            // Event handler for the shoulder control
            double position = ((ShoulderCtrl.Value * 1.8) + 270) % 360; // Do some scaling
            this.ActiveControl = GrabberLabel;
            Robot_Interface.SetJointRotation(ohandle, JointType.A_Shoulder, position); // Set the position
            
        }
        private void WristCtrl_Scroll(object sender, EventArgs e)
        {
            // Event handler for the wrist control 
            double position = ((WristCtrl.Value * 1.8) + 270) % 360; // Do some scaling
            this.ActiveControl = GrabberLabel;
            Robot_Interface.SetJointRotation(ohandle, JointType.C_Wrist, position); // Set the position 
        }

        private void ElbowCtrl_Scroll(object sender, EventArgs e)
        {
            // Event handler for the elbow control 
            double position = ((ElbowCtrl.Value * 1.8) + 270) % 360; // Do some scaling 
            this.ActiveControl = GrabberLabel;
            Robot_Interface.SetJointRotation(ohandle, JointType.B_Elbow, position); // Set the position 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
