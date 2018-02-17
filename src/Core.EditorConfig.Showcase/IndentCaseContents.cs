﻿namespace CustomCode.Core.EditorConfig
{
    public sealed class IndentCaseContents
    {
        public void ShowCase()
        {
            int foo;

            // csharp_indent_case_contents = true
            switch (foo)
            {
                case 42:
                    break;
                case 13:
                    break;
            }

            // csharp_indent_case_contents = false
            switch (foo)
            {
                case 42:
                break;
                case 13:
                break;
            }
        }
    }
}