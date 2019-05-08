using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tanks
{
    public partial class Controller : Form
    {
        private View view;

        public Controller(int Field_Size = 500, int Tank_Count = 5, int Apple_Count = 2, int Game_Speed = 1)
        {
            InitializeComponent();
            view = new View();
            Controls.Add(view);
        }
    }
}
