namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentBraces
    {
        public void ShowCase()
        {
            var foo = false;

            // csharp_indent_braces = true
            if (foo)
                {
                var bar = 42;
                }

            // csharp_indent_braces = false
            if (foo)
            {
                var bar = 42;
            }
        }
    }
}