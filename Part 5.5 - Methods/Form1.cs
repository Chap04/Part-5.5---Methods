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
    public partial class frmMethods : Form
    {
        public frmMethods()
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
            label.Text = ($"[0v0]\n" +
                "/|##|\\\n" +
                "^  ^");
        }
        async void WriteJoke(Label label)
        {
            label.Text = ("Knock Knock");
            await Task.Delay(2500);
            label.Text = ("Who's There?");
            await Task.Delay(2500);
            label.Text = ("Candice");
            await Task.Delay(2500);
            label.Text = ("Candice Who?");
            await Task.Delay(2500);
            label.Text = ("Candice joke get any worse?");
            await Task.Delay(5000);
            label.Text = ("");
        }
        private void btnAsciiArt1_Click(object sender, EventArgs e)
        {
            DrawFrog(lblOutput);
        }

        private void btnAsciiArt2_Click(object sender, EventArgs e)
        {
            DrawShrug(lblOutput);
        }

        private void btnAsciiArt3_Click(object sender, EventArgs e)
        {
            DrawRobot(lblOutput);
        }

        private void btnKnockKnock_Click(object sender, EventArgs e)
        {
            WriteJoke(lblOutput);
        }
    } 
}
