//UC-1-Given a Message, ability to analyse and respond Happy or Sad Mood
namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message;
            Random random = new Random();
            int mood = random.Next(2);

            if (mood == 1)
            {
                message = "Happy";
            }
            else
            {
                message = "Sad";

            }
            Console.WriteLine(MoodAnalyzer.analyzeMood(message));
            Console.ReadLine();
        }
    }
}