namespace Paraminter.Arguments.CSharp.Method.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Arguments.Models;

/// <summary>Represents syntactic data about a normal C# method argument.</summary>
public interface INormalCSharpMethodArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the normal C# method argument.</summary>
    public abstract ArgumentSyntax SyntacticArgument { get; }
}
