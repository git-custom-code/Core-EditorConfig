namespace CustomCode.Core.EditorConfig
{
    public sealed class CoalesceExpression
    {
        public void ShowCase()
        {
            int? bar = null;
            int? baz = 0;

            // dotnet_style_coalesce_expression = true:error
            var foo = bar ?? baz;

            // dotnet_style_coalesce_expression = false:error
            foo = bar != null ? bar : baz;
        }
    }
}