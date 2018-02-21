namespace CustomCode.Core.EditorConfig.Properties
{
    public class Foo
    {
        public int Bar { get; }

        public int baz { get; }

        public int _bar { get; } // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)

        public int Bar_Baz { get; } // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
    }
}