namespace CustomCode.Core.EditorConfig
{
    public sealed class BeforeSemicolonInForStatement
    {
        public void ShowCase()
        {
            // csharp_space_before_semicolon_in_for_statement = true
            for (var foo = 0 ; foo < 10 ; ++foo)
            {
            }

            // csharp_space_before_semicolon_in_for_statement = false
            for (var foo = 0; foo < 10; ++foo)
            {
            }
        }
    }
}