namespace CustomCode.Core.EditorConfig
{
    public sealed class AroundDeclarationStatements
    {
        public void ShowCase()
        {
            // csharp_space_around_declaration_statements = ignore
            var    foo  =    42;

            // csharp_space_around_declaration_statements = do_not_ignore
            foo = 42;
        }
    }
}