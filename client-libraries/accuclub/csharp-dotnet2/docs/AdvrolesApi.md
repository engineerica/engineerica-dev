# Org.OpenAPITools.Api.AdvrolesApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvrolesUserlist**](AdvrolesApi.md#advrolesuserlist) | **GET** /advroles/userlist | List users. Alias to user.list, use that one instead.


<a name="advrolesuserlist"></a>
# **AdvrolesUserlist**
> void AdvrolesUserlist (int? from, int? count, Guid? roleid, string onlywithoutcard, int? photosize)

List users. Alias to user.list, use that one instead.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvrolesUserlistExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvrolesApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var roleid = new Guid?(); // Guid? | The id of the role to filter users by, or empty to return all users. (optional) 
            var onlywithoutcard = onlywithoutcard_example;  // string | If is 1 then only the users without a card are returned, otherwise all users are returned. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // List users. Alias to user.list, use that one instead.
                apiInstance.AdvrolesUserlist(from, count, roleid, onlywithoutcard, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvrolesApi.AdvrolesUserlist: " + e.Message );
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
 **roleid** | [**Guid?**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

