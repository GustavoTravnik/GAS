using GAS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAS
{
    public partial class Principal : Form
    {
        public static Form principalFrm;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public static String SEVEN_ZIP_FILE = Path.Combine(Application.StartupPath, "7za.exe");

        public const String NETWORK_SERVER = "http://34.199.179.34/vor/public/gas/";

        public const string SNES = "snes";
        public const string N64 = "n64";
        public const string MAME = "mame";
        public const string EPSXE = "epsxe";

        //-----------------------------------------------------

        public static String ROOM_PATH = Path.Combine(Application.StartupPath, "rom");

        public const string SNES_DIRECTORY_ROOMS = "rom/"+ SNES;
        public const string N64_DIRECTORY_ROOMS = "rom/" + N64;
        public const string MAME_DIRECTORY_ROOMS = "rom/" + MAME;
        public const string EPSXE_DIRECTORY_ROOMS = "rom/" + EPSXE;

        public static String LIST_NAME = "romlist.txt";

        //------------------------------------------------------

        public static String EMULATOR_PATH = Path.Combine(Application.StartupPath, "EMU");

        public const string SNES_DIRECTORY_EMULATOR = "emu/" + SNES;
        public const string N64_DIRECTORY__EMULATOR = "emu/" + N64;
        public const string MAME_DIRECTORY__EMULATOR = "emu/" + MAME;
        public const string EPSXE_DIRECTORY__EMULATOR = "emu/" + EPSXE;

        //-----------------------------------------------------

        private ConsoleForm consoleForm;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Principal()
        {
            principalFrm = this;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            CreateDirectoryStruct();
            flowConsoles.Left = 900;
            pnChat.Left = -900;
        }

        private void CreateDirectoryStruct()
        {
            Directory.CreateDirectory(ROOM_PATH);
            Directory.CreateDirectory(EMULATOR_PATH);
            //TODO - Read server directories of rooms and emulators to create directory tree
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imgMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void initialize_Tick(object sender, EventArgs e)
        {
            if (Opacity < 1)
            {
                Opacity += 0.02f;
            }
            else
            {
                Opacity = 1;
            }

            if (flowConsoles.Left > 3)
            {
                flowConsoles.Left -= 15;
            }
            else
            {
                flowConsoles.Left = 3;
            }

            if (pnChat.Left < 3)
            {
                pnChat.Left += 15;
            }
            else
            {
                pnChat.Left = 3;
            }

            if (flowConsoles.Left == 3 && Opacity == 1 && pnChat.Left == 3)
            {
                initialize.Enabled = false;
            }
        }

        private void txtSendMessage_Leave(object sender, EventArgs e)
        {
            txtSendMessage.Text = "Type your text here";
        }

        private void txtSendMessage_Enter(object sender, EventArgs e)
        {
            txtSendMessage.Text = "";
        }

        #region Open Forms

        private void CreateConsoleForm(String consoleName, Image consoleImage, String directory, String networkDirectory)
        {
            consoleForm?.Close();
            consoleForm = new GAS.ConsoleForm(consoleName, consoleImage, directory, networkDirectory);
            consoleForm.Location = this.Location;
            consoleForm.Show();
        }

        public void OpenSnesForm()
        {
            CreateConsoleForm("Super Nintendo", Resources.game_controller_1, SNES, NETWORK_SERVER + SNES_DIRECTORY_ROOMS);
        }

        public void OpenEpsxeForm()
        {
            CreateConsoleForm("Playstation 1", Resources.game_controller_5, EPSXE, NETWORK_SERVER + EPSXE_DIRECTORY_ROOMS);
        }

        public void OpenMAMEForm()
        {
            CreateConsoleForm("Fliperama", Resources.game_console_15, MAME, NETWORK_SERVER + MAME_DIRECTORY_ROOMS);
        }

        public void OpenN64Form()
        {
            CreateConsoleForm("Nintendo 64", Resources.game_controller, N64, NETWORK_SERVER + N64_DIRECTORY_ROOMS);
        }

        #endregion

        private void gamePlatform2_Click(object sender, EventArgs e)
        {
            OpenEpsxeForm();
        }

        private void gamePlatform1_Click(object sender, EventArgs e)
        {
            OpenSnesForm();
        }

        private void gamePlatform3_Click(object sender, EventArgs e)
        {
            OpenMAMEForm();
        }

        private void gamePlatform4_Click(object sender, EventArgs e)
        {
            OpenN64Form();
        }
    }
}
