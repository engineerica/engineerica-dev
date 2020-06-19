# Org.OpenAPITools.Api.SsoApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SsoGeneratekey**](SsoApi.md#ssogeneratekey) | **GET** /sso/generatekey | Generate/reset single sign on access key.
[**SsoGetsettings**](SsoApi.md#ssogetsettings) | **GET** /sso/getsettings | View single sign on settings.
[**SsoIssuetoken**](SsoApi.md#ssoissuetoken) | **GET** /sso/issuetoken | Issue single sign-on token
[**SsoSavesettings**](SsoApi.md#ssosavesettings) | **POST** /sso/savesettings | Edit single sign-on settings.


<a name="ssogeneratekey"></a>
# **SsoGeneratekey**
> void SsoGeneratekey ()

Generate/reset single sign on access key.

Allows the user to generate or reset the access key for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoGeneratekeyExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SsoApi();

            try
            {
                // Generate/reset single sign on access key.
                apiInstance.SsoGeneratekey();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoGeneratekey: " + e.Message );
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

<a name="ssogetsettings"></a>
# **SsoGetsettings**
> void SsoGetsettings ()

View single sign on settings.

Allows the user to view settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoGetsettingsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SsoApi();

            try
            {
                // View single sign on settings.
                apiInstance.SsoGetsettings();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoGetsettings: " + e.Message );
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

<a name="ssoissuetoken"></a>
# **SsoIssuetoken**
> void SsoIssuetoken (string key, string username, bool? expires)

Issue single sign-on token

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoIssuetokenExample
    {
        public void main()
        {
            var apiInstance = new SsoApi();
            var key = key_example;  // string | The single sign-on key of the account.
            var username = username_example;  // string | The email of the user to sign-on.
            var expires = true;  // bool? | Specifies whether the session should expire when inactive. (optional) 

            try
            {
                // Issue single sign-on token
                apiInstance.SsoIssuetoken(key, username, expires);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoIssuetoken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The single sign-on key of the account. | 
 **username** | **string**| The email of the user to sign-on. | 
 **expires** | **bool?**| Specifies whether the session should expire when inactive. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ssosavesettings"></a>
# **SsoSavesettings**
> void SsoSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Edit single sign-on settings.

Allows the user to edit settings for single sign-on.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SsoSavesettingsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SsoApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Edit single sign-on settings.
                apiInstance.SsoSavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SsoApi.SsoSavesettings: " + e.Message );
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

