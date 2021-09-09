using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextCopy;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : MaterialForm
    {
        public PasswordGenerator()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void themeToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (themeToggle.Checked)
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green900, Primary.Green500, Accent.Green400, TextShade.WHITE);
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue900, Primary.Blue500, Accent.Blue400, TextShade.WHITE);
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            ThemeManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Orange900, Primary.Orange500, Accent.Orange400, TextShade.WHITE);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            int size = Int32.Parse(materialTextBox1.Text);
            materialTextBox2.Text = Generator.Generate(size);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            materialTextBox1.Text = materialTextBox2.Text = "";
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            ClipboardService.SetText(materialTextBox2.Text);
        }
    }
}
