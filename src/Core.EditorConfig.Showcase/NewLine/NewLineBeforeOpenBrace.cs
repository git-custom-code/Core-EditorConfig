namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeOpenBrace
    {
        // csharp_new_line_before_open_brace = all
        public void Foo()
        {
            if (true)
            {
            }
        }

        // csharp_new_line_before_open_brace = methods
        public void Bar()
        {
            if (true) {
            }
        }

        // csharp_new_line_before_open_brace = methods,control_blocks
        public void Baz()
        {
            if (true)
            {
            }
        }

        // ...
    }
}