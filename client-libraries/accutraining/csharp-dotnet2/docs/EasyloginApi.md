# Org.OpenAPITools.Api.EasyloginApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EasyloginAddbgimage**](EasyloginApi.md#easyloginaddbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login


<a name="easyloginaddbgimage"></a>
# **EasyloginAddbgimage**
> void EasyloginAddbgimage (string upload, string filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuTraining account not using SSO.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class EasyloginAddbgimageExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EasyloginApi();
            var upload = upload_example;  // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
            var filename = filename_example;  // string | The original filename, needed to process the file.

            try
            {
                // Adds background image for the login
                apiInstance.EasyloginAddbgimage(upload, filename);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EasyloginApi.EasyloginAddbgimage: " + e.Message );
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

