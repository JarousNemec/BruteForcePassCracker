using System;
using System.Linq;
using System.Threading;

namespace BruteForcePassCracker
{
    public class Brutus
    {
        private char[] _crackedPass;
        private string _findingPass;

        public Brutus(string pass)
        {
            _crackedPass = new char[pass.Length];
            _findingPass = pass;
            _crackedPass[^1] = 'a';
        }

        public void Crack()
        {
            while (_findingPass != new string(_crackedPass))
            {
                if (_crackedPass[^1] == 'z')
                {
                    RollCounterOver(_crackedPass.Length - 2);
                    _crackedPass[^1] = 'a';
                    continue;
                }

                _crackedPass[^1]++;
            }
        }

        private void RollCounterOver(int index)
        {
            if (_crackedPass[index] == 'z' || _crackedPass[index] < 'a')
            {
                if (_crackedPass[index] < 'a')
                {
                    _crackedPass[index] = 'a';
                    return;
                }

                if (_crackedPass[index] + 1 > 'z')
                {
                    RollCounterOver(index - 1);
                    _crackedPass[index] = 'a';
                    return;
                }
            }

            _crackedPass[index]++;
        }
    }
}