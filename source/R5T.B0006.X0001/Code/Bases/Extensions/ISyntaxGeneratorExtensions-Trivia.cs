using System;
using System.Collections.Generic;

using Microsoft.CodeAnalysis;

using R5T.B0006;

using SyntaxFactory = Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

using Instances = R5T.B0006.X0001.Instances;


namespace System
{
    public static partial class ISyntaxGeneratorExtensions
    {
        public static SyntaxTrivia EndOfLine(this ISyntaxGenerator _,
            string endOfLineText)
        {
            var output = SyntaxFactory.EndOfLine(endOfLineText);
            return output;
        }

        /// <summary>
        /// Uses the <see cref="Environment.NewLine"/> value.
        /// </summary>
        public static SyntaxTrivia EndOfLine_Environment(this ISyntaxGenerator syntaxGenerator)
        {
            var output = syntaxGenerator.EndOfLine(Environment.NewLine);
            return output;
        }

        public static SyntaxTrivia EndOfLine_Windows(this ISyntaxGenerator syntaxGenerator)
        {
            var output = syntaxGenerator.EndOfLine(Instances.Strings.NewLine_Windows);
            return output;
        }

        public static SyntaxTrivia EndOfLine_NonWindows(this ISyntaxGenerator syntaxGenerator)
        {
            var output = syntaxGenerator.EndOfLine(Instances.Strings.NewLine_NonWindows);
            return output;
        }

        /// <summary>
        /// Chooses <see cref="EndOfLine_Environment(ISyntaxGenerator)"/> as the default.
        /// </summary>
        public static SyntaxTrivia EndOfLine(this ISyntaxGenerator syntaxGenerator)
        {
            var output = syntaxGenerator.EndOfLine_Environment();
            return output;
        }

        public static IEnumerable<SyntaxTrivia> GetNewLines_Enumerable(this ISyntaxGenerator syntaxGenerator,
            int newLineCount)
        {
            var tab = syntaxGenerator.NewLine();

            for (int i = 0; i < newLineCount; i++)
            {
                yield return tab;
            }
        }

        public static SyntaxTriviaList GetNewLines_SyntaxTriviaList(this ISyntaxGenerator syntaxGenerator,
            int newLineCount)
        {
            var output = new SyntaxTriviaList(
                syntaxGenerator.GetNewLines_Enumerable(newLineCount));

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetNewLines_Enumerable(ISyntaxGenerator, int)"/> as the default.
        /// </summary>
        public static IEnumerable<SyntaxTrivia> GetNewLines(this ISyntaxGenerator syntaxGenerator,
            int newLineCount)
        {
            return syntaxGenerator.GetNewLines_Enumerable(newLineCount);
        }

        public static IEnumerable<SyntaxTrivia> GetTabs_Enumerable(this ISyntaxGenerator syntaxGenerator,
            int tabCount)
        {
            var tab = syntaxGenerator.Tab();

            for (int i = 0; i < tabCount; i++)
            {
                yield return tab;
            }
        }

        public static SyntaxTriviaList GetTabs_SyntaxTriviaList(this ISyntaxGenerator syntaxGenerator,
            int tabCount)
        {
            var output = new SyntaxTriviaList(
                syntaxGenerator.GetTabs_Enumerable(tabCount));

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetTabs_Enumerable(ISyntaxGenerator, int)"/> as the default.
        /// </summary>
        public static IEnumerable<SyntaxTrivia> GetTabs(this ISyntaxGenerator syntaxGenerator,
            int tabCount)
        {
            return syntaxGenerator.GetTabs_Enumerable(tabCount);
        }

        /// <summary>
        /// Note, new line is the same as <see cref="EndOfLine(ISyntaxGenerator)"/>.
        /// </summary>
        public static SyntaxTrivia NewLine(this ISyntaxGenerator syntaxGenerator)
        {
            var output = syntaxGenerator.EndOfLine();
            return output;
        }

        public static SyntaxTrivia Space(this ISyntaxGenerator _)
        {
            var output = Instances.SyntaxGenerator_Simple.Space();
            return output;
        }

        public static SyntaxTrivia Tab(this ISyntaxGenerator _)
        {
            var output = SyntaxFactory.Tab;
            return output;
        }
    }
}
