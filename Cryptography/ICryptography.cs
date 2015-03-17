using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    interface ICryptography
    {
        byte[] Encrypt(string data);
        string Decrypt(byte[] data);
    }
}