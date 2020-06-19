# Org.OpenAPITools.Api.ActionassignmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActionassignmentDelete**](ActionassignmentApi.md#actionassignmentdelete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**ActionassignmentGet**](ActionassignmentApi.md#actionassignmentget) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**ActionassignmentList**](ActionassignmentApi.md#actionassignmentlist) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**ActionassignmentListhistory**](ActionassignmentApi.md#actionassignmentlisthistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**ActionassignmentListmine**](ActionassignmentApi.md#actionassignmentlistmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**ActionassignmentListpublichistory**](ActionassignmentApi.md#actionassignmentlistpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**ActionassignmentMarkcomplete**](ActionassignmentApi.md#actionassignmentmarkcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**ActionassignmentSave**](ActionassignmentApi.md#actionassignmentsave) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**ActionassignmentSavehistory**](ActionassignmentApi.md#actionassignmentsavehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user


<a name="actionassignmentdelete"></a>
# **ActionassignmentDelete**
> void ActionassignmentDelete (Guid? id, AnyType body)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var id = new Guid?(); // Guid? | The id of the action assignment to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Remove an action item from an action plan
                apiInstance.ActionassignmentDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action assignment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentget"></a>
# **ActionassignmentGet**
> void ActionassignmentGet (Guid? id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var id = new Guid?(); // Guid? | The id of the action assignment to get.

            try
            {
                // Search and view details of an action item assigned to a user
                apiInstance.ActionassignmentGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the action assignment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlist"></a>
# **ActionassignmentList**
> void ActionassignmentList (int? from, int? count, int? assignee, int? status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var assignee = 56;  // int? | The assignee's id to filter the assignments. (optional) 
            var status = 56;  // int? | The status to filter the assignments. (optional) 

            try
            {
                // View a list of action items in a user's plan
                apiInstance.ActionassignmentList(from, count, assignee, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentList: " + e.Message );
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
 **assignee** | **int?**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **int?**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlisthistory"></a>
# **ActionassignmentListhistory**
> void ActionassignmentListhistory (Guid? actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentListhistoryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var actionassignment = new Guid?(); // Guid? | The action assignment's id whose history the user wants to get.

            try
            {
                // View the history of an action item assigned to a user
                apiInstance.ActionassignmentListhistory(actionassignment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentListhistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**Guid?**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlistmine"></a>
# **ActionassignmentListmine**
> void ActionassignmentListmine (int? from, int? count, int? status)

List public action assignments assigned to the logged user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentListmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | The status to filter the assignments. (optional) 

            try
            {
                // List public action assignments assigned to the logged user
                apiInstance.ActionassignmentListmine(from, count, status);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentListmine: " + e.Message );
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
 **status** | **int?**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentlistpublichistory"></a>
# **ActionassignmentListpublichistory**
> void ActionassignmentListpublichistory (Guid? actionassignment)

List public action assignment history

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentListpublichistoryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var actionassignment = new Guid?(); // Guid? | The action assignment's id whose history the user wants to get.

            try
            {
                // List public action assignment history
                apiInstance.ActionassignmentListpublichistory(actionassignment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentListpublichistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**Guid?**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentmarkcomplete"></a>
# **ActionassignmentMarkcomplete**
> void ActionassignmentMarkcomplete (string item, Guid? assignee, Guid? group, string notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentMarkcompleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var item = item_example;  // string | The action item to assign.
            var assignee = new Guid?(); // Guid? | The assignee of the item. (optional) 
            var group = new Guid?(); // Guid? | The group to assing the item. (optional) 
            var notes = notes_example;  // string | The assignment's notes. (optional) 

            try
            {
                // Bulk complete action items
                apiInstance.ActionassignmentMarkcomplete(item, assignee, group, notes);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentMarkcomplete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **string**| The action item to assign. | 
 **assignee** | [**Guid?**](.md)| The assignee of the item. | [optional] 
 **group** | [**Guid?**](.md)| The group to assing the item. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="actionassignmentsave"></a>
# **ActionassignmentSave**
> void ActionassignmentSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Add an action item to a user's action plan
                apiInstance.ActionassignmentSave(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentSave: " + e.Message );
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

<a name="actionassignmentsavehistory"></a>
# **ActionassignmentSavehistory**
> void ActionassignmentSavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ActionassignmentSavehistoryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ActionassignmentApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Update an action item assigned to a user
                apiInstance.ActionassignmentSavehistory(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ActionassignmentApi.ActionassignmentSavehistory: " + e.Message );
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

