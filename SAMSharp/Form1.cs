using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SAMSharp
{
    public partial class SAMSharp : Form
    {
        public SAMSharp() => InitializeComponent();
        private void Checks(object sender, EventArgs e)
        {
            if (chkOutput.Checked == false && chkSpeak.Checked == false) (sender as CheckBox).Checked = true;
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rtbText.Text == string.Empty) MessageBox.Show("The text box is empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tempfolder = Path.Combine(Path.GetTempPath(), "SAMSharp");
                if (!Directory.Exists(tempfolder)) Directory.CreateDirectory(tempfolder); 
                if (!File.Exists(Path.Combine(tempfolder, "sam.exe")))
                {
                    byte[] sam = Properties.Resources.sam;
                    using (FileStream exe = new FileStream(Path.Combine(tempfolder, "sam.exe"), FileMode.CreateNew))
                    {
                        exe.Write(sam, 0, sam.Length);
                        exe.Close();
                    }
                }
                if (!File.Exists(Path.Combine(tempfolder, "SDL.dll")))
                {
                    byte[] sdl = Properties.Resources.sdl;
                    using (FileStream dll = new FileStream(Path.Combine(tempfolder, "SDL.dll"), FileMode.CreateNew))
                    {
                        dll.Write(sdl, 0, sdl.Length);
                        dll.Close();
                    }
                }
                if (chkOutput.Checked)
                {
                    SaveFileDialog sfd = new SaveFileDialog()
                    {
                        Filter = "WAV file|*.wav"
                    };
                    if (sfd.ShowDialog() !=  DialogResult.Cancel)
                    {
                        Process.Start(Path.Combine(Path.GetTempPath(), "sam.exe"), $"-wav \"{sfd.FileName}\" {rtbText.Text}");
                    }
                }
                if (chkSpeak.Checked)
                {
                    Process.Start(Path.Combine(tempfolder, "sam.exe"), rtbText.Text);
                }
                Directory.Delete(tempfolder, true);
            }
        }
    }
}