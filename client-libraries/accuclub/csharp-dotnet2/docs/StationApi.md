# Org.OpenAPITools.Api.StationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**StationDelete**](StationApi.md#stationdelete) | **DELETE** /station/{id} | Delete a sign-in station
[**StationGet**](StationApi.md#stationget) | **GET** /station/{id} | View details of a sign-in station
[**StationGetcurrentterms**](StationApi.md#stationgetcurrentterms) | **GET** /station/getcurrentterms | Get all the current terms
[**StationGetinfo**](StationApi.md#stationgetinfo) | **GET** /station/getinfo | Gets a the info to display in the sign-in station by it&#39;s ID.
[**StationGetlicense**](StationApi.md#stationgetlicense) | **GET** /station/getlicense | Gets the current license information
[**StationList**](StationApi.md#stationlist) | **GET** /station/list | View a list of sign-in stations
[**StationSave**](StationApi.md#stationsave) | **POST** /station/{id} | Create or edit a sign-in station
[**StationUnlock**](StationApi.md#stationunlock) | **GET** /station/unlock | Unlocks the sign-in station.


<a name="stationdelete"></a>
# **StationDelete**
> void StationDelete (Guid? id, AnyType body)

Delete a sign-in station

Allows the user to delete a sign-in station from the list of existing sign-in stations that they can view based on their scope.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a sign-in station
                apiInstance.StationDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationget"></a>
# **StationGet**
> void StationGet (Guid? id)

View details of a sign-in station

Allows the user to view an individual sign-in station and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.

            try
            {
                // View details of a sign-in station
                apiInstance.StationGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetcurrentterms"></a>
# **StationGetcurrentterms**
> void StationGetcurrentterms (Guid? station)

Get all the current terms

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationGetcurrenttermsExample
    {
        public void main()
        {
            var apiInstance = new StationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station whose account's current terms have to be retrieved.

            try
            {
                // Get all the current terms
                apiInstance.StationGetcurrentterms(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationGetcurrentterms: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station whose account&#39;s current terms have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetinfo"></a>
# **StationGetinfo**
> void StationGetinfo (Guid? id, Guid? _event)

Gets a the info to display in the sign-in station by it's ID.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationGetinfoExample
    {
        public void main()
        {
            var apiInstance = new StationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to get.
            var _event = new Guid?(); // Guid? | The id of the event, to override the one by schedule. (optional) 

            try
            {
                // Gets a the info to display in the sign-in station by it's ID.
                apiInstance.StationGetinfo(id, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationGetinfo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **_event** | [**Guid?**](.md)| The id of the event, to override the one by schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationgetlicense"></a>
# **StationGetlicense**
> void StationGetlicense (string station)

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationGetlicenseExample
    {
        public void main()
        {
            var apiInstance = new StationApi();
            var station = station_example;  // string | The id of the sign-in station whose account's license has to be retrieved.

            try
            {
                // Gets the current license information
                apiInstance.StationGetlicense(station);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationGetlicense: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | **string**| The id of the sign-in station whose account&#39;s license has to be retrieved. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationlist"></a>
# **StationList**
> void StationList (int? from, int? count)

View a list of sign-in stations

Allows the user to view the list of sign-in stations, limited to the stations in the locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StationApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of sign-in stations
                apiInstance.StationList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationList: " + e.Message );
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

<a name="stationsave"></a>
# **StationSave**
> void StationSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a sign-in station

Allows the user to create, edit, or install a sign-in station based in an area to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a sign-in station
                apiInstance.StationSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stationunlock"></a>
# **StationUnlock**
> void StationUnlock (Guid? id, string passcode, string method)

Unlocks the sign-in station.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class StationUnlockExample
    {
        public void main()
        {
            var apiInstance = new StationApi();
            var id = new Guid?(); // Guid? | The id of the sign-in station to unlock.
            var passcode = passcode_example;  // string | The passcode to unlock the station.
            var method = method_example;  // string | The authentication method. Valid values are 'token' and 'cookie'.

            try
            {
                // Unlocks the sign-in station.
                apiInstance.StationUnlock(id, passcode, method);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StationApi.StationUnlock: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the sign-in station to unlock. | 
 **passcode** | **string**| The passcode to unlock the station. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

