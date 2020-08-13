# About
This POC domonstrate how the XPO Dotnet Core API SDK would work.

# XPO API SDK (Dotnet Core)

.NET SDK for XPO Connect oAuth API that is usable from the following frameworks:
 -   .NET Framework 4.5
-   .NET Core 1.0 or above

Prerequisites
-   Visual Studio 2017
-   .NET Core SDK (if running .NET Core samples)
-  X-API-Key
- Client Id
- Client Secret


## Quick Start

### Installation

Install the SDK using Nuget

PM> Install-Package XPO.Connect.Util.API.SDK -Version 1.0.0

### oAuth API
 User can generate JWT token using oAuth API, that last for 2 hours.
 
 

 - Step 1: Add below name spaces in your code.

         using XPO.Connect.Util.API.SDK;

  
  - Step 2:  Create OAuth API class instance by passing "X-API-Key".

      var oauthApi = new OAuthAPI("X-API-Key");

- Step 3: Call oAuthAPI's GenerateToken Method by passing "Client_Id" and "Client_Secret".
  
        

    var Response = await oauthApi.GenerateToken("Client_Id", "Client_Secret");

