namespace CustomCode.Core.EditorConfig
{
    using System;

    public sealed class QualificationForEvent
    {
        public void ShowCase()
        {
            // dotnet_style_qualification_for_event = true:error
            this.FooHappened += OnFoo;

            // dotnet_style_qualification_for_event = false:error
            FooHappened += OnFoo;
        }

        private event Action FooHappened;

        private void OnFoo()
        { }
    }
}