namespace Paraminter.Arguments.CSharp.Method.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

/// <summary>Represents syntactic data about a C# method argument.</summary>
public interface ICSharpMethodArgumentData
{
    /// <summary>The syntactic data about the C# method argument.</summary>
    public abstract ArgumentSyntax SyntacticArgument { get; }
}
