using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_scoreCalc
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      //double sum = double.Parse(txtKor.Text) +
      //  double.Parse(txtMath.Text) + double.Parse(txtEng.Text);
      double sum = Convert.ToDouble(txtKor.Text) +
        Convert.ToDouble(txtMath.Text) 
        + Convert.ToDouble(txtEng.Text);

      double avg = sum / 3;

      txtSum.Text = sum.ToString();
      txtAvg.Text = avg.ToString("0.0");  // 소수점 한자리
    }
  }
}
