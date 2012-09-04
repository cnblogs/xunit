using System;
using System.Collections.Generic;

namespace Xunit.Abstractions
{
    /// <summary>
    /// Represents information about a type. The primary implementation is based on runtime
    /// reflection, but may also be implemented by runner authors to provide non-reflection-based
    /// test discovery (for example, AST-based runners like CodeRush or Resharper).
    /// </summary>
    public interface ITypeInfo
    {
        /// <summary>
        /// Gets the base type of the given type.
        /// </summary>
        ITypeInfo BaseType { get; }

        /// <summary>
        /// Gets the interfaces implemented by the given type.
        /// </summary>
        IEnumerable<ITypeInfo> Interfaces { get; }

        /// <summary>
        /// Gets a value indicating whether the type is abstract.
        /// </summary>
        bool IsAbstract { get; }

        /// <summary>
        /// Gets a value indicating whether the type is sealed.
        /// </summary>
        bool IsSealed { get; }

        /// <summary>
        /// Gets the fully qualified type name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets all the custom attributes for the given type.
        /// </summary>
        /// <param name="attributeType">The type of the attribute</param>
        /// <returns>The matching attributes that decorate the type</returns>
        IEnumerable<IAttributeInfo> GetCustomAttributes(Type attributeType);

        /// <summary>
        /// Gets all the methods in this type.
        /// </summary>
        /// <param name="includePrivateMethods">Set to <c>true</c> to return all methods in the type,
        /// or <c>false</c> to return only public methods.</param>
        IEnumerable<IMethodInfo> GetMethods(bool includePrivateMethods);
    }
}
