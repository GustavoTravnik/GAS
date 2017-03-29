using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

namespace GAS
{
    public static class Utils
    {
        const String SNES_CONFIG_FILE = "zsnesw.cfg";


        public static WebClient DownloadFile(String url, String diskDestiny, Action<Object, DownloadProgressChangedEventArgs> eventProgress, Action<Object, AsyncCompletedEventArgs> eventFinish)
        {
            WebClient wc = new WebClient();
            try
            {
               // if (URLExists(url))
               // {
                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(eventProgress);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(eventFinish);
                    wc.DownloadFileAsync(new Uri(url), diskDestiny);
                    return wc;
              //  }
              //  else
              //  {
              //      throw new Exception("Sem conexao");
              //  }
            }
            catch (Exception ex)
            {
               
                try
                {
                    wc.CancelAsync();
                    if (File.Exists(diskDestiny))
                    {
                        File.Delete(diskDestiny);
                    }
                }
                catch { }
                throw new Exception("Operação Cancelada");
            }
            return null;
        }

        public static void DownloadFile(String url, String diskDestiny)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(new Uri(url), diskDestiny);
            }
            catch (Exception ex)
            {
                try
                {
                    if (File.Exists(diskDestiny))
                    {
                        File.Delete(diskDestiny);
                    }
                }
                catch { }
                throw new Exception("Erro ao Fazer Download do Arquivo: " + ex.Message);
            }
        }

        public static void ExtractFileToSameDirectory(String filename, String pathToStract, Boolean deleteAfter)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Principal.SEVEN_ZIP_FILE;
                proc.StartInfo.WorkingDirectory = pathToStract;
                proc.StartInfo.Arguments = "e \"" + filename + "\" -y";
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro Durante a Extração da Rom: " + ex.Message);
            }
        }

        public static void ConfigureSNESVersions(String directory, String romDirectory)
        {
            foreach (DirectoryInfo d in new DirectoryInfo(directory).GetDirectories())
            {
                StreamReader sr = new StreamReader(directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE);
                StreamWriter sw = new StreamWriter(directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE + ".tmp");
                while (!sr.EndOfStream)
                {
                    String line = sr.ReadLine();
                    if (line.Contains("GameDirectory"))
                    {
                        sw.WriteLine("GameDirectory = " + romDirectory.ToUpper());
                    }
                    else
                    {
                        sw.WriteLine(line);
                    }
                }
                sr.Close();
                sw.Close();

                File.Delete(directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE);
                File.Copy(directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE + ".tmp", directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE);
                File.Delete(directory + "\\" + d.Name + "\\" + SNES_CONFIG_FILE + ".tmp");

            }
        }

        static public bool URLExists(string url)
        {
            bool result = false;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Timeout = 5200; // miliseconds
            webRequest.Method = "HEAD";

            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)webRequest.GetResponse();
                result = true;
            }
            catch (WebException webException)
            {
                MessageBox.Show("URL requisitada Não Existe");
            }
            finally
            {
                if (response != null)
                {
                    response.Close();
                }
            }

            return result;
        }
    }
}
