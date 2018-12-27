namespace CustomCode.Core.EditorConfig
{
    public sealed class NewLineBeforeFinally
    {
        public void ShowCase()
        {
            // csharp_new_line_before_finally = true
            try
            {
            }
            catch
            {
            }
            finally
            {
            }

            // csharp_new_line_before_finally = false
            try
            {
            }
            catch
            {
            } finally
            {
            }
        }
    }
}