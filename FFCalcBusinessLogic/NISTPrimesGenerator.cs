using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FFCalcBusinessLogic
{
    public static class NISTPrimesGenerator
    {
        public static BigInteger GetP192()
        {
            return BigInteger.Pow(2, 192) - BigInteger.Pow(2, 64) - BigInteger.One;
        }

        public static BigInteger GetP224()
        {
            return BigInteger.Pow(2, 224) - BigInteger.Pow(2, 96) + BigInteger.One;
        }

        public static BigInteger GetP256()
        {
            return BigInteger.Pow(2, 256) - BigInteger.Pow(2, 224) + BigInteger.Pow(2, 192) + BigInteger.Pow(2, 96) - BigInteger.One;
        }

        public static BigInteger GetP384()
        {
            return BigInteger.Pow(2, 384) - BigInteger.Pow(2, 128) - BigInteger.Pow(2, 96) + BigInteger.Pow(2, 32) - BigInteger.One;
        }

        public static BigInteger GetP521()
        {
            return BigInteger.Pow(2, 521) - BigInteger.One;
        }
    }
}
