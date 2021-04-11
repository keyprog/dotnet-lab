using System;
using System.Net.Http;

string response = await new HttpClient().GetStringAsync("https://raw.githubusercontent.com/keyprog/dotnet-lab/master/README.md");

Console.WriteLine(response);
