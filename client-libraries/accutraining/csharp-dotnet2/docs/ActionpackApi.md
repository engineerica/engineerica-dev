# Org.OpenAPITools.Api.ActionpackApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionpackAssign**](ActionpackApi.md#actionpackassign) | **GET** /actionpack/assign | Assign an action item pack to a user
[**ActionpackDelete**](ActionpackApi.md#actionpackdelete) | **DELETE** /actionpack/{id} | Delete an action item pack
[**ActionpackGet**](ActionpackApi.md#actionpackget) | **GET** /actionpack/{id} | View details of an action item pack
[**ActionpackList**](ActionpackApi.md#actionpacklist) | **GET** /actionpack/list | View a list of action item packs
[**ActionpackSave**](ActionpackApi.md#actionpacksave) | **POST** /actionpack/{id} | Create or edit an action item pack


<a name="actionpackassign"></a>
# **ActionpackAssign**
> void ActionpackAssign (Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackAssignExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionpackApi();
            var pack = new Guid?(); // Guid? | The id of the action pack to assign.
            var itemsdata = true;  // bool? | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
            var assignee = new Guid?(); // Guid? | The assignee of the pack. (optional) 
            var group = new Guid?(); // Guid? | The group to assign the pack. (optional) 
            var notes = notes_example;  // string | The assignment's notes. (optional) 

            try
            {
                // Assign an action item pack to a user
                apiInstance.ActionpackAssign(pack, itemsdata, assignee, group, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionpackApi.ActionpackAssign: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pack** | [**Guid?**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **bool?**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**Guid?**](.md)| The assignee of the pack. | [optional] 
 **group** | [**Guid?**](.md)| The group to assign the pack. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpackdelete"></a>
# **ActionpackDelete**
> void ActionpackDelete (Guid? id, AnyType body)

Delete an action item pack

Allows the user to delete an action item pack.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionpackApi();
            var id = new Guid?(); // Guid? | The id of the action pack to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an action item pack
                apiInstance.ActionpackDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionpackApi.ActionpackDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action pack to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpackget"></a>
# **ActionpackGet**
> void ActionpackGet (Guid? id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionpackApi();
            var id = new Guid?(); // Guid? | The id of the action pack to get.

            try
            {
                // View details of an action item pack
                apiInstance.ActionpackGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionpackApi.ActionpackGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action pack to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionpacklist"></a>
# **ActionpackList**
> void ActionpackList (int? from, int? count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionpackApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of action item packs
                apiInstance.ActionpackList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionpackApi.ActionpackList: " + e.Message );
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

<a name="actionpacksave"></a>
# **ActionpackSave**
> void ActionpackSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionpackSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionpackApi();
            var id = new Guid?(); // Guid? | The id of the action pack to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an action item pack
                apiInstance.ActionpackSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionpackApi.ActionpackSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action pack to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

