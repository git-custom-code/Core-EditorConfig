namespace CustomCode.Core.EditorConfig
{
    public sealed class AroundBinaryOperators
    {
        public void ShowCase()
        {
            // csharp_space_around_binary_operators  = before_and_after
            var foo = 42 + 42;

            // csharp_space_around_binary_operators  = ignore
            foo = 42+    42;

            // csharp_space_around_binary_operators  = none
            foo = 42+42;
        }
    }
}