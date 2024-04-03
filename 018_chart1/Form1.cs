using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_chart1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      // 차트컨트롤을 사용하여
      // 랜덤하게 0~100사이의 값 10개를 그래프로 그려라
      Random r = new Random();

      for(int i=0; i<10; i++)
      {
        chart1.Series[0].Points.Add(r.Next(101));
      }
      chart1.Series[0].LegendText = "비주얼\n프로그래밍";
      chart1.Titles.Add("성적");
    }
  }
}
