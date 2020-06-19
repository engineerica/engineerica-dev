# Org.OpenAPITools.Api.NotificationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NotificationDelete**](NotificationApi.md#notificationdelete) | **DELETE** /notification/{id} | Delete a notification
[**NotificationGet**](NotificationApi.md#notificationget) | **GET** /notification/{id} | View a notification
[**NotificationGetforstation**](NotificationApi.md#notificationgetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**NotificationGetunreadcount**](NotificationApi.md#notificationgetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
[**NotificationList**](NotificationApi.md#notificationlist) | **GET** /notification/list | View a list of all sent notifications
[**NotificationListmine**](NotificationApi.md#notificationlistmine) | **GET** /notification/listmine | View all the notifications sent to the current user
[**NotificationMarkasread**](NotificationApi.md#notificationmarkasread) | **GET** /notification/markasread | Mark a notification as read
[**NotificationMarkasunread**](NotificationApi.md#notificationmarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
[**NotificationSend**](NotificationApi.md#notificationsend) | **GET** /notification/send | Send notifications on screen, via email or text to users
[**NotificationSendonscreen**](NotificationApi.md#notificationsendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications


<a name="notificationdelete"></a>
# **NotificationDelete**
> void NotificationDelete (Guid? id, AnyType body)

Delete a notification

Allows the user to delete an existing notification.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationDeleteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var id = new Guid?(); // Guid? | The id of the notification to delete.
            var body = ;  // AnyType |  (optional) 

            try
            {
                // Delete a notification
                apiInstance.NotificationDelete(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationget"></a>
# **NotificationGet**
> void NotificationGet (Guid? id)

View a notification

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var id = new Guid?(); // Guid? | The id of the notification to get.

            try
            {
                // View a notification
                apiInstance.NotificationGet(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetforstation"></a>
# **NotificationGetforstation**
> void NotificationGetforstation (Guid? station, string user)

Gets all public (in station) notifications for the specific user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationGetforstationExample
    {
        public void main()
        {
            var apiInstance = new NotificationApi();
            var station = new Guid?(); // Guid? | The id of the sign-in station to get.
            var user = user_example;  // string | The card of the user.

            try
            {
                // Gets all public (in station) notifications for the specific user
                apiInstance.NotificationGetforstation(station, user);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationGetforstation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**Guid?**](.md)| The id of the sign-in station to get. | 
 **user** | **string**| The card of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationgetunreadcount"></a>
# **NotificationGetunreadcount**
> void NotificationGetunreadcount ()

Get the number of unread notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationGetunreadcountExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();

            try
            {
                // Get the number of unread notifications
                apiInstance.NotificationGetunreadcount();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationGetunreadcount: " + e.Message );
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

<a name="notificationlist"></a>
# **NotificationList**
> void NotificationList (int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationListExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var recipient = new Guid?(); // Guid? | The recipient whose notifications have to be listed. (optional) 
            var status = 56;  // int? | The status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 
            var sentonscreen = true;  // bool? | Specifies whether to list the notifications that were sent on-screen or not. (optional) 
            var sentemail = true;  // bool? | Specifies whether to list the notifications that were sent via e-mail or not. (optional) 
            var sentsms = true;  // bool? | Specifies whether to list the notifications that were sent via sms or not. (optional) 

            try
            {
                // View a list of all sent notifications
                apiInstance.NotificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationList: " + e.Message );
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
 **recipient** | [**Guid?**](.md)| The recipient whose notifications have to be listed. | [optional] 
 **status** | **int?**| The status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 
 **sentonscreen** | **bool?**| Specifies whether to list the notifications that were sent on-screen or not. | [optional] 
 **sentemail** | **bool?**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional] 
 **sentsms** | **bool?**| Specifies whether to list the notifications that were sent via sms or not. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationlistmine"></a>
# **NotificationListmine**
> void NotificationListmine (int? from, int? count, int? status, DateTime? startdate, DateTime? enddate)

View all the notifications sent to the current user

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationListmineExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var from = 56;  // int? | The first record to return.
            var count = 56;  // int? | The max number of records to return.
            var status = 56;  // int? | Specifies the status of the notifications to list. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // View all the notifications sent to the current user
                apiInstance.NotificationListmine(from, count, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationListmine: " + e.Message );
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
 **status** | **int?**| Specifies the status of the notifications to list. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasread"></a>
# **NotificationMarkasread**
> void NotificationMarkasread (Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as read

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationMarkasreadExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var id = new Guid?(); // Guid? | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as read
                apiInstance.NotificationMarkasread(id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationMarkasread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationmarkasunread"></a>
# **NotificationMarkasunread**
> void NotificationMarkasunread (Guid? id, int? status, DateTime? startdate, DateTime? enddate)

Mark a notification as unread

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationMarkasunreadExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var id = new Guid?(); // Guid? | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. (optional) 
            var status = 56;  // int? | Specifies the status to filter the notifications. Read, Unread or All. (optional) 
            var startdate = 2013-10-20T19:20:30+01:00;  // DateTime? | The start date of the period to filter the notifications. (optional) 
            var enddate = 2013-10-20T19:20:30+01:00;  // DateTime? | The end date of the period to filter the notifications. (optional) 

            try
            {
                // Mark a notification as unread
                apiInstance.NotificationMarkasunread(id, status, startdate, enddate);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationMarkasunread: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional] 
 **status** | **int?**| Specifies the status to filter the notifications. Read, Unread or All. | [optional] 
 **startdate** | **DateTime?**| The start date of the period to filter the notifications. | [optional] 
 **enddate** | **DateTime?**| The end date of the period to filter the notifications. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsend"></a>
# **NotificationSend**
> void NotificationSend (bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationSendExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var emailenabled = true;  // bool? | Whether send the notification via email.
            var onscreenenabled = true;  // bool? | Whether to display the notification on screen.
            var smsenabled = true;  // bool? | Whether to send the notification via text message.
            var title = title_example;  // string | Notification title.
            var tousers = tousers_example;  // string | Comma-separated Ids of users to send the notification. (optional) 
            var togroups = togroups_example;  // string | Comma-separated Ids of user groups to send the notification. (optional) 
            var onscreenbody = onscreenbody_example;  // string | Body of the message for on-screen display. (optional) 
            var onscreenclick = onscreenclick_example;  // string | What to do when the notification is clicked. Valid values: hide, view, url. (optional) 
            var onscreenurl = onscreenurl_example;  // string | Url to redirect the user, if onscreenclick=url. (optional) 
            var onscreenclass = onscreenclass_example;  // string | How to display the notification. Valid values: info, success, warning, error (optional) 
            var onscreenduration = 56;  // int? | Time in seconds to display the notification. (optional) 
            var showonstation = 56;  // int? | Whether to show the notification in the sign-in station. (optional) 
            var emailfromname = emailfromname_example;  // string | Name of the email sender. (optional) 
            var emailfrom = emailfrom_example;  // string | Reply-to email. (optional) 
            var emailsubject = emailsubject_example;  // string | Subject of the email. (optional) 
            var emailbody = emailbody_example;  // string | Body of the email. (optional) 
            var textmessagebody = textmessagebody_example;  // string | Message for SMS. Max 160 characters. (optional) 

            try
            {
                // Send notifications on screen, via email or text to users
                apiInstance.NotificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationSend: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **bool?**| Whether send the notification via email. | 
 **onscreenenabled** | **bool?**| Whether to display the notification on screen. | 
 **smsenabled** | **bool?**| Whether to send the notification via text message. | 
 **title** | **string**| Notification title. | 
 **tousers** | **string**| Comma-separated Ids of users to send the notification. | [optional] 
 **togroups** | **string**| Comma-separated Ids of user groups to send the notification. | [optional] 
 **onscreenbody** | **string**| Body of the message for on-screen display. | [optional] 
 **onscreenclick** | **string**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional] 
 **onscreenurl** | **string**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional] 
 **onscreenclass** | **string**| How to display the notification. Valid values: info, success, warning, error | [optional] 
 **onscreenduration** | **int?**| Time in seconds to display the notification. | [optional] 
 **showonstation** | **int?**| Whether to show the notification in the sign-in station. | [optional] 
 **emailfromname** | **string**| Name of the email sender. | [optional] 
 **emailfrom** | **string**| Reply-to email. | [optional] 
 **emailsubject** | **string**| Subject of the email. | [optional] 
 **emailbody** | **string**| Body of the email. | [optional] 
 **textmessagebody** | **string**| Message for SMS. Max 160 characters. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="notificationsendonscreen"></a>
# **NotificationSendonscreen**
> void NotificationSendonscreen (Guid? notification)

Send on-screen notifications

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class NotificationSendonscreenExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NotificationApi();
            var notification = new Guid?(); // Guid? | The ID of the notification to send.

            try
            {
                // Send on-screen notifications
                apiInstance.NotificationSendonscreen(notification);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NotificationApi.NotificationSendonscreen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**Guid?**](.md)| The ID of the notification to send. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

