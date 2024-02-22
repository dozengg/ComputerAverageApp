namespace ComputerAvaregeApp
{
    class ComputerAverageProgram
    {
        private static double gradess,Average, round;

        static void Main(string[] args) {

            Console.WriteLine("Enter 5 grades separeted by a new line ");
            for(int i = 0; i <5 ; i++) {

                  double grade = Convert.ToDouble(Console.ReadLine());

                gradess += grade;

                Average = gradess / 5;

                round = Math.Round(Average);
            }
           Console.WriteLine("The Average is " + Average + " and round off to " + round);
        }

          

    }
}
