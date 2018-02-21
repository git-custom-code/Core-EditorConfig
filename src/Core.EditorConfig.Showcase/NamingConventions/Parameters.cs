namespace CustomCode.Core.EditorConfig.Parameters
{
    public class Foo
    {
        public void Bar(int parameter)
        { }

        public void Baz(int Parameter)
        { }

        public void BarBaz(int _parameter) // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
        { }
    }
}