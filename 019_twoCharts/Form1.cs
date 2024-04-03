using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_twoCharts
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      chart1.Titles.Add("중간고사 성적");

      // Series2 추가
      chart1.Series.Add("Series2");

      chart1.Series[0].LegendText = "수학";
      chart1.Series[1].LegendText = "영어";

      Random r = new Random();

      for(int i=1; i<=10; i++)
      {
        chart1.Series[0].Points.AddXY(i, r.Next(101));
        chart1.Series[1].Points.AddXY(i, r.Next(101));
      }
    }

    // 나누어 그리기
    private void button2_Click(object sender, EventArgs e)
    {
      if(chart1.ChartAreas.Count == 1) 
      {
        chart1.ChartAreas.Add("ChartArea2");
      }      
      chart1.Series[1].ChartArea = "ChartArea2";
    }

    // 합쳐서 그리기
    private void button1_Click(object sender, EventArgs e)
    {
      if(chart1.ChartAreas.Count > 1)
      {
        chart1.ChartAreas.RemoveAt(1);
      }      
      chart1.Series[1].ChartArea = "ChartArea1";
    }
  }
}
