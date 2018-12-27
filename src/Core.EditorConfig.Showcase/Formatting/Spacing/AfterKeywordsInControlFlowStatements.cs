namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterKeywordsInControlFlowStatements
    {
        public void ShowCase()
        {
            var foo = true;

            // csharp_space_after_keywords_in_control_flow_statements = true
            if (foo)
            {
            }

            while (foo)
            {
            }

            // csharp_space_after_keywords_in_control_flow_statements = false
            if(foo)
            {
            }

            while(foo)
            {
            }
        }
    }
}