# Org.OpenAPITools.Api.AttendancerestrictionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancerestrictionDelete**](AttendancerestrictionApi.md#attendancerestrictiondelete) | **DELETE** /attendancerestriction/{id} | Delete an attendance restriction
[**AttendancerestrictionGet**](AttendancerestrictionApi.md#attendancerestrictionget) | **GET** /attendancerestriction/{id} | View details of an attendance restriction
[**AttendancerestrictionList**](AttendancerestrictionApi.md#attendancerestrictionlist) | **GET** /attendancerestriction/list | View a list of attendance restrictions
[**AttendancerestrictionSave**](AttendancerestrictionApi.md#attendancerestrictionsave) | **POST** /attendancerestriction/{id} | Create or edit an attendance restriction


<a name="attendancerestrictiondelete"></a>
# **AttendancerestrictionDelete**
> void AttendancerestrictionDelete (Guid? id, AnyType body)

Delete an attendance restriction

Allows the user to delete an existing attendance restriction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancerestrictionApi();
            var id = new Guid?(); // Guid? | The id of the restriction to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an attendance restriction
                apiInstance.AttendancerestrictionDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancerestrictionApi.AttendancerestrictionDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the restriction to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictionget"></a>
# **AttendancerestrictionGet**
> void AttendancerestrictionGet (Guid? id)

View details of an attendance restriction

Allows the user to view an individual attendance restriction and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancerestrictionApi();
            var id = new Guid?(); // Guid? | The id of the restriction to get.

            try
            {
                // View details of an attendance restriction
                apiInstance.AttendancerestrictionGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancerestrictionApi.AttendancerestrictionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the restriction to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancerestrictionlist"></a>
# **AttendancerestrictionList**
> void AttendancerestrictionList (int? from, int? count)

View a list of attendance restrictions

Allows the user to view the list of all attendance restrictions.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancerestrictionApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of attendance restrictions
                apiInstance.AttendancerestrictionList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancerestrictionApi.AttendancerestrictionList: " + e.Message );
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

<a name="attendancerestrictionsave"></a>
# **AttendancerestrictionSave**
> void AttendancerestrictionSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an attendance restriction

Allows the user to create or edit an attendance restriction.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancerestrictionSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancerestrictionApi();
            var id = new Guid?(); // Guid? | The id of the restriction save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an attendance restriction
                apiInstance.AttendancerestrictionSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancerestrictionApi.AttendancerestrictionSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the restriction save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

