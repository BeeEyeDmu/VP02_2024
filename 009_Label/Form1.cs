using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _009_Label
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string raffello = "라파엘로 산치오 다 우르비노" + 
        "(이탈리아어: Raffaello Sanzio da Urbino, " + 
        "1483년 4월 6일 ~ 1520년 4월 6일)";
      string schoolOfAthens = "아테네 학당(이탈리아어: Scuola" +
        " di Atene)은 화가 라파엘로의 프레스코화로 1510 ~ 1511년에" +
        " 바티칸 사도 궁전 내부의 방들 가운데 교황의 개인 서재인 서명의" +
        " 방에 교황 율리오 2세를 위해 만들어졌다. " +
        "이 그림은 연작의 한 부분으로 아테네 학당 옆에는 신성한 성단식의" +
        " 논의( 성체논의, Disputa del Sacramento )와 추덕을 " +
        "보여주는 파르나소스산을 표현했다. 그림의 제목은 고대 " +
        "그리스의 뛰어난 철학적 사고 학당을 나타내고, 그들의 선구자, " +
        "주요 대표자 및 후계자를 구현해냈다. 중심에는 철학자 플라톤과 " +
        "아리스토텔레스가 있다. 이 프레스코는 르네상스 정신 속에 유럽 " +
        "문화, 그들의 철학 그리고 학문의 기원에 대한 고대 사상을 찬양한다.";

      label1.Text = raffello;
      label2.Text = schoolOfAthens;
    }


    private void Form1_Load(object sender, EventArgs e)
    {
      label1.Text = "";
      label2.Text = "";
    }
  }
}
