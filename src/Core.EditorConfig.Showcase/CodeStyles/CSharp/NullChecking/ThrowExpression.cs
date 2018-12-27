namespace CustomCode.Core.EditorConfig
{
    using System;

    public sealed class ThrowExpression
    {
        public void ShowCase()
        {
            var foo = (int?)0;
            var bar = (int?)42;

            // csharp_style_throw_expression = true:error
            foo = bar ?? throw new ArgumentNullException(nameof(bar));

            // csharp_style_throw_expression = false:error
            if (bar == null)
            {
                throw new ArgumentNullException(nameof(bar));
            }

            foo = bar;
        }
    }
}