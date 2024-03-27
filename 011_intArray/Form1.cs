using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _011_intArray
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int[] arr = {1,2,3,4,5};
      string s = "";

      foreach(var i in arr)
      {
        s += i + " ";
      }

      MessageBox.Show(s);

    }
  }
}
