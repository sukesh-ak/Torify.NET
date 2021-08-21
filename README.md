# TORIFY.NET 6.0
A sample showing how to connect & browse DarkWeb .onion websites using .NET 6.0 in 6 lines of C# code.  
*Keep in mind this is the new minimalistic way of writing C# code in .NET 6*
## .NET 6.0 Preview 5 added SOCKS proxy support!
SOCKS is a proxy server implementation that can process any TCP or UDP traffic, making it a very versatile system. The implementation is made easier by just using WebProxy by using socks schemes. Also supports Socks4, Socks4a and Socks5.

```c#
// Below code snippet shows how to add Socks5 support in code using .NET 6.0
var handler = new HttpClientHandler
{
    Proxy = new WebProxy("socks5://127.0.0.1", 9050)
};
var httpClient = new HttpClient(handler);
```

Thank you [Huo Yaoyan](https://github.com/huoyaoyuan) for the implementation.

## How to connect to .onion websites through Tor using .NET 6.0
Please read the detailed accompanying article which explains the steps and also tips on how to setup Tor for connecting from your .NET application.


> Article link here on my blog => [Blog Article on sukesh.me](https://sukesh.me/2021/08/22/how-to-browse-darkweb-using-net-6/)

