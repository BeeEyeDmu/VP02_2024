using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _015_susi
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      //comboBox1.Items.Add(1);
      //comboBox1.Items.Add(2);
      //comboBox1.Items.Add(3);
      //comboBox1.Items.Add(4);
      for(int i=1; i<=4; i++)
      {
        comboBox1.Items.Add(i);
      }
      comboBox1.SelectedItem = 2;
    }
  }
}
