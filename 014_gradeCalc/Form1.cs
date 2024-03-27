using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _014_gradeCalc
{
  public partial class Form1 : Form
  {
    TextBox[] titles;
    ComboBox[] crds;
    ComboBox[] grds;

    public Form1()  // 생성자함수
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      double totalS = 0;  // 총점
      int totalC = 0;     // 학점수

      for(int i=0; i<titles.Length; i++)
      {
        if (titles[i].Text != "")
        {
          int crd = int.Parse(crds[i].SelectedItem.ToString());
          totalC += crd;
          totalS += crd * GetGrade(grds[i].SelectedItem.ToString());
        }
      }

      txtGrade.Text = (totalS/totalC).ToString("0.00");
    }

    private double GetGrade(string v)
    {
      double grade = 0;

      if (v == "A+") grade = 4.5;
      else if (v == "A0") grade = 4.0;
      else if (v == "B+") grade = 3.5;
      else if (v == "B0") grade = 3.0;
      else if (v == "C+") grade = 2.5;
      else if (v == "C0") grade = 2.0;
      else if (v == "D+") grade = 1.5;
      else if (v == "D0") grade = 1.0;
      else grade = 0.0;

      return grade;
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      txt1.Text = "인체의구조와기능I";
      txt2.Text = "일반수학I";
      txt3.Text = "전기전자회로공학및실험";
      txt4.Text = "데이터사이언스";
      txt5.Text = "비주얼프로그래밍";
      txt6.Text = "설계및프로젝트기본I";
      txt7.Text = "영어";
      txt8.Text = "교양";

      // 학점 콤보박스의 배열
      crds = new ComboBox[] { crd1, crd2, crd3, crd4,
        crd5, crd6, crd7, crd8 };

      // 성적 콤보박스의 배열
      grds = new ComboBox[] { grd1, grd2, grd3, grd4, 
        grd5, grd6, grd7, grd8 };

      // 교과목 텍스트박스의 배열
      titles = new TextBox[] { txt1,  txt2, txt3, txt4, 
        txt5, txt6, txt7, txt8 };


      // 학점을 콤보박스에 표시하기 위해 배열을 만든다
      int[] arr = { 1, 2, 3, 4, 5 };

      // 성적을 콤보박스에 표시하기 위해 리스트를 만든다
      List<string> list = new List<string>{"A+", "A0", "B+",
        "B0", "C+", "C0", "D+", "D0", "F" };

      // 학점 콤보박스 처리
      foreach(var c in crds)
      {
        foreach(var i in arr)
          c.Items.Add(i);
        c.SelectedItem = 3;
      }

      // 성적 콤보박스 처리
      foreach (var c in grds)
      {
        foreach (var s in list)
          c.Items.Add(s);
        c.SelectedItem = "A+";
      }
    }
  }
}
