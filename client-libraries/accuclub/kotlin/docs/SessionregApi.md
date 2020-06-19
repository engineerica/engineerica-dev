# SessionregApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionregAddcurrentuser**](SessionregApi.md#sessionregAddcurrentuser) | **GET** /sessionreg/addcurrentuser | Register current user to an event session
[**sessionregAdduser**](SessionregApi.md#sessionregAdduser) | **GET** /sessionreg/adduser | Register users for events
[**sessionregGetmysessions**](SessionregApi.md#sessionregGetmysessions) | **GET** /sessionreg/getmysessions | View all the sessions the logged user is registered to
[**sessionregGetsessions**](SessionregApi.md#sessionregGetsessions) | **GET** /sessionreg/getsessions | Lists the registrations for a specific user
[**sessionregGetsettings**](SessionregApi.md#sessionregGetsettings) | **GET** /sessionreg/getsettings | Get the settings for session registration
[**sessionregGetusers**](SessionregApi.md#sessionregGetusers) | **GET** /sessionreg/getusers | Lists the registrations for a specific session
[**sessionregListsessions**](SessionregApi.md#sessionregListsessions) | **GET** /sessionreg/listsessions | List the sessions available for a specific event
[**sessionregListupcoming**](SessionregApi.md#sessionregListupcoming) | **GET** /sessionreg/listupcoming | View a list of upcoming event sessions
[**sessionregListupcomingevent**](SessionregApi.md#sessionregListupcomingevent) | **GET** /sessionreg/listupcomingevent | View a list of upcoming sessions of a particular event
[**sessionregRemovecurrentuser**](SessionregApi.md#sessionregRemovecurrentuser) | **GET** /sessionreg/removecurrentuser | Unregister current user from an event session
[**sessionregRemoveuser**](SessionregApi.md#sessionregRemoveuser) | **GET** /sessionreg/removeuser | Removes a user from an event session
[**sessionregSavesettings**](SessionregApi.md#sessionregSavesettings) | **POST** /sessionreg/savesettings | Save the settings for an event&#39;s session registration


<a name="sessionregAddcurrentuser"></a>
# **sessionregAddcurrentuser**
> sessionregAddcurrentuser(eventid, sessiondate)

Register current user to an event session

Allows the user to register themselves for an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregAddcurrentuser(eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregAddcurrentuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregAddcurrentuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregAdduser"></a>
# **sessionregAdduser**
> sessionregAdduser(userid, eventid, sessiondate)

Register users for events

Allows the user to register another user for an upcoming event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregAdduser(userid, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregAdduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregAdduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregGetmysessions"></a>
# **sessionregGetmysessions**
> sessionregGetmysessions(date)

View all the sessions the logged user is registered to

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Start date to filter the sessions.
try {
    apiInstance.sessionregGetmysessions(date)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregGetmysessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregGetmysessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **java.time.OffsetDateTime**| Start date to filter the sessions. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregGetsessions"></a>
# **sessionregGetsessions**
> sessionregGetsessions(userid)

Lists the registrations for a specific user

Allows the user to view the session registrations for a specified user, provided they have the ability to view that user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list sessions.
try {
    apiInstance.sessionregGetsessions(userid)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregGetsessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregGetsessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The user id to list sessions. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregGetsettings"></a>
# **sessionregGetsettings**
> sessionregGetsettings(locationid, eventid, sessiondate, noinherit)

Get the settings for session registration

Allows the user to view a event&#39;s session registration settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location to save settings.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event to save settings.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
val noinherit : kotlin.Boolean = true // kotlin.Boolean | True to get the location/event/session specific settings without looking for the more global settings.
try {
    apiInstance.sessionregGetsettings(locationid, eventid, sessiondate, noinherit)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregGetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregGetsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**java.util.UUID**](.md)| The id of the location to save settings. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event to save settings. | [optional]
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. | [optional]
 **noinherit** | **kotlin.Boolean**| True to get the location/event/session specific settings without looking for the more global settings. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregGetusers"></a>
# **sessionregGetusers**
> sessionregGetusers(eventid, sessiondate)

Lists the registrations for a specific session

Allows the user to view the registration for a specified event session.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list sessions.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date of the session to find.
try {
    apiInstance.sessionregGetusers(eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregGetusers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregGetusers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **java.time.OffsetDateTime**| The date of the session to find. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregListsessions"></a>
# **sessionregListsessions**
> sessionregListsessions(eventid, sessiondate)

List the sessions available for a specific event

Allows the user to view all the sessions available for a recurring event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list sessions.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date of the session to find.
try {
    apiInstance.sessionregListsessions(eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregListsessions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregListsessions")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The event id to list sessions. |
 **sessiondate** | **java.time.OffsetDateTime**| The date of the session to find. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregListupcoming"></a>
# **sessionregListupcoming**
> sessionregListupcoming(date)

View a list of upcoming event sessions

Allows the user to view the full list of upcoming events.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Only sessions in the week of the specified date will be returned.
try {
    apiInstance.sessionregListupcoming(date)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregListupcoming")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregListupcoming")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **java.time.OffsetDateTime**| Only sessions in the week of the specified date will be returned. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregListupcomingevent"></a>
# **sessionregListupcomingevent**
> sessionregListupcomingevent(date, event)

View a list of upcoming sessions of a particular event

Allows the user to view the upcoming recurring sessions of a specified event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val date : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | Start date to filter the returned sessions.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event whose sessions will be returned
try {
    apiInstance.sessionregListupcomingevent(date, event)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregListupcomingevent")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregListupcomingevent")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **date** | **java.time.OffsetDateTime**| Start date to filter the returned sessions. |
 **event** | [**java.util.UUID**](.md)| The id of the event whose sessions will be returned |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregRemovecurrentuser"></a>
# **sessionregRemovecurrentuser**
> sessionregRemovecurrentuser(eventid, sessiondate)

Unregister current user from an event session

Allows the user to un-register themselves from an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregRemovecurrentuser(eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregRemovecurrentuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregRemovecurrentuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregRemoveuser"></a>
# **sessionregRemoveuser**
> sessionregRemoveuser(userid, eventid, sessiondate)

Removes a user from an event session

Allows the user to un-register another user from an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val sessiondate : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time when the session starts.
try {
    apiInstance.sessionregRemoveuser(userid, eventid, sessiondate)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregRemoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregRemoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **sessiondate** | **java.time.OffsetDateTime**| The date and time when the session starts. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionregSavesettings"></a>
# **sessionregSavesettings**
> sessionregSavesettings(UNKNOWN_BASE_TYPE)

Save the settings for an event&#39;s session registration

Allows the user to save the settings for an event.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionregApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionregSavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SessionregApi#sessionregSavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionregApi#sessionregSavesettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

