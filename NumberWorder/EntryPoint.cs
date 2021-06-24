using NumberWorder.Abstract;
using System;

namespace NumberWorder
{
    public class EntryPoint
    {
        private readonly IMapNumberService _mapNumberService;
        private readonly IDigitSeperatorService _digitSeperatorService;
        public EntryPoint(
                  IMapNumberService mapNumberService
                , IDigitSeperatorService digitSeperatorService
            )
        {
            _mapNumberService = mapNumberService;
            _digitSeperatorService = digitSeperatorService;
        }

        public void Run(string[] args)
        {
            Console.WriteLine("Please enter the nmbers.");

            string numbers = Console.ReadLine();

            int.TryParse(numbers, out int parsedInt);
            if (parsedInt != 0)
            {
                var digits = _digitSeperatorService.GetIntArray(parsedInt);
                _mapNumberService.MapNumber(digits);
            }
        }
    }
}
