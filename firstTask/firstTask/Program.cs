namespace firstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            convertNumber cn = new convertNumber();
          int num = Convert.ToInt32(Console.ReadLine());
          string ans =   cn.convertNumberToWords(num);
            Console.WriteLine(ans);
        }
    }
}