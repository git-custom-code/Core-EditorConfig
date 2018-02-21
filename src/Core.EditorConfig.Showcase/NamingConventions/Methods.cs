namespace CustomCode.Core.EditorConfig.Methods
{
    using System.Threading.Tasks;

    public class Foo
    {
        public void Bar()
        { }

        public void baz()
        { }

        public void _bar() // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
        { }

        public void Bar_Baz() // no way to prevent this currently (see https://github.com/dotnet/roslyn/issues/18409)
        { }

        public async Task<int> BarAsync()
        {
            var result = await Task.FromResult(0);
            return result;
        }

        public async Task<int> Bar2()
        {
            var result = await Task.FromResult(0);
            return result;
        }
    }
}