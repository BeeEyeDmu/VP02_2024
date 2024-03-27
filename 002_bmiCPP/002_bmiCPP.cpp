// 002_bmiCPP.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
using namespace std;

int main()
{
  double w, h;

  cout << "체중(kg) : ";
  cin >> w;
  cout << "키(cm) : ";
  cin >> h;

  double bmi = w / ((h / 100) * (h / 100));
  cout << "BMI = " << bmi << endl;
  
}
