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

namespace _029_Language
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

    private void btnSubmit_Click(object sender, RoutedEventArgs e)
    {
      CheckBox[] c = new CheckBox[] {cbC, cbCPP, cbCS, cbPython, cbJava };
      string s = "";

      foreach(var cb in c)
      {
        if (cb.IsChecked == true)
          s += cb.Content + " ";
      }

      MessageBox.Show(s + "선택하였습니다!", "Language Preferred!");
    }

    private void btnQuit_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }
  }
}
