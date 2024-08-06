namespace Paraminter.Arguments.CSharp.Method.Models;

using Microsoft.CodeAnalysis.CSharp.Syntax;

using Paraminter.Arguments.Models;

using System.Collections.Generic;

/// <summary>Represents syntactic data about <see langword="params"/> C# method arguments.</summary>
public interface IParamsCSharpMethodArgumentData
    : IArgumentData
{
    /// <summary>The syntactic data about the <see langword="params"/> C# method arguments.</summary>
    public abstract IReadOnlyList<ArgumentSyntax> SyntacticArguments { get; }
}
