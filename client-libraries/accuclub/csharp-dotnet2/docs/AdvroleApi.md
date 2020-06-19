# Org.OpenAPITools.Api.AdvroleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AdvroleAddmissing**](AdvroleApi.md#advroleaddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**AdvroleCheckperm**](AdvroleApi.md#advrolecheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**AdvroleDelete**](AdvroleApi.md#advroledelete) | **DELETE** /advrole/{id} | Delete a role
[**AdvroleDeletemapping**](AdvroleApi.md#advroledeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**AdvroleGet**](AdvroleApi.md#advroleget) | **GET** /advrole/{id} | View details of a role
[**AdvroleList**](AdvroleApi.md#advrolelist) | **GET** /advrole/list | Lists the roles for the current account
[**AdvroleListmaps**](AdvroleApi.md#advrolelistmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**AdvroleListrolesmapped**](AdvroleApi.md#advrolelistrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**AdvroleListtemplates**](AdvroleApi.md#advrolelisttemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**AdvroleSave**](AdvroleApi.md#advrolesave) | **POST** /advrole/{id} | Create or edit a role
[**AdvroleSavemapping**](AdvroleApi.md#advrolesavemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**AdvroleUserupgrade**](AdvroleApi.md#advroleuserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)


<a name="advroleaddmissing"></a>
# **AdvroleAddmissing**
> void AdvroleAddmissing (string roles, string permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleAddmissingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Adds the missing permissions to a role. Requires access to advrole.save
                apiInstance.AdvroleAddmissing(roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleAddmissing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolecheckperm"></a>
# **AdvroleCheckperm**
> void AdvroleCheckperm (string roles, string permissions)

Checks the permissions are assigned for the given roles

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleCheckpermExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var roles = roles_example;  // string | CSV list of the role ids to check
            var permissions = permissions_example;  // string | CSV list of the permissions to check

            try
            {
                // Checks the permissions are assigned for the given roles
                apiInstance.AdvroleCheckperm(roles, permissions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleCheckperm: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check | 
 **permissions** | **string**| CSV list of the permissions to check | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroledelete"></a>
# **AdvroleDelete**
> void AdvroleDelete (Guid? id, AnyType body)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var id = new Guid?(); // Guid? | The id of the location to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a role
                apiInstance.AdvroleDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advroledeletemapping"></a>
# **AdvroleDeletemapping**
> void AdvroleDeletemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleDeletemappingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Delete a role mapping
                apiInstance.AdvroleDeletemapping(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleDeletemapping: " + e.Message );
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

<a name="advroleget"></a>
# **AdvroleGet**
> void AdvroleGet (Guid? id)

View details of a role

Allows the user to view a role and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var id = new Guid?(); // Guid? | The id of the location to get.

            try
            {
                // View details of a role
                apiInstance.AdvroleGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the location to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelist"></a>
# **AdvroleList**
> void AdvroleList (bool? includepolicies, bool? includeinternal, string name)

Lists the roles for the current account

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var includepolicies = true;  // bool? | True to include the policies, defaults to false. (optional) 
            var includeinternal = true;  // bool? | True to include the internal roles too. (optional) 
            var name = name_example;  // string | Filter by name of the role. (optional) 

            try
            {
                // Lists the roles for the current account
                apiInstance.AdvroleList(includepolicies, includeinternal, name);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **bool?**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **bool?**| True to include the internal roles too. | [optional] 
 **name** | **string**| Filter by name of the role. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistmaps"></a>
# **AdvroleListmaps**
> void AdvroleListmaps (Guid? roleid)

Lists the maps a roles is mapped to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleListmapsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var roleid = new Guid?(); // Guid? | The id of the role to list the maps.

            try
            {
                // Lists the maps a roles is mapped to
                apiInstance.AdvroleListmaps(roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleListmaps: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**Guid?**](.md)| The id of the role to list the maps. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelistrolesmapped"></a>
# **AdvroleListrolesmapped**
> void AdvroleListrolesmapped (string map)

Lists the roles mappings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleListrolesmappedExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var map = map_example;  // string | List only the roles in the specified map. (optional) 

            try
            {
                // Lists the roles mappings
                apiInstance.AdvroleListrolesmapped(map);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleListrolesmapped: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map** | **string**| List only the roles in the specified map. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolelisttemplates"></a>
# **AdvroleListtemplates**
> void AdvroleListtemplates ()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleListtemplatesExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();

            try
            {
                // View a list of role templates
                apiInstance.AdvroleListtemplates();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleListtemplates: " + e.Message );
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

<a name="advrolesave"></a>
# **AdvroleSave**
> void AdvroleSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var id = new Guid?(); // Guid? | The id of the role to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a role
                apiInstance.AdvroleSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the role to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="advrolesavemapping"></a>
# **AdvroleSavemapping**
> void AdvroleSavemapping (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleSavemappingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves a role mapping
                apiInstance.AdvroleSavemapping(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleSavemapping: " + e.Message );
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

<a name="advroleuserupgrade"></a>
# **AdvroleUserupgrade**
> void AdvroleUserupgrade (Guid? userid, Guid? roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AdvroleUserupgradeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AdvroleApi();
            var userid = new Guid?(); // Guid? | Id of the user to upgrade
            var roleid = new Guid?(); // Guid? | Id of the role to add

            try
            {
                // Upgrade a user to another role (requires permission to edit those roles)
                apiInstance.AdvroleUserupgrade(userid, roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AdvroleApi.AdvroleUserupgrade: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| Id of the user to upgrade | 
 **roleid** | [**Guid?**](.md)| Id of the role to add | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

