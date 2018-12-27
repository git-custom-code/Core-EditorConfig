namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferInferredAnonymousTypeMemberNames
    {
        public void ShowCase()
        {
            var foo = 0;
            var bar = 0;

            // dotnet_style_prefer_inferred_anonymous_type_member_names = true
            var anon = new { foo, bar };

            // dotnet_style_prefer_inferred_anonymous_type_member_names = false
            anon = new { foo = foo, bar = bar };
        }
    }
}