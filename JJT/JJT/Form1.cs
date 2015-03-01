using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using ProcessMemoryReaderLib;
using System.Runtime.InteropServices;

namespace JJT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Gold()
        {
            try
            {
                ProcessMemoryReaderLib.ProcessMemoryReader preader = new ProcessMemoryReaderLib.ProcessMemoryReader();
                ProcessMemoryReader Reader = new ProcessMemoryReader();
                Process[] MyProcess = Process.GetProcessesByName("JetpackJoyride_Win8");
                preader.ReadProcess = MyProcess[0];
                preader.OpenProcess();

                int byteswritten;
                long value;
                byte[] memory;
                string wadress = "010D73C8";
                IntPtr writeadress = new IntPtr(Convert.ToInt32(wadress, 16));

                value = Convert.ToInt64(textBox1.Text);
                memory = BitConverter.GetBytes(value);
                preader.WriteProcessMemory((IntPtr)writeadress, memory, out byteswritten);
                MessageBox.Show("Value has been successfully injected to Jetpack Joyride !");
            }
            catch
            {
                MessageBox.Show("Something goes wrong !");
            }
        }

        public void Token()
        {
            try
            {
                ProcessMemoryReaderLib.ProcessMemoryReader preader = new ProcessMemoryReaderLib.ProcessMemoryReader();
                ProcessMemoryReader Reader = new ProcessMemoryReader();
                Process[] MyProcess = Process.GetProcessesByName("JetpackJoyride_Win8");
                preader.ReadProcess = MyProcess[0];
                preader.OpenProcess();

                int byteswritten;
                long value;
                byte[] memory;
                string wadress = "010D73D0";
                IntPtr writeadress = new IntPtr(Convert.ToInt32(wadress, 16));

                value = Convert.ToInt64(textBox2.Text);
                memory = BitConverter.GetBytes(value);
                preader.WriteProcessMemory((IntPtr)writeadress, memory, out byteswritten);
                MessageBox.Show("Value has been successfully injected to Jetpack Joyride !");
            }
            catch
            {
                MessageBox.Show("Something goes wrong !");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gold();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Token();
        }
    }
}
