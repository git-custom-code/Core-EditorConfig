namespace CustomCode.Core.EditorConfig
{
    public sealed class BetweenMethodDeclarationEmptyParameterListParentheses
    {
        // csharp_space_between_method_declaration_empty_parameter_list_parentheses = true
        public void Foo( )
        {
        }

        // csharp_space_between_method_declaration_empty_parameter_list_parentheses = false
        public void Bar()
        {
        }
    }
}