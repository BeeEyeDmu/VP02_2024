namespace _005_format
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
      Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}",
        2, 3, 5, 7);

      int x = 4;
      double y = 3.14159;

      Console.WriteLine("y = {1:F2}, x = {0}", x, y);

      string s = string.Format("x = {0}, y = {1:F2}", x, y);
      Console.WriteLine(s);
    }
  }
}