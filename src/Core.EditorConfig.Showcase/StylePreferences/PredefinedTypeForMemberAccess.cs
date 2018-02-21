namespace CustomCode.Core.EditorConfig
{
    using System;

    public sealed class PredefinedTypeForMemberAccess
    {
        public void ShowCase()
        {
            // dotnet_style_predefined_type_for_member_access = true:error
            var foo = int.MinValue;

            // dotnet_style_predefined_type_for_member_access = false:error
            foo = Int32.MinValue;
        }
    }
}