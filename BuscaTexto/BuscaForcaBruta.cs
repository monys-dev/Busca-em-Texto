﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTexto {
    class BuscaForcaBruta {

        private static bool coringa = false;
        public static void setCoringa(bool c) {
            coringa = c;
        }

        public static Tuple<int, int> forcaBruta(String p, String t) {
            int i, j, aux;
            int m = p.Length;
            int n = t.Length;
            int totalTestes = 0;
            for (i = 0; i < n; i++) {
                aux = i;
                for (j = 0; j < m && aux < n; j++) {
                    totalTestes++;
                    if (t[aux] != p[j] && (coringa ? p[j] != '?' : true))
                        break;
                    aux++;
                }
                if (j == m)
                    return Tuple.Create(i, totalTestes);
            }
            return Tuple.Create(-1, totalTestes);
        }
    }
}
