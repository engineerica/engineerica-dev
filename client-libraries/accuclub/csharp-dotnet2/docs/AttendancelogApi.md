# Org.OpenAPITools.Api.AttendancelogApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AttendancelogDelete**](AttendancelogApi.md#attendancelogdelete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**AttendancelogGet**](AttendancelogApi.md#attendancelogget) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**AttendancelogGetchangehistory**](AttendancelogApi.md#attendanceloggetchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**AttendancelogList**](AttendancelogApi.md#attendanceloglist) | **GET** /attendancelog/list | View a list of attendance logs
[**AttendancelogListmine**](AttendancelogApi.md#attendanceloglistmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**AttendancelogSave**](AttendancelogApi.md#attendancelogsave) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**AttendancelogSignout**](AttendancelogApi.md#attendancelogsignout) | **GET** /attendancelog/signout | Sign out an attendance log
[**AttendancelogWhosin**](AttendancelogApi.md#attendancelogwhosin) | **GET** /attendancelog/whosin | View who&#39;s in a location


<a name="attendancelogdelete"></a>
# **AttendancelogDelete**
> void AttendancelogDelete (Guid? id, AnyType body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete an attendance log
                apiInstance.AttendancelogDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogget"></a>
# **AttendancelogGet**
> void AttendancelogGet (Guid? id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log
                apiInstance.AttendancelogGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloggetchangehistory"></a>
# **AttendancelogGetchangehistory**
> void AttendancelogGetchangehistory (Guid? id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogGetchangehistoryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log to get.

            try
            {
                // Search and view details of an attendance log's swipe history
                apiInstance.AttendancelogGetchangehistory(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogGetchangehistory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglist"></a>
# **AttendancelogList**
> void AttendancelogList (int? from, int? count, string filter, Guid? userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 
            var userid = new Guid?(); // Guid? | The user ID of the user to get the logs. (optional) 

            try
            {
                // View a list of attendance logs
                apiInstance.AttendancelogList(from, count, filter, userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogList: " + e.Message );
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
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**Guid?**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendanceloglistmine"></a>
# **AttendancelogListmine**
> void AttendancelogListmine (int? from, int? count, string filter)

Gets the attendance logs of the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogListmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var filter = filter_example;  // string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. (optional) 

            try
            {
                // Gets the attendance logs of the current user
                apiInstance.AttendancelogListmine(from, count, filter);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogListmine: " + e.Message );
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
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogsave"></a>
# **AttendancelogSave**
> void AttendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var id = new Guid?(); // Guid? | The id of the room to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit an attendance log
                apiInstance.AttendancelogSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the room to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogsignout"></a>
# **AttendancelogSignout**
> void AttendancelogSignout (Guid? id, Guid? location, Guid? _event, DateTime? datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogSignoutExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log to sign-out. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to filter the users to sign out. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to filter the users to sign out. (optional) 
            var datetime = 2013-10-20T19:20:30+01:00;  // DateTime? | Specifies the date and time when the specified logs have to be signed out. (optional) 

            try
            {
                // Sign out an attendance log
                apiInstance.AttendancelogSignout(id, location, _event, datetime);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogSignout: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime?**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="attendancelogwhosin"></a>
# **AttendancelogWhosin**
> void AttendancelogWhosin (int? from, int? count, Guid? location, Guid? _event, string sorting, string roles, int? photosize, string extensions, bool? export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class AttendancelogWhosinExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AttendancelogApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var location = new Guid?(); // Guid? | The id of the location to search for users that are in. (optional) 
            var _event = new Guid?(); // Guid? | The id of the event to search for users that are in. (optional) 
            var sorting = sorting_example;  // string | Field to sort by. Either first-name, last-name or sign-in-time. (optional) 
            var roles = roles_example;  // string | The comma-separated list of ids of the roles to search for users that are in. (optional) 
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 
            var extensions = extensions_example;  // string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]). (optional) 
            var export = true;  // bool? | True to export the results as CSV (optional) 

            try
            {
                // View who's in a location
                apiInstance.AttendancelogWhosin(from, count, location, _event, sorting, roles, photosize, extensions, export);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AttendancelogApi.AttendancelogWhosin: " + e.Message );
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
 **location** | [**Guid?**](.md)| The id of the location to search for users that are in. | [optional] 
 **_event** | [**Guid?**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **bool?**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

