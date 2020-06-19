# Org.OpenAPITools.Api.CompassserviceApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompassserviceList**](CompassserviceApi.md#compassservicelist) | **GET** /compassservice/list | View all the services added to the compass
[**CompassserviceListlocations**](CompassserviceApi.md#compassservicelistlocations) | **GET** /compassservice/listlocations | View all the locations where a service added to the compass is available


<a name="compassservicelist"></a>
# **CompassserviceList**
> void CompassserviceList (Guid? category)

View all the services added to the compass

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompassserviceListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompassserviceApi();
            var category = new Guid?(); // Guid? | The id of the category to filter the services. (optional) 

            try
            {
                // View all the services added to the compass
                apiInstance.CompassserviceList(category);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompassserviceApi.CompassserviceList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **category** | [**Guid?**](.md)| The id of the category to filter the services. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="compassservicelistlocations"></a>
# **CompassserviceListlocations**
> void CompassserviceListlocations (Guid? serviceid)

View all the locations where a service added to the compass is available

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CompassserviceListlocationsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CompassserviceApi();
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // View all the locations where a service added to the compass is available
                apiInstance.CompassserviceListlocations(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompassserviceApi.CompassserviceListlocations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service to get its locations. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

