# Org.OpenAPITools.Api.UsertaskApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsertaskDeleteplan**](UsertaskApi.md#usertaskdeleteplan) | **DELETE** /usertask/deleteplan | Deletes a task plan
[**UsertaskGetmine**](UsertaskApi.md#usertaskgetmine) | **GET** /usertask/getmine | Lists the task plans of the logged user
[**UsertaskGetplan**](UsertaskApi.md#usertaskgetplan) | **GET** /usertask/getplan | Gets a task plan by Id
[**UsertaskListdefs**](UsertaskApi.md#usertasklistdefs) | **GET** /usertask/listdefs | Lists task types or definitions
[**UsertaskListplan**](UsertaskApi.md#usertasklistplan) | **GET** /usertask/listplan | Lists task plans
[**UsertaskSaveplan**](UsertaskApi.md#usertasksaveplan) | **POST** /usertask/saveplan | Saves a task plan


<a name="usertaskdeleteplan"></a>
# **UsertaskDeleteplan**
> void UsertaskDeleteplan (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Deletes a task plan

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskDeleteplanExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsertaskApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Deletes a task plan
                apiInstance.UsertaskDeleteplan(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskDeleteplan: " + e.Message );
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

<a name="usertaskgetmine"></a>
# **UsertaskGetmine**
> void UsertaskGetmine ()

Lists the task plans of the logged user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskGetmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsertaskApi();

            try
            {
                // Lists the task plans of the logged user
                apiInstance.UsertaskGetmine();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskGetmine: " + e.Message );
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

<a name="usertaskgetplan"></a>
# **UsertaskGetplan**
> void UsertaskGetplan (Guid? id)

Gets a task plan by Id

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskGetplanExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsertaskApi();
            var id = new Guid?(); // Guid? | The id of the task plan to get.

            try
            {
                // Gets a task plan by Id
                apiInstance.UsertaskGetplan(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskGetplan: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the task plan to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usertasklistdefs"></a>
# **UsertaskListdefs**
> void UsertaskListdefs ()

Lists task types or definitions

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskListdefsExample
    {
        public void main()
        {
            var apiInstance = new UsertaskApi();

            try
            {
                // Lists task types or definitions
                apiInstance.UsertaskListdefs();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskListdefs: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usertasklistplan"></a>
# **UsertaskListplan**
> void UsertaskListplan (int? from, int? count)

Lists task plans

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskListplanExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsertaskApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // Lists task plans
                apiInstance.UsertaskListplan(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskListplan: " + e.Message );
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

<a name="usertasksaveplan"></a>
# **UsertaskSaveplan**
> void UsertaskSaveplan (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a task plan

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsertaskSaveplanExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsertaskApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a task plan
                apiInstance.UsertaskSaveplan(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsertaskApi.UsertaskSaveplan: " + e.Message );
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

