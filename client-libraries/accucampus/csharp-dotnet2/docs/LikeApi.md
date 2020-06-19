# Org.OpenAPITools.Api.LikeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LikeDelete**](LikeApi.md#likedelete) | **DELETE** /like/delete | Delete a like
[**LikeList**](LikeApi.md#likelist) | **GET** /like/list | View all the likes associated to a target
[**LikeSave**](LikeApi.md#likesave) | **POST** /like/save | Save a like


<a name="likedelete"></a>
# **LikeDelete**
> void LikeDelete (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a like

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikeDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikeApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a like
                apiInstance.LikeDelete(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LikeApi.LikeDelete: " + e.Message );
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

<a name="likelist"></a>
# **LikeList**
> void LikeList (Guid? interactionid, int? photosize)

View all the likes associated to a target

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikeListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikeApi();
            var interactionid = new Guid?(); // Guid? | The id of the interaction to unlike.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View all the likes associated to a target
                apiInstance.LikeList(interactionid, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LikeApi.LikeList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **interactionid** | [**Guid?**](.md)| The id of the interaction to unlike. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="likesave"></a>
# **LikeSave**
> void LikeSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a like

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LikeSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LikeApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a like
                apiInstance.LikeSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LikeApi.LikeSave: " + e.Message );
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

