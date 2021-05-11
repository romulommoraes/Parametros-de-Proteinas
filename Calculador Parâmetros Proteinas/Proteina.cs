using System;
using System.Collections.Generic;
using System.Text;

namespace ParametrosProteinas
{
    class Proteina
    {
        public Proteina(string head, string seq, int nA, double mW, double gravy)
        {
            this.head = head;
            this.seq = seq;
            this.nA = nA;
            this.mW = mW;
            this.gravy = gravy;
        }

        public string head { get; set; }
        public string seq { get; set; }
        public int nA { get; set; }
        public double mW { get; set; }
        public double gravy { get; set; }

        public int calcNa()
        {
            char[] na = this.seq.ToCharArray();
            return na.Length;
        }
        public double calcMW()
        {
            char[] ma = this.seq.ToCharArray();
            double peso = 18.02;//peso de uma molécula de água (faz parte da fórmula)

            foreach (char aa in ma)
            {
                switch (aa)
                {
                    case 'D':
                        peso = peso + 115.0886;
                        break;
                    case 'E':
                        peso = peso + 129.1155;
                        break;
                    case 'C':
                        peso = peso + 103.1388;
                        break;
                    case 'Y':
                        peso = peso + 163.1760;
                        break;
                    case 'H':
                        peso = peso + 137.1411;
                        break;
                    case 'K':
                        peso = peso + 128.1741;
                        break;
                    case 'R':
                        peso = peso + 156.1875;
                        break;
                    case 'M':
                        peso = peso + 131.1926;
                        break;
                    case 'F':
                        peso = peso + 147.1766;
                        break;
                    case 'L':
                        peso = peso + 113.1594;
                        break;
                    case 'V':
                        peso = peso + 99.1326;
                        break;
                    case 'A':
                        peso = peso + 71.0788;
                        break;
                    case 'G':
                        peso = peso + 57.0519;
                        break;
                    case 'Q':
                        peso = peso + 128.1307;
                        break;
                    case 'N':
                        peso = peso + 114.1038;
                        break;
                    case 'I':
                        peso = peso + 113.1594;
                        break;
                    case 'W':
                        peso = peso + 186.2132;
                        break;
                    case 'S':
                        peso = peso + 87.0782;
                        break;
                    case 'P':
                        peso = peso + 97.1167;
                        break;
                    case 'T':
                        peso = peso + 101.1051;
                        break;
                    case 'U':
                        peso = peso + 141.05;
                        break;
                    case 'Z':
                        peso = peso + 128.6231;
                        break;
                    case 'O':
                        peso = peso + 255.31;
                        break;
                    case 'B':
                        peso = peso + 114.5962;
                        break;
                    case 'J':
                        peso = peso + 113.1594;
                        break;
                    default:
                        break;
                }
            }

            peso = Math.Round(peso, 2);
            return peso;
        }

        public double calcGravy()
        {
            char[] ma = this.seq.ToCharArray();
            double gravy = 0;

            foreach (char aa in ma)
            {
                switch (aa)
                {
                    case 'D':
                        gravy = gravy - 3.5;
                        break;
                    case 'E':
                        gravy = gravy - 3.5;
                        break;
                    case 'C':
                        gravy = gravy + 2.5;
                        break;
                    case 'Y':
                        gravy = gravy - 1.3;
                        break;
                    case 'H':
                        gravy = gravy - 3.2;
                        break;
                    case 'K':
                        gravy = gravy - 3.9;
                        break;
                    case 'R':
                        gravy = gravy - 4.5;
                        break;
                    case 'M':
                        gravy = gravy + 1.9;
                        break;
                    case 'F':
                        gravy = gravy + 2.8;
                        break;
                    case 'L':
                        gravy = gravy + 3.8;
                        break;
                    case 'V':
                        gravy = gravy + 4.2;
                        break;
                    case 'A':
                        gravy = gravy + 1.8;
                        break;
                    case 'G':
                        gravy = gravy - 0.4;
                        break;
                    case 'Q':
                        gravy = gravy - 3.5;
                        break;
                    case 'N':
                        gravy = gravy - 3.5;
                        break;
                    case 'I':
                        gravy = gravy + 4.5;
                        break;
                    case 'W':
                        gravy = gravy - 0.9;
                        break;
                    case 'S':
                        gravy = gravy - 0.8;
                        break;
                    case 'P':
                        gravy = gravy - 1.6;
                        break;
                    case 'T':
                        gravy = gravy - 0.7;
                        break;
                    case 'U':
                        gravy = gravy + 0;
                        break;
                    case 'Z':
                        gravy = gravy + 0;
                        break;
                    case 'O':
                        gravy = gravy + 0;
                        break;
                    case 'B':
                        gravy = gravy + 0;
                        break;
                    case 'J':
                        gravy = gravy + 0;
                        break;
                    default:
                        break;
                }
            }
            gravy = Math.Round(gravy / ma.Length, 3);
            return gravy;
        }

        public override string ToString()
        {
            return $"Proteina: {head}, NºAa: {nA}, mW(D): {mW} , Gravy: {gravy} \n Sequencia: {seq} \n";
        }
        public string ToCSV()
        {
            return $"{head}\t{nA}\t{mW}\t{gravy}\t{seq}";
        }
    }
}
