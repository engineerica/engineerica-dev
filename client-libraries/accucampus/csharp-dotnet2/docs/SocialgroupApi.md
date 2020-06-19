# Org.OpenAPITools.Api.SocialgroupApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SocialgroupAddmembers**](SocialgroupApi.md#socialgroupaddmembers) | **GET** /socialgroup/addmembers | Adds new members to a group (which the user must own already)
[**SocialgroupDelete**](SocialgroupApi.md#socialgroupdelete) | **DELETE** /socialgroup/{id} | Deletes a group
[**SocialgroupList**](SocialgroupApi.md#socialgrouplist) | **GET** /socialgroup/list | View all the groups the current user is in
[**SocialgroupListmembers**](SocialgroupApi.md#socialgrouplistmembers) | **GET** /socialgroup/listmembers | Lists the members of a group
[**SocialgroupRemovemembers**](SocialgroupApi.md#socialgroupremovemembers) | **GET** /socialgroup/removemembers | Removes members from a group (which the user must own already)
[**SocialgroupRemovemyself**](SocialgroupApi.md#socialgroupremovemyself) | **GET** /socialgroup/removemyself | Removes myself from an existent group
[**SocialgroupSave**](SocialgroupApi.md#socialgroupsave) | **POST** /socialgroup/{id} | Saves a new group


<a name="socialgroupaddmembers"></a>
# **SocialgroupAddmembers**
> void SocialgroupAddmembers (Guid? id, string userids)

Adds new members to a group (which the user must own already)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupAddmembersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to add members to.
            var userids = userids_example;  // string | Csv list of user Ids to add.

            try
            {
                // Adds new members to a group (which the user must own already)
                apiInstance.SocialgroupAddmembers(id, userids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupAddmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to add members to. | 
 **userids** | **string**| Csv list of user Ids to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupdelete"></a>
# **SocialgroupDelete**
> void SocialgroupDelete (Guid? id, AnyType body)

Deletes a group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Deletes a group
                apiInstance.SocialgroupDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgrouplist"></a>
# **SocialgroupList**
> void SocialgroupList ()

View all the groups the current user is in

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();

            try
            {
                // View all the groups the current user is in
                apiInstance.SocialgroupList();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupList: " + e.Message );
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

<a name="socialgrouplistmembers"></a>
# **SocialgroupListmembers**
> void SocialgroupListmembers (Guid? id)

Lists the members of a group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupListmembersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to list members.

            try
            {
                // Lists the members of a group
                apiInstance.SocialgroupListmembers(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupListmembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to list members. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupremovemembers"></a>
# **SocialgroupRemovemembers**
> void SocialgroupRemovemembers (Guid? id, string userids)

Removes members from a group (which the user must own already)

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupRemovemembersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to remove members from.
            var userids = userids_example;  // string | Csv list of user Ids to remove.

            try
            {
                // Removes members from a group (which the user must own already)
                apiInstance.SocialgroupRemovemembers(id, userids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupRemovemembers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to remove members from. | 
 **userids** | **string**| Csv list of user Ids to remove. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupremovemyself"></a>
# **SocialgroupRemovemyself**
> void SocialgroupRemovemyself (Guid? id)

Removes myself from an existent group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupRemovemyselfExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to remove me from.

            try
            {
                // Removes myself from an existent group
                apiInstance.SocialgroupRemovemyself(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupRemovemyself: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to remove me from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="socialgroupsave"></a>
# **SocialgroupSave**
> void SocialgroupSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a new group

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SocialgroupSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SocialgroupApi();
            var id = new Guid?(); // Guid? | ID of the group to update. Leave blank to create new.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a new group
                apiInstance.SocialgroupSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SocialgroupApi.SocialgroupSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| ID of the group to update. Leave blank to create new. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

