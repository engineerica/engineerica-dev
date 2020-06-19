# Org.OpenAPITools.Api.SessionApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionBulkupdate**](SessionApi.md#sessionbulkupdate) | **GET** /session/bulkupdate | Bulk update event sessions
[**SessionGet**](SessionApi.md#sessionget) | **GET** /session/{id} | View details of a session
[**SessionGetschedule**](SessionApi.md#sessiongetschedule) | **GET** /session/getschedule | Gets the schedule for a location, instructor or attendees
[**SessionList**](SessionApi.md#sessionlist) | **GET** /session/list | Gets all future sessions of the current semester


<a name="sessionbulkupdate"></a>
# **SessionBulkupdate**
> void SessionBulkupdate (Guid? eventid, string sessions)

Bulk update event sessions

Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionBulkupdateExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionApi();
            var eventid = new Guid?(); // Guid? | The id of the event to bulk update.
            var sessions = sessions_example;  // string | A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties.

            try
            {
                // Bulk update event sessions
                apiInstance.SessionBulkupdate(eventid, sessions);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionBulkupdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event to bulk update. | 
 **sessions** | **string**| A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionget"></a>
# **SessionGet**
> void SessionGet (Guid? id)

View details of a session

Allows the user to view a session in order to take attendance.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionApi();
            var id = new Guid?(); // Guid? | The id of the session to get.

            try
            {
                // View details of a session
                apiInstance.SessionGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the session to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessiongetschedule"></a>
# **SessionGetschedule**
> void SessionGetschedule (DateTime? day, Guid? attendee, Guid? location, Guid? instructor)

Gets the schedule for a location, instructor or attendees

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionGetscheduleExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionApi();
            var day = 2013-10-20T19:20:30+01:00;  // DateTime? | The day to return. It will also return the whole week for that day. (optional) 
            var attendee = new Guid?(); // Guid? | The id of the attendee to get the schedule. (optional) 
            var location = new Guid?(); // Guid? | The id of the location to get the schedule. (optional) 
            var instructor = new Guid?(); // Guid? | The id of the instructor to get the schedule. (optional) 

            try
            {
                // Gets the schedule for a location, instructor or attendees
                apiInstance.SessionGetschedule(day, attendee, location, instructor);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionGetschedule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **day** | **DateTime?**| The day to return. It will also return the whole week for that day. | [optional] 
 **attendee** | [**Guid?**](.md)| The id of the attendee to get the schedule. | [optional] 
 **location** | [**Guid?**](.md)| The id of the location to get the schedule. | [optional] 
 **instructor** | [**Guid?**](.md)| The id of the instructor to get the schedule. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionlist"></a>
# **SessionList**
> void SessionList (int? from, int? count, DateTime? startdate, DateTime? enddate)

Gets all future sessions of the current semester

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date to filter the sessions (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date to filter the sessions. (optional) 

            try
            {
                // Gets all future sessions of the current semester
                apiInstance.SessionList(from, count, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionApi.SessionList: " + e.Message );
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
 **startdate** | **DateTime?**| The start date to filter the sessions | [optional] 
 **enddate** | **DateTime?**| The end date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

