using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VelychkoOOP_27
{
    public partial class Form1 : Form
    {
        public List<String> checkedDirs = new List<string>();
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    treeView1.Nodes.Add(drive.Name);
                    Console.WriteLine($"Об’єм диску: {drive.TotalSize}");
                    Console.WriteLine($"Вільний простір: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Мітка диску: {drive.VolumeLabel}");
                }
                Console.WriteLine();
            }
        }
        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            string path, newPath, shortPath;
            path = treeView1.SelectedNode.FullPath;
            shortPath = path.Substring(path.LastIndexOf('\\') + 1);

            try
            {
                Directory.GetDirectories(path);
            }
            catch
            {
                if (File.Exists(path)) titleLabel.Text = $"📄 {shortPath}";
                return;
            }

            if (!checkedDirs.Contains(path)) checkedDirs.Add(path);
            else return;

            foreach (string s in Directory.GetDirectories(path))
            {
                newPath = Path.Combine(path, s);

                try
                {
                    Directory.GetFiles(newPath);
                }
                catch (UnauthorizedAccessException)
                {
                    continue;
                }

                TreeNode child = treeView1.SelectedNode.Nodes.Add(s.Substring(path.Length).Replace("\\", ""));
                child.BackColor = Color.LightYellow;
                child.NodeFont = new Font("Tahoma", 8, FontStyle.Bold);
            }


            foreach (string s in Directory.GetFiles(path))
            {
                TreeNode child = treeView1.SelectedNode.Nodes.Add(s.Substring(path.Length).Replace("\\", ""));
                child.NodeFont = new Font("Tahoma", 8, FontStyle.Regular);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path, shortPath;
            path = treeView1.SelectedNode.FullPath;
            shortPath = path.Substring(path.LastIndexOf('\\') + 1);

            try
            {
                Directory.GetDirectories(path);
            }
            catch
            {
                if (File.Exists(path))
                {
                    FileInfo fileInfo = new FileInfo(path);
                    
                    titleLabel.Text = $"📄 {shortPath}";                    
                    descLabel.Text = $"Час створення: {fileInfo.CreationTime}\n" +
                        $"Остання зміна: {fileInfo.LastWriteTime}\n" +
                        $"Розширення: {fileInfo.Extension}";
                }
                
                return;
            }

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
    
            titleLabel.Text = $"📂 {shortPath}";
            descLabel.Text = $"Час створення: {directoryInfo.CreationTime}\n" +
                $"Остання зміна: {directoryInfo.LastWriteTime}\nКаталог.";
        }
    }
}
