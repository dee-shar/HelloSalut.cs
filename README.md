# HelloSalut.cs
Web-API for [hellosalut.stefanbohacek.com](hellosalut.stefanbohacek.com) get hello translation following user language

## Example
```cs
using HelloSalutApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new HelloSalut();
            string salut = await api.GetSalutByLanguage("ja");
            Console.WriteLine(salut);
        }
    }
}
```
