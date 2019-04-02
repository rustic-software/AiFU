using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.IO;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace AiFU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public SpeechSynthesizer speech = new SpeechSynthesizer();
        public WebClient client = new WebClient();

        public void Form1_Load(object sender, EventArgs e)
        {
            speech.SetOutputToDefaultAudioDevice();
            MinimizeBox = false;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            speech.Speak("Welcome back!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = textBox1.Text;

            switch (command)
            {
                case "send nudes":
                    speech.Speak("Maybe later, when i know you better");
                break;
                case "hello":
                    speech.Speak("Hi!");
                break;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
