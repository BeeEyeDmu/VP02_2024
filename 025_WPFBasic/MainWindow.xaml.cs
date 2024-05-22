using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _025_WPFBasic
{
  /// <summary>
  /// MainWindow.xaml에 대한 상호 작용 논리
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
    {
      MessageBox.Show("Text Clicked!");

      if(grid1.Background == Brushes.Orange)
        grid1.Background = Brushes.Aqua;
      else
        grid1.Background = Brushes.Orange;
    }
  }
}
