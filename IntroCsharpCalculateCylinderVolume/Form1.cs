using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroCsharpCalculateCylinderVolume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Variables
        public double cylinderHeight;
        public double cylinderRadius;
        public double cylinderVolume;
        public const double piValue = Math.PI;
       
        #endregion

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxRadius.Text))
            {
                labelWarning.Visible = true;
                labelWarning.Text = "Silindirin Yarıçapını Giriniz ! / Please Enter Radius of Cylinder";
                labelWarning.BackColor = Color.Red;
                return;
            }
            else if (String.IsNullOrEmpty(textBoxHeight.Text))
            {
                labelWarning.Visible = true;
                labelWarning.Text = "Silindirin Yüksekliğini Giriniz ! / Please Enter Height of Cylinder";
                labelWarning.BackColor = Color.Red;
                return;
            }
            else
            {
                cylinderHeight = Convert.ToDouble(textBoxHeight.Text);
                cylinderRadius = Convert.ToDouble(textBoxRadius.Text);
                cylinderVolume = Math.PI * Math.Pow(cylinderRadius, 2) * cylinderHeight;
                labelResult.Text = cylinderVolume.ToString();
                labelWarning.Visible = true;
                labelWarning.Text = "Hesaplama Başarılı :)";
                labelWarning.BackColor = Color.Turquoise;
            }
        }
    }
}
