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
        public static AttributeSyntax Attribute(this ISyntaxGenerator _,
            string name)
        {
            var nameSyntax = _.Name(name);

            var output = SyntaxFactory.Attribute(nameSyntax);
            return output;
        }

        public static IdentifierNameSyntax IdentifierName(this ISyntaxGenerator _,
           string name)
        {
            var output = SyntaxFactory.IdentifierName(name);
            return output;
        }

        public static IdentifierNameSyntax Name(this ISyntaxGenerator _,
            string name)
        {
            var output = _.IdentifierName(name);
            return output;
        }
    }
}


namespace R5T.N0001.Generation.Initial.Simple
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static CompilationUnitSyntax CompilationUnit(this ISyntaxGenerator _)
        {
            var output = Instances.SyntaxGenerator_Simple.CompilationUnit();
            return output;
        }

        public static InterfaceDeclarationSyntax Interface(this ISyntaxGenerator _,
            string interfaceTypeName)
        {
            var output = SyntaxFactory.InterfaceDeclaration(interfaceTypeName);
            return output;
        }

        public static NamespaceDeclarationSyntax Namespace(this ISyntaxGenerator _,
            string namespaceName)
        {
            var output = Instances.SyntaxGenerator_Simple.Namespace(namespaceName);
            return output;
        }
    }
}