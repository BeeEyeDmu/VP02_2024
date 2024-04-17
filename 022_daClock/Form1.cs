using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_daClock
{
  public partial class Form1 : Form
  {
    // 필드(멤버변수)
    private Graphics g;
    private bool aClockFlag = true; // 아날로그 시계
    private Point center;
    private int radius;
    private int hourHand; // 시침의 길이
    private int minHand;  // 분침
    private int secHand;  // 초침

    private const int clientSize = 400;  // client의 크기
    private const int clockSize = 300;   // 시계의 크기

    private Font fDate; // 날짜 폰트
    private Font fTime; // 시간 폰트
    private Brush bDate;
    private Brush bTime;

    private Point panelCenter;

    // 생성자
    public Form1()
    {
      InitializeComponent();

      this.ClientSize = new Size(clientSize,
        clientSize + menuStrip1.Height);
      this.Text = "My Form Clock";

      // panel 지정
      panel1.BackColor = Color.WhiteSmoke;
      panel1.Width = clockSize + 1;
      panel1.Height = clockSize + 1;
      panel1.Location = new Point(
        clientSize / 2 - clockSize / 2,
        clientSize / 2 - clockSize / 2 + menuStrip1.Height);

      panelCenter.X = panel1.Width / 2;
      panelCenter.Y = panel1.Height / 2;

      g = panel1.CreateGraphics(); // panel1에 그려주는 그래픽 객체

      aClockSetting();
      dClockSetting();
      timerSetting();

    }

    private void dClockSetting()
    {
      fDate = new Font("맑은 고딕", 12, FontStyle.Bold);
      fTime = new Font("맑은 고딕", 32, 
        FontStyle.Bold|FontStyle.Italic);
      bDate = Brushes.SkyBlue;
      bTime = Brushes.Blue;
    }

    private void timerSetting()
    {
      Timer t = new Timer();

      t.Enabled = true;
      t.Interval = 1000;
      t.Tick += T_Tick;
    }

    private void T_Tick(object sender, EventArgs e)
    {
      DateTime c = DateTime.Now; // 현재 시간
      panel1.Refresh();

      if (aClockFlag == true) // 아날로그
      {
        DrawClockFace();

        // 시계바늘 각도
        double radHr 
          = (c.Hour%12+c.Minute/60.0)*30*Math.PI/180;
        double radMin 
          = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
        double radSec = c.Second * 6 * Math.PI / 180;

        DrawHands(radHr, radMin, radSec);
      }
      else // 디지털 시계
      {
        string date = DateTime.Today.ToString("D");
        string time = string.Format("{0:D2}:{1:D2}:{2:D2}",
          c.Hour, c.Minute, c.Second);

        g.DrawString(date, fDate, bDate, new Point(5, 70));
        g.DrawString(time, fTime, bTime, new Point(5, 100));
      }
    }

    private void DrawHands(double radHr, double radMin, double radSec)
    {
      DrawLine(0,0,
        (int)(hourHand * Math.Sin(radHr)),
        (int)(hourHand * Math.Cos(radHr)),
        Brushes.RoyalBlue, 8);
      DrawLine(0, 0,
        (int)(minHand * Math.Sin(radMin)),
        (int)(minHand * Math.Cos(radMin)),
        Brushes.SkyBlue, 6);
      DrawLine(0, 0,
        (int)(secHand * Math.Sin(radSec)),
        (int)(secHand * Math.Cos(radSec)),
        Brushes.OrangeRed, 4);

      // 시계배꼽
      int coreSize = 16;
      Rectangle r = new Rectangle(panelCenter.X - coreSize/2,
        panelCenter.Y - coreSize/2, coreSize, coreSize);
      g.FillEllipse(Brushes.Gold, r);
      g.DrawEllipse(new Pen(Brushes.Green), r);

    }

    private void DrawLine(int x1, int y1, int x2, int y2, 
      Brush brush, int thick)
    {
      Pen p = new Pen(brush, thick);
      p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
      g.DrawLine(p, panelCenter.X + x1, panelCenter.Y + y1,
        panelCenter.X + x2, panelCenter.Y - y2);
    }

    private void DrawClockFace()
    {
      const int penWidth = 30;

      Pen p = new Pen(Brushes.LightSteelBlue, penWidth);
      g.DrawEllipse(p, penWidth/2, penWidth/2, 
        clockSize - penWidth, clockSize - penWidth);

      // 눈금 그리기
      Pen lPen = new Pen(Brushes.Blue, 10);
      for(int i = 0; i<360; i += 90)
      {
        int x1 = (int)(radius * 0.85 * Math.Sin(i * Math.PI / 180));
        int y1 = (int)(radius * 0.85 * Math.Cos(i * Math.PI / 180));
        int x2 = (int)(radius * 0.95 * Math.Sin(i * Math.PI / 180));
        int y2 = (int)(radius * 0.95 * Math.Cos(i * Math.PI / 180));
        g.DrawLine(lPen, panelCenter.X + x1, panelCenter.Y - y1, 
          panelCenter.X+x2, panelCenter.Y-y2);
      }
      Pen sPen = new Pen(Brushes.SteelBlue, 4);
      for (int i = 0; i < 360; i += 30)
      {
        if (i % 90 == 0)
          continue;
        int x1 = (int)(radius * 0.85 * Math.Sin(i * Math.PI / 180));
        int y1 = (int)(radius * 0.85 * Math.Cos(i * Math.PI / 180));
        int x2 = (int)(radius * 0.92 * Math.Sin(i * Math.PI / 180));
        int y2 = (int)(radius * 0.92 * Math.Cos(i * Math.PI / 180));
        g.DrawLine(sPen, panelCenter.X + x1, panelCenter.Y - y1,
          panelCenter.X + x2, panelCenter.Y - y2);
      }
    }

    private void aClockSetting()
    {
      center = new Point(clientSize/2, clientSize/2);
      radius = clockSize / 2;
      hourHand = (int)(radius * 0.45);
      minHand = (int)(radius * 0.55);
      secHand = (int)(radius * 0.65);
    }

    private void 아날로그ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      aClockFlag = true;
    }

    private void 디지털ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      aClockFlag = false;
    }

    private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
