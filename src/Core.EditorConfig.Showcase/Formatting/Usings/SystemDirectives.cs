namespace CustomCode.Core.EditorConfig.Foo
{ }

namespace CustomCode.Core.EditorConfig
{
    // dotnet_sort_system_directives_first = true
    using System;
    using Foo;

    // dotnet_sort_system_directives_first = false
    using Foo;
    using System;

    public sealed class SystemDirectives
    { }
}