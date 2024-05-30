using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _032_snakebite
{
  /// <summary>
  /// Game.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class Game : Window
  {
    private Random r = new Random();
    private Ellipse[] snakes;
    private Ellipse egg;
    private int unit = 10;  // 위치를 10 단위로 설정
    private int visibleCount = 5;
    private DispatcherTimer t = new DispatcherTimer();  // Form에서 Timer
    private Stopwatch sw = new Stopwatch();
    private string move = "";
    private int eaten = 0;
    public Game()
    {
      InitializeComponent();
      InitSnake();
      InitEgg();
      t.Interval = new TimeSpan(0, 0, 0, 0, 100); // 0.1초
      t.Tick += T_Tick;
    }

    private void T_Tick(object sender, EventArgs e)
    {
      for (int i = visibleCount; i > 0; i--)
        snakes[i].Tag = (Point)snakes[i - 1].Tag;

      Point q = (Point)snakes[0].Tag; // 뱀 머리 좌표

      if (move == "U")
        snakes[0].Tag = new Point(q.X, q.Y - unit);
      else if (move == "D")
        snakes[0].Tag = new Point(q.X, q.Y + unit);
      else if (move == "L")
        snakes[0].Tag = new Point(q.X - unit, q.Y);
      else if (move == "R")
        snakes[0].Tag = new Point(q.X + unit, q.Y);

      DrawSnakes();
      EatEgg();
    }

    private void EatEgg()
    {
      Point pS = (Point)snakes[0].Tag;
      Point pE = (Point)egg.Tag;

      if(pS.X == pE.X && pS.Y == pE.Y)
      {
        egg.Visibility = Visibility.Hidden;
        visibleCount++;
        snakes[visibleCount-1].Visibility = Visibility.Visible;
        score.Text = "Eggs = " + ++eaten;

        // 새로운 알을 만들기
        int x = r.Next(1, 48);
        int y = r.Next(1, 38);
        egg.Tag = new Point(x * unit, y * unit);
        egg.Visibility = Visibility.Visible;
        Canvas.SetLeft(egg, x*unit);
        Canvas.SetTop(egg, y*unit);
      }
    }

    private void DrawSnakes()
    {
      for(int i=0; i<visibleCount; i++)
      {
        Point p = (Point)snakes[i].Tag;
        Canvas.SetLeft(snakes[i], p.X);
        Canvas.SetTop(snakes[i], p.Y);
      }
    }

    private void InitSnake()
    {
      snakes = new Ellipse[30];

      int x = r.Next(1, 48);
      int y = r.Next(1, 38);

      for(int i = 0; i < 30; i++)
      {
        snakes[i] = new Ellipse();
        snakes[i].Width = unit;
        snakes[i].Height = unit;
        snakes[i].Stroke = Brushes.Black;
        if(i%5 == 0)
          snakes[i].Fill = Brushes.Green;
        else
          snakes[i].Fill = Brushes.Gold;

        snakes[0].Fill = Brushes.Chocolate;

        snakes[i].Tag = new Point(x * unit, (y + i) * unit);
        field.Children.Add(snakes[i]);
        Canvas.SetLeft(snakes[i], x * unit);
        Canvas.SetTop(snakes[i], (y + i) * unit);        
      }

      for (int i = visibleCount; i < 30; i++)
        snakes[i].Visibility = Visibility.Hidden;
    }

    private void InitEgg()
    {
      egg = new Ellipse();
      egg.Width = unit;
      egg.Height = unit;
      egg.Tag = new Point(r.Next(1, 480 / unit) * unit,
        r.Next(1, 380 / unit) * unit);
      egg.Stroke = Brushes.Black;
      egg.Fill = Brushes.Red;

      Point p = (Point)egg.Tag;
      field.Children.Add(egg);
      Canvas.SetLeft(egg, p.X);
      Canvas.SetTop(egg, p.Y);
    }

    private void Window_KeyDown(object sender, KeyEventArgs e)
    {
      // MessageBox.Show("KeyDown");
      t.Start();
      sw.Start();
      if (e.Key == Key.Left)
        move = "L";
      else if (e.Key == Key.Right)
        move = "R";
      else if (e.Key == Key.Up)
        move = "U";
      else if (e.Key == Key.Down)
        move = "D";
      else if (e.Key == Key.Escape)
      {
        move = "";
        t.Stop();
      }
    }
  }
}
