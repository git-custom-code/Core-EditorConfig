namespace CustomCode.Core.EditorConfig
{
    public sealed class DeconstructedVariableDeclaration
    {
        public void ShowCase()
        {
            // csharp_style_deconstructed_variable_declaration = true
            var (foo, bar) = GetFoo();
            var result = foo;

            // csharp_style_deconstructed_variable_declaration = false
            var tuple = GetFoo();
            result = tuple.foo;
        }

        private (int foo, int bar) GetFoo()
        {
            return (42, 42);
        }
    }
}