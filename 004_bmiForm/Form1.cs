using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_bmiForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnBMI_Click(object sender, EventArgs e)
    {
      double h = double.Parse(txtH.Text) / 100; // m로 변환
      double w = double.Parse(txtW.Text);

      double bmi = w / (h * h);

      // [Ctrl]-KC : Comment
      // [Ctrl]-KU : UnComment
      //lblBMI.Text = "BMI = " + bmi;
      lblBMI.Text = string.Format("BMI = {0:F2}", bmi);

      if (bmi < 20)
      {
        lblResult.Text = "저체중입니다";
        pictureBox1.BackColor = Color.Blue;
      }
      else if (bmi < 25)
      {
        lblResult.Text = "정상체중입니다";
        pictureBox1.BackColor = Color.Green;
      }
      else if (bmi < 30)
      {
        lblResult.Text = "경도비만입니다";
        pictureBox1.BackColor = Color.Yellow;
      }
      else if (bmi < 40)
      {
        lblResult.Text = "비만입니다";
        pictureBox1.BackColor = Color.Orange;
      }
      else
      {
        lblResult.Text = "고도비만입니다";
        pictureBox1.BackColor = Color.Red;
      }

    }
  }
}
