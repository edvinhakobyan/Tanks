using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arg)
        {
            int[] prm = arg.Select(x => int.Parse(x)).ToArray();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Controller controller;
            switch (arg.Length)
            {
                case 1:
                    controller = new Controller(prm[0]);
                    break;
                case 2:
                    controller = new Controller(prm[0], prm[1]);
                    break;
                case 3:
                    controller = new Controller(prm[0], prm[1], prm[2]);
                    break;
                case 4:
                    controller = new Controller(prm[0], prm[1], prm[2], prm[3]);
                    break;
                default:
                    controller = new Controller();
                    break;
            }
            Application.Run(controller);
        }
    }
}
