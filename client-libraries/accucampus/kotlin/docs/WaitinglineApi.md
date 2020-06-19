# WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitinglineAdduser**](WaitinglineApi.md#waitinglineAdduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitinglineDelete**](WaitinglineApi.md#waitinglineDelete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitinglineGet**](WaitinglineApi.md#waitinglineGet) | **GET** /waitingline/{id} | View details of a waiting line
[**waitinglineIsuserin**](WaitinglineApi.md#waitinglineIsuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitinglineList**](WaitinglineApi.md#waitinglineList) | **GET** /waitingline/list | View a list of waiting lines
[**waitinglineRemoveuser**](WaitinglineApi.md#waitinglineRemoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitinglineSave**](WaitinglineApi.md#waitinglineSave) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitinglineSigninuser**](WaitinglineApi.md#waitinglineSigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


<a name="waitinglineAdduser"></a>
# **waitinglineAdduser**
> waitinglineAdduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize)

Put user in a waiting line

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station.
val user : kotlin.String = user_example // kotlin.String | The user's card number.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The location's id where the swipe must be saved.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val signinrole : kotlin.String = signinrole_example // kotlin.String | Specifies if the sign-in is for an attendee or a staff member
val roleid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Specifies the role the user has selected in order to sign-in
val services : kotlin.String = services_example // kotlin.String | The services ids the user has selected.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event the user selected.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member the user selected.
val photosize : kotlin.Int = 56 // kotlin.Int | The swiping user's photo size.
try {
    apiInstance.waitinglineAdduser(station, user, locationid, time, signinrole, roleid, services, eventid, staff, photosize)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineAdduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineAdduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station. |
 **user** | **kotlin.String**| The user&#39;s card number. |
 **locationid** | [**java.util.UUID**](.md)| The location&#39;s id where the swipe must be saved. | [optional]
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. | [optional]
 **signinrole** | **kotlin.String**| Specifies if the sign-in is for an attendee or a staff member | [optional]
 **roleid** | [**java.util.UUID**](.md)| Specifies the role the user has selected in order to sign-in | [optional]
 **services** | **kotlin.String**| The services ids the user has selected. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The id of the event the user selected. | [optional]
 **staff** | [**java.util.UUID**](.md)| The id of the staff member the user selected. | [optional]
 **photosize** | **kotlin.Int**| The swiping user&#39;s photo size. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineDelete"></a>
# **waitinglineDelete**
> waitinglineDelete(id, body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the line to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.waitinglineDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the line to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="waitinglineGet"></a>
# **waitinglineGet**
> waitinglineGet(id, photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.waitinglineGet(id, photosize)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the waiting line to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineIsuserin"></a>
# **waitinglineIsuserin**
> waitinglineIsuserin(station, time, user, location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val user : kotlin.String = user_example // kotlin.String | The card number of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.waitinglineIsuserin(station, time, user, location)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineIsuserin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineIsuserin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station. |
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. |
 **user** | **kotlin.String**| The card number of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineList"></a>
# **waitinglineList**
> waitinglineList(from, count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.waitinglineList(from, count)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineRemoveuser"></a>
# **waitinglineRemoveuser**
> waitinglineRemoveuser(waitingline, itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val waitingline : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line whose item has to be removed.
val itemid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the item that has to be removed.
try {
    apiInstance.waitinglineRemoveuser(waitingline, itemid)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineRemoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineRemoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**java.util.UUID**](.md)| The id of the waiting line whose item has to be removed. |
 **itemid** | [**java.util.UUID**](.md)| The ID of the item that has to be removed. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="waitinglineSave"></a>
# **waitinglineSave**
> waitinglineSave(id, UNKNOWN_BASE_TYPE)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.waitinglineSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the waiting line save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="waitinglineSigninuser"></a>
# **waitinglineSigninuser**
> waitinglineSigninuser(waitingline, itemid, staff, photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = WaitinglineApi()
val waitingline : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the waiting line whose item needs to be signed-in.
val itemid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the item that has to be signed-in.
val staff : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the staff member selected to sign-in.
val photosize : kotlin.Int = 56 // kotlin.Int | The swiping user's photo size.
try {
    apiInstance.waitinglineSigninuser(waitingline, itemid, staff, photosize)
} catch (e: ClientException) {
    println("4xx response calling WaitinglineApi#waitinglineSigninuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling WaitinglineApi#waitinglineSigninuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**java.util.UUID**](.md)| The id of the waiting line whose item needs to be signed-in. |
 **itemid** | [**java.util.UUID**](.md)| The ID of the item that has to be signed-in. |
 **staff** | [**java.util.UUID**](.md)| The id of the staff member selected to sign-in. |
 **photosize** | **kotlin.Int**| The swiping user&#39;s photo size. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

