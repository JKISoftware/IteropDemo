using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JKIRobot; //Open namespace for our LV interop

namespace NET_RobotController
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Robot_Interface.
            Robot_Interface handle;
          
            Robot_Interface.Init(out handle); // Initialize the LabVIEW application / pass out the handle
           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Application.Run(new Form1(handle)); // Start the controller app UI

            Robot_Interface.Shutdown(handle); // Shutdown the LabVIEW application
        }
    }
}
