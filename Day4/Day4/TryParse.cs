namespace Day4
{
    internal class TryParse
    {
        static void Main1(string[] args)

        {
            // Parse 

            string Number = "100";
            /* int ParseNumber = int.Parse(Number);
             Console.WriteLine(Number);  
            Console.WriteLine(ParseNumber); 
            */


            // Try parse

            bool ISInt  = int.TryParse(Number, out int ParsedNumber);

            if(ISInt)
            {
                Console.WriteLine("The Number is parsed"+ParsedNumber);
            }
            else {

                Console.WriteLine("The Number is not parsed"+ParsedNumber);

            }
        }
    }
}