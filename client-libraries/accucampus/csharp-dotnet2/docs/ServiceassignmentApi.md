# Org.OpenAPITools.Api.ServiceassignmentApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceassignmentAddservice**](ServiceassignmentApi.md#serviceassignmentaddservice) | **GET** /serviceassignment/addservice | Enable a service in a specific location
[**ServiceassignmentGetlocation**](ServiceassignmentApi.md#serviceassignmentgetlocation) | **GET** /serviceassignment/getlocation | View a list of services enabled for a specific location
[**ServiceassignmentGetservice**](ServiceassignmentApi.md#serviceassignmentgetservice) | **GET** /serviceassignment/getservice | View a list of locations where a service is available
[**ServiceassignmentRemoveservice**](ServiceassignmentApi.md#serviceassignmentremoveservice) | **GET** /serviceassignment/removeservice | Remove a service from a location


<a name="serviceassignmentaddservice"></a>
# **ServiceassignmentAddservice**
> void ServiceassignmentAddservice (Guid? serviceid, Guid? locationid)

Enable a service in a specific location

Allows the user to enable a service in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentAddserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceassignmentApi();
            var serviceid = new Guid?(); // Guid? | The id of the service to add.
            var locationid = new Guid?(); // Guid? | The id of the location.

            try
            {
                // Enable a service in a specific location
                apiInstance.ServiceassignmentAddservice(serviceid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceassignmentApi.ServiceassignmentAddservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service to add. | 
 **locationid** | [**Guid?**](.md)| The id of the location. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentgetlocation"></a>
# **ServiceassignmentGetlocation**
> void ServiceassignmentGetlocation (Guid? locationid, bool? includegloballyavailable, bool? namefilter, int? count)

View a list of services enabled for a specific location

Allows the user to view a list of services available in a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentGetlocationExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceassignmentApi();
            var locationid = new Guid?(); // Guid? | The id of the location to get.
            var includegloballyavailable = true;  // bool? | Specifies whether the services available globally must be returned or not. (optional) 
            var namefilter = true;  // bool? | Filters the name of the services to return. (optional) 
            var count = 56;  // int? | The max number of services to return. (optional) 

            try
            {
                // View a list of services enabled for a specific location
                apiInstance.ServiceassignmentGetlocation(locationid, includegloballyavailable, namefilter, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceassignmentApi.ServiceassignmentGetlocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**Guid?**](.md)| The id of the location to get. | 
 **includegloballyavailable** | **bool?**| Specifies whether the services available globally must be returned or not. | [optional] 
 **namefilter** | **bool?**| Filters the name of the services to return. | [optional] 
 **count** | **int?**| The max number of services to return. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceassignmentgetservice"></a>
# **ServiceassignmentGetservice**
> void ServiceassignmentGetservice (Guid? serviceid)

View a list of locations where a service is available

Allows the user to view a list of locations in which a service is available.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentGetserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceassignmentApi();
            var serviceid = new Guid?(); // Guid? | The id of the service to get its locations.

            try
            {
                // View a list of locations where a service is available
                apiInstance.ServiceassignmentGetservice(serviceid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceassignmentApi.ServiceassignmentGetservice: " + e.Message );
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

<a name="serviceassignmentremoveservice"></a>
# **ServiceassignmentRemoveservice**
> void ServiceassignmentRemoveservice (Guid? serviceid, Guid? locationid)

Remove a service from a location

Allows the user to disable a service from a location to which they are scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ServiceassignmentRemoveserviceExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ServiceassignmentApi();
            var serviceid = new Guid?(); // Guid? | The id of the service to remove.
            var locationid = new Guid?(); // Guid? | The id of the location to remove the service from.

            try
            {
                // Remove a service from a location
                apiInstance.ServiceassignmentRemoveservice(serviceid, locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceassignmentApi.ServiceassignmentRemoveservice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**Guid?**](.md)| The id of the service to remove. | 
 **locationid** | [**Guid?**](.md)| The id of the location to remove the service from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

