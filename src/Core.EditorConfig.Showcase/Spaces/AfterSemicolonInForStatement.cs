namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterSemicolonInForStatement
    {
        public void ShowCase()
        {
            // csharp_space_after_semicolon_in_for_statement = true
            for (var foo = 0; foo < 10; ++foo)
            {
            }

            // csharp_space_after_semicolon_in_for_statement = false
            for (var foo = 0;foo < 10;++foo)
            {
            }
        }
    }
}