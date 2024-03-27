// 001_bmiC.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <stdio.h>

int main()
{
  double w, h;  // 체중, 키

  printf("체중(kg) : ");
  scanf_s("%lf", &w);

  printf("키(cm) : ");
  scanf_s("%lf", &h);

  double bmi = w / ((h/100) * (h/100));
  printf("BMI = %f\n", bmi);
}
