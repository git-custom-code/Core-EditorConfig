namespace CustomCode.Core.EditorConfig
{
    public sealed class ExpressionBodiedConstructors
    {
        // csharp_style_expression_bodied_constructors = true:error
        public ExpressionBodiedConstructors() => Foo = 42;

        // csharp_style_expression_bodied_constructors = false:error
        public ExpressionBodiedConstructors(int bar)
        {
            Foo = bar;
        }

        private int Foo { get; set; }
    }
}