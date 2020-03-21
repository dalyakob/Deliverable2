using System;

namespace Deliverable2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string input, message = "Your encoded message is ";
            int checkSum =0;

            Console.WriteLine("What is your message?");
            input = Console.ReadLine().ToUpper();

            


            int i = 0;
            foreach (char temp in input)
            {
                message += ((int)temp - 64).ToString();
                checkSum += (int)temp; 
                i++;

                if (i < input.Length)
                    message += "-" ;
            }

            Console.WriteLine(message);
            Console.WriteLine("Message checksum is " + checkSum);



        }
    }
}
