using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            label1.Text = "My Screen Resolution = " + resolution.Size;
            label1.Location = new Point(resolution.Right - 250, 30);
            
            monthCalendar1.Location = new Point(resolution.Right-250, 30); 
                
                }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            System.Windows.Forms.Form.ActiveForm.Opacity = ((double)(trackBar1.Value) / 100.0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.

            this.BackgroundImage = new Bitmap(openFileDialog1.FileName);
        }
    }
}
