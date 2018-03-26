[package-url]:   https://www.nuget.org/packages/ES.FX.Vies
[package-image]: https://img.shields.io/nuget/v/ES.FX.Vies.svg
[build-url]:     https://sintari.visualstudio.com/ES.FX
[build-image]:   https://sintari.visualstudio.com/_apis/public/build/definitions/34e057ec-f09f-4d30-92f4-5895eeaa3f74/10/badge
[wiki-url]:      https://github.com/EmberStack/ES.FX.Vies/wiki

# ES.FX.Vies [![build][build-image]][build-url] [![package][package-image]][package-url]
.NET client for the VIES - European Commission - VAT validation service


## Installation
Package Manager:
```shell
Install-Package ES.FX.Vies
```
.NET CLI:
```shell
dotnet add package ES.FX.Vies
```


## Usage
Checking a VAT number using the VIES service
```csharp
var vatService = new VatCheckService();
var result = await vatService.CheckAsync(new VatCheckRequest {CountryCode = "RO", VatNumber = "1234567"});    
```


## Documentation
Additional documentation may be found in the [Project Wiki][wiki-url]
