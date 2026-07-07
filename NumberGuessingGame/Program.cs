namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberGuessing numberGuessing = new NumberGuessing();
            numberGuessing.GenerateRandomNumber(1, 100);
        }
    }
}
