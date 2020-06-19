# Org.OpenAPITools.Api.SessionattendancelogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionattendancelogAddnote**](SessionattendancelogApi.md#sessionattendancelogaddnote) | **GET** /sessionattendancelog/addnote | Add a note to a class attendance log
[**SessionattendancelogGet**](SessionattendancelogApi.md#sessionattendancelogget) | **GET** /sessionattendancelog/{id} | View details of a class attendance log
[**SessionattendancelogGetuser**](SessionattendancelogApi.md#sessionattendanceloggetuser) | **GET** /sessionattendancelog/getuser | View the class session attendance information for a specific user
[**SessionattendancelogList**](SessionattendancelogApi.md#sessionattendanceloglist) | **GET** /sessionattendancelog/list | View attendance logs of the specified session
[**SessionattendancelogListevent**](SessionattendancelogApi.md#sessionattendanceloglistevent) | **GET** /sessionattendancelog/listevent | View the attendance information of an entire class
[**SessionattendancelogListsummary**](SessionattendancelogApi.md#sessionattendanceloglistsummary) | **GET** /sessionattendancelog/listsummary | View the attendance summary for a class and/or a attendee
[**SessionattendancelogMylistsummary**](SessionattendancelogApi.md#sessionattendancelogmylistsummary) | **GET** /sessionattendancelog/mylistsummary | View my attendance summary
[**SessionattendancelogSave**](SessionattendancelogApi.md#sessionattendancelogsave) | **POST** /sessionattendancelog/{id} | Create or edit a class attendance log
[**SessionattendancelogSaveswipe**](SessionattendancelogApi.md#sessionattendancelogsaveswipe) | **POST** /sessionattendancelog/saveswipe | Create or edit a class attendance log swipe


<a name="sessionattendancelogaddnote"></a>
# **SessionattendancelogAddnote**
> void SessionattendancelogAddnote (Guid? id, string text)

Add a note to a class attendance log

Allows the user to add a note to a class attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogAddnoteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log.
            var text = text_example;  // string | The text of the note to add.

            try
            {
                // Add a note to a class attendance log
                apiInstance.SessionattendancelogAddnote(id, text);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogAddnote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log. | 
 **text** | **string**| The text of the note to add. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogget"></a>
# **SessionattendancelogGet**
> void SessionattendancelogGet (Guid? id, int? photosize)

View details of a class attendance log

Allows the user to view an individual class attendance log and its details.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var id = new Guid?(); // Guid? | The id of the attendance log to get.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View details of a class attendance log
                apiInstance.SessionattendancelogGet(id, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the attendance log to get. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 400. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloggetuser"></a>
# **SessionattendancelogGetuser**
> void SessionattendancelogGetuser (Guid? attendee, Guid? eventid)

View the class session attendance information for a specific user

Allows the user to view the attendance for a specified student.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogGetuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var attendee = new Guid?(); // Guid? | The id of the attendee to get statistic for.
            var eventid = new Guid?(); // Guid? | The id of the event whose attendee statistics have to be returned.

            try
            {
                // View the class session attendance information for a specific user
                apiInstance.SessionattendancelogGetuser(attendee, eventid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogGetuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **attendee** | [**Guid?**](.md)| The id of the attendee to get statistic for. | 
 **eventid** | [**Guid?**](.md)| The id of the event whose attendee statistics have to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglist"></a>
# **SessionattendancelogList**
> void SessionattendancelogList (Guid? session, int? from, int? count, int? photosize)

View attendance logs of the specified session

Allows the user to view the full list of logs from a specified session

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var session = new Guid?(); // Guid? | The id of the session whose attendees logs have to be returned.
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var photosize = 56;  // int? | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. (optional) 

            try
            {
                // View attendance logs of the specified session
                apiInstance.SessionattendancelogList(session, from, count, photosize);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **session** | [**Guid?**](.md)| The id of the session whose attendees logs have to be returned. | 
 **from** | **int?**| The first record to return. | 
 **count** | **int?**| The max number of records to return. | 
 **photosize** | **int?**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglistevent"></a>
# **SessionattendancelogListevent**
> void SessionattendancelogListevent (Guid? eventid)

View the attendance information of an entire class

Allows the user to view the attendance information for an entire class

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogListeventExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned.

            try
            {
                // View the attendance information of an entire class
                apiInstance.SessionattendancelogListevent(eventid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogListevent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendanceloglistsummary"></a>
# **SessionattendancelogListsummary**
> void SessionattendancelogListsummary (Guid? eventid, Guid? attendeeid, Guid? groupid, string start, string end)

View the attendance summary for a class and/or a attendee

Allows the user to view the attendance summary for a given class and/or attendee.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogListsummaryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned. (optional) 
            var attendeeid = new Guid?(); // Guid? | The id of the attendee whose attendance has to be returned. (optional) 
            var groupid = new Guid?(); // Guid? | The id of the group whose attendance has to be returned. (optional) 
            var start = start_example;  // string | The start date to filter (beginning of time by default). (optional) 
            var end = end_example;  // string | The end date to filter (today by default). (optional) 

            try
            {
                // View the attendance summary for a class and/or a attendee
                apiInstance.SessionattendancelogListsummary(eventid, attendeeid, groupid, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogListsummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **attendeeid** | [**Guid?**](.md)| The id of the attendee whose attendance has to be returned. | [optional] 
 **groupid** | [**Guid?**](.md)| The id of the group whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogmylistsummary"></a>
# **SessionattendancelogMylistsummary**
> void SessionattendancelogMylistsummary (Guid? eventid, string start, string end)

View my attendance summary

Allows the user to view their own attendance summary.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogMylistsummaryExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var eventid = new Guid?(); // Guid? | The id of the event whose attendance has to be returned. (optional) 
            var start = start_example;  // string | The start date to filter (beginning of time by default). (optional) 
            var end = end_example;  // string | The end date to filter (today by default). (optional) 

            try
            {
                // View my attendance summary
                apiInstance.SessionattendancelogMylistsummary(eventid, start, end);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogMylistsummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event whose attendance has to be returned. | [optional] 
 **start** | **string**| The start date to filter (beginning of time by default). | [optional] 
 **end** | **string**| The end date to filter (today by default). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogsave"></a>
# **SessionattendancelogSave**
> void SessionattendancelogSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a class attendance log

Allows the user to create or edit a class attendance log.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogSaveExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var id = new Guid?(); // Guid? | The id of the att log to save (leave empty to create a new one).
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a class attendance log
                apiInstance.SessionattendancelogSave(id, UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogSave: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the att log to save (leave empty to create a new one). | 
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionattendancelogsaveswipe"></a>
# **SessionattendancelogSaveswipe**
> void SessionattendancelogSaveswipe (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Create or edit a class attendance log swipe

Allows the user to create or edit a class attendance log swipe, which are the details of time in or out.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionattendancelogSaveswipeExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionattendancelogApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Create or edit a class attendance log swipe
                apiInstance.SessionattendancelogSaveswipe(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionattendancelogApi.SessionattendancelogSaveswipe: " + e.Message );
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

