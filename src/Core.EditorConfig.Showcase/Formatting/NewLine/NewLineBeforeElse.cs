namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeElse
    {
        public void ShowCase()
        {
            var foo = false;

            // csharp_new_line_before_else = true
            if (foo)
            {
            }
            else
            {
            }

            // csharp_new_line_before_else = false
            if (foo)
            {
            } else
            {
            }
        }
    }
}