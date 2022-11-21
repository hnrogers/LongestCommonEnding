using System.Text;

class Working
{
    public string? CommonEnding(string a, string b)
    {
        StringBuilder ending = new StringBuilder();

        for (int i = 0; i < (a.Length <= b.Length ? a.Length : b.Length); i++)
        {
            if (a[(a.Length - 1) - i] == b[(b.Length - 1) - i])
            {
                ending.Insert(0, a[(a.Length - 1) - i]);
            }

            else 
            {
                break;
            }
        }
        return ending.ToString();
    }
}