using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GAS.Components
{
    public partial class GamePlatform : UserControl
    {
        public String ConsoleName
        {
            get
            {
                return lblConsoleName.Text;
            }
            set
            {
                lblConsoleName.Text = value;
            }
        }
        
        public int ConsoleNamePositionX
        {
            get
            {
                return lblConsoleName.Left;
            }
            set
            {
                lblConsoleName.Left = value;
            }
        }

        public GamePlatform()
        {
            InitializeComponent();
        }

        private void SnesGamePlatform_MouseEnter(object sender, EventArgs e)
        {
            pnHeader.BackColor = Color.Blue;
        }

        private void SnesGamePlatform_MouseLeave(object sender, EventArgs e)
        {
            pnHeader.BackColor = Color.Gray;
        }
    }
}
