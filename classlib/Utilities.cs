


namespace Utilities
{
    public class Text
    {
        /// <summary>Takes In text and a color, writes that text in that color. Sets text back to white when done. </summary>
        
        static public void ChangeTextColor(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }/// <summary>Takes In text 2 colors, writes that text in the first color. Sets all procedeing text to the second color. </summary>
        static public void ChangeTextColor2(string text, ConsoleColor color, ConsoleColor returnColor = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = returnColor;
        }
        
    }
}