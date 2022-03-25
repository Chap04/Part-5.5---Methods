using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_5._5___Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static void DrawFrog(Label label)
        {
            label.Text = ($"@..@\n" +
                "(-- -- --)\n" +
                "(  >__<  )\n" +
                " ^^ ~~ ^^");
        }

        public static void DrawShrug(Label label)
        {
            label.Text = ($"_                    _ \n" +
                "\\_((o)_(O))_/");
        }

        public static void DrawRobot(Label label)
        {
            label.Text = ($"[00]\n" +
                "/|##|\\\n" +
                "d  b");
        }
        private void btnAsciiArt1_Click(object sender, EventArgs e)
        {
            DrawFrog(lblAsciiOutput);
        }

        private void btnAsciiArt2_Click(object sender, EventArgs e)
        {
            DrawShrug(lblAsciiOutput);
        }

        private void btnAsciiArt3_Click(object sender, EventArgs e)
        {
            DrawRobot(lblAsciiOutput);
        }
    } 
}
