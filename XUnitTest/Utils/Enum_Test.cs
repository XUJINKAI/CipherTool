﻿using CipherTool.AST;
using CipherTool.Tokenizer;
using Xunit;
using Xunit.Abstractions;

namespace CipherTool.Test.Utils
{
    public class Enum_Test : TestBase
    {
        public Enum_Test(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void EnumCast()
        {
            Assert.True(TokenType.Txt.CastToEnum<PrintFormat>() != null);
            Assert.True(TokenType.Txt.CastToEnum<HashAlgr>() == null);
        }
    }
}