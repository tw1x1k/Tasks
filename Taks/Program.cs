namespace Taks;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        var newText = GetFirstAndLastWord(text);
        Console.WriteLine(newText);
    }

    public static string GetFirstAndLastWord(string text)
    {
        string newText = "";
        
        for (int i = 0; i < text.Length; i++)
        {
            if (Convert.ToChar(text[i]) == ',' || Convert.ToChar(text[i]) == ' ' )
            {
                newText += " ";
                break;
            }
            newText += text[i];
        }

        string reverse = "";
        
        for (int i = text.Length-1; i >= 0; i--)
        {
            if (Convert.ToChar(text[i]) == ',' || Convert.ToChar(text[i]) == ' ' )
            {
                break;
            }
            reverse += text[i];
        }

        char[] array = reverse.ToCharArray();
        Array.Reverse(array);
        return newText + new string(array);
    }
    
    

}