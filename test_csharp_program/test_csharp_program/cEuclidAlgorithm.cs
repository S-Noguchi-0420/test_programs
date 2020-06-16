//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace test_csharp_program {
    /// <summary>
    /// ユークリッドの互除法
    /// </summary>
    class cEuclidAlgorithm {
        /// <summary>
        /// コンストラクタ(処理なし)
        /// </summary>
        public cEuclidAlgorithm() {
        }

        /// <summary>
        /// mとnの最大公約数を求める
        /// </summary>
        /// <param name="m">0以上の整数</param>
        /// <param name="n">0以上の整数</param>
        /// <returns>mとnの最大公約数</returns>
        public ulong getGCD(ulong m, ulong n) {
            while (n != 0) {
                ulong r = m % n;
                m = n;
                n = r;
            }
            return m;
        }

        /// <summary>
        /// mとnの最小公倍数を求める<br />
        /// </summary>
        /// <param name="m">0以上の整数</param>
        /// <param name="n">0以上の整数</param>
        /// <returns>mとnの最小公倍数</returns>
        public ulong getLCM(ulong m, ulong n) {
            if (m != 0 || n != 0) {
                //GCD(m, n) * LCM(m, n) = m * n
                return m * n / getGCD(m, n);
            } else {
                //0と0の最小公倍数は0
                return 0;
            }
        }
    }
}
