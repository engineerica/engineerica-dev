# Org.OpenAPITools.Api.SocialApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SocialContacts**](SocialApi.md#socialcontacts) | **GET** /social/contacts | Gets the list of contacts in the network


<a name="socialcontacts"></a>
# **SocialContacts**
> void SocialContacts (string filter, bool? showdefaultphoto)

Gets the list of contacts in the network

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialContactsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialApi();
            var filter = filter_example;  // string | Text to filter results. (optional) 
            var showdefaultphoto = true;  // bool? | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. (optional) 

            try
            {
                // Gets the list of contacts in the network
                apiInstance.SocialContacts(filter, showdefaultphoto);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialApi.SocialContacts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to filter results. | [optional] 
 **showdefaultphoto** | **bool?**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

