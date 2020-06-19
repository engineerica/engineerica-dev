# Org.OpenAPITools.Api.InteractionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InteractionDelete**](InteractionApi.md#interactiondelete) | **DELETE** /interaction/{id} | Delete an interaction
[**InteractionFeed**](InteractionApi.md#interactionfeed) | **GET** /interaction/feed | Get the interactions feed
[**InteractionGet**](InteractionApi.md#interactionget) | **GET** /interaction/{id} | View an interaction
[**InteractionListprivatesummary**](InteractionApi.md#interactionlistprivatesummary) | **GET** /interaction/listprivatesummary | Get current user&#39;s latest private interactions
[**InteractionSave**](InteractionApi.md#interactionsave) | **POST** /interaction/{id} | Save an interaction


<a name="interactiondelete"></a>
# **InteractionDelete**
> void InteractionDelete (Guid? id, AnyType body)

Delete an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var id = new Guid?(); // Guid? | The id of the interaction to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an interaction
                apiInstance.InteractionDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.InteractionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the interaction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionfeed"></a>
# **InteractionFeed**
> void InteractionFeed (int? from, int? count, DateTime? startdate, bool? _public, string contexttype, Guid? contextid, string types, int? photosize, bool? showdefaultphoto, bool? orderdescending)

Get the interactions feed

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionFeedExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | If set, only interactions that happened after this date are returned. (optional) 
            var _public = true;  // bool? | Specifies whether to return public or private interactions. (optional) 
            var contexttype = contexttype_example;  // string | The type of the context of the interactions to return. (optional) 
            var contextid = new Guid?(); // Guid? | The id of the context of the interactions to return. (optional) 
            var types = types_example;  // string | The  comma separated types of the interactions to return. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 
            var orderdescending = true;  // bool? | If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. (optional) 

            try
            {
                // Get the interactions feed
                apiInstance.InteractionFeed(from, count, startdate, _public, contexttype, contextid, types, photosize, showdefaultphoto, orderdescending);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.InteractionFeed: " + e.Message );
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
 **startdate** | **DateTime?**| If set, only interactions that happened after this date are returned. | [optional] 
 **_public** | **bool?**| Specifies whether to return public or private interactions. | [optional] 
 **contexttype** | **string**| The type of the context of the interactions to return. | [optional] 
 **contextid** | [**Guid?**](.md)| The id of the context of the interactions to return. | [optional] 
 **types** | **string**| The  comma separated types of the interactions to return. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 
 **orderdescending** | **bool?**| If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionget"></a>
# **InteractionGet**
> void InteractionGet (string id, int? thumbnailmediasize, int? photosize)

View an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var id = id_example;  // string | The id of the interaction.
            var thumbnailmediasize = 56;  // int? | The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View an interaction
                apiInstance.InteractionGet(id, thumbnailmediasize, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.InteractionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the interaction. | 
 **thumbnailmediasize** | **int?**| The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionlistprivatesummary"></a>
# **InteractionListprivatesummary**
> void InteractionListprivatesummary (int? photosize, bool? showdefaultphoto)

Get current user's latest private interactions

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionListprivatesummaryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 

            try
            {
                // Get current user's latest private interactions
                apiInstance.InteractionListprivatesummary(photosize, showdefaultphoto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.InteractionListprivatesummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="interactionsave"></a>
# **InteractionSave**
> void InteractionSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save an interaction

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class InteractionSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InteractionApi();
            var id = new Guid?(); // Guid? | The id of the interaction to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save an interaction
                apiInstance.InteractionSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InteractionApi.InteractionSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the interaction to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

