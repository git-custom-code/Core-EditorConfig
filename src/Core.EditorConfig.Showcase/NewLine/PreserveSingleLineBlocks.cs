namespace CustomCode.Core.EditorConfig
{
    public sealed class PreserveSingleLineBlocks
    {
        public void ShowCase()
        {
            // csharp_preserve_single_line_blocks = true
            { var x = 0; }

            // csharp_preserve_single_line_blocks = false
            {
                var x = 0;
            }
        }
    }
}