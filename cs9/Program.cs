using System;
using System.Net.Http;

const string DEFAULT_URL = "https://raw.githubusercontent.com/keyprog/dotnet-lab/master/README.md";

string url = args?.Length > 0 ? args[0] : DEFAULT_URL;
string response = await new HttpClient().GetStringAsync(url);

Console.WriteLine(response);

Console.WriteLine(new MyData("Alex","123"));

record MyData (string Name, string Code);