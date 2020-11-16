using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misty
{
    public partial class Misty : Form
    {
        public Misty()
        {
            InitializeComponent();
        }

        private Task UILogs(string new_string)
        {
            status.Text = new_string;
            status.Refresh();

            return (Task.CompletedTask);
        }

        private Task boxer(string message, string title, MessageBoxIcon type)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons, type);
            return (Task.CompletedTask);
        }

        private int count_char(string str, char c)
        {
            int total = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    total++;
            }
            return (total);
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private string crop(string message)
        {
            if (count_char(message, '\\') >= 3)
            {
                return ($"{message.Split('\\')[0]}\\{message.Split('\\')[1]}\\...\\{message.Split('\\')[count_char(message, '\\')]}");
            }

            return (message);
        }

        private int get_folder()
        {
            directory.ShowDialog();
            if (directory.SelectedPath.Length == 0)
                return (-1);
            else
                UILogs(crop(directory.SelectedPath)).Wait();

            return (0);
        }

        private string get_full_path(string path, int minimum)
        {
            string full = "";
            int slash = 0;

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '\\')
                    slash++;
                if (slash >= minimum)
                    full += path[i];
            }
            return (full);
        }

        private Task progress_bar(int percent)
        {
            int max = 424;
            int progress = (percent * max) / 100;

            bar.Size = new Size(progress, 10);
            bar.Refresh();

            return (Task.CompletedTask);
        }

        private Task compress(string output)
        {
            string[] files = Directory.GetFiles(directory.SelectedPath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine(files.Length);
            string name = null;
            int progress = 0;
            int total = count_char(directory.SelectedPath, '\\');
            Dictionary<string, byte[]> content = new Dictionary<string, byte[]>();

            for (int i = 0; i < files.Length; i++)
            {
                progress = (i * 100) / files.Length;
                name = get_full_path(files[i], total);
                UILogs($"{name}").Wait();
                progress_bar(progress).Wait();
                content.Add($"{name}", File.ReadAllBytes(files[i]));
            }

            settings.DATA_CONTENT new_content = new settings.DATA_CONTENT()
            {
                DATA = content
            };

            UILogs("Compressing").Wait();
            string json = JsonConvert.SerializeObject(new_content);
            UILogs($"Writing in {output}").Wait();
            File.WriteAllText(output, json);

            progress_bar(0).Wait();
            new_content.DATA = null;
            return (Task.CompletedTask);
        }

        private string clean_path(string path)
        {
            string new_path = "";

            for (int i = 0; i < path.Length - 1; i++)
            {
                new_path += path[i + 1];
            }
            Console.WriteLine(new_path);
            return (new_path);
        }

        private void launch_Click(object sender, EventArgs e)
        {
            string dump = "DUMP.mis";
            progress_bar(0);

            if (get_folder() == 0)
            {
                dump = $"{directory.SelectedPath.Split('\\')[count_char(directory.SelectedPath, '\\')]}.mis";
                compress(dump).Wait();
                UILogs($"Files compressed").Wait();
                boxer($"Files compressed check: {dump}", "Success", MessageBoxIcon.Information).Wait();
            } else
            {
                UILogs("Sorry but i can't compress nothing").Wait();
            }
        }

        private int get_file()
        {
            file_mist.ShowDialog();
            if (file_mist.FileName.Length == 0)
                return (-1);
            else
                UILogs(crop(file_mist.FileName)).Wait();

            return (0);
        }

        private Task generate_directory(string key)
        {
            int slashes = count_char(key, '\\');
            string dir = "";

            for (int i = 0; i < (slashes - 1); i++)
            {
                dir += $"{key.Split('\\')[i + 1]}\\";
                Console.WriteLine(dir);

                if (Directory.Exists(dir))
                {
                    UILogs($"Directory found :: {dir}");
                } else
                {
                    UILogs($"Creating directory :: {dir}");
                    Directory.CreateDirectory(dir);
                    UILogs($"Directory created :: {dir}");
                }
            }

            return (Task.CompletedTask);
        }

        private Task decompress()
        {
            string mist = File.ReadAllText(file_mist.FileName);
            int progress = 0;
            settings.DATA_CONTENT content = JsonConvert.DeserializeObject<settings.DATA_CONTENT>(mist);
            var keys = content.DATA.Keys.ToArray();
            var values = content.DATA.Values.ToArray();
            int total = keys.Length;

            for (int i = 0; i < keys.Length; i++)
            {
                progress = (i * 100) / keys.Length;
                progress_bar(progress).Wait();
                generate_directory(keys[i]).Wait();

                if (File.Exists(keys[i]) == false)
                {
                    UILogs($"Extracting file :: {keys[i]}").Wait();
                    File.WriteAllBytes(clean_path(keys[i]), values[i]);
                    UILogs($"File extracted :: {keys[i]}").Wait();
                } else
                {
                    UILogs($"File already present :: {keys[i]}").Wait();
                }
            }
            progress_bar(0).Wait();
            UILogs("Files extracted").Wait();

            return (Task.CompletedTask);
        }

        private void uncompress_Click(object sender, EventArgs e)
        {
            progress_bar(0);
            if (get_file() == 0)
            {
                UILogs($"Uncompressing {file_mist.FileName}").Wait();
                decompress().Wait();
                boxer("Files extracted", "Success", MessageBoxIcon.Information).Wait();
            } else
            {
                UILogs("Sorry but i can't uncompress nothing").Wait();
            }
        }

        private void reduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
