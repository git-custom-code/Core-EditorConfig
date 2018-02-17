namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentLabels
    {
        public void ShowCase()
        {
            // csharp_indent_labels = flush_left
flush_left:
            var x = 42;

            // csharp_indent_labels = one_less_than_current
        one_less_than_current:
            var y = 42;

            // csharp_indent_labels = no_change
            no_change:
            var z = 42;
        }
    }
}