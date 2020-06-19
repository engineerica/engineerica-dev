# Org.OpenAPITools.Api.SessionswipeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionswipeDelete**](SessionswipeApi.md#sessionswipedelete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
[**SessionswipeGet**](SessionswipeApi.md#sessionswipeget) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
[**SessionswipeListunresolved**](SessionswipeApi.md#sessionswipelistunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
[**SessionswipeResolve**](SessionswipeApi.md#sessionswiperesolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
[**SessionswipeSave**](SessionswipeApi.md#sessionswipesave) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
[**SessionswipeSaveanonym**](SessionswipeApi.md#sessionswipesaveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


<a name="sessionswipedelete"></a>
# **SessionswipeDelete**
> void SessionswipeDelete (Guid? id, AnyType body)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionswipeApi();
            var id = new Guid?(); // Guid? | The id of the session swipe to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a session swipe
                apiInstance.SessionswipeDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the session swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipeget"></a>
# **SessionswipeGet**
> void SessionswipeGet (Guid? id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionswipeApi();
            var id = new Guid?(); // Guid? | The id of the swipe to get.

            try
            {
                // View details of a class attendance swipe
                apiInstance.SessionswipeGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipelistunresolved"></a>
# **SessionswipeListunresolved**
> void SessionswipeListunresolved (int? from, int? count)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeListunresolvedExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionswipeApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of unresolved swipes
                apiInstance.SessionswipeListunresolved(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeListunresolved: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswiperesolve"></a>
# **SessionswipeResolve**
> void SessionswipeResolve (Guid? id, Guid? session, Guid? user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeResolveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionswipeApi();
            var id = new Guid?(); // Guid? | The id of the swipe to resolve.
            var session = new Guid?(); // Guid? | The id of the session whose swipe has to be saved. (optional) 
            var user = new Guid?(); // Guid? | The id of the user who signed-in. (optional) 

            try
            {
                // Resolve a swipe and create the corresponding attendance log
                apiInstance.SessionswipeResolve(id, session, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeResolve: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the swipe to resolve. | 
 **session** | [**Guid?**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**Guid?**](.md)| The id of the user who signed-in. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionswipesave"></a>
# **SessionswipeSave**
> void SessionswipeSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionswipeApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe, and if possible, creates the attendance log
                apiInstance.SessionswipeSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeSave: " + e.Message );
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

<a name="sessionswipesaveanonym"></a>
# **SessionswipeSaveanonym**
> void SessionswipeSaveanonym (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionswipeSaveanonymExample
    {
        public void main()
        {
            var apiInstance = new SessionswipeApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Creates a new swipe from a sign-in station, and if possible, creates the attendance log
                apiInstance.SessionswipeSaveanonym(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionswipeApi.SessionswipeSaveanonym: " + e.Message );
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

