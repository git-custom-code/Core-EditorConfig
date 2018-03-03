namespace CustomCode.Core.EditorConfig
{
    public sealed class InlinedVariableDeclaration
    {
        public void ShowCase()
        {
            // csharp_style_inlined_variable_declaration = true:error
            if (TryParseFoo(out var foo))
            {
            }

            // csharp_style_inlined_variable_declaration = false:error
            int bar;
            if (TryParseFoo(out bar))
            {
            }
        }

        private bool TryParseFoo(out int foo)
        {
            foo = 0;
            return true;
        }
    }
}