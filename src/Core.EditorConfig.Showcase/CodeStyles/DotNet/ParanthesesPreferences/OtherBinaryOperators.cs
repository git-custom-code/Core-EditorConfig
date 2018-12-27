namespace CustomCode.Core.EditorConfig
{
    public sealed class OtherBinaryOperators
    {
        public void Showcase()
        {
            // dotnet_style_parentheses_in_other_binary_operators = always_for_clarity
            var result = true || (true && false);

            // dotnet_style_parentheses_in_other_binary_operators = never_if_unnecessary
            result = true || true && false;
        }
    }
}