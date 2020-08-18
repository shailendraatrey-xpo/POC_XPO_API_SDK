# XPO API SDK (Dotnet Core)

.NET SDK for XPO Connect oAuth API that is usable from the following frameworks:
 -   .NET Framework 4.5
-   .NET Core 1.0 or above

Prerequisites
-   Visual Studio 2017
-   .NET Core SDK (if running .NET Core )
-  X-API-Key
- Client Id
- Client Secret


## Quick Start

### Installation

Install the SDK using Nuget

PM> Install-Package XPO.Connect.Util.API.SDK -Version 1.0.1

### oAuth API
 User can generate JWT token using oAuth API, that last for 2 hours.
 
 

 - Step 1: Add below name spaces in your code.

     *using XPO.Connect.Util.API.SDK;*

   - Step 2:  Add appsettings.json file in your project and configure oAuthAPIKey, Client_Id & Client_Secret.

    *{
      "oAuthAPIKey": "X-API-Key",
      "client_id": "client_Id_value",
      "client-secret": "client_secret_value"
   }*
  
  - Step 3:  Create OAuth API class instance.

    *var oauthApi = new OAuthAPI();*

- Step 4: Call oAuthAPI's GenerateToken Method.          

*`var Response = await oauthApi.GenerateToken();`*

### Code Sample

    class Program
        {
            static void Main(string[] args)
            {
                Task.Run(() => CallTokenApi());
    
                Console.ReadLine();
            }
    
            static async void CallTokenApi()
            {
                 var oauthApi = new OAuthAPI();
                var Response = await oauthApi.GenerateToken();
               if (Response.StatusCode == HttpStatusCode.OK)
              {
                Console.WriteLine(await Response.Content.ReadAsStringAsync());
              }
             else
             {
                Console.WriteLine("Error while fetching data.");
             }
             
            }
        }

### Sample Response

    {
      "access_token": "eyJhbGciOiJSUzI1NiIsImtpZCI6IkU1OEQ3N0M3MEE2MkRCMUQwMDYwODRCNUNCREI0QkVBMUJGRjhGM0YiLCJ0eXAiOiJKV1QiLCJ4NXQiOiI1WTEzeHdwaTJ4MEFZSVMxeTl0TDZodl9qejgifQ.eyJuYmYiOjE1ODc1NzQxMDYsImV4cCI6MTU4NzU4MTMwNiwiaXNzIjoiaHR0cHM6Ly9sb2dpbi1zYW5kYm94LmF1dGh4cG8uY29tIiwiYXVkIjpbImh0dHBzOi8vbG9naW4tc2FuZGJveC5hdXRoeHBvLmNvbS9yZXNvdXJjZXMiLCJ4cG8tcmF0ZXMtYXBpIl0sImNsaWVudF9pZCI6Inhwby1rcmFmdC1oZWluei1pbnRlZ3JhdGlvbiIsInNjb3BlIjpbInhwby1yYXRlcy1hcGkiXX0.dnoOVJQdZTFTUIY8uWf4izO7gLmY8fIXZ4N7tlWMhxkZdk6uD8VtOoY8BaJodruSpYXD2qDDHBKQe0VN-VGFBOyjx1hBXt7MSNJM_KP9H66m1VVGouuO4NV9knhTogUK_Mmt4wsfUhpFhR6MZDPkDFkLI7RpajcOfqJCQE8w7dq_AWpcD8R1sWozWcuaJHZ9su0d6x_FIwbA58iZXi7Mw1iWBPi1uuemo3iL5sKyng8V5Pp3IPELUgTFxugtcIEkw9uw3NMcXhT6qLUzfjFaXGJMyxHY-P2VaCgrt6FURkltvef9kqd2_5mB-oJNB4CEqIw9QLOHcW62OnIoi_6Tiw",
      "expires_in": 7200,
      "token_type": "Bearer"
    }

## Documentation

Documentation for all XPO Connect APIs is available here
[XPO Connect APIs](https://apisolutions.xpo.com/docs/api-docs)
