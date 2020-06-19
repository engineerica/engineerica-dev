# Org.OpenAPITools.Api.SettingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SettingAddlogo**](SettingApi.md#settingaddlogo) | **GET** /setting/addlogo | Add a logo to the account
[**SettingGet**](SettingApi.md#settingget) | **GET** /setting/get | Get settings for the account or the specified scope
[**SettingSave**](SettingApi.md#settingsave) | **POST** /setting/save | Save settings for the account or the specified scope
[**SettingViewgeneral**](SettingApi.md#settingviewgeneral) | **GET** /setting/viewgeneral | View general settings for the account


<a name="settingaddlogo"></a>
# **SettingAddlogo**
> void SettingAddlogo (string upload, string filename)

Add a logo to the account

Allows the user to add the logo for the account, which appears on all pages on the AccuCampus browser version.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingAddlogoExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingApi();
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Add a logo to the account
                apiInstance.SettingAddlogo(upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingApi.SettingAddlogo: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The original filename, needed to process the file. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingget"></a>
# **SettingGet**
> void SettingGet (string keys, string domain, string scope)

Get settings for the account or the specified scope

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingApi();
            var keys = keys_example;  // string | The option keys to get values for. Enter multiple separated by comma.
            var domain = domain_example;  // string | The account domain, in case of reading settings annonymously. (optional) 
            var scope = scope_example;  // string | The scope of the settings to get. (optional) 

            try
            {
                // Get settings for the account or the specified scope
                apiInstance.SettingGet(keys, domain, scope);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingApi.SettingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **keys** | **string**| The option keys to get values for. Enter multiple separated by comma. | 
 **domain** | **string**| The account domain, in case of reading settings annonymously. | [optional] 
 **scope** | **string**| The scope of the settings to get. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="settingsave"></a>
# **SettingSave**
> void SettingSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save settings for the account or the specified scope

Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save settings for the account or the specified scope
                apiInstance.SettingSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingApi.SettingSave: " + e.Message );
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

<a name="settingviewgeneral"></a>
# **SettingViewgeneral**
> void SettingViewgeneral ()

View general settings for the account

Allows the user to view the settings' general section.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SettingViewgeneralExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SettingApi();

            try
            {
                // View general settings for the account
                apiInstance.SettingViewgeneral();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SettingApi.SettingViewgeneral: " + e.Message );
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

