namespace CustomCode.Core.EditorConfig
{
    using System;

    public sealed class PredefinedTypeForLocalsParametersMembers
    {
        // dotnet_style_predefined_type_for_locals_parameters_members = true:error
        public void Foo(int bar)
        { }

        // dotnet_style_predefined_type_for_locals_parameters_members = false:error
        public void Bar(Int32 bar)
        { }
    }
}