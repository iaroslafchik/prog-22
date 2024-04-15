using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2
{
    public partial class Form1 : Form
    {
        double input = 0;


        public Form1()
        {
            InitializeComponent();
            updateInputBox();
        }

        private void AddDigit(object sender, EventArgs e)
        {
            addDigit(int.Parse((sender as Button).Text));
        }

        void updateInputBox()
        {
            textBox1.Clear();
            textBox1.AppendText(string.Format("{0}", input));
            Refresh();
        }

        void addDigit(int digit)
        {
            input *= 10;
            input += digit;
            updateInputBox();
        }
    }
}