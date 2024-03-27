namespace _003_bmiCS
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double w, h;

      Console.Write("체중(kg) : ");
      w = double.Parse(Console.ReadLine());

      Console.Write("키(cm) : ");
      h = double.Parse(Console.ReadLine());

      double bmi = w / ((h / 100) * (h / 100));
      Console.WriteLine("BMI = " + bmi);
    }
  }
}