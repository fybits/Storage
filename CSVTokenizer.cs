using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage {
    class CSVTokenizer {
        string line;
        int pos;
        bool isBetweenQuotes;

        public CSVTokenizer(string line) {
            this.line = line;
            pos = 0;
            isBetweenQuotes = false;
        }

        public bool HasNext() {
            return pos < line.Length;
        }

        public string NextToken() {
            string token = "";
            while (pos < line.Length) {
                char c = line[pos++];
                switch (c) {
                    case '"':
                        isBetweenQuotes = !isBetweenQuotes;
                        break;
                    case ',':
                        if (isBetweenQuotes) {
                            token += c;
                        } else {
                            return token;
                        }
                        break;
                    default:
                        token += c;
                        break;
                }
            }
            return token;
        }
    }
}
