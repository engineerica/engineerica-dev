# Org.OpenAPITools.Api.SessionregApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SessionregAddcurrentuser**](SessionregApi.md#sessionregaddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**SessionregAdduser**](SessionregApi.md#sessionregadduser) | **GET** /sessionreg/adduser | Register users for events
[**SessionregGetmysessions**](SessionregApi.md#sessionreggetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**SessionregGetsessions**](SessionregApi.md#sessionreggetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**SessionregGetsettings**](SessionregApi.md#sessionreggetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**SessionregGetusers**](SessionregApi.md#sessionreggetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**SessionregListsessions**](SessionregApi.md#sessionreglistsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**SessionregListupcoming**](SessionregApi.md#sessionreglistupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**SessionregListupcomingevent**](SessionregApi.md#sessionreglistupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**SessionregRemovecurrentuser**](SessionregApi.md#sessionregremovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**SessionregRemoveuser**](SessionregApi.md#sessionregremoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**SessionregSavesettings**](SessionregApi.md#sessionregsavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration


<a name="sessionregaddcurrentuser"></a>
# **SessionregAddcurrentuser**
> void SessionregAddcurrentuser (Guid? eventid, DateTime? sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregAddcurrentuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register current user to an event session
                apiInstance.SessionregAddcurrentuser(eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregAddcurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregadduser"></a>
# **SessionregAdduser**
> void SessionregAdduser (Guid? userid, Guid? eventid, DateTime? sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregAdduserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var userid = new Guid?(); // Guid? | The id of the user to add.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Register users for events
                apiInstance.SessionregAdduser(userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregAdduser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to add. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetmysessions"></a>
# **SessionregGetmysessions**
> void SessionregGetmysessions (DateTime? date)

View all the sessions the logged user is registered to

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregGetmysessionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the sessions. (optional) 

            try
            {
                // View all the sessions the logged user is registered to
                apiInstance.SessionregGetmysessions(date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregGetmysessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime?**| Start date to filter the sessions. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsessions"></a>
# **SessionregGetsessions**
> void SessionregGetsessions (Guid? userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregGetsessionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var userid = new Guid?(); // Guid? | The user id to list sessions.

            try
            {
                // Lists the registrations for a specific user
                apiInstance.SessionregGetsessions(userid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregGetsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The user id to list sessions. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetsettings"></a>
# **SessionregGetsettings**
> void SessionregGetsettings (Guid? locationid, Guid? eventid, DateTime? sessiondate, bool? noinherit)

Get the settings for session registration

Allows the user to view a event's session registration settings.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregGetsettingsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var locationid = new Guid?(); // Guid? | The id of the location to save settings. (optional) 
            var eventid = new Guid?(); // Guid? | The id of the event to save settings. (optional) 
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts. (optional) 
            var noinherit = true;  // bool? | True to get the location/event/session specific settings without looking for the more global settings. (optional) 

            try
            {
                // Get the settings for session registration
                apiInstance.SessionregGetsettings(locationid, eventid, sessiondate, noinherit);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregGetsettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**Guid?**](.md)| The id of the location to save settings. | [optional] 
 **eventid** | [**Guid?**](.md)| The id of the event to save settings. | [optional] 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | [optional] 
 **noinherit** | **bool?**| True to get the location/event/session specific settings without looking for the more global settings. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreggetusers"></a>
# **SessionregGetusers**
> void SessionregGetusers (Guid? eventid, DateTime? sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregGetusersExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find.

            try
            {
                // Lists the registrations for a specific session
                apiInstance.SessionregGetusers(eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregGetusers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistsessions"></a>
# **SessionregListsessions**
> void SessionregListsessions (Guid? eventid, DateTime? sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregListsessionsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var eventid = new Guid?(); // Guid? | The event id to list sessions.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date of the session to find. (optional) 

            try
            {
                // List the sessions available for a specific event
                apiInstance.SessionregListsessions(eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregListsessions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The event id to list sessions. | 
 **sessiondate** | **DateTime?**| The date of the session to find. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcoming"></a>
# **SessionregListupcoming**
> void SessionregListupcoming (DateTime? date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregListupcomingExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Only sessions in the week of the specified date will be returned.

            try
            {
                // View a list of upcoming event sessions
                apiInstance.SessionregListupcoming(date);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregListupcoming: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime?**| Only sessions in the week of the specified date will be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionreglistupcomingevent"></a>
# **SessionregListupcomingevent**
> void SessionregListupcomingevent (DateTime? date, Guid? _event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregListupcomingeventExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var date = 2013-10-20T19:20:30+01:00;  // DateTime? | Start date to filter the returned sessions.
            var _event = new Guid?(); // Guid? | The id of the event whose sessions will be returned

            try
            {
                // View a list of upcoming sessions of a particular event
                apiInstance.SessionregListupcomingevent(date, _event);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregListupcomingevent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **DateTime?**| Start date to filter the returned sessions. | 
 **_event** | [**Guid?**](.md)| The id of the event whose sessions will be returned | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremovecurrentuser"></a>
# **SessionregRemovecurrentuser**
> void SessionregRemovecurrentuser (Guid? eventid, DateTime? sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregRemovecurrentuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Unregister current user from an event session
                apiInstance.SessionregRemovecurrentuser(eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregRemovecurrentuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregremoveuser"></a>
# **SessionregRemoveuser**
> void SessionregRemoveuser (Guid? userid, Guid? eventid, DateTime? sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregRemoveuserExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var userid = new Guid?(); // Guid? | The id of the user to remove.
            var eventid = new Guid?(); // Guid? | The id of the event.
            var sessiondate = 2013-10-20T19:20:30+01:00;  // DateTime? | The date and time when the session starts.

            try
            {
                // Removes a user from an event session
                apiInstance.SessionregRemoveuser(userid, eventid, sessiondate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregRemoveuser: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**Guid?**](.md)| The id of the user to remove. | 
 **eventid** | [**Guid?**](.md)| The id of the event. | 
 **sessiondate** | **DateTime?**| The date and time when the session starts. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sessionregsavesettings"></a>
# **SessionregSavesettings**
> void SessionregSavesettings (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)

Save the settings for an event's session registration

Allows the user to save the settings for an event.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SessionregSavesettingsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SessionregApi();
            var UNKNOWN_BASE_TYPE = new UNKNOWN_BASE_TYPE(); // UNKNOWN_BASE_TYPE |  (optional) 

            try
            {
                // Save the settings for an event's session registration
                apiInstance.SessionregSavesettings(UNKNOWN_BASE_TYPE);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SessionregApi.SessionregSavesettings: " + e.Message );
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

