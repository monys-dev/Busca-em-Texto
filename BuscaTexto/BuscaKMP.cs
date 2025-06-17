using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTexto {
    class BuscaKMP {
        static int[] next = new int[1000];

        public static void initNext(String p) {
            int i = 0, j = -1, m = p.Length;
            next[0] = -1;
            while (i < m) {
                while (j >= 0 && p[i] != p[j])
                    j = next[j];
                i++;
                j++;
                next[i] = j;
            }
        }

        public static Tuple<int, int> KMPSearch(String p, String t) {
            int i = 0, j = 0, m = p.Length, n = t.Length;
            int totalTestes = 0;
            initNext(p);
            while (j < m && i < n) {
                while (j >= 0 && (totalTestes++ >=0 && t[i] != p[j])) {
                    j = next[j];
                }
                i++;
                j++;
            }
            if (j == m)
                return Tuple.Create(i - m, totalTestes);
            else
                return Tuple.Create(-1, totalTestes);
        }
    }
}
