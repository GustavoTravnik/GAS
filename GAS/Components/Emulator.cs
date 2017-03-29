using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace GAS.Components
{
    public partial class Emulator : UserControl
    {
        String emulatorPath;
        public Emulator(String emulatorPath, Image emulatorImage)
        {
            InitializeComponent();
            this.emulatorPath = emulatorPath;
            picEmulator.Image = emulatorImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WorkingDirectory = emulatorPath;
                proc.StartInfo.FileName = new DirectoryInfo(emulatorPath).GetFiles().Where(k => k.Extension.ToLower().Equals(".exe")).ToList()[0].FullName;
                proc.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arquivo de emulador não encontrado: " + ex.Message);
            }
        }
    }
}
