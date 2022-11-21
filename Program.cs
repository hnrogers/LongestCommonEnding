
namespace LongestCommonEnding
{
    class Primary
    {
        public static void Main()
        {
            Working work = new Working();

            Console.WriteLine(work.CommonEnding("multiplication", "ration"));   
            Console.WriteLine(work.CommonEnding("potent", "tent"));   
            Console.WriteLine(work.CommonEnding("skyscraper", "carnivore"));     
        }
    }
}