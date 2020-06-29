using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace test_csharp_program {
    /// <summary>
    /// テストプログラム本体
    /// </summary>
    class Program {
        /// <summary>
        /// テストプログラム本体のメイン処理
        /// </summary>
        /// <param name="args">コマンドライン引数</param>
        static void Main(string[] args) {
            ulong m = 0;
            ulong n = 0;
            string errMsg = "コマンドライン引数には、2つの整数値(負の数不可)を指定してね！";

            if (args.Length != 2) {
                //コマンドライン引数が2つでない場合、エラーで終了
                Console.Error.WriteLine(errMsg);
                Console.Error.WriteLine("指定された引数の数 : " + args.Length.ToString());
                for (int i = 0; i < args.Length; i++) {
                    Console.Error.WriteLine("指定された引数(" + i.ToString() + "個目) : " + args[i]);
                }
                Environment.Exit(0);
            } else if (ulong.TryParse(args[0], out m) == false || ulong.TryParse(args[1], out n) == false) {
                //コマンドライン引数に0以上の整数値以外が指定されている場合、エラーで終了
                Console.Error.WriteLine(errMsg);
                Console.Error.WriteLine("指定された引数(1個目) : " + args[0]);
                Console.Error.WriteLine("指定された引数(2個目) : " + args[1]);
                Environment.Exit(0);
            }

            cEuclidAlgorithm oEuclid = new cEuclidAlgorithm();
            string msg = m.ToString() + "と" + n.ToString() + "の";

            if (m != 0 || n != 0) {
                Console.WriteLine(msg + "最大公約数 : " + oEuclid.getGCD(m, n));
            } else {
                Console.WriteLine(msg + "最大公約数は求めらないよ！");
            }

            Console.WriteLine(msg + "最小公倍数 : " + oEuclid.getLCM(m, n));
        }
    }
}
