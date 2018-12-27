namespace CustomCode.Core.EditorConfig
{
    public sealed class ExplicitTupleNames
    {
        public void ShowCase()
        {
            // dotnet_style_explicit_tuple_names = true:error
            (int foo, int bar) data = (0, 0);
            var foo = data.foo;

            // dotnet_style_explicit_tuple_names = false:error
            data = (0, 0);
            foo = data.Item1;
        }
    }
}