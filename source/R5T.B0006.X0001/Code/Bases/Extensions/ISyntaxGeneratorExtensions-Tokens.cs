using System;

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

using R5T.B0006;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

using Instances = R5T.B0006.X0001.Instances;


namespace System
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static SyntaxToken Abstract(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.AbstractKeyword);
            return output;
        }

        public static SyntaxToken Async(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.AsyncKeyword);
            return output;
        }

        public static SyntaxToken Const(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.ConstKeyword);
            return output;
        }

        public static SyntaxToken Extern(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.ExternKeyword);
            return output;
        }

        public static SyntaxToken Internal(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.InternalKeyword);
            return output;
        }

        public static SyntaxToken Override(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.OverrideKeyword);
            return output;
        }

        public static SyntaxToken Partial(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.PartialKeyword);
            return output;
        }

        public static SyntaxToken Private(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.PrivateKeyword);
            return output;
        }

        public static SyntaxToken Protected(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.ProtectedKeyword);
            return output;
        }

        public static SyntaxToken Public(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.PublicKeyword);
            return output;
        }

        public static SyntaxToken ReadOnly(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.ReadOnlyKeyword);
            return output;
        }

        public static SyntaxToken Sealed(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.SealedKeyword);
            return output;
        }

        public static SyntaxToken Static(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.StaticKeyword);
            return output;
        }

        public static SyntaxToken Unsafe(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.UnsafeKeyword);
            return output;
        }

        public static SyntaxToken Virtual(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.VirtualKeyword);
            return output;
        }

        public static SyntaxToken Volatile(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Token(SyntaxKind.VolatileKeyword);
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
