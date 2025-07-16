using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {

        string[] leftA = {
            "0001101",  // 0
            "0011001",  // 1
            "0010011",  // 2
            "0111101",  // 3
            "0100011",  // 4
            "0110001",  // 5
            "0101111",  // 6
            "0111011",  // 7
            "0110111",  // 8
            "0001011"   // 9
        };

        string[] leftB = {
            "0100111",  // 0
            "0110011",  // 1
            "0011011",  // 2
            "0100001",  // 3
            "0011101",  // 4
            "0111001",  // 5
            "0000101",  // 6
            "0010001",  // 7
            "0001001",  // 8
            "0010111"   // 9
        };

        string[] rightC = {
            "1110010",  // 0
            "1100110",  // 1
            "1101100",  // 2
            "1000010",  // 3
            "1011100",  // 4
            "1001110",  // 5
            "1010000",  // 6
            "1000100",  // 7
            "1001000",  // 8
            "1110100"   // 9
        };

        string[,] encodingMatrix = {
            // 2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13
            { "A", "A", "A", "A", "A", "A", "C", "C", "C", "C", "C", "C" }, // 0
            { "A", "A", "B", "A", "B", "B", "C", "C", "C", "C", "C", "C" }, // 1
            { "A", "A", "B", "B", "A", "B", "C", "C", "C", "C", "C", "C" }, // 2
            { "A", "A", "B", "B", "B", "A", "C", "C", "C", "C", "C", "C" }, // 3
            { "A", "B", "A", "A", "B", "B", "C", "C", "C", "C", "C", "C" }, // 4
            { "A", "B", "B", "A", "A", "B", "C", "C", "C", "C", "C", "C" }, // 5
            { "A", "B", "B", "B", "A", "A", "C", "C", "C", "C", "C", "C" }, // 6
            { "A", "B", "A", "B", "A", "B", "C", "C", "C", "C", "C", "C" }, // 7
            { "A", "B", "A", "B", "B", "A", "C", "C", "C", "C", "C", "C" }, // 8
            { "A", "B", "B", "A", "B", "A", "C", "C", "C", "C", "C", "C" }  // 9
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateEAN13Barcode();
        }

        public void DrawEAN13Barcode(PictureBox pictureBox, string input)
        {
            // Create a Bitmap with the same size as the PictureBox
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Create a Graphics object from the Bitmap
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // Clear the background to white
                g.Clear(Color.White);

                // Define the width and height of each rectangle
                int rectWidth = 10;  // You can adjust this value as needed
                int rectHeight = pictureBox.Height; // Rectangles fill the height of PictureBox

                // Loop through each element in the inputTable
                for (int i = 0; i < input.Length; i++)
                {
                    // Calculate the position of the rectangle
                    int x = i * rectWidth;
                    int y = 0;

                    // Set the color based on the value at inputTable[i]
                    Brush brush = (input[i].ToString() == "1") ? Brushes.Black : Brushes.White;

                    // Draw the rectangle
                    g.FillRectangle(brush, x, y, rectWidth, rectHeight);
                 
                }
            }

            // Set the Bitmap as the image for the PictureBox
            pictureBox.Image = bitmap;
        }

        private void GenerateEAN13Barcode()
        {
            string data = textBox1.Text;
            string fullEAN = data + CalculateEAN13CheckDigit(data);
            textBox2.Text = fullEAN;
            label1.Text = "checkdigit: " + CalculateEAN13CheckDigit(data);
            int firstDigit = int.Parse(data[0].ToString());
            string binaryString = string.Empty;
            binaryString += "000101";
            binaryString += leftA[firstDigit];
            for (int i = 1; i < fullEAN.Length; i++)
            {
                int digit = int.Parse(fullEAN[i].ToString());
                //Console.WriteLine(i);
                string encoding = encodingMatrix[firstDigit, i - 1];
                Console.WriteLine(encoding);
                if (encoding == "A")
                {
                    binaryString += leftA[digit];
                }
                else if (encoding == "B")
                {
                    binaryString += leftB[digit];
                }
                else
                {
                    binaryString += rightC[digit];
                }

                if (i == 6)
                {
                    binaryString += "01010";
                }
            }

            binaryString += "101000";

            DrawEAN13Barcode(pictureBox1, binaryString);

        }

        private static int CalculateEAN13CheckDigit(string data)
        {
            int sum = 0;
            for(int i = 0; i < data.Length; i++)
            {
                int digit = int.Parse(data[i].ToString());
                sum += i % 2 == 0 ? digit : digit * 3;
            }
            int mod = sum % 10;
            return mod % 10 == 0 ? 0 : 10 - mod;
        }

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
