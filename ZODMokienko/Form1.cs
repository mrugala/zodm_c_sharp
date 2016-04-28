using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZODMokienko
{
    public partial class Okienko : Form
    {
        public Okienko()
        {
            InitializeComponent();
            inpD = new InputData(numX.Value, numY.Value, numZ.Value, numAlfa.Value, numBeta.Value, numGamma.Value);
            zodm = new ZODM(inpD);
        }

        private void suwAlfa_Scroll(object sender, ScrollEventArgs e)
        {
            numAlfa.Value = (decimal)suwAlfa.Value;
        }

        private void suwBeta_Scroll(object sender, ScrollEventArgs e)
        {
            numBeta.Value = (decimal)suwBeta.Value;
        }

        private void suwGamma_Scroll(object sender, ScrollEventArgs e)
        {
            numGamma.Value = (decimal)suwGamma.Value;
        }

        private void suwX_Scroll(object sender, ScrollEventArgs e)
        {
            numX.Value = (decimal)suwX.Value;
        }

        private void suwY_Scroll(object sender, ScrollEventArgs e)
        {
            numY.Value = (decimal)suwY.Value;
        }

        private void suwZ_Scroll(object sender, ScrollEventArgs e)
        {
            numZ.Value = (decimal)suwZ.Value;
        }

        private void numAlfa_ValueChanged(object sender, EventArgs e)
        {
            suwAlfa.Value = (int)numAlfa.Value;
        }

        private void numBeta_ValueChanged(object sender, EventArgs e)
        {
            suwBeta.Value = (int)numBeta.Value;
        }

        private void numGamma_ValueChanged(object sender, EventArgs e)
        {
            suwGamma.Value = (int)numGamma.Value;
        }

        private void numX_ValueChanged(object sender, EventArgs e)
        {
            suwX.Value = (int)numX.Value;
        }

        private void numY_ValueChanged(object sender, EventArgs e)
        {
            suwY.Value = (int)numY.Value;
        }

        private void numZ_ValueChanged(object sender, EventArgs e)
        {
            suwZ.Value = (int)numZ.Value;
        }

        private InputData inpD;
        private ZODM zodm;

        private void timer1_Tick(object sender, EventArgs e)
        {
            inpD.X = numX.Value;
            inpD.Y = numY.Value;
            inpD.Z = numZ.Value;
            inpD.Alfa = numAlfa.Value;
            inpD.Beta = numBeta.Value;
            inpD.Gamma = numGamma.Value;
            zodm.calculate();
            textBox1.Text = inpD.X.ToString("0.##") + " " + inpD.Y.ToString("0.##") + " " + inpD.Z.ToString("0.##") + " " +
                inpD.Alfa.ToString("0.##") + " " + inpD.Beta.ToString("0.##") + " " + " " + inpD.Gamma.ToString("0.##"); 
            try
            {
                textBox2.Text = zodm[1].ToString("0.##") + " " + zodm[2].ToString("0.##") + " " + zodm[3].ToString("0.##") + " " +
                    zodm[4].ToString("0.##") + " " + zodm[5].ToString("0.##");
            }
            catch(System.OverflowException ex)
            {
                Console.WriteLine(ex.Message + " timer");
            }

        }
    }
}
