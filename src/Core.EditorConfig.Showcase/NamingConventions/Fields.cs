namespace CustomCode.Core.EditorConfig.Fields
{
    public sealed class Foo
    {
        private int _bar;

        private int Bar;

        private int baz;

        public const int ConstBar = 42;

        public const int constBaz = 42;

        public const int _constBar = 42; // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
    }
}