using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum<T> where T : IComparable
    {
        public T fNumber, sNumber, thirdNumber;

        public Maximum(T fNumber, T sNumber, T thirdNumber)
        {
            this.fNumber = fNumber;
            this.sNumber = sNumber;
            this.thirdNumber = thirdNumber;
        }
        public static T Maximum1(T fNumber, T sNumber, T thirdNumber)
        {
            if ((fNumber.CompareTo(sNumber) > 0 && fNumber.CompareTo(thirdNumber) > 0) ||
                (fNumber.CompareTo(sNumber) >= 0 && fNumber.CompareTo(thirdNumber) > 0) ||
                (fNumber.CompareTo(sNumber) > 0 && fNumber.CompareTo(thirdNumber) >= 0))
            {
                return fNumber;
            }

            if ((sNumber.CompareTo(fNumber) > 0 && sNumber.CompareTo(thirdNumber) > 0) ||
               (sNumber.CompareTo(fNumber) >= 0 && sNumber.CompareTo(thirdNumber) > 0) ||
               (sNumber.CompareTo(fNumber) > 0 && sNumber.CompareTo(thirdNumber) >= 0))
            {
                return sNumber;
            }


            if ((thirdNumber.CompareTo(fNumber) > 0 && thirdNumber.CompareTo(sNumber) > 0) ||
               (thirdNumber.CompareTo(fNumber) >= 0 && thirdNumber.CompareTo(sNumber) > 0) ||
               (thirdNumber.CompareTo(fNumber) > 0 && thirdNumber.CompareTo(sNumber) >= 0))
            {
                return thirdNumber;
            }
            return fNumber;
        }

        public T maxvalue()
        {
            T max = Maximum<T>.Maximum1(this.fNumber, this.sNumber, this.thirdNumber);
            return max;
        }




        }
    }
