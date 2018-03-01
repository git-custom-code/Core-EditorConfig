namespace CustomCode.Core.EditorConfig
{
    public sealed class BetwwenMethodDeclarationParameterListParentheses
    {
        // csharp_space_between_method_declaration_parameter_list_parentheses = true
        public void Foo( int bar )
        {
        }

        // csharp_space_between_method_declaration_parameter_list_parentheses = false
        public void Bar(int foo)
        {
        }
    }
}