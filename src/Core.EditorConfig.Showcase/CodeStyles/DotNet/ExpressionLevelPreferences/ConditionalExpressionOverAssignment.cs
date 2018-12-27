namespace CustomCode.Core.EditorConfig
{
    public sealed class ConditionalExpressionOverAssignment
    {
        public void Showcase(bool condition)
        {
            // dotnet_style_prefer_conditional_expression_over_assignment = true
            var foo = condition ? "foo" : "bar";

            // dotnet_style_prefer_conditional_expression_over_assignment = false
            string bar;
            if (condition)
            {
                bar = "foo";
            }
            else
            {
                bar = "bar";
            }
        }
    }
}