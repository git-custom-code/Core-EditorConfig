using System;

namespace CustomCode.Core.EditorConfig
{
    public sealed class LocalOverAnonymousFunction
    {
        public void Showcase()
        {
            // csharp_style_pattern_local_over_anonymous_function = true
            // Note: requires c# 7.1
            int LocalFunction()
            {
                return 42;
            }
            var foo = LocalFunction();

            // csharp_style_pattern_local_over_anonymous_function = false
            Func<int> func = () => { return 42; };
            foo = func();
        }
    }
}