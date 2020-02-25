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
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Drukarka_mozaikowa
{
    public partial class Form1 : Form
    {
        private string portName;
        private char ESC = (char)27;

        private List<string> fonts = new List<string>{ "Roman", "Sanserif", "Courier" };
        private List<string> sizes = new List<string> { "Standard size", "Double width and height", "Double height" };
        private List<string> styles = new List<string> { "Italic", "Up right", "Emphasized"};

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern SafeFileHandle CreateFile(string lfFileName, FileAccess dwDesiredAccess, uint dwShareMode, IntPtr lpSecurityAtributes, FileMode dwCreationDisposition, uint dwFlags, IntPtr hTemplateFile);
        public Form1()
        {
            InitializeComponent();
            foreach(string font in fonts)
            {
                comboBoxFont.Items.Add(font);
            }

            foreach(string size in sizes)
            {
                comboBoxSize.Items.Add(size);
            }
            foreach(string style in styles)
            {
                comboBoxStyle.Items.Add(style);
            }
            comboBoxFont.SelectedItem = fonts.ElementAt(0);
            comboBoxSize.SelectedItem = sizes.ElementAt(0);
            comboBoxStyle.SelectedItem = styles.ElementAt(0);

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (textBoxPortName.Text == "" || textBoxTextToWrite.Text == "")
                MessageBox.Show("Nie podałeś nazwy portu lub tekstu do wydrukowania!");
            else
            {
                portName = textBoxPortName.Text;
                Drukarka();
            }
        }
        public void Drukarka()
        {
            // Port = ?
            using (SafeFileHandle fileHandle = CreateFile(portName, FileAccess.Write, 0, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero))
            {
                if (fileHandle.IsInvalid)
                    throw new ApplicationException("Nie znaleziono drukarki na podanym porcie!");

                using (FileStream stream = new FileStream(fileHandle, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream, Encoding.ASCII))
                    {
                        var fontType = GetFontType();
                        var fontSize = GetFontSize();
                        var fontStyle = GetFontStyle();
                        string dataToWrite = textBoxTextToWrite.Text;

                        writer.Write(fontType);
                        writer.Write(fontSize);
                        writer.Write(fontStyle);
                        writer.Write(dataToWrite);

                    }
                }
            }
        }


        private string GetFontType()
        {
            string selected = comboBoxFont.Text;
            switch (selected)
            {
                case "Roman":
                default:
                    return "((F))0";
                case "Saserif":
                    return "((F))1";
                case "Courier":
                    return "((F))2";
            }
        }

        private string GetFontSize()
        {
            string selected = comboBoxSize.Text;
            switch (selected)
            {
                case "Standard size":
                default:
                    return "((S))0";
                case "Double width and height":
                    return "((S))3";
                case "Double height":
                    return "((S))2";
            }
        }

        private string GetFontStyle()
        {
            string selected = comboBoxStyle.Text;
            switch (selected)
            {
                case "Italic":
                    return ESC + "4";
                case "Up right":
                default:
                    return ESC + "5";
                case "Emphasized":
                    return ESC + "E";
            }
        }
    }
}
