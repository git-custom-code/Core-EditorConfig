namespace CustomCode.Core.EditorConfig
{
    using System.Collections.Generic;

    public sealed class VarWhenTypeIsApparent
    {
        public void ShowCase()
        {
            // csharp_style_var_when_type_is_apparent = true:error
            var foo = new List<int>();

            // csharp_style_var_when_type_is_apparent = false:error
            List<int> bar = new List<int>();
        }
    }
}