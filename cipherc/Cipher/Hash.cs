﻿using System;
using System.Collections.Generic;
using System.Text;
using Org.BouncyCastle.Crypto.Digests;

namespace CipherTool.Cipher
{
    public static class Hash
    {
        public static Data MessageDigest<T>(Data data) where T : GeneralDigest
        {
            var digest = Activator.CreateInstance<T>();
            digest.BlockUpdate(data, 0, data.Length);
            var output = new byte[digest.GetDigestSize()];
            digest.DoFinal(output, 0);
            return output;
        }

        public static Data SM3(Data data) => MessageDigest<SM3Digest>(data);
        public static Data MD5(Data data) => MessageDigest<MD5Digest>(data);
        public static Data SHA1(Data data) => MessageDigest<Sha1Digest>(data);
        public static Data SHA256(Data data) => MessageDigest<Sha256Digest>(data);
    }
}
