using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace QuickFrontEnd
{
    public partial class FQ2 : Form
    {
        public string lastPath = "";

        public FQ2()
        {
            InitializeComponent();
        }

        private string PathHere()
        {
            return Path.GetDirectoryName(Application.ExecutablePath.ToString()).ToString() + Path.DirectorySeparatorChar.ToString();
        }

        private void FQLoad(object sender, EventArgs e)
        {
            string here = PathHere();   // c:\folder\at\
            string[] sFiles = Directory.GetDirectories(here, "*", SearchOption.TopDirectoryOnly);
            for (int i = 0; i < sFiles.Count(); i++) { sFiles[i] = Path.GetFileName(sFiles[i]); }

            string[] sortedFiles = sFiles.OrderBy(x => x).Where(x => x != "bin" && x != "dje").ToArray();

            //Add buttons
            foreach (string sf in sortedFiles)
            {
                //got directories, parse them to make sure they're not empty...
                List<string> temp = GetEmulatorFiles(here + Path.DirectorySeparatorChar + sf);
                if (temp.Count != 0)
                {
                    Button Button1 = new Button()
                    {
                        Text = sf,
                        AutoSize = false,
                        Width = flowLayoutPanel1.Width - 6,
                        Visible = true
                    };
                    Button1.Click += ButtonClick;
                    flowLayoutPanel1.Controls.Add(Button1);
                }
            }
            if (sortedFiles.Length == 0)
            {
                labelFolder.Text = "No folders present!";
            } else if(sortedFiles.Length >1)
            {
                labelFolder.Text = "Folders:";
            }

        }

        public string Selection
        {
            get
            {
                return lastPath + Path.DirectorySeparatorChar.ToString() + listBox1.SelectedItem.ToString();
            }
        }

        //Get emulator files. Won't delete list, allowing appends
        public List<string> GetEmulatorFiles(string pathname)
        {
            List<string> myList =Directory.GetFiles(pathname, "*.bin").ToList<string>();
            myList.InsertRange(myList.Count, Directory.GetFiles(pathname, "*.rom").ToList<string>());
            myList.InsertRange(myList.Count, Directory.GetFiles(pathname, "*.int").ToList<string>());
            return myList;
        }

        public void ReadGames(string folderName)
        {
            listBox1.Items.Clear();
            lastPath = PathHere() + folderName;

            //.rom, .bin and .int only            
            List<string> sFiles = GetEmulatorFiles(lastPath);


            //only filename
            for (int i=0; i<sFiles.Count();i++)
            {
                sFiles[i] = Path.GetFileName(sFiles[i]);
            }

            //foreach (var fileName in sFiles) {fileName = Path.GetFileNameWithoutExtension(fileName);}
            /*  string[] sortedFiles = sFiles.OrderBy(x=>x).Where(x=> 
                (x!="ecs.bin" && x!="grom.bin" && x!="exec.bin" & x!="desktop.ini" & (x.Length>4 && x.Substring(x.Length-4)!=".cfg")) ).ToArray();   */
                        
            var sortedFiles = from x in sFiles orderby x select x;
            listBox1.Items.AddRange(sortedFiles.ToArray());
        }

        private void ButtonClick(object sender, EventArgs e)
        {            
            Button b = (Button)sender;            
            ReadGames(b.Text);
        }
        
        private void HelpClick(object sender, EventArgs e)
        {
            // using (Form myForm = new Form2())
            // {                
            //     myForm.Show();
            //     myForm.Activate();
            // }        
            Form myForm = new FormHelp();
            myForm.Show();
        }

        private void RunClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a game."); return;
            }


            //string executable = "\"" + PathHere() + "bin" + Path.DirectorySeparatorChar.ToString() + "jzintv.exe" + "\"";
            string executable = $"\"{PathHere()}bin{Path.DirectorySeparatorChar}jzintv.exe\"";

            //resolution
            string rez = $"-f0 --displaysize={comboBox1.Text}";
            if (chkFull.Checked) rez = "--fullscreen=1";

            //parameters
            string parameters = String.Format("-a44100 --prescale=scale4x --voice={0} --ecs={1}", cVoice.Checked ? "1" : "0", cECS.Checked ? "1" : "0");


            string final = $"{parameters} {rez} \"{Selection}\"";
            //MessageBox.Show(executable + "\n\n" + final);
            //System.Diagnostics.Debug.WriteLine(executable);
            //System.Diagnostics.Debug.WriteLine(final);
            //System.Diagnostics.Process.Start(@"bin\jzintv.exe", final);

            //FormConsole f = new FormConsole();
            //f.Show();

            using (System.Diagnostics.Process p = new System.Diagnostics.Process())
            {
                p.StartInfo = new System.Diagnostics.ProcessStartInfo(executable, final)
                {
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    UseShellExecute = false
                };
                //string s = "";
                p.Start();
                while (!p.HasExited)
                {
                    System.Diagnostics.Debug.WriteLine(p.StandardOutput.ReadLine());
                    //s = p.StandardOutput.ReadLine();
                    //if (s!=null && s.Length>0) { f.listcon.Items.Add(s); } 
                }
                if (p.ExitCode != 0)
                {
                    MessageBox.Show($"Emulator returned error #{p.ExitCode.ToString()}.");
                }
            }
            System.Diagnostics.Debug.WriteLine("Emulator stopped.");
            
        }

        private void FQ_ResizeBegin(object sender, EventArgs e)
        {
            //
        }

        private void FQ_ResizeEnd(object sender, EventArgs e)
        {
            Form f = (Form)sender;

            if (f.Width < 512) f.Width = 512;
            if (f.Height < 200) f.Height = 200;
        }
    }

}
