namespace CustomCode.Core.EditorConfig
{
    public sealed class PreferredModifierOrder
    {
        // csharp_preferred_modifier_order = public,private,protected,internal,static,extern,new,virtual,abstract,sealed,override,readonly,unsafe,volatile,async:suggestion
        private static void Foo()
        { }

        static private void Bar()
        { }
    }
}