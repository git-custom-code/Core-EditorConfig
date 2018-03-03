namespace CustomCode.Core.EditorConfig
{
    public sealed class RequireAccessibilityModifiers
    {
        // dotnet_style_require_accessibility_modifiers = always
        private const string Foo = "constant";

        // dotnet_style_require_accessibility_modifiers = never
        const string Bar = "constant";
    }
}