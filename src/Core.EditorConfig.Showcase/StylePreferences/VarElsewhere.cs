namespace CustomCode.Core.EditorConfig
{
    public sealed class VarElsewhere
    {
        private class Foo
        { }

        public void ShowCase()
        {
            // csharp_style_var_elsewhere = true:error
            var foo = ToFoo();

            // csharp_style_var_elsewhere = false:error
            Foo bar = ToFoo();
        }

        private Foo ToFoo()
        {
            return null;
        }
    }
}