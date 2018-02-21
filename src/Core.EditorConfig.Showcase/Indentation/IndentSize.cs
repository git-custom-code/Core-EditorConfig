namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentSize
    {
        public void ShowCase()
        {
            var foo = false;

            // indent_size = 4
            if (foo)
            {
                var bar = 42;
            }

            // indent_size = 2
            if (foo)
            {
              var bar = 42;
            }
        }
    }
}