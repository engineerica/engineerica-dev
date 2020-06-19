# Org.OpenAPITools.Api.UsersettingsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersettingsGet**](UsersettingsApi.md#usersettingsget) | **GET** /usersettings/get | Lists available user settings
[**UsersettingsGetmultiple**](UsersettingsApi.md#usersettingsgetmultiple) | **GET** /usersettings/getmultiple | Get multiple user settings
[**UsersettingsSave**](UsersettingsApi.md#usersettingssave) | **POST** /usersettings/save | Saves a user setting
[**UsersettingsSavemultiple**](UsersettingsApi.md#usersettingssavemultiple) | **POST** /usersettings/savemultiple | Save multiple user settings at once


<a name="usersettingsget"></a>
# **UsersettingsGet**
> void UsersettingsGet (string keys, Guid? user)

Lists available user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersettingsApi();
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Lists available user settings
                apiInstance.UsersettingsGet(keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UsersettingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingsgetmultiple"></a>
# **UsersettingsGetmultiple**
> void UsersettingsGetmultiple (string keys, Guid? user)

Get multiple user settings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsGetmultipleExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersettingsApi();
            var keys = keys_example;  // string | Setting key to get. Can be multiple separated by commas.
            var user = new Guid?(); // Guid? | The user id whose settings have to be returned. (optional) 

            try
            {
                // Get multiple user settings
                apiInstance.UsersettingsGetmultiple(keys, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UsersettingsGetmultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| Setting key to get. Can be multiple separated by commas. | 
 **user** | [**Guid?**](.md)| The user id whose settings have to be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersettingssave"></a>
# **UsersettingsSave**
> void UsersettingsSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a user setting

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersettingsApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a user setting
                apiInstance.UsersettingsSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UsersettingsSave: " + e.Message );
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

<a name="usersettingssavemultiple"></a>
# **UsersettingsSavemultiple**
> void UsersettingsSavemultiple (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save multiple user settings at once

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsersettingsSavemultipleExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsersettingsApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save multiple user settings at once
                apiInstance.UsersettingsSavemultiple(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersettingsApi.UsersettingsSavemultiple: " + e.Message );
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

