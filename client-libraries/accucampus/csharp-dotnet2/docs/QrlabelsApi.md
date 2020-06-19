# Org.OpenAPITools.Api.QrlabelsApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**QrlabelsPrint**](QrlabelsApi.md#qrlabelsprint) | **GET** /qrlabels/print | Print and email QR labels


<a name="qrlabelsprint"></a>
# **QrlabelsPrint**
> void QrlabelsPrint (Guid? user, Guid? group)

Print and email QR labels

Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class QrlabelsPrintExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new QrlabelsApi();
            var user = new Guid?(); // Guid? | The id of the user whose label needs to be printed. (optional) 
            var group = new Guid?(); // Guid? | The id of the group whose members' labels need to be printed. (optional) 

            try
            {
                // Print and email QR labels
                apiInstance.QrlabelsPrint(user, group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling QrlabelsApi.QrlabelsPrint: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**Guid?**](.md)| The id of the user whose label needs to be printed. | [optional] 
 **group** | [**Guid?**](.md)| The id of the group whose members&#39; labels need to be printed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

