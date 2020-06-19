# Org.OpenAPITools.Api.UsergroupApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsergroupAddmember**](UsergroupApi.md#usergroupaddmember) | **GET** /usergroup/addmember | Add a user to a group
[**UsergroupDelete**](UsergroupApi.md#usergroupdelete) | **DELETE** /usergroup/{id} | Delete a group
[**UsergroupGet**](UsergroupApi.md#usergroupget) | **GET** /usergroup/{id} | Search and view details of a user group
[**UsergroupGetmembers**](UsergroupApi.md#usergroupgetmembers) | **GET** /usergroup/getmembers | View the members of a user group
[**UsergroupGetuser**](UsergroupApi.md#usergroupgetuser) | **GET** /usergroup/getuser | View the groups which a user is registered to
[**UsergroupList**](UsergroupApi.md#usergrouplist) | **GET** /usergroup/list | View a list of user groups
[**UsergroupRefresh**](UsergroupApi.md#usergrouprefresh) | **GET** /usergroup/refresh | Refresh the dynamic group
[**UsergroupRemovemember**](UsergroupApi.md#usergroupremovemember) | **GET** /usergroup/removemember | Remove a user from a group
[**UsergroupSave**](UsergroupApi.md#usergroupsave) | **POST** /usergroup/{id} | Create or edit a group


<a name="usergroupaddmember"></a>
# **UsergroupAddmember**
> void UsergroupAddmember (Guid? userid, Guid? groupid)

Add a user to a group

Allows the user to add a user to a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupAddmemberExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Add a user to a group
                apiInstance.UsergroupAddmember(userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupAddmember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupdelete"></a>
# **UsergroupDelete**
> void UsergroupDelete (Guid? id, AnyType body)

Delete a group

Allows the user to delete a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var id = new Guid?(); // Guid? | The id of the group to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a group
                apiInstance.UsergroupDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupget"></a>
# **UsergroupGet**
> void UsergroupGet (Guid? id)

Search and view details of a user group

Allows the user to view a user group and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var id = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // Search and view details of a user group
                apiInstance.UsergroupGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetmembers"></a>
# **UsergroupGetmembers**
> void UsergroupGetmembers (Guid? groupid)

View the members of a user group

Allows the user to view the list of users in a group that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupGetmembersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var groupid = new Guid?(); // Guid? | The id of the user group to get.

            try
            {
                // View the members of a user group
                apiInstance.UsergroupGetmembers(groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupGetmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **groupid** | [**Guid?**](.md)| The id of the user group to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupgetuser"></a>
# **UsergroupGetuser**
> void UsergroupGetuser (Guid? userid)

View the groups which a user is registered to

Allows the user to view the groups an individual user is registered to, based on group and user permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupGetuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var userid = new Guid?(); // Guid? | The id of the user to get his groups.

            try
            {
                // View the groups which a user is registered to
                apiInstance.UsergroupGetuser(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupGetuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to get his groups. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouplist"></a>
# **UsergroupList**
> void UsergroupList (int? from, int? count, string type)

View a list of user groups

Allows the user to view the list of groups that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 
            var type = type_example;  // string | The type of the groups to return. Either 'user', 'dynamic' or any other type of group. (optional) 

            try
            {
                // View a list of user groups
                apiInstance.UsergroupList(from, count, type);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int?**| The first record to return. | [optional] 
 **count** | **int?**| The max number of records to return. | [optional] 
 **type** | **string**| The type of the groups to return. Either &#39;user&#39;, &#39;dynamic&#39; or any other type of group. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergrouprefresh"></a>
# **UsergroupRefresh**
> void UsergroupRefresh (Guid? group)

Refresh the dynamic group

Allows the user to refresh a dynamic group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupRefreshExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var group = new Guid?(); // Guid? | The ID of the group to refresh.

            try
            {
                // Refresh the dynamic group
                apiInstance.UsergroupRefresh(group);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupRefresh: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**Guid?**](.md)| The ID of the group to refresh. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupremovemember"></a>
# **UsergroupRemovemember**
> void UsergroupRemovemember (Guid? userid, Guid? groupid)

Remove a user from a group

Allows the user to remove a user from a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupRemovememberExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var groupid = new Guid?(); // Guid? | The id of the group.

            try
            {
                // Remove a user from a group
                apiInstance.UsergroupRemovemember(userid, groupid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupRemovemember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **groupid** | [**Guid?**](.md)| The id of the group. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergroupsave"></a>
# **UsergroupSave**
> void UsergroupSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a group

Allows the user to create a new group or edit a group that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UsergroupSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UsergroupApi();
            var id = new Guid?(); // Guid? | The id of the group to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a group
                apiInstance.UsergroupSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsergroupApi.UsergroupSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the group to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

