using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _008_MessageBox
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      MessageBox.Show("안녕하세요");
      MessageBox.Show("안녕하세요", "Title");
      DialogResult result1 
        = MessageBox.Show("두개의 버튼", 
        "Question",
        MessageBoxButtons.YesNo);
      DialogResult result2 = MessageBox.Show(
        "세개의 버튼과 물음표", 
        "Question",
        MessageBoxButtons.YesNoCancel, 
        MessageBoxIcon.Question);
    }
  }
}
