using System.Runtime.InteropServices;

namespace _017_array
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int[] a = new int[10];

      //for(int i=0; i<a.Length; i++)
      //{
      //  a[i] = int.Parse(Console.ReadLine());
      //}

      // 배열에 10개의 랜덤값을 저장하시오
      Random r = new Random();
      for (int i = 0; i < 10; i++)
        a[i] = r.Next(1000);

      // (1) 원소를 모두 출력하시오
      // (1)-1 인덱스를 사용하기
      for(int i=0; i<10; i++)
        Console.Write(a[i] + " ");
      Console.WriteLine();

      // (1)-2 foreach 사용
      foreach(var x  in a)
        Console.Write(x + " ");
      Console.WriteLine();

      // (2) 원소의 합을 출력하시오
      int sum = 0;
      for(int i=0; i<10; i++)
        sum += a[i];
      Console.WriteLine("합 = " + sum);

      int sum2 = 0;
      foreach (var x in a)
        sum2 += x;
      Console.WriteLine("합 = " + sum2);

      // (3) 가장 큰 값을 출력하시오
      int max = a[0];
      for (int i = 1; i < 10; i++)
        if (max < a[i])
          max = a[i];

      Console.WriteLine("최대값 = " + max);
    }
  }
}