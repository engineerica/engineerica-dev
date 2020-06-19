# Org.OpenAPITools.Api.VirtuallineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VirtuallineAddmyself**](VirtuallineApi.md#virtuallineaddmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**VirtuallineList**](VirtuallineApi.md#virtuallinelist) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**VirtuallineRemovemyself**](VirtuallineApi.md#virtuallineremovemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line


<a name="virtuallineaddmyself"></a>
# **VirtuallineAddmyself**
> void VirtuallineAddmyself (Guid? waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallineAddmyselfExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VirtuallineApi();
            var waitinglineid = new Guid?(); // Guid? | ID of the waiting line to join.

            try
            {
                // Add myself to a waiting line
                apiInstance.VirtuallineAddmyself(waitinglineid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtuallineApi.VirtuallineAddmyself: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitinglineid** | [**Guid?**](.md)| ID of the waiting line to join. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="virtuallinelist"></a>
# **VirtuallineList**
> void VirtuallineList ()

Lists waiting lines that have remote access enabled

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallineListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VirtuallineApi();

            try
            {
                // Lists waiting lines that have remote access enabled
                apiInstance.VirtuallineList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtuallineApi.VirtuallineList: " + e.Message );
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

<a name="virtuallineremovemyself"></a>
# **VirtuallineRemovemyself**
> void VirtuallineRemovemyself ()

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class VirtuallineRemovemyselfExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new VirtuallineApi();

            try
            {
                // Remove myself from a waiting line
                apiInstance.VirtuallineRemovemyself();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VirtuallineApi.VirtuallineRemovemyself: " + e.Message );
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

