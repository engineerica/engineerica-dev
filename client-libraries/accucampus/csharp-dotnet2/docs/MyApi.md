# Org.OpenAPITools.Api.MyApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MyAccount**](MyApi.md#myaccount) | **GET** /my/account | Gets the logged in user account.
[**MyIanatimezone**](MyApi.md#myianatimezone) | **GET** /my/ianatimezone | Gets the current time zone&#39;s iana name
[**MyProfile**](MyApi.md#myprofile) | **GET** /my/profile | Gets the logged in user information.
[**MyRights**](MyApi.md#myrights) | **GET** /my/rights | Gets the list of actions the user can execute.
[**MySaveprofile**](MyApi.md#mysaveprofile) | **POST** /my/saveprofile | Updates logged user&#39;s profile information


<a name="myaccount"></a>
# **MyAccount**
> void MyAccount ()

Gets the logged in user account.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyAccountExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyApi();

            try
            {
                // Gets the logged in user account.
                apiInstance.MyAccount();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyApi.MyAccount: " + e.Message );
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

<a name="myianatimezone"></a>
# **MyIanatimezone**
> void MyIanatimezone ()

Gets the current time zone's iana name

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyIanatimezoneExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyApi();

            try
            {
                // Gets the current time zone's iana name
                apiInstance.MyIanatimezone();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyApi.MyIanatimezone: " + e.Message );
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

<a name="myprofile"></a>
# **MyProfile**
> void MyProfile (int? photosize)

Gets the logged in user information.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyProfileExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyApi();
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // Gets the logged in user information.
                apiInstance.MyProfile(photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyApi.MyProfile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="myrights"></a>
# **MyRights**
> void MyRights ()

Gets the list of actions the user can execute.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MyRightsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyApi();

            try
            {
                // Gets the list of actions the user can execute.
                apiInstance.MyRights();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyApi.MyRights: " + e.Message );
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

<a name="mysaveprofile"></a>
# **MySaveprofile**
> void MySaveprofile (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Updates logged user's profile information

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MySaveprofileExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MyApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Updates logged user's profile information
                apiInstance.MySaveprofile(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MyApi.MySaveprofile: " + e.Message );
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

