// New minimalistic way of writing C# code in .NET 6
using System.Net;

// DarkWeb DuckDuckGo v3 website url
Uri url = new("https://duckduckgogg42xjoc72x3sjasowoarfbgcmvfimaftt6twagswzczad.onion");

HttpClient client = new(new HttpClientHandler
{
    // Magic happens with socks scheme used below
    Proxy = new WebProxy("socks5://127.0.0.1:9050")
});
Console.WriteLine(await client.GetStringAsync(url));

