using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GAS.Properties;
using System.IO;
using System.Threading;
using System.Net;

namespace GAS.Components
{
    public partial class Room : UserControl
    {
        String localFullPath = "";
        String cloudFullPath = "";
        WebClient downloadClient;

        public string[] knowExtensions = new string[]
        {
            "smc",
            "iso",
            "n64",
            "bin",
            "sfc"
        };

        public Room()
        {
            InitializeComponent();
        }

        public Room(String localFullPath, String cloudFullPath, String gameName)
        {
            InitializeComponent();
            try
            {
                this.localFullPath = localFullPath;
                this.cloudFullPath = cloudFullPath;
                lblGameName.Text = gameName.Substring(0, gameName.IndexOf('.')).Replace('_', ' ');
                checkSync.Checked = ExistsOnDisk();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Criar Rom: " + ex.Message);
            }
        }

        private void checkSync_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSync.Checked)
            {
                checkSync.BackgroundImage = Resources.sign_check;
            }
            else
            {
                checkSync.BackgroundImage = Resources.sign_error;
            }
        }

        public void Download()
        {
            if (checkSync.Checked && !ExistsOnDisk())
            {
                try
                {
                    progress.Width = 0;
                    checkSync.Enabled = false;
                    downloadClient = Utils.DownloadFile(cloudFullPath, localFullPath, OnDownloadProgress, OnDownloadFinish);
                    if (!File.Exists(localFullPath))
                    {
                        throw new Exception("Sem conexao");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro ao Efetuar Download: " + ex.Message);
                    checkSync.Enabled = true;
                    progress.Width = 0;
                }
            }
            Refresh();
        }

        public void OnDownloadProgress(Object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                progress.Width = Width / 100 * e.ProgressPercentage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Durante o Download da Rom: " + ex.Message);
            }
        }

        public void OnDownloadFinish(Object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                Thread edThread = new Thread(OnDownloadFinish);
                edThread.IsBackground = true;
                edThread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Na Conclusão do Download: " + ex.Message);
            }
            Refresh();
        }

        public void OnDownloadFinish()
        {
            Utils.ExtractFileToSameDirectory(localFullPath, new FileInfo(localFullPath).DirectoryName, true);
            checkSync.Enabled = true;
            progress.Width = 0;
            checkSync.Checked = true;
            Invoke(new MethodInvoker(Refresh));
        }

        public void Delete()
        {
            if (!checkSync.Checked && ExistsOnDisk())
            {
                try
                {
                    File.Delete(localFullPath);
                    foreach (String s in knowExtensions)
                    {
                        String fileName = localFullPath.Substring(0, localFullPath.LastIndexOf('.')) + "." + s;
                        if (File.Exists(fileName))
                        {
                            File.Delete(fileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Deletar Arquivo: " + ex.Message);
                }
            }
            Refresh();
        }

        public void StopDownload()
        {
            try
            {
                downloadClient?.CancelAsync();
                downloadClient = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Cancelar o Download: " + ex.Message);
            }
            Refresh();
        }

        public bool ExistsOnDisk()
        {
            try
            {
                foreach (String s in knowExtensions)
                {
                    String fileName = localFullPath.Substring(0, localFullPath.LastIndexOf('.')) + "." + s;
                    if (File.Exists(fileName))
                    {
                        if (new FileInfo(fileName).Length > 100)
                            return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Validar Arquivo em Disco: " + ex.Message);
            }
            return false;
        }

        public override void Refresh()
        {
            base.Refresh();
            pictureBox1.BackColor = ExistsOnDisk() ? Color.Green : Color.Red;
        }
    }
}