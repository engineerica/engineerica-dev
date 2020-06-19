# Org.OpenAPITools.Api.ActiontypeApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActiontypeDelete**](ActiontypeApi.md#actiontypedelete) | **DELETE** /actiontype/{id} | Delete an action item type
[**ActiontypeGet**](ActiontypeApi.md#actiontypeget) | **GET** /actiontype/{id} | View details of an action item type
[**ActiontypeList**](ActiontypeApi.md#actiontypelist) | **GET** /actiontype/list | View a list of action item types
[**ActiontypeSave**](ActiontypeApi.md#actiontypesave) | **POST** /actiontype/{id} | Create or edit an action item type


<a name="actiontypedelete"></a>
# **ActiontypeDelete**
> void ActiontypeDelete (Guid? id, AnyType body)

Delete an action item type

Allows the user to delete an action item type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypeDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActiontypeApi();
            var id = new Guid?(); // Guid? | The id of the action type to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an action item type
                apiInstance.ActiontypeDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiontypeApi.ActiontypeDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action type to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypeget"></a>
# **ActiontypeGet**
> void ActiontypeGet (Guid? id)

View details of an action item type

Allows the user to view an individual action item type and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypeGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActiontypeApi();
            var id = new Guid?(); // Guid? | The id of the action type to get.

            try
            {
                // View details of an action item type
                apiInstance.ActiontypeGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiontypeApi.ActiontypeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action type to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actiontypelist"></a>
# **ActiontypeList**
> void ActiontypeList (int? from, int? count)

View a list of action item types

Allows the user to view the full list of action item types.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypeListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActiontypeApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of action item types
                apiInstance.ActiontypeList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiontypeApi.ActiontypeList: " + e.Message );
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

<a name="actiontypesave"></a>
# **ActiontypeSave**
> void ActiontypeSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an action item type

Allows the user to dit an action item type.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActiontypeSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActiontypeApi();
            var id = new Guid?(); // Guid? | The id of the action type to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an action item type
                apiInstance.ActiontypeSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActiontypeApi.ActiontypeSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action type to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

