namespace MakingWavesTask
{
    public class InputQuantityValidator
    {
        public bool QuantityOfArgs(string[] args)
        {
            if (args.Length != 2)
                return false;
            return true;
        }
    }
}
