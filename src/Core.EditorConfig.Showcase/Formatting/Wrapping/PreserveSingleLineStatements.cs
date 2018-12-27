namespace CustomCode.Core.EditorConfig
{
    public sealed class PreserveSingleLineStatements
    {
        public void ShowCase()
        {
            // csharp_preserve_single_line_statements = true
            if (true) { var x = 42; }

            // csharp_preserve_single_line_statements = false
            if (true)
            {
                var x = 42;
            }
        }
    }
}