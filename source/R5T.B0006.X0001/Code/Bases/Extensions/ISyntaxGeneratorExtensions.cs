using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

using R5T.B0006;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

using Instances = R5T.B0006.X0001.Instances;


namespace System
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static SyntaxList<AttributeListSyntax> AttributeLists(this ISyntaxGenerator _)
        {
            var output = new SyntaxList<AttributeListSyntax>();
            return output;
        }

        public static AttributeListSyntax AttributeList(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.AttributeList();
            return output;
        }
    }
}


namespace R5T.N0001.Generation.Initial.Simple
{
    public static partial class ISyntaxGeneratorExtensions
    {

    }
}