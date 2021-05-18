using System;

namespace LCD_Display
{
    class Program
    {
        static void Main()
        {
            static void Standard()
            {
                //my array that contains the lcd dispaly for each letter in their correct position allowing for me to call on them when they need to be output 
                string[] LCDNum = { "\n |\n |", " _\n _|\n|_", " _\n _|\n _|", "\n|_|\n  |", " _\n|_\n _|", " _\n|_\n|_|", " _\n  |\n  |", " _ \n|_|\n|_|", " _ \n|_|\n _|", " _ \n| |\n|_|" };
                Console.WriteLine("Please enter the numbers you want to convert to LCD:");
                string input = Console.ReadLine();//takes the users input for the number on the lcd 
                for (int i = 0; i < input.Length; i++)//gets each number the users inputs seperately
                {
                    int temp = (int)char.GetNumericValue(input[i]);//changes the input from a string to an integer to allow me to find it in the array 
                    Console.WriteLine(LCDNum[temp - 1]);//writes the LCD in the console 
                }
            }
            static void VarSize() //current;y only working for numbers 1 and 2
            {
                Console.WriteLine("Please enter the numbers you want to convert to LCD:");//gets all the information required from the user 
                string input = Console.ReadLine();
                Console.WriteLine("Please enter the width:");
                string width = Console.ReadLine();
                Console.WriteLine("Please enter the height:");
                string height = Console.ReadLine();
                int h = Int32.Parse(height);//changes the users inputs for the width and height to integers 
                int w = Int32.Parse(width);
                string stringwidth = new string('_', w);//creates a line of the width as it will be usefull to have a line the complete width of the number
                for (int i = 0; i < input.Length; i++)//loops through the users input to get each number they want 
                {
                    int temp = (int)char.GetNumericValue(input[i]); //gets the int val of the input 
                    if((temp) == 1) 
                    {
                        for(int y = 0; y < h; y++)//loops through the height of the number and writes it as a vertical bar 
                        {
                            Console.WriteLine("|\n|"); //wites the line the amount of times the height is 
                        }
                    }
                    else if ((temp) == 2)
                    {
                        int gap = w - 1;//creates a variable that is the right width and has a certain gap to the right one off the end 
                        string spacer = new string(' ', gap); //turns this gap into spaces so i can write it correctly 
                        Console.WriteLine(stringwidth);//writes the complete width of the letter as dashes, as created before 
                        for (int y = 0; y < h; y++)//loops through the height
                        {
                            Console.WriteLine(spacer+"|");//moves the bar to the other side of the number
                        }
                        Console.WriteLine(stringwidth);//again writes the line all the way across 
                        for (int y = 0; y < h; y++)//loops the height again 
                        {
                            Console.WriteLine("|");//writes the bar without the space this time to create the 2 shape 
                        }
                        Console.WriteLine(stringwidth);//finall finishes with the line 
                    }
                }
            }
            Standard();//calls both the functions
            VarSize();
        }
    }
}
