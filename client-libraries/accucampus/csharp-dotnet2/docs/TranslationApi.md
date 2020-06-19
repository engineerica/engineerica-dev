# Org.OpenAPITools.Api.TranslationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TranslationGet**](TranslationApi.md#translationget) | **GET** /translation/get | Gets the translations of the specified values
[**TranslationGetcachefile**](TranslationApi.md#translationgetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**TranslationList**](TranslationApi.md#translationlist) | **GET** /translation/list | Lists all the available translations in the system
[**TranslationSave**](TranslationApi.md#translationsave) | **POST** /translation/{id} | Edit a translation


<a name="translationget"></a>
# **TranslationGet**
> void TranslationGet (string universal)

Gets the translations of the specified values

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi();
            var universal = universal_example;  // string | Pipe separated list of universal text to be translated.

            try
            {
                // Gets the translations of the specified values
                apiInstance.TranslationGet(universal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **universal** | **string**| Pipe separated list of universal text to be translated. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationgetcachefile"></a>
# **TranslationGetcachefile**
> void TranslationGetcachefile (string account)

Get the file containing the translations

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationGetcachefileExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi();
            var account = account_example;  // string | The id of the account whose translations file has to be retrieved. (optional) 

            try
            {
                // Get the file containing the translations
                apiInstance.TranslationGetcachefile(account);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslationGetcachefile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationlist"></a>
# **TranslationList**
> void TranslationList (string filter, bool? nondefaultonly, bool? appdefaultasuniversal)

Lists all the available translations in the system

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi();
            var filter = filter_example;  // string | Text to search/filter translations. (optional) 
            var nondefaultonly = true;  // bool? | If true then it returns only the terms translated. Otherwise, it returns all. (optional) 
            var appdefaultasuniversal = true;  // bool? | If true then it uses the app default translation as the universal term. (optional) 

            try
            {
                // Lists all the available translations in the system
                apiInstance.TranslationList(filter, nondefaultonly, appdefaultasuniversal);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslationList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **bool?**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **bool?**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="translationsave"></a>
# **TranslationSave**
> void TranslationSave (string id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class TranslationSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TranslationApi();
            var id = id_example;  // string | The id of the translation as returned by translation.list.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit a translation
                apiInstance.TranslationSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TranslationApi.TranslationSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the translation as returned by translation.list. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

