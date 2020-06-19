# AdvancedstationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advancedstationCheckunknownuser**](AdvancedstationApi.md#advancedstationCheckunknownuser) | **GET** /advancedstation/checkunknownuser | Check whether the user is known by the system.
[**advancedstationCheckuserrole**](AdvancedstationApi.md#advancedstationCheckuserrole) | **GET** /advancedstation/checkuserrole | Check whether the user is a staff member, an attendee or both.
[**advancedstationCreateuser**](AdvancedstationApi.md#advancedstationCreateuser) | **GET** /advancedstation/createuser | Creates a user via a sign-in station.
[**advancedstationGetevents**](AdvancedstationApi.md#advancedstationGetevents) | **GET** /advancedstation/getevents | Gets the courses available for a specific location and a specific student.
[**advancedstationGetinfo**](AdvancedstationApi.md#advancedstationGetinfo) | **GET** /advancedstation/getinfo | Gets the info to display in the sign-in station by it&#39;s ID.
[**advancedstationGetlocations**](AdvancedstationApi.md#advancedstationGetlocations) | **GET** /advancedstation/getlocations | Gets the locations available in a sign-in station.
[**advancedstationGetlogstaff**](AdvancedstationApi.md#advancedstationGetlogstaff) | **GET** /advancedstation/getlogstaff | Gets the staff/tutors available filtered by the location, course and services of the given attendance log.
[**advancedstationGetroles**](AdvancedstationApi.md#advancedstationGetroles) | **GET** /advancedstation/getroles | Gets the user roles of the user trying to sign-in.
[**advancedstationGetservices**](AdvancedstationApi.md#advancedstationGetservices) | **GET** /advancedstation/getservices | Gets the services available for a specific location.
[**advancedstationGetstaff**](AdvancedstationApi.md#advancedstationGetstaff) | **GET** /advancedstation/getstaff | Gets the staff/tutors available for a specific location, course and service.
[**advancedstationIssignedin**](AdvancedstationApi.md#advancedstationIssignedin) | **GET** /advancedstation/issignedin | Gets whether a user is signed-in or not.


<a name="advancedstationCheckunknownuser"></a>
# **advancedstationCheckunknownuser**
> advancedstationCheckunknownuser(station, user, location)

Check whether the user is known by the system.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationCheckunknownuser(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationCheckunknownuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationCheckunknownuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationCheckuserrole"></a>
# **advancedstationCheckuserrole**
> advancedstationCheckuserrole(station, user, location)

Check whether the user is a staff member, an attendee or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationCheckuserrole(station, user, location)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationCheckuserrole")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationCheckuserrole")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationCreateuser"></a>
# **advancedstationCreateuser**
> advancedstationCreateuser(station, user, location, firstname, lastname, email, middlename)

Creates a user via a sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user to create.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
val firstname : kotlin.String = firstname_example // kotlin.String | The first name of the user to create.
val lastname : kotlin.String = lastname_example // kotlin.String | The last name of the user to create.
val email : kotlin.String = email_example // kotlin.String | The email of the user to create.
val middlename : kotlin.String = middlename_example // kotlin.String | The middle name of the user to create.
try {
    apiInstance.advancedstationCreateuser(station, user, location, firstname, lastname, email, middlename)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationCreateuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationCreateuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **user** | **kotlin.String**| The card of the user to create. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |
 **firstname** | **kotlin.String**| The first name of the user to create. |
 **lastname** | **kotlin.String**| The last name of the user to create. |
 **email** | **kotlin.String**| The email of the user to create. |
 **middlename** | **kotlin.String**| The middle name of the user to create. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetevents"></a>
# **advancedstationGetevents**
> advancedstationGetevents(station, location, user)

Gets the courses available for a specific location and a specific student.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationGetevents(station, location, user)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetinfo"></a>
# **advancedstationGetinfo**
> advancedstationGetinfo(id, event)

Gets the info to display in the sign-in station by it&#39;s ID.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val event : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event (or session), to override the scheduled one.
try {
    apiInstance.advancedstationGetinfo(id, event)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetinfo")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetinfo")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **event** | [**java.util.UUID**](.md)| The id of the event (or session), to override the scheduled one. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetlocations"></a>
# **advancedstationGetlocations**
> advancedstationGetlocations(station, user)

Gets the locations available in a sign-in station.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station whose locations have to be returned.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationGetlocations(station, user)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetlocations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetlocations")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station whose locations have to be returned. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetlogstaff"></a>
# **advancedstationGetlogstaff**
> advancedstationGetlogstaff(station, attendancelog, photosize)

Gets the staff/tutors available filtered by the location, course and services of the given attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val attendancelog : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the attendance log to filter the staff members.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advancedstationGetlogstaff(station, attendancelog, photosize)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetlogstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetlogstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **attendancelog** | [**java.util.UUID**](.md)| The id of the attendance log to filter the staff members. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetroles"></a>
# **advancedstationGetroles**
> advancedstationGetroles(station, signinrole, user, location)

Gets the user roles of the user trying to sign-in.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val signinrole : kotlin.String = signinrole_example // kotlin.String | Specifies how the user is signing-in.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationGetroles(station, signinrole, user, location)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetroles")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetroles")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **signinrole** | **kotlin.String**| Specifies how the user is signing-in. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetservices"></a>
# **advancedstationGetservices**
> advancedstationGetservices(station, location, user)

Gets the services available for a specific location.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.advancedstationGetservices(station, location, user)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **location** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationGetstaff"></a>
# **advancedstationGetstaff**
> advancedstationGetstaff(station, locationid, user, services, eventid, photosize)

Gets the staff/tutors available for a specific location, course and service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val locationid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the student picked.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val services : kotlin.String = services_example // kotlin.String | The list of services selected by the user, in JSON format.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the event selected.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.advancedstationGetstaff(station, locationid, user, services, eventid, photosize)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationGetstaff")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationGetstaff")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **locationid** | [**java.util.UUID**](.md)| The id of the location the student picked. |
 **user** | **kotlin.String**| The card of the user. |
 **services** | **kotlin.String**| The list of services selected by the user, in JSON format. | [optional]
 **eventid** | [**java.util.UUID**](.md)| The ID of the event selected. | [optional]
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="advancedstationIssignedin"></a>
# **advancedstationIssignedin**
> advancedstationIssignedin(station, time, user, location)

Gets whether a user is signed-in or not.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = AdvancedstationApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val time : java.time.OffsetDateTime = 2013-10-20T19:20:30+01:00 // java.time.OffsetDateTime | The date and time of the swipe.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location the user picked.
try {
    apiInstance.advancedstationIssignedin(station, time, user, location)
} catch (e: ClientException) {
    println("4xx response calling AdvancedstationApi#advancedstationIssignedin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling AdvancedstationApi#advancedstationIssignedin")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**java.util.UUID**](.md)| The id of the sign-in station to get. |
 **time** | **java.time.OffsetDateTime**| The date and time of the swipe. |
 **user** | **kotlin.String**| The card of the user. |
 **location** | [**java.util.UUID**](.md)| The id of the location the user picked. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

