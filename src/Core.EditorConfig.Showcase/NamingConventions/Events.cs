namespace CustomCode.Core.EditorConfig.Events
{
    using System;

    public class Foo
    {
        public event Action Bar;

        public event Action baz;

        public event Action _bar; // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)

        public event Action Bar_Baz; // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
    }
}