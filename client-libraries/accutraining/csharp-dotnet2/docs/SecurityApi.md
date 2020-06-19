# Org.OpenAPITools.Api.SecurityApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SecurityAssesspermission**](SecurityApi.md#securityassesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**SecurityAssessrole**](SecurityApi.md#securityassessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**SecurityAssessscope**](SecurityApi.md#securityassessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**SecurityAssessuser**](SecurityApi.md#securityassessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user


<a name="securityassesspermission"></a>
# **SecurityAssesspermission**
> void SecurityAssesspermission (string commandname)

Returns the list of users for a specific permission

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityAssesspermissionExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var commandname = commandname_example;  // string | Name of the action or command to get the roles.

            try
            {
                // Returns the list of users for a specific permission
                apiInstance.SecurityAssesspermission(commandname);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAssesspermission: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commandname** | **string**| Name of the action or command to get the roles. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessrole"></a>
# **SecurityAssessrole**
> void SecurityAssessrole (Guid? roleid)

Returns the list of permissions for a specific role

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityAssessroleExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var roleid = new Guid?(); // Guid? | Role ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific role
                apiInstance.SecurityAssessrole(roleid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAssessrole: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**Guid?**](.md)| Role ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessscope"></a>
# **SecurityAssessscope**
> void SecurityAssessscope (Guid? locationid)

Returns the list of users for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityAssessscopeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var locationid = new Guid?(); // Guid? | Location ID to list the users with that scope. (optional) 

            try
            {
                // Returns the list of users for a specific user
                apiInstance.SecurityAssessscope(locationid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAssessscope: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**Guid?**](.md)| Location ID to list the users with that scope. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="securityassessuser"></a>
# **SecurityAssessuser**
> void SecurityAssessuser (Guid? userid)

Returns the list of permissions for a specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SecurityAssessuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SecurityApi();
            var userid = new Guid?(); // Guid? | User ID to list the effective permissions.

            try
            {
                // Returns the list of permissions for a specific user
                apiInstance.SecurityAssessuser(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SecurityApi.SecurityAssessuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| User ID to list the effective permissions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

