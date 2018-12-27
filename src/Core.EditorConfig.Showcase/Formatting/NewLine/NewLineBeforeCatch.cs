namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeCatch
    {
        public void ShowCase()
        {
            // csharp_new_line_before_catch = true
            try
            {
            }
            catch
            {
            }

            // csharp_new_line_before_catch = false
            try
            {
            } catch
            {
            }
        }
    }
}