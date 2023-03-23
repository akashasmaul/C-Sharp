namespace Interface_Quiz_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Implementation cal = new Implementation();
            cal.Addition(5, 3);
            cal.Subtract(5, 3);
            cal.Multiply(5, 3);
            cal.Divide(10, 2);

            cal.Power(5, 2);
            cal.Root(144);

            cal.ShowInfo();
        }
    }
}