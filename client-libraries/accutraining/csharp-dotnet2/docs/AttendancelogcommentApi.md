# Org.OpenAPITools.Api.AttendancelogcommentApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancelogcommentDelete**](AttendancelogcommentApi.md#attendancelogcommentdelete) | **DELETE** /attendancelogcomment/{id} | Delete a comment on an attendance log
[**AttendancelogcommentGet**](AttendancelogcommentApi.md#attendancelogcommentget) | **GET** /attendancelogcomment/{id} | View a comment on an attendance log
[**AttendancelogcommentList**](AttendancelogcommentApi.md#attendancelogcommentlist) | **GET** /attendancelogcomment/list | View all the comments on a specific attendance log
[**AttendancelogcommentSave**](AttendancelogcommentApi.md#attendancelogcommentsave) | **POST** /attendancelogcomment/{id} | Save a comment on an attendance log


<a name="attendancelogcommentdelete"></a>
# **AttendancelogcommentDelete**
> void AttendancelogcommentDelete (Guid? id, AnyType body)

Delete a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogcommentApi();
            var id = new Guid?(); // Guid? | The id of the attendance log comment to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a comment on an attendance log
                apiInstance.AttendancelogcommentDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogcommentApi.AttendancelogcommentDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log comment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentget"></a>
# **AttendancelogcommentGet**
> void AttendancelogcommentGet (Guid? id)

View a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogcommentApi();
            var id = new Guid?(); // Guid? | The id of the comment to get.

            try
            {
                // View a comment on an attendance log
                apiInstance.AttendancelogcommentGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogcommentApi.AttendancelogcommentGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the comment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentlist"></a>
# **AttendancelogcommentList**
> void AttendancelogcommentList (Guid? attendancelog)

View all the comments on a specific attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogcommentApi();
            var attendancelog = new Guid?(); // Guid? | The id of the attendance log whose comments have to be retrieved.

            try
            {
                // View all the comments on a specific attendance log
                apiInstance.AttendancelogcommentList(attendancelog);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogcommentApi.AttendancelogcommentList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendancelog** | [**Guid?**](.md)| The id of the attendance log whose comments have to be retrieved. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogcommentsave"></a>
# **AttendancelogcommentSave**
> void AttendancelogcommentSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save a comment on an attendance log

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogcommentSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogcommentApi();
            var id = new Guid?(); // Guid? | The id of the comment to edit (leave empty to create a new one)
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save a comment on an attendance log
                apiInstance.AttendancelogcommentSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogcommentApi.AttendancelogcommentSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the comment to edit (leave empty to create a new one) | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

