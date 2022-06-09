using System;

using R5T.Z0000;

using ISyntaxGenerator_Simple = R5T.F0004.ISyntaxGenerator;


namespace R5T.B0006.X0001
{
    public static class Instances
    {
        public static ISyntaxGenerator_Simple SyntaxGenerator_Simple { get; } = F0004.SyntaxGenerator.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
    }
}
