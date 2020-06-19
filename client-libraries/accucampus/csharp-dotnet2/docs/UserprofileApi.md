# Org.OpenAPITools.Api.UserprofileApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserprofileDelete**](UserprofileApi.md#userprofiledelete) | **DELETE** /userprofile/{id} | Delete a user profile
[**UserprofileGet**](UserprofileApi.md#userprofileget) | **GET** /userprofile/{id} | View a specific user profile
[**UserprofileGetallview**](UserprofileApi.md#userprofilegetallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**UserprofileList**](UserprofileApi.md#userprofilelist) | **GET** /userprofile/list | View the list of user profiles
[**UserprofileListquestions**](UserprofileApi.md#userprofilelistquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
[**UserprofilePreparestats**](UserprofileApi.md#userprofilepreparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
[**UserprofileSave**](UserprofileApi.md#userprofilesave) | **POST** /userprofile/{id} | Create or edit user profile questions
[**UserprofileSaveanswers**](UserprofileApi.md#userprofilesaveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.


<a name="userprofiledelete"></a>
# **UserprofileDelete**
> void UserprofileDelete (Guid? id, AnyType body)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var id = new Guid?(); // Guid? | The id of the user profile to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a user profile
                apiInstance.UserprofileDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user profile to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofileget"></a>
# **UserprofileGet**
> void UserprofileGet (Guid? id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var id = new Guid?(); // Guid? | The id of the profile question set.

            try
            {
                // View a specific user profile
                apiInstance.UserprofileGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the profile question set. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilegetallview"></a>
# **UserprofileGetallview**
> void UserprofileGetallview (Guid? id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileGetallviewExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var id = new Guid?(); // Guid? | The id of the user to view, or empty for current user. (optional) 

            try
            {
                // Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
                apiInstance.UserprofileGetallview(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileGetallview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the user to view, or empty for current user. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilelist"></a>
# **UserprofileList**
> void UserprofileList (int? from, int? count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var from = 56;  // int? | The first record to return. (optional) 
            var count = 56;  // int? | The max number of records to return. (optional) 

            try
            {
                // View the list of user profiles
                apiInstance.UserprofileList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileList: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilelistquestions"></a>
# **UserprofileListquestions**
> void UserprofileListquestions ()

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileListquestionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();

            try
            {
                // Gets the list of all the available user questions
                apiInstance.UserprofileListquestions();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileListquestions: " + e.Message );
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

<a name="userprofilepreparestats"></a>
# **UserprofilePreparestats**
> void UserprofilePreparestats (string _params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofilePreparestatsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var _params = _params_example;  // string | The ID of the group, specified as 'group=...' (optional) 

            try
            {
                // Gets the statistics of a user group
                apiInstance.UserprofilePreparestats(_params);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofilePreparestats: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **_params** | **string**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilesave"></a>
# **UserprofileSave**
> void UserprofileSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var id = new Guid?(); // Guid? | The id of the profile question set.
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit user profile questions
                apiInstance.UserprofileSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the profile question set. | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userprofilesaveanswers"></a>
# **UserprofileSaveanswers**
> void UserprofileSaveanswers (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserprofileSaveanswersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserprofileApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
                apiInstance.UserprofileSaveanswers(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UserprofileApi.UserprofileSaveanswers: " + e.Message );
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

