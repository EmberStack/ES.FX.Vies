# ES.FX.Vies - Overview
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
This gulp plugin supports converting .resx files to multiple file types.
```csharp
var vatService = new VatCheckService();
var result = await vatService.CheckAsync(new VatCheckRequest {CountryCode = "RO", VatNumber = "1234567"});    
```

## Documentation
Additional documentation may be found at https://github.com/EmberStack/ES.FX.Vies/wiki


## Packages & Status
EmberStack Frameworks contain multiple packages. For information about each package please follow the links
---
Package  | Build status | NuGet 
-------- | :------------ | :------------ 
ES.FX.Vies | [![VSTS](https://sintari.visualstudio.com/_apis/public/build/definitions/34e057ec-f09f-4d30-92f4-5895eeaa3f74/10/badge)](https://sintari.visualstudio.com/ES.FX) |  [![NuGet](https://img.shields.io/nuget/v/ES.FX.Vies.svg)](https://www.nuget.org/packages/ES.FX.Vies)
