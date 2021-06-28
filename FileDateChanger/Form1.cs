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

namespace FileDateChanger
{
    public partial class Main : Form
    {
        string filename = "";
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "", Title = "Load File" };
            if (ofd.ShowDialog() == DialogResult.OK)
                filename = ofd.FileName;

        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (filename != "")
            {
                if (!check_Creation.Checked && !check_LastAccess.Checked && !check_LastWrite.Checked)
                    MessageBox.Show("Check one option to continue !");
                else
                {
                    DateTime time = new DateTime(int.Parse(year.Value.ToString()),
                            int.Parse(month.Value.ToString()), int.Parse(day.Value.ToString()),
                            int.Parse(hour.Value.ToString()), int.Parse(minute.Value.ToString()), int.Parse(sec.Value.ToString()));
                    if(check_Creation.Checked)
                        File.SetCreationTime(filename, time);
                    if(check_LastAccess.Checked)
                        File.SetLastAccessTime(filename, time);
                    if(check_LastWrite.Checked)
                        File.SetLastWriteTime(filename, time);
                    MessageBox.Show("Done\r\n New Time: " + time);
                }
            }
        }
    }
}