using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public class Tokens2: IEnumerable
    {
        private string[] elemnets;

        Tokens2(string source, char[] delimiters)
        {
            elemnets = source.Split(delimiters);
        }

        public TokenEnumerator GetEnumerator()
        {
            return new TokenEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)new TokenEnumerator(this);
        }

        public class TokenEnumerator: IEnumerator
        {
            private int position = -1;
            private Tokens2 t;

            public TokenEnumerator(Tokens2 t)
            {
                this.t = t;
            }

            public bool MoveNext()
            {
                if(position < t.elemnets.Length - 1)
                {
                    position++;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                position = -1;
            }

            public string Current
            {
                get
                {
                    return t.elemnets[position];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return t.elemnets[position];
                }
            }
        }

        static void Main()
        {
            Tokens2 f = new Tokens2("This is a well-done program.",
    new char[] { ' ', '-' });
            foreach (string item in f) // try changing string to int
            {
                Console.WriteLine(item);
            }

        }

    }
}
