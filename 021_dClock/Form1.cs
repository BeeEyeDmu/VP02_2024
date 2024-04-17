using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_dClock
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.Text = "나의 디지털 시계";
      lblDate.Text = "";
      lblTime.Text = "";

      timer1.Enabled = true; // timer1.Start();
      timer1.Interval = 1000; // 단위: 밀리초
      timer1.Tick += Timer1_Tick;

      lblDate.Font = new Font("맑은 고딕", 16, FontStyle.Bold);
      lblDate.ForeColor = Color.DarkOrange;

      lblTime.Font = new Font("맑은 고딕", 32, FontStyle.Bold);
      lblTime.ForeColor = Color.DarkBlue;
    }

    private void Timer1_Tick(object sender, EventArgs e)
    {
      // 현재 시간을 가져와서 화면에 표시
      lblTime.Text = DateTime.Now.ToString("tt h:mm:ss");
      lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일");

      lblDate.Location = new Point(
        ClientSize.Width / 2 - lblDate.Width / 2,
        ClientSize.Height / 2 - lblDate.Height / 2 - 30);

      lblTime.Location = new Point(
        ClientSize.Width / 2 - lblTime.Width / 2,
        ClientSize.Height / 2 - lblTime.Height / 2 + 30);
    }
  }
}
