using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace GAS
{
    public partial class ConsoleForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        String consoleName;
        String cloudLocation;

        Thread syncThread;

        public ConsoleForm(String consoleText, Image consoleImage, String directoryRooms, String cloudLocation)
        {
            InitializeComponent();
            pnInitRoom.Location = new Point(900, 600);
            pnOptions.Top = 600;
            flowRooms.Top = -600;
            this.consoleName = directoryRooms;
            picConsole.Image = consoleImage;
            lblConsole.Text = consoleText;
            this.cloudLocation = cloudLocation;
            FillFlowRomList();
            FillFlowEmulatorList();
            ConfigureEmulators();
        }

        private void FillFlowRomList()
        {
            flowRooms.Controls.Clear();
            Directory.CreateDirectory(Path.Combine(Principal.ROOM_PATH, consoleName));
            String serverListPath = cloudLocation + "/romlist.txt";
            String localListPath = Path.Combine(Principal.ROOM_PATH, consoleName, "romlist.txt");
            Utils.DownloadFile(serverListPath, localListPath);

            String[] serverList = File.ReadAllLines(localListPath);

            foreach (String s in serverList)
            {
                flowRooms.Controls.Add(new Components.Room(Path.Combine(Principal.ROOM_PATH, consoleName, s), cloudLocation + "/" + s, s));
            }
        }

        private void FillFlowEmulatorList()
        {
            flowEmulators.Controls.Clear();
            Directory.CreateDirectory(Path.Combine(Principal.EMULATOR_PATH, consoleName));
            foreach(DirectoryInfo di in new DirectoryInfo(Path.Combine(Principal.EMULATOR_PATH, consoleName)).GetDirectories())
            {
                String emulatorPath = di.FullName;
                Image emulatorImage = Image.FromFile(di.FullName + ".png");
                Components.Emulator emu = new Components.Emulator(emulatorPath, emulatorImage);
                flowEmulators.Controls.Add(emu);
            }
        }

        private void ConfigureEmulators()
        {
            if (consoleName.Equals(Principal.SNES))
            {
                Utils.ConfigureSNESVersions(Path.Combine(Principal.EMULATOR_PATH, Principal.SNES), Path.Combine(Principal.ROOM_PATH, consoleName));
            }
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

            if (flowRooms.Top < 3)
            {
                flowRooms.Top += 10;
            }
            else
            {
                flowRooms.Top = 3;
            }

            if (pnOptions.Top > 489)
            {
                pnOptions.Top-=2;
            }
            else
            {
                pnOptions.Top = 489;
            }

            if (pnInitRoom.Left > 608)
            {
                pnInitRoom.Left -= 10;
            }
            else
            {
                pnInitRoom.Left = 608;
            }

            if (pnInitRoom.Top > 3)
            {
                pnInitRoom.Top -= 10;
            }
            else
            {
                pnInitRoom.Top = 3;
            }

            if (Opacity == 1 && flowRooms.Top == 3 && pnOptions.Top == 489 && pnInitRoom.Left == 608 && pnInitRoom.Top == 3)
            {
                initialize.Enabled = false;
            }

            //608; 3


        }

        private void btnSyncronize_Click(object sender, EventArgs e)
        {
            btnSyncronize.Enabled = false;
            syncThread = new Thread(StartSync);
            syncThread.IsBackground = true;
            syncThread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Components.Room> rooms = new List<Components.Room>();
            foreach (Components.Room room in flowRooms.Controls)
            {
                rooms.Add(room);
            }
            btnSyncronize.Enabled = true;

            syncThread?.Abort();
            syncThread = null;

            rooms.ForEach(k => k.StopDownload());
        }

        private void StartSync()
        {
            try
            {
                List<Components.Room> rooms = new List<Components.Room>();
                foreach (Components.Room room in flowRooms.Controls)
                {
                    rooms.Add(room);
                }

                rooms.ForEach(k => k.Delete());
                rooms.ForEach(k => k.Download());

                btnSyncronize.Enabled = true;
            }
            catch { }
        }
    }
}
