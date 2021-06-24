using NumberWorder.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberWorder.Services
{
    public class MapNumberService : IMapNumberService
    {
        private readonly Dictionary<int, string> _mappedNumbers;

        public MapNumberService()
        {
            _mappedNumbers = new Dictionary<int, string>()
            {
                 { 0,"ZERO" }
                ,{ 1,"ONE" }
                ,{ 2,"TWO" }
                ,{ 3,"THREE" }
                ,{ 4,"FOUR" }
                ,{ 5,"FIVE" }
                ,{ 6,"SIX" }
                ,{ 7,"SEVEN" }
                ,{ 8,"EIGHT" }
                ,{ 9,"NINE" }
            };
        }

        public void MapNumber(int[] numbers)
        {
            foreach (var number in numbers)
            {
                if (_mappedNumbers.ContainsKey(number))
                {
                    var foundItem = _mappedNumbers.FirstOrDefault(q => q.Key == number);
                    Console.Write(foundItem.Value);
                }
            }
        }
    }
}
