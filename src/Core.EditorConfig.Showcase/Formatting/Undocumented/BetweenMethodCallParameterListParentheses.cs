namespace CustomCode.Core.EditorConfig
{
    public sealed class BetwwenMethodCallParameterListParentheses
    {
        public void ShowCase()
        {
            object foo = null;
            object bar = null;

            // csharp_space_between_method_call_empty_parameter_list_parentheses = true
            var result = foo.Equals( bar );

            // csharp_space_between_method_call_empty_parameter_list_parentheses = false
            result = foo.Equals(bar);
        }
    }
}