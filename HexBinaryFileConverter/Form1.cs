using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace HexBinaryFileConverter
{
    public partial class HexToBinary : Form
    {

        public HexToBinary()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                String filePath = openFileDialog1.FileName;
                if (filePath.Substring(filePath.Length - 4) == ".hex")
                    FilePathtxtbox.Text = filePath;
                else
                    MessageBox.Show("Choose a hex file");
            }


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void HexToBinary_Load(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();

        }

        private void Convert_Click(object sender, EventArgs e)
        {
            String filePath = FilePathtxtbox.Text;
            if (filePath.Length > 0)
                ConvertFile(filePath);
            else
                MessageBox.Show("Choose a hex file");
        }

        void ConvertFile(String path) {

            // Open hex file to convert .
            // Create a new bin file to push the result.
            StreamReader hexFile = new StreamReader(path);
            if(hexFile == null)
            {
                MessageBox.Show("Invalid Path");
                return;
            }
            String binpath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            binpath += "\\app.bin";
            StreamWriter binFile = new StreamWriter(binpath);
            String line = hexFile.ReadLine();
            int dataLength;
            int datainit = 9;
            int FileSize = 0;
            int packets  = 0;
            while (line != null)
            {
                if (line[7] != '0' || line[8] != '0') // Data Record
                {
                    line = hexFile.ReadLine();
                    continue;
                }
                // number of bytes in a record
                dataLength = int.Parse(line.Substring(1, 2), System.Globalization.NumberStyles.HexNumber);
                FileSize += dataLength;
                
                // one byte is 2 Hex chars     
                String bin = "";
                for (int i = 0; i < dataLength*2; i += 2)
                {
                    string HexByte = "";
                    HexByte += line[datainit + i];
                    HexByte += line[datainit + i + 1];

                    bin = HexToBin(HexByte);
                    binFile.Write(bin);
                    binFile.Write(" ");
                }
                binFile.WriteLine();
                line = hexFile.ReadLine();

            }
            FileSizetxtBox.Text = FileSize.ToString();
            packets = FileSize / 1024;
            TotalPacketstextBox.Text = packets.ToString();
            ExtraBytesTextBox.Text = (FileSize % 1024).ToString();
            hexFile.Close();
            binFile.Close();
            MessageBox.Show("Conversion Completed");
        }

        String HexToBin(string hex)
        {
            String res = "";
            int deci = HexToDeci(hex);
            while (deci > 0)
            {
                if (deci % 2 > 0)
                {
                    res += '1';
                } else
                {
                    res += '0';
                }
                deci /= 2;
            }
            while (res.Length < 8) { res += "0"; }

           char[] arr = res.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        int HexToDeci(string hex)
        {
            int deci = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            return deci;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Output_Click(object sender, EventArgs e)
        {
            String binpath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            binpath += "\\app.bin";
            System.Diagnostics.Process.Start(binpath);

        }
    }

   
}
