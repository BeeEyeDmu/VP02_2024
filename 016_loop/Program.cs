namespace _016_loop
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // 1에서 100까지의 합
      int sum = 0;
      for(int i=1; i<=100; i++)
      {
        sum += i;
      }
      Console.WriteLine("1~100까지의 합 = " + sum);

      // x에서 y까지의 합
      int sumXy = 0;

      Console.Write("x : ");
      int x = int.Parse(Console.ReadLine());
      Console.Write("y : ");
      int y = int.Parse(Console.ReadLine());

      for (int i = x; i <= y; i++)
      {
        sumXy += i;
      }
      Console.WriteLine("{0}~{1}까지의 합 = {2}", x, y,sumXy);

      // 1에서 100까지의 홀수의 합
      int oddSum = 0;
      for (int i = x; i <= y; i++)
      {
        if( i%2 == 1)
          oddSum += i;
      }
      Console.WriteLine("{0}~{1}까지의 홀수 합 = {2}", x, y, oddSum);

      // 1에서 100까지의 역수의 합
      double reciSum = 0;
      for (int i = x; i <= y; i++)
      {
          reciSum += 1.0/i;
      }
      Console.WriteLine("{0}~{1}까지의 역수 합 = {2}", x, y, reciSum);

      // (43장) x에서 y까지 합, 홀수 합, 역수 합\

      // (45장) 구구단
      for(int yy=1; yy<=9; yy++)
      {
        for (int xx = 2; xx <= 9; xx++)
          Console.Write("{0}x{1}={2}\t", xx, yy, xx * yy);
        Console.WriteLine();
      }

      // (47장) a의 b승 = a를 b번 곱한다
      int pow = 1;

      Console.Write("a = ");
      int a = int.Parse(Console.ReadLine());
      Console.Write("b = ");
      int b = int.Parse(Console.ReadLine());

      for (int i = 0; i < b; i++)
        pow *= a;

      Console.WriteLine("{0}의 {1}승 = {2}", a, b, pow);

      // (53장) 팩토리얼
      int fact = 1;

      Console.Write("n = ");
      int n = int.Parse(Console.ReadLine());

      for (int i = 1; i <= n; i++)
        fact *= i;

      Console.WriteLine("{0}! = {1}", n, fact);
    }
  }
}