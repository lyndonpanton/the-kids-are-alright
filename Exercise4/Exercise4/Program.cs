namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kid kid = new Kid();
            Happy happy = new Happy();
            Adventurous adventurous = new Adventurous();

            kid.PrintMessage();
            happy.PrintMessage();
            adventurous.PrintMessage();
        }
    }
}