using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010_checkBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string states = "";
      CheckBox[] c = { checkBox1, checkBox2, 
        checkBox3, checkBox4, checkBox5 };

      foreach(var i in c) 
      {
        states += string.Format("{0} : {1}\n",
          i.Text, i.Checked);
      }
      MessageBox.Show(states, "좋아하는 과일은?");

      string summary = "좋아하는 과일은 : ";
      foreach(var item in c) 
      { 
        if(item.Checked)
        {
          summary += item.Text + " ";
        }
      }
      MessageBox.Show(summary, "Summary");
    }
  }
}
