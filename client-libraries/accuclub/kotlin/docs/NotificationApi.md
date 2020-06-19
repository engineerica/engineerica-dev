# NotificationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationDelete**](NotificationApi.md#notificationDelete) | **DELETE** /notification/{id} | Delete a notification
[**notificationGet**](NotificationApi.md#notificationGet) | **GET** /notification/{id} | View a notification
[**notificationGetforstation**](NotificationApi.md#notificationGetforstation) | **GET** /notification/getforstation | Gets all public (in station) notifications for the specific user
[**notificationGetunreadcount**](NotificationApi.md#notificationGetunreadcount) | **GET** /notification/getunreadcount | Get the number of unread notifications
[**notificationList**](NotificationApi.md#notificationList) | **GET** /notification/list | View a list of all sent notifications
[**notificationListmine**](NotificationApi.md#notificationListmine) | **GET** /notification/listmine | View all the notifications sent to the current user
[**notificationMarkasread**](NotificationApi.md#notificationMarkasread) | **GET** /notification/markasread | Mark a notification as read
[**notificationMarkasunread**](NotificationApi.md#notificationMarkasunread) | **GET** /notification/markasunread | Mark a notification as unread
[**notificationSend**](NotificationApi.md#notificationSend) | **GET** /notification/send | Send notifications on screen, via email or text to users
[**notificationSendonscreen**](NotificationApi.md#notificationSendonscreen) | **GET** /notification/sendonscreen | Send on-screen notifications


<a name="notificationDelete"></a>
# **notificationDelete**
> notificationDelete(id, body)

Delete a notification

Allows the user to delete an existing notification.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.notificationDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="notificationGet"></a>
# **notificationGet**
> notificationGet(id)

View a notification

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to get.
try {
    apiInstance.notificationGet(id)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationGetforstation"></a>
# **notificationGetforstation**
> notificationGetforstation(station, user)

Gets all public (in station) notifications for the specific user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.notificationGetforstation(station, user)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationGetforstation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationGetforstation")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationGetunreadcount"></a>
# **notificationGetunreadcount**
> notificationGetunreadcount()

Get the number of unread notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
try {
    apiInstance.notificationGetunreadcount()
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationGetunreadcount")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationGetunreadcount")
    e.printStackTrace()
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationList"></a>
# **notificationList**
> notificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)

View a list of all sent notifications

Allows the user to view the list of all sent notifications.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val recipient : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The recipient whose notifications have to be listed.
val status : kotlin.Int = 56 // kotlin.Int | The status of the notifications to list. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
val sentonscreen : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent on-screen or not.
val sentemail : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent via e-mail or not.
val sentsms : kotlin.Boolean = true // kotlin.Boolean | Specifies whether to list the notifications that were sent via sms or not.
try {
    apiInstance.notificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **recipient** | [**java.util.UUID**](.md)| The recipient whose notifications have to be listed. | [optional]
 **status** | **kotlin.Int**| The status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]
 **sentonscreen** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent on-screen or not. | [optional]
 **sentemail** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent via e-mail or not. | [optional]
 **sentsms** | **kotlin.Boolean**| Specifies whether to list the notifications that were sent via sms or not. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationListmine"></a>
# **notificationListmine**
> notificationListmine(from, count, status, startdate, enddate)

View all the notifications sent to the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status of the notifications to list. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationListmine(from, count, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationListmine")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationListmine")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **status** | **kotlin.Int**| Specifies the status of the notifications to list. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationMarkasread"></a>
# **notificationMarkasread**
> notificationMarkasread(id, status, startdate, enddate)

Mark a notification as read

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status to filter the notifications. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationMarkasread(id, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationMarkasread")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationMarkasread")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read. | [optional]
 **status** | **kotlin.Int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationMarkasunread"></a>
# **notificationMarkasunread**
> notificationMarkasunread(id, status, startdate, enddate)

Mark a notification as unread

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.
val status : kotlin.Int = 56 // kotlin.Int | Specifies the status to filter the notifications. Read, Unread or All.
val startdate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The start date of the period to filter the notifications.
val enddate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The end date of the period to filter the notifications.
try {
    apiInstance.notificationMarkasunread(id, status, startdate, enddate)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationMarkasunread")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationMarkasunread")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread. | [optional]
 **status** | **kotlin.Int**| Specifies the status to filter the notifications. Read, Unread or All. | [optional]
 **startdate** | **java.time.OffsetDateTime**| The start date of the period to filter the notifications. | [optional]
 **enddate** | **java.time.OffsetDateTime**| The end date of the period to filter the notifications. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationSend"></a>
# **notificationSend**
> notificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)

Send notifications on screen, via email or text to users

Allows the user to send notifications to other users through the Send Message link.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val emailenabled : kotlin.Boolean = true // kotlin.Boolean | Whether send the notification via email.
val onscreenenabled : kotlin.Boolean = true // kotlin.Boolean | Whether to display the notification on screen.
val smsenabled : kotlin.Boolean = true // kotlin.Boolean | Whether to send the notification via text message.
val title : kotlin.String = title_example // kotlin.String | Notification title.
val tousers : kotlin.String = tousers_example // kotlin.String | Comma-separated Ids of users to send the notification.
val togroups : kotlin.String = togroups_example // kotlin.String | Comma-separated Ids of user groups to send the notification.
val onscreenbody : kotlin.String = onscreenbody_example // kotlin.String | Body of the message for on-screen display.
val onscreenclick : kotlin.String = onscreenclick_example // kotlin.String | What to do when the notification is clicked. Valid values: hide, view, url.
val onscreenurl : kotlin.String = onscreenurl_example // kotlin.String | Url to redirect the user, if onscreenclick=url.
val onscreenclass : kotlin.String = onscreenclass_example // kotlin.String | How to display the notification. Valid values: info, success, warning, error
val onscreenduration : kotlin.Int = 56 // kotlin.Int | Time in seconds to display the notification.
val showonstation : kotlin.Int = 56 // kotlin.Int | Whether to show the notification in the sign-in station.
val emailfromname : kotlin.String = emailfromname_example // kotlin.String | Name of the email sender.
val emailfrom : kotlin.String = emailfrom_example // kotlin.String | Reply-to email.
val emailsubject : kotlin.String = emailsubject_example // kotlin.String | Subject of the email.
val emailbody : kotlin.String = emailbody_example // kotlin.String | Body of the email.
val textmessagebody : kotlin.String = textmessagebody_example // kotlin.String | Message for SMS. Max 160 characters.
try {
    apiInstance.notificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationSend")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationSend")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **emailenabled** | **kotlin.Boolean**| Whether send the notification via email. |
 **onscreenenabled** | **kotlin.Boolean**| Whether to display the notification on screen. |
 **smsenabled** | **kotlin.Boolean**| Whether to send the notification via text message. |
 **title** | **kotlin.String**| Notification title. |
 **tousers** | **kotlin.String**| Comma-separated Ids of users to send the notification. | [optional]
 **togroups** | **kotlin.String**| Comma-separated Ids of user groups to send the notification. | [optional]
 **onscreenbody** | **kotlin.String**| Body of the message for on-screen display. | [optional]
 **onscreenclick** | **kotlin.String**| What to do when the notification is clicked. Valid values: hide, view, url. | [optional]
 **onscreenurl** | **kotlin.String**| Url to redirect the user, if onscreenclick&#x3D;url. | [optional]
 **onscreenclass** | **kotlin.String**| How to display the notification. Valid values: info, success, warning, error | [optional]
 **onscreenduration** | **kotlin.Int**| Time in seconds to display the notification. | [optional]
 **showonstation** | **kotlin.Int**| Whether to show the notification in the sign-in station. | [optional]
 **emailfromname** | **kotlin.String**| Name of the email sender. | [optional]
 **emailfrom** | **kotlin.String**| Reply-to email. | [optional]
 **emailsubject** | **kotlin.String**| Subject of the email. | [optional]
 **emailbody** | **kotlin.String**| Body of the email. | [optional]
 **textmessagebody** | **kotlin.String**| Message for SMS. Max 160 characters. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="notificationSendonscreen"></a>
# **notificationSendonscreen**
> notificationSendonscreen(notification)

Send on-screen notifications

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = NotificationApi()
val notification : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the notification to send.
try {
    apiInstance.notificationSendonscreen(notification)
} catch (e: ClientException) {
    println("4xx response calling NotificationApi#notificationSendonscreen")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling NotificationApi#notificationSendonscreen")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **notification** | [**java.util.UUID**](.md)| The ID of the notification to send. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

