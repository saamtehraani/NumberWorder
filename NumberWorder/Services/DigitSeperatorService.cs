using NumberWorder.Abstract;
using System.Collections.Generic;

namespace NumberWorder.Services
{
    public class DigitSeperatorService : IDigitSeperatorService
    {
        public int[] GetIntArray(int num)
        {
            List<int> listOfInts = new();
            while (num > 0)
            {
                listOfInts.Add(num % 10);
                num /= 10;
            }
            listOfInts.Reverse();
            return listOfInts.ToArray();
        }
    }
}
