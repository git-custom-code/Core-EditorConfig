namespace CustomCode.Core.EditorConfig
{
    public sealed class ConditionalExpressionOverReturn
    {
        public string Foo(bool condition)
        {
            // dotnet_style_prefer_conditional_expression_over_return = true
            return condition ? "foo" : "bar";
        }

        public string Bar(bool condition)
        {
            // dotnet_style_prefer_conditional_expression_over_return = false
            if (condition)
            {
                return "foo";
            }
            else
            {
                return "bar";
            }
        }
    }
}