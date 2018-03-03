namespace CustomCode.Core.EditorConfig
{
    public sealed class VarForBuildInTypes
    {
        public void ShowCase()
        {
            // csharp_style_var_for_built_in_types = true:error
            var foo = ToString();

            // csharp_style_var_for_built_in_types = false:error
            string bar = ToString();
        }
    }
}