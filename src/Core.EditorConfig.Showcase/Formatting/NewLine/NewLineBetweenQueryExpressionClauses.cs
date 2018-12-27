namespace CustomCode.Core.EditorConfig
{
    using System.Linq;
    using System.Collections.Generic;

    public sealed class NewLineBetweenQueryExpressionClauses
    {
        public void ShowCase()
        {
            var xs = new List<int>(4);

            // csharp_new_line_between_query_expression_clauses = true
            var result = from x in xs
                         select x;

            // csharp_new_line_between_query_expression_clauses = false
            result = from x in xs select x;
        }
    }
}