namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentSwitchLabels
    {
        public void ShowCase()
        {
            var foo = 0;

            // csharp_indent_switch_labels = true
            switch (foo)
            {
                case 42:
                    break;
                case 13:
                    break;
            }

            // csharp_indent_switch_labels = false
            switch (foo)
            {
            case 42:
                break;
            case 13:
                break;
            }
        }
    }
}