namespace CustomCode.Core.EditorConfig
{
    public sealed class NullCheckOverReferenceEquals
    {
        public void Showcase()
        {
            object foo = null;

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = true
            if (foo is null)
            {
                return;
            }

            // dotnet_style_prefer_is_null_check_over_reference_equality_method = false
            if (object.ReferenceEquals(foo, null))
            {
                return;
            }
        }
    }
}