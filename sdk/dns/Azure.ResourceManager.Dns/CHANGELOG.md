# Release History

## 1.0.0 (2022-09-29)

This is the first stable release of the DNS Management library.

### Breaking Changes

- Renamed the model `RecordSetData` to `RecordSetData`.
- Renamed the method `GetAllRecordSets` to `GetAllRecordData`.
- Renamed properties `MaxNumberOfRecordSets`, `MaxNumberOfRecordsPerRecordSet` and `NumberOfRecordSets` in the model `DnsZoneData`.
- Removed the method `GetRecordSets`.

### Other Changes

- Upgraded dependent Azure.ResourceManager to 1.3.1.
- Optimized the implementation of methods related to tag operations.

## 1.0.0-beta.2 (2022-08-29)

### Breaking Changes

Polishing since last public beta release:
- Optimized the name of some resources, models and functions.
- Corrected the format of all `Guid` type properties / parameters.
- Corrected the format of all `ResourceIdentifier` type properties / parameters.
- Corrected the format of all `ResouceType` type properties / parameters.
- Corrected the format of all `ETag` type properties / parameters.
- Corrected the format of all `AzureLocation` type properties / parameters.
- Corrected the format of all binary type properties / parameters.
- Corrected all acronyms which not follow [.Net Naming Guidelines](https://docs.microsoft.com/dotnet/standard/design-guidelines/naming-guidelines).
- Corrected enumeration name by following [Naming Enumerations Rule](https://docs.microsoft.com/dotnet/standard/design-guidelines/names-of-classes-structs-and-interfaces#naming-enumerations).
- Corrected the suffix of `DateTimeOffset` properties / parameters.
- Corrected the name of interval / duration properties / parameters which end with units.

### Other Changes

- Upgraded dependent `Azure.ResourceManager` to 1.3.0

## 1.0.0-beta.1 (2022-07-12)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Dns` to `Azure.ResourceManager.Dns`

### Features Added

- Added ArmClient extension methods to support [start from the middle scenario](https://github.com/Azure/azure-sdk-for-net/tree/main/sdk/resourcemanager/Azure.ResourceManager#managing-existing-resources-by-id).

### General New Features

* Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET
* Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing
* HTTP pipeline with custom policies
* Better error-handling
* Support uniform telemetry across all languages
> NOTE: For more information about unified authentication, please refer to [Azure Identity documentation for .NET](https://docs.microsoft.com/dotnet/api/overview/azure/identity-readme?view=azure-dotnet)

### Management Client Changes

Before upgrade:

``` c#
using Microsoft.Rest;
using Microsoft.Azure.Management.Dns;
using Microsoft.Azure.Management.Dns.Models;
```

``` c#
var tokenCredentials = new TokenCredentials("YOUR ACCESS TOKEN");
DnsManagementClient dnsManagementClient = new DnsManagementClient(credentials);
var dnsZone = await dnsManagementClient.Zones.CreateOrUpdateAsync(resourceGroupName, dnsZoneName, zone);
```

After upgrade:

```C# Snippet:Manage_DnsZones_Namespaces
using System;
using System.Threading.Tasks;
using Azure.Identity;
using Azure.ResourceManager.Dns;
using Azure.ResourceManager.Resources;
using NUnit.Framework;
```

```C# Snippet:Managing_DnsZones_CreateADnsZones
ArmClient armClient = new ArmClient(new DefaultAzureCredential());
SubscriptionResource subscription = await armClient.GetDefaultSubscriptionAsync();
// first we need to get the resource group
string rgName = "myRgName";
ResourceGroupResource resourceGroup = await subscription.GetResourceGroups().GetAsync(rgName);
// Now we get the DnsZone collection from the resource group
DnsZoneCollection dnsZoneCollection = resourceGroup.GetDnsZones();
// Use the same location as the resource group
string dnsZoneName = "sample.com";
DnsZoneData data = new DnsZoneData("Global")
{
};
ArmOperation<DnsZoneResource> lro = await dnsZoneCollection.CreateOrUpdateAsync(WaitUntil.Completed, dnsZoneName, data);
DnsZoneResource dnsZone = lro.Value;
```
