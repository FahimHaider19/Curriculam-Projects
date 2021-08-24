using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;

namespace GameStore.WinForms
{
    public partial class TestForm : Form
    {
        public TestForm(GameStore.Classes.Store store)
        {
            InitializeComponent();
            int id = 6002;
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", ""));
            OpenFileDialog fileDialogueBox = new OpenFileDialog();
            if(fileDialogueBox.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(fileDialogueBox.FileName);
                if(File.Exists(@"C:\Users\WolfEye19\Desktop\To\" + id.ToString() + "_title" + ".jpg"))
                {
                    File.Delete(@"C:\Users\WolfEye19\Desktop\To\" + id.ToString() + "_title" + ".jpg");
                }
                File.Move(fileDialogueBox.FileName, @"C:\Users\WolfEye19\Desktop\To\"+id.ToString()+"_title"+".jpg");
            }
            /*string str = System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
            string from = @"C:\Users\WolfEye19\Desktop\From\";
            string to = @"C:\Users\WolfEye19\Desktop\To\";
            DirectoryInfo di = new DirectoryInfo(from);
            foreach(var fi in di.GetFiles())
            {
                if(File.Exists(to+fi)==false)
                    File.Move(from+fi,to+fi);
            }*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void gameBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
