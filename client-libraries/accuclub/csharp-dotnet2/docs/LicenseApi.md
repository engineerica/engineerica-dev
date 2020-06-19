# Org.OpenAPITools.Api.LicenseApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LicenseAcceptagreement**](LicenseApi.md#licenseacceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**LicenseGetagreementstatus**](LicenseApi.md#licensegetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**LicenseGetcurrent**](LicenseApi.md#licensegetcurrent) | **GET** /license/getcurrent | Gets the current license information
[**LicenseRenew**](LicenseApi.md#licenserenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuClub subscription


<a name="licenseacceptagreement"></a>
# **LicenseAcceptagreement**
> void LicenseAcceptagreement ()

Accept the license agreement

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseAcceptagreementExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseApi();

            try
            {
                // Accept the license agreement
                apiInstance.LicenseAcceptagreement();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseAcceptagreement: " + e.Message );
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

<a name="licensegetagreementstatus"></a>
# **LicenseGetagreementstatus**
> void LicenseGetagreementstatus ()

Check if license agreement has been accepted

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseGetagreementstatusExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseApi();

            try
            {
                // Check if license agreement has been accepted
                apiInstance.LicenseGetagreementstatus();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseGetagreementstatus: " + e.Message );
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

<a name="licensegetcurrent"></a>
# **LicenseGetcurrent**
> void LicenseGetcurrent ()

Gets the current license information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseGetcurrentExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseApi();

            try
            {
                // Gets the current license information
                apiInstance.LicenseGetcurrent();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseGetcurrent: " + e.Message );
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

<a name="licenserenew"></a>
# **LicenseRenew**
> void LicenseRenew (string email, string phonenumber, string jobtitle, string institution, string comments)

Contact Engineerica in order to renew the AccuClub subscription

Allows the user to select the option to contact Engineerica when the AccuClub account is nearing its renewal date.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LicenseRenewExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LicenseApi();
            var email = email_example;  // string | The e-mail of the user sending the request.
            var phonenumber = phonenumber_example;  // string | The phone number of the user sending the request.
            var jobtitle = jobtitle_example;  // string | The job title of the user sending the request. (optional) 
            var institution = institution_example;  // string | The institution of the user sending the request. (optional) 
            var comments = comments_example;  // string | Comments entered by the user sending the request. (optional) 

            try
            {
                // Contact Engineerica in order to renew the AccuClub subscription
                apiInstance.LicenseRenew(email, phonenumber, jobtitle, institution, comments);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LicenseApi.LicenseRenew: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The e-mail of the user sending the request. | 
 **phonenumber** | **string**| The phone number of the user sending the request. | 
 **jobtitle** | **string**| The job title of the user sending the request. | [optional] 
 **institution** | **string**| The institution of the user sending the request. | [optional] 
 **comments** | **string**| Comments entered by the user sending the request. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

