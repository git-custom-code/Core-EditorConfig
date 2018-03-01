namespace CustomCode.Core.EditorConfig
{
    public sealed class AfterColonInInheritanceClause
    {
        private abstract class Foo
        { }

        // csharp_space_after_colon_in_inheritance_clause = true
        private class Bar : Foo
        { }

        // csharp_space_after_colon_in_inheritance_clause = false
        private class Baz :Foo
        { }
    }
}