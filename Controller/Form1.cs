using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            port.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            write("toggle");
        }
        void write(string data)
        {
            port.Write(data);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            write("toggle");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            write("toggle");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            write("beep");
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                string endString = "";
                e.Handled = true;
                e.SuppressKeyPress = true;
                foreach(char l in textBox1.Text)
                {
                    endString += " / ";
                    endString += charToMorse(l);
                }
                write(endString);
            }
        }
        string charToMorse(char c)
        {
            switch (c)
            {
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'z':
                    return "--..";
                default:
                    return null;
            }
        }
    }
}
