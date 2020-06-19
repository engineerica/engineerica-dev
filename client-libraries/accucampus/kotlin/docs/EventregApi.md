# EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventregAddme**](EventregApi.md#eventregAddme) | **GET** /eventreg/addme | Register current user to a course
[**eventregAddmetoall**](EventregApi.md#eventregAddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventregAddmetogroup**](EventregApi.md#eventregAddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventregAdduser**](EventregApi.md#eventregAdduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventregAddusertoall**](EventregApi.md#eventregAddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventregAddusertogroup**](EventregApi.md#eventregAddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventregGetevents**](EventregApi.md#eventregGetevents) | **GET** /eventreg/getevents | View course registration by user
[**eventregGetgroups**](EventregApi.md#eventregGetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventregGetmyevents**](EventregApi.md#eventregGetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventregGetmygroups**](EventregApi.md#eventregGetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventregGetusers**](EventregApi.md#eventregGetusers) | **GET** /eventreg/getusers | View course registration
[**eventregGetusersfromgroup**](EventregApi.md#eventregGetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventregGetuserstoall**](EventregApi.md#eventregGetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventregRemoveme**](EventregApi.md#eventregRemoveme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventregRemovemefromall**](EventregApi.md#eventregRemovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventregRemovemefromgroup**](EventregApi.md#eventregRemovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventregRemoveuser**](EventregApi.md#eventregRemoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventregRemoveuserfromall**](EventregApi.md#eventregRemoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventregRemoveuserfromgroup**](EventregApi.md#eventregRemoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group


<a name="eventregAddme"></a>
# **eventregAddme**
> eventregAddme(eventid, listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAddme(eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAddme")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAddme")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregAddmetoall"></a>
# **eventregAddmetoall**
> eventregAddmetoall(listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAddmetoall(listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAddmetoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAddmetoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregAddmetogroup"></a>
# **eventregAddmetogroup**
> eventregAddmetogroup(codegroup, listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val codegroup : kotlin.String = codegroup_example // kotlin.String | The code used to group events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAddmetogroup(codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAddmetogroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAddmetogroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **kotlin.String**| The code used to group events. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregAdduser"></a>
# **eventregAdduser**
> eventregAdduser(userid, eventid, listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAdduser(userid, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAdduser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAdduser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregAddusertoall"></a>
# **eventregAddusertoall**
> eventregAddusertoall(userid, listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAddusertoall(userid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAddusertoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAddusertoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregAddusertogroup"></a>
# **eventregAddusertogroup**
> eventregAddusertogroup(userid, codegroup, listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val codegroup : kotlin.String = codegroup_example // kotlin.String | The code used to group events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user has to be registered.
try {
    apiInstance.eventregAddusertogroup(userid, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregAddusertogroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregAddusertogroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **codegroup** | **kotlin.String**| The code used to group events. |
 **listname** | **kotlin.String**| The name of the list where the user has to be registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetevents"></a>
# **eventregGetevents**
> eventregGetevents(userid, listname, termid, namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term id to list events.
val namefilter : kotlin.String = namefilter_example // kotlin.String | The value used to filter the events by name.
try {
    apiInstance.eventregGetevents(userid, listname, termid, namefilter)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The user id to list events. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |
 **termid** | [**java.util.UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **kotlin.String**| The value used to filter the events by name. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetgroups"></a>
# **eventregGetgroups**
> eventregGetgroups(userid, listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list events.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregGetgroups(userid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetgroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetgroups")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The user id to list events. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetmyevents"></a>
# **eventregGetmyevents**
> eventregGetmyevents(listname, termid, namefilter)

View the event registrations of the current user

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
val termid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The term id to list events.
val namefilter : kotlin.String = namefilter_example // kotlin.String | The value used to filter the events by name.
try {
    apiInstance.eventregGetmyevents(listname, termid, namefilter)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetmyevents")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetmyevents")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **kotlin.String**| The name of the list where the user is registered. |
 **termid** | [**java.util.UUID**](.md)| The term id to list events. | [optional]
 **namefilter** | **kotlin.String**| The value used to filter the events by name. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetmygroups"></a>
# **eventregGetmygroups**
> eventregGetmygroups(listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregGetmygroups(listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetmygroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetmygroups")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetusers"></a>
# **eventregGetusers**
> eventregGetusers(eventid, listname, photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The event id to list users.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
val photosize : kotlin.Int = 56 // kotlin.Int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
try {
    apiInstance.eventregGetusers(eventid, listname, photosize)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetusers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetusers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The event id to list users. |
 **listname** | **kotlin.String**| The name of the list to get. |
 **photosize** | **kotlin.Int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetusersfromgroup"></a>
# **eventregGetusersfromgroup**
> eventregGetusersfromgroup(codegroup, listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group to list users.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
try {
    apiInstance.eventregGetusersfromgroup(codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetusersfromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetusersfromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**java.util.UUID**](.md)| The code group to list users. |
 **listname** | **kotlin.String**| The name of the list to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregGetuserstoall"></a>
# **eventregGetuserstoall**
> eventregGetuserstoall(listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val listname : kotlin.String = listname_example // kotlin.String | The name of the list to get.
try {
    apiInstance.eventregGetuserstoall(listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregGetuserstoall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregGetuserstoall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **kotlin.String**| The name of the list to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemoveme"></a>
# **eventregRemoveme**
> eventregRemoveme(eventid, listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemoveme(eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemoveme")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemoveme")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemovemefromall"></a>
# **eventregRemovemefromall**
> eventregRemovemefromall(listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemovemefromall(listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemovemefromall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemovemefromall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemovemefromgroup"></a>
# **eventregRemovemefromgroup**
> eventregRemovemefromgroup(codegroup, listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group of the events/courses.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemovemefromgroup(codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemovemefromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemovemefromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**java.util.UUID**](.md)| The code group of the events/courses. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemoveuser"></a>
# **eventregRemoveuser**
> eventregRemoveuser(userid, eventid, listname)

Remove a user from a course

Allows the user to remove a user from a course&#39;s registration.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val eventid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the event.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemoveuser(userid, eventid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemoveuser")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemoveuser")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **eventid** | [**java.util.UUID**](.md)| The id of the event. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemoveuserfromall"></a>
# **eventregRemoveuserfromall**
> eventregRemoveuserfromall(userid, listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemoveuserfromall(userid, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemoveuserfromall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemoveuserfromall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="eventregRemoveuserfromgroup"></a>
# **eventregRemoveuserfromgroup**
> eventregRemoveuserfromgroup(userid, codegroup, listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = EventregApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val codegroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The code group of the events/courses.
val listname : kotlin.String = listname_example // kotlin.String | The name of the list where the user is registered.
try {
    apiInstance.eventregRemoveuserfromgroup(userid, codegroup, listname)
} catch (e: ClientException) {
    println("4xx response calling EventregApi#eventregRemoveuserfromgroup")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling EventregApi#eventregRemoveuserfromgroup")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **codegroup** | [**java.util.UUID**](.md)| The code group of the events/courses. |
 **listname** | **kotlin.String**| The name of the list where the user is registered. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

