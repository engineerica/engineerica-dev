# Org.OpenAPITools.Api.DepartmentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DepartmentDelete**](DepartmentApi.md#departmentdelete) | **DELETE** /department/{id} | Delete a college department
[**DepartmentGet**](DepartmentApi.md#departmentget) | **GET** /department/{id} | Search and view details of a college department
[**DepartmentList**](DepartmentApi.md#departmentlist) | **GET** /department/list | View a list of college departments
[**DepartmentSave**](DepartmentApi.md#departmentsave) | **POST** /department/{id} | Create or edit a college department


<a name="departmentdelete"></a>
# **DepartmentDelete**
> void DepartmentDelete (Guid? id, AnyType body)

Delete a college department

Allows the user to delete an existing college department.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi();
            var id = new Guid?(); // Guid? | The id of the department to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a college department
                apiInstance.DepartmentDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepartmentApi.DepartmentDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the department to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentget"></a>
# **DepartmentGet**
> void DepartmentGet (Guid? id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi();
            var id = new Guid?(); // Guid? | The id of the department to get.

            try
            {
                // Search and view details of a college department
                apiInstance.DepartmentGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepartmentApi.DepartmentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the department to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="departmentlist"></a>
# **DepartmentList**
> void DepartmentList (int? from, int? count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.

            try
            {
                // View a list of college departments
                apiInstance.DepartmentList(from, count);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepartmentApi.DepartmentList: " + e.Message );
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

<a name="departmentsave"></a>
# **DepartmentSave**
> void DepartmentSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a college department

Allows the user to create or edit a college department.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DepartmentSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi();
            var id = new Guid?(); // Guid? | The id of the department save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a college department
                apiInstance.DepartmentSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DepartmentApi.DepartmentSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the department save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

