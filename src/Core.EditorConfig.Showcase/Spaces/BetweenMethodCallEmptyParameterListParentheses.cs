namespace CustomCode.Core.EditorConfig
{
    public sealed class BetweenMethodCallEmptyParameterListParentheses
    {
        public void ShowCase()
        {
            object foo = null;

            // csharp_space_between_method_call_empty_parameter_list_parentheses = true
            var result = foo.ToString( );

            // csharp_space_between_method_call_empty_parameter_list_parentheses = false
            result = foo.ToString();
        }
    }
}