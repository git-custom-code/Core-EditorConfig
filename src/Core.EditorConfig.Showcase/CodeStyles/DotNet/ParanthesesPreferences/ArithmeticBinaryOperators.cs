namespace CustomCode.Core.EditorConfig
{
    public sealed class ArithmeticBinaryOperators
    {
        public void Showcase()
        {
            // dotnet_style_parentheses_in_arithmetic_binary_operators = always_for_clarity
            var result = 1 + (2 * 3);

            // dotnet_style_parentheses_in_arithmetic_binary_operators = never_if_unnecessary
            result = 1 + 2 * 3;
        }
    }
}