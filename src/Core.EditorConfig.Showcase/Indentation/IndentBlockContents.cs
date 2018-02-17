namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentBlockContents
    {
        public void ShowCase()
        {
            bool foo;

            // csharp_indent_block_contents = true
            if (foo)
            {
                var bar = 42;
            }

            // csharp_indent_block_contents = false
            if (foo)
            {
            var bar = 42;
            }
        }
    }
}