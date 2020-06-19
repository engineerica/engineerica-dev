# Org.OpenAPITools.Api.ScheduleintegrationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ScheduleintegrationClearids**](ScheduleintegrationApi.md#scheduleintegrationclearids) | **GET** /scheduleintegration/clearids | Clear all third party IDs from specified staff member&#39;s schedule items.
[**ScheduleintegrationDeleteitem**](ScheduleintegrationApi.md#scheduleintegrationdeleteitem) | **DELETE** /scheduleintegration/deleteitem | Delete a schedule item looking up by a third party ID
[**ScheduleintegrationDeleteitemsbymasterid**](ScheduleintegrationApi.md#scheduleintegrationdeleteitemsbymasterid) | **DELETE** /scheduleintegration/deleteitemsbymasterid | Delete multiple schedule items looking up by a third party master ID
[**ScheduleintegrationGetitem**](ScheduleintegrationApi.md#scheduleintegrationgetitem) | **GET** /scheduleintegration/getitem | Get a schedule item looking up by a third party ID
[**ScheduleintegrationSaveitem**](ScheduleintegrationApi.md#scheduleintegrationsaveitem) | **POST** /scheduleintegration/saveitem | Save a schedule item looking up by a third party ID
[**ScheduleintegrationSetid**](ScheduleintegrationApi.md#scheduleintegrationsetid) | **GET** /scheduleintegration/setid | Set a 3rd party ID on a specific schedule item


<a name="scheduleintegrationclearids"></a>
# **ScheduleintegrationClearids**
> void ScheduleintegrationClearids (Guid? staff)

Clear all third party IDs from specified staff member's schedule items.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationClearidsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var staff = new Guid?(); // Guid? | The ID of the staff member whose schedule items third party IDs must be cleared.

            try
            {
                // Clear all third party IDs from specified staff member's schedule items.
                apiInstance.ScheduleintegrationClearids(staff);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationClearids: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **staff** | [**Guid?**](.md)| The ID of the staff member whose schedule items third party IDs must be cleared. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationdeleteitem"></a>
# **ScheduleintegrationDeleteitem**
> void ScheduleintegrationDeleteitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationDeleteitemExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a schedule item looking up by a third party ID
                apiInstance.ScheduleintegrationDeleteitem(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationDeleteitem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationdeleteitemsbymasterid"></a>
# **ScheduleintegrationDeleteitemsbymasterid**
> void ScheduleintegrationDeleteitemsbymasterid (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete multiple schedule items looking up by a third party master ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationDeleteitemsbymasteridExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete multiple schedule items looking up by a third party master ID
                apiInstance.ScheduleintegrationDeleteitemsbymasterid(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationDeleteitemsbymasterid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationgetitem"></a>
# **ScheduleintegrationGetitem**
> void ScheduleintegrationGetitem (string thirdpartyid)

Get a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationGetitemExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var thirdpartyid = thirdpartyid_example;  // string | The third party id to search for the schedule item.

            try
            {
                // Get a schedule item looking up by a third party ID
                apiInstance.ScheduleintegrationGetitem(thirdpartyid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationGetitem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **thirdpartyid** | **string**| The third party id to search for the schedule item. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationsaveitem"></a>
# **ScheduleintegrationSaveitem**
> void ScheduleintegrationSaveitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a schedule item looking up by a third party ID

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationSaveitemExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a schedule item looking up by a third party ID
                apiInstance.ScheduleintegrationSaveitem(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationSaveitem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="scheduleintegrationsetid"></a>
# **ScheduleintegrationSetid**
> void ScheduleintegrationSetid (Guid? id, string thirdpartyid, string thirdpartymasterid)

Set a 3rd party ID on a specific schedule item

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleintegrationSetidExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScheduleintegrationApi();
            var id = new Guid?(); // Guid? | The id of the schedule block / appointment.
            var thirdpartyid = thirdpartyid_example;  // string | The 3rd party ID to set.
            var thirdpartymasterid = thirdpartymasterid_example;  // string | The 3rd party master ID to set (useful to handle recurring items). (optional) 

            try
            {
                // Set a 3rd party ID on a specific schedule item
                apiInstance.ScheduleintegrationSetid(id, thirdpartyid, thirdpartymasterid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScheduleintegrationApi.ScheduleintegrationSetid: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the schedule block / appointment. | 
 **thirdpartyid** | **string**| The 3rd party ID to set. | 
 **thirdpartymasterid** | **string**| The 3rd party master ID to set (useful to handle recurring items). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

