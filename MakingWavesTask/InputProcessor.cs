using System;

namespace MakingWavesTask
{
    public class InputProcessor
    {
        private InputValidator _inputValidator;
        private InputOrderValidator _inputOrderValidator;
        private InputQuantityValidator _inputQuantityValidator;
        private InputConverter _inputConverter;
        public InputProcessor()
        {
            this._inputValidator = new InputValidator();
            this._inputOrderValidator = new InputOrderValidator();
            this._inputQuantityValidator = new InputQuantityValidator();
            this._inputConverter = new InputConverter();
        }

        public Period ProcessInput(string[] args)
        {
            bool areTwoArguments = _inputQuantityValidator.QuantityOfArgs(args);
            if (!areTwoArguments)
                throw new Exception("Number of arguments is not correct.");
            string inputFirstDate = args[0];
            string inputSecondDate = args[1];
            isItValidDateCheck(inputFirstDate);
            isItValidDateCheck(inputSecondDate);
            DateTime startDate = _inputConverter.Converter(inputFirstDate);
            DateTime endDate = _inputConverter.Converter(inputSecondDate);
            bool isOrderDateValid = _inputOrderValidator.Order(startDate, endDate);
            if (!isOrderDateValid)
                throw new Exception("Second date is before first date.");
            return new Period(startDate, endDate);
        }
        private void isItValidDateCheck(string input)
        {
            bool isItValidDate = _inputValidator.Validator(input);
            if (!isItValidDate)
                throw new Exception($"{input} is not a date in proper format.");
        }

    }
}