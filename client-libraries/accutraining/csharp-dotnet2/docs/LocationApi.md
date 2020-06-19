# Org.OpenAPITools.Api.LocationApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocationDelete**](LocationApi.md#locationdelete) | **DELETE** /location/{id} | Delete a location
[**LocationGet**](LocationApi.md#locationget) | **GET** /location/{id} | Search and view details of a location
[**LocationList**](LocationApi.md#locationlist) | **GET** /location/list | View a list of locations
[**LocationSave**](LocationApi.md#locationsave) | **POST** /location/{id} | Create or edit a location


<a name="locationdelete"></a>
# **LocationDelete**
> void LocationDelete (Guid? id, AnyType body)

Delete a location

Allows the user to delete an existing location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var id = new Guid?(); // Guid? | The id of the location to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a location
                apiInstance.LocationDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.LocationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationget"></a>
# **LocationGet**
> void LocationGet (Guid? id)

Search and view details of a location

Allows the user to search and view an individual location and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // Search and view details of a location
                apiInstance.LocationGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.LocationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationlist"></a>
# **LocationList**
> void LocationList (int? from, int? count, string locations, bool? sortbygroup)

View a list of locations

Allows the user to view the list of all locations to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var locations = locations_example;  // string | The comma-separated list containing the ids of the locations to list. (optional) 
            var sortbygroup = true;  // bool? | True to list locations sorted by the 'Located In' property. Defaults to false. (optional) 

            try
            {
                // View a list of locations
                apiInstance.LocationList(from, count, locations, sortbygroup);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.LocationList: " + e.Message );
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
 **locations** | **string**| The comma-separated list containing the ids of the locations to list. | [optional] 
 **sortbygroup** | **bool?**| True to list locations sorted by the &#39;Located In&#39; property. Defaults to false. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="locationsave"></a>
# **LocationSave**
> void LocationSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a location

Allows the user to create or edit a location.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LocationSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi();
            var id = new Guid?(); // Guid? | The id of the location save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a location
                apiInstance.LocationSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LocationApi.LocationSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the location save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

