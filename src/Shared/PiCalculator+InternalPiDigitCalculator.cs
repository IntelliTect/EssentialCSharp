using System;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared
{
    public partial class PiCalculator
    {
        internal static class InternalPiDigitCalculator
        {
            #region Modulus
            private static int MultiplyModulus(long left, long right, int modulus)
            {
                return (int)((left * right) % modulus);
            }

            // return the inverse of x mod y
            private static int InverseModulus(int left, int right)
            {
                int q;
                int u = left;
                int v = right;
                int a = 0;
                int c = 1;
                int t;

                do
                {
                    q = v / u;

                    t = c;
                    c = a - q * c;
                    a = t;

                    t = u;
                    u = v - q * u;
                    v = t;
                }
                while (u != 0);

                a %= right;
                if (a < 0) a = right + a;

                return a;
            }

            // return (a^b) mod m
            private static int PowerModulus(int left, int right, int modulus)
            {
                int r = 1;
                int aa = left;

                while (true)
                {
                    if ((right & 0x01) != 0) r = MultiplyModulus(r, aa, modulus);
                    right >>= 1;
                    if (right == 0) break;
                    aa = MultiplyModulus(aa, aa, modulus);
                }

                return r;
            }
            #endregion

            #region Primes
            // return true if num is prime
            private static bool IsPrime(int num)
            {
                // not prime if divisible by two
                if ((num % 2) == 0) return false;

                int max = (int)(Math.Sqrt(num));
                for (int i = 3; i <= max; i += 2)
                {
                    if ((num % i) == 0) return false;
                }

                return true;
            }

            // return the prime number immediately after num
            private static int NextPrime(int num)
            {
                do
                {
                    num++;
                }
                while (!IsPrime(num));

                return num;
            }
            #endregion

            public static int ComputeSection(int startingDigit)
            {
                int av;
                int vmax;
                int N = (int)((startingDigit + 20) * Math.Log(10) / Math.Log(2));
                int num;
                int den;
                int kq;
                int kq2;
                int t;
                int v;
                int s;
                double sum = 0.0;

                for (int a = 3; a <= (2 * N); a = NextPrime(a))
                {
                    vmax = (int)(Math.Log(2 * N) / Math.Log(a));
                    av = 1;

                    for (int i = 0; i < vmax; ++i) av *= a;

                    s = 0;
                    num = 1;
                    den = 1;
                    v = 0;
                    kq = 1;
                    kq2 = 1;

                    for (int k = 1; k <= N; ++k)
                    {
                        t = k;
                        if (kq >= a)
                        {
                            do
                            {
                                t /= a;
                                --v;
                            }
                            while ((t % a) == 0);

                            kq = 0;
                        }

                        ++kq;
                        num = MultiplyModulus(num, t, av);

                        t = (2 * k - 1);
                        if (kq2 >= a)
                        {
                            if (kq2 == a)
                            {
                                do
                                {
                                    t /= a;
                                    ++v;
                                }
                                while ((t % a) == 0);
                            }

                            kq2 -= a;
                        }

                        den = MultiplyModulus(den, t, av);
                        kq2 += 2;

                        if (v > 0)
                        {
                            t = InverseModulus(den, av);
                            t = MultiplyModulus(t, num, av);
                            t = MultiplyModulus(t, k, av);

                            for (int i = v; i < vmax; ++i)
                            {
                                t = MultiplyModulus(t, a, av);
                            }
                            s += t;
                            if (s >= av) s -= av;
                        }
                    }

                    t = PowerModulus(10, startingDigit - 1, av);
                    s = MultiplyModulus(s, t, av);
                    sum = (sum + (double)s / (double)av) % 1.0;
                }

                return (int)(sum * 1e9);
            }
        }
    }
}