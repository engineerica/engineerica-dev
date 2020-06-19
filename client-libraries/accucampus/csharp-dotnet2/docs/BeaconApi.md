# Org.OpenAPITools.Api.BeaconApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BeaconDelete**](BeaconApi.md#beacondelete) | **DELETE** /beacon/{id} | Delete a beacon profile
[**BeaconDisable**](BeaconApi.md#beacondisable) | **GET** /beacon/disable | Disable beacon support account wide
[**BeaconGet**](BeaconApi.md#beaconget) | **GET** /beacon/{id} | View details of a beacon profile
[**BeaconGetlocations**](BeaconApi.md#beacongetlocations) | **GET** /beacon/getlocations | Get the sign-in stations assigned to specific beacons.
[**BeaconGetstationlocation**](BeaconApi.md#beacongetstationlocation) | **GET** /beacon/getstationlocation | Get the location settings in the specified sign-in station.
[**BeaconGetuuid**](BeaconApi.md#beacongetuuid) | **GET** /beacon/getuuid | View the identifier for the account&#39;s beacon region (for sign-in stations).
[**BeaconList**](BeaconApi.md#beaconlist) | **GET** /beacon/list | View a list of beacon profiles
[**BeaconListprofiles**](BeaconApi.md#beaconlistprofiles) | **GET** /beacon/listprofiles | View a list of beacon profiles with their characteristics
[**BeaconResetuuid**](BeaconApi.md#beaconresetuuid) | **GET** /beacon/resetuuid | Generate or reset the identifier for the account&#39;s beacon region.
[**BeaconSave**](BeaconApi.md#beaconsave) | **POST** /beacon/{id} | Create or edit a beacon profile
[**BeaconScanlocations**](BeaconApi.md#beaconscanlocations) | **GET** /beacon/scanlocations | Check if there&#39;s location available to sign-in / out.
[**BeaconSetuuid**](BeaconApi.md#beaconsetuuid) | **GET** /beacon/setuuid | Set the identifier for the account&#39;s beacon region (for sign-in stations).
[**BeaconSilentregions**](BeaconApi.md#beaconsilentregions) | **GET** /beacon/silentregions | View all the beacon regions defined for silent tracking
[**BeaconSilentsignin**](BeaconApi.md#beaconsilentsignin) | **GET** /beacon/silentsignin | Sign-in silently from the location specified by a beacon
[**BeaconSilentsignout**](BeaconApi.md#beaconsilentsignout) | **GET** /beacon/silentsignout | Sign-out silently from the location specified by a beacon


<a name="beacondelete"></a>
# **BeaconDelete**
> void BeaconDelete (Guid? id, AnyType body)

Delete a beacon profile

Allows the user to delete an existing beacon profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var id = new Guid?(); // Guid? | The id of the beacon to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a beacon profile
                apiInstance.BeaconDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the beacon to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacondisable"></a>
# **BeaconDisable**
> void BeaconDisable ()

Disable beacon support account wide

Allows the user to enable or disable beacon usage account wide.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconDisableExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();

            try
            {
                // Disable beacon support account wide
                apiInstance.BeaconDisable();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconDisable: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconget"></a>
# **BeaconGet**
> void BeaconGet (Guid? id)

View details of a beacon profile

Allows the user to view an individual beacon profile and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var id = new Guid?(); // Guid? | The id of the beacon to get.

            try
            {
                // View details of a beacon profile
                apiInstance.BeaconGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the beacon to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacongetlocations"></a>
# **BeaconGetlocations**
> void BeaconGetlocations (string beacons)

Get the sign-in stations assigned to specific beacons.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconGetlocationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var beacons = beacons_example;  // string | A JSON array containg the beacons data (region, minor and major) values.

            try
            {
                // Get the sign-in stations assigned to specific beacons.
                apiInstance.BeaconGetlocations(beacons);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconGetlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacongetstationlocation"></a>
# **BeaconGetstationlocation**
> void BeaconGetstationlocation (Guid? station, Guid? location)

Get the location settings in the specified sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconGetstationlocationExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose location information has to be retrieved.
            var location = new Guid?(); // Guid? | The id of the location whose information has to be retrieved.

            try
            {
                // Get the location settings in the specified sign-in station.
                apiInstance.BeaconGetstationlocation(station, location);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconGetstationlocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose location information has to be retrieved. | 
 **location** | [**Guid?**](.md)| The id of the location whose information has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beacongetuuid"></a>
# **BeaconGetuuid**
> void BeaconGetuuid ()

View the identifier for the account's beacon region (for sign-in stations).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconGetuuidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();

            try
            {
                // View the identifier for the account's beacon region (for sign-in stations).
                apiInstance.BeaconGetuuid();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconGetuuid: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconlist"></a>
# **BeaconList**
> void BeaconList (int? from, int? count)

View a list of beacon profiles

Allows the user to view the list of all beacon profiles without their basic details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of beacon profiles
                apiInstance.BeaconList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconlistprofiles"></a>
# **BeaconListprofiles**
> void BeaconListprofiles ()

View a list of beacon profiles with their characteristics

Allows the user to view the list of all beacon profiles with their basic details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconListprofilesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();

            try
            {
                // View a list of beacon profiles with their characteristics
                apiInstance.BeaconListprofiles();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconListprofiles: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconresetuuid"></a>
# **BeaconResetuuid**
> void BeaconResetuuid ()

Generate or reset the identifier for the account's beacon region.

Allows the user to reset the identifier for the beacon region, generally not necessary.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconResetuuidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();

            try
            {
                // Generate or reset the identifier for the account's beacon region.
                apiInstance.BeaconResetuuid();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconResetuuid: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsave"></a>
# **BeaconSave**
> void BeaconSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a beacon profile

Allows the user to create or edit a beacon profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var id = new Guid?(); // Guid? | The id of the beacon save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a beacon profile
                apiInstance.BeaconSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the beacon save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconscanlocations"></a>
# **BeaconScanlocations**
> void BeaconScanlocations (string beacons)

Check if there's location available to sign-in / out.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconScanlocationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var beacons = beacons_example;  // string | A JSON array containg the beacons data (region, minor and major) values.

            try
            {
                // Check if there's location available to sign-in / out.
                apiInstance.BeaconScanlocations(beacons);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconScanlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **beacons** | **string**| A JSON array containg the beacons data (region, minor and major) values. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsetuuid"></a>
# **BeaconSetuuid**
> void BeaconSetuuid (Guid? id)

Set the identifier for the account's beacon region (for sign-in stations).

Allows the user to set the identifier for the account's beacon regions for sign-in stations, generally not necessary as each sign-in station profile generates its own region.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconSetuuidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var id = new Guid?(); // Guid? | The custom region UUID.

            try
            {
                // Set the identifier for the account's beacon region (for sign-in stations).
                apiInstance.BeaconSetuuid(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconSetuuid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The custom region UUID. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsilentregions"></a>
# **BeaconSilentregions**
> void BeaconSilentregions ()

View all the beacon regions defined for silent tracking

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconSilentregionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();

            try
            {
                // View all the beacon regions defined for silent tracking
                apiInstance.BeaconSilentregions();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconSilentregions: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsilentsignin"></a>
# **BeaconSilentsignin**
> void BeaconSilentsignin (Guid? uuid)

Sign-in silently from the location specified by a beacon

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconSilentsigninExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var uuid = new Guid?(); // Guid? | The id of the region the user is in.

            try
            {
                // Sign-in silently from the location specified by a beacon
                apiInstance.BeaconSilentsignin(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconSilentsignin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](.md)| The id of the region the user is in. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="beaconsilentsignout"></a>
# **BeaconSilentsignout**
> void BeaconSilentsignout (Guid? uuid)

Sign-out silently from the location specified by a beacon

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BeaconSilentsignoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BeaconApi();
            var uuid = new Guid?(); // Guid? | The id of the region the user has left.

            try
            {
                // Sign-out silently from the location specified by a beacon
                apiInstance.BeaconSilentsignout(uuid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BeaconApi.BeaconSilentsignout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](.md)| The id of the region the user has left. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

