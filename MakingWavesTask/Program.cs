using System;

namespace MakingWavesTask
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var inputProcessor = new InputProcessor();
                var periodObject = inputProcessor.ProcessInput(args);

                var outputGenerator = new DateResolver();
                var result = outputGenerator.dateToString(periodObject);

                Console.WriteLine(result);
            }
            catch (Exception inputException)
            {
                Console.WriteLine(inputException.Message);
            }

        }
    }
}
