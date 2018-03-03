namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedOperators
    {
        // csharp_style_expression_bodied_operators = true:error
        public static int operator +(ExpressionBodiedOperators first, ExpressionBodiedOperators second) => first.Value + second.Value;

        // csharp_style_expression_bodied_operators = false:error
        public static int operator -(ExpressionBodiedOperators first, ExpressionBodiedOperators second)
        {
            return first.Value + second.Value;
        }

        private int Value { get; set; }
    }
}