# StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavailAddmetoallservices**](StaffavailApi.md#staffavailAddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavailAddmetoservice**](StaffavailApi.md#staffavailAddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavailAddusertoallservices**](StaffavailApi.md#staffavailAddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavailAddusertoservice**](StaffavailApi.md#staffavailAddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavailGetmyservices**](StaffavailApi.md#staffavailGetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavailGetservices**](StaffavailApi.md#staffavailGetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavailGetusersforservice**](StaffavailApi.md#staffavailGetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavailListtypes**](StaffavailApi.md#staffavailListtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavailRemovemefromallservices**](StaffavailApi.md#staffavailRemovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavailRemovemefromservice**](StaffavailApi.md#staffavailRemovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavailRemoveuserfromallservices**](StaffavailApi.md#staffavailRemoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavailRemoveuserfromservice**](StaffavailApi.md#staffavailRemoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavailSetavailability**](StaffavailApi.md#staffavailSetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavailSetmyavailability**](StaffavailApi.md#staffavailSetmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type


<a name="staffavailAddmetoallservices"></a>
# **staffavailAddmetoallservices**
> staffavailAddmetoallservices()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
try {
    apiInstance.staffavailAddmetoallservices()
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailAddmetoallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailAddmetoallservices")
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

<a name="staffavailAddmetoservice"></a>
# **staffavailAddmetoservice**
> staffavailAddmetoservice(serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailAddmetoservice(serviceid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailAddmetoservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailAddmetoservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailAddusertoallservices"></a>
# **staffavailAddusertoallservices**
> staffavailAddusertoallservices(userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
try {
    apiInstance.staffavailAddusertoallservices(userid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailAddusertoallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailAddusertoallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailAddusertoservice"></a>
# **staffavailAddusertoservice**
> staffavailAddusertoservice(userid, serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to add.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailAddusertoservice(userid, serviceid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailAddusertoservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailAddusertoservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to add. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailGetmyservices"></a>
# **staffavailGetmyservices**
> staffavailGetmyservices()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
try {
    apiInstance.staffavailGetmyservices()
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailGetmyservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailGetmyservices")
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

<a name="staffavailGetservices"></a>
# **staffavailGetservices**
> staffavailGetservices(userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The user id to list services.
try {
    apiInstance.staffavailGetservices(userid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailGetservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailGetservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The user id to list services. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailGetusersforservice"></a>
# **staffavailGetusersforservice**
> staffavailGetusersforservice(serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The service id to list users.
try {
    apiInstance.staffavailGetusersforservice(serviceid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailGetusersforservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailGetusersforservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The service id to list users. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailListtypes"></a>
# **staffavailListtypes**
> staffavailListtypes()

View all the availability types

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
try {
    apiInstance.staffavailListtypes()
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailListtypes")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailListtypes")
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

<a name="staffavailRemovemefromallservices"></a>
# **staffavailRemovemefromallservices**
> staffavailRemovemefromallservices()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
try {
    apiInstance.staffavailRemovemefromallservices()
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailRemovemefromallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailRemovemefromallservices")
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

<a name="staffavailRemovemefromservice"></a>
# **staffavailRemovemefromservice**
> staffavailRemovemefromservice(serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailRemovemefromservice(serviceid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailRemovemefromservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailRemovemefromservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailRemoveuserfromallservices"></a>
# **staffavailRemoveuserfromallservices**
> staffavailRemoveuserfromallservices(userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member&#39;s availability to all services.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
try {
    apiInstance.staffavailRemoveuserfromallservices(userid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailRemoveuserfromallservices")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailRemoveuserfromallservices")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailRemoveuserfromservice"></a>
# **staffavailRemoveuserfromservice**
> staffavailRemoveuserfromservice(userid, serviceid)

Remove a staff member from a service

Allows the user to remove a staff member&#39;s service availability.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to remove.
val serviceid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the service.
try {
    apiInstance.staffavailRemoveuserfromservice(userid, serviceid)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailRemoveuserfromservice")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailRemoveuserfromservice")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user to remove. |
 **serviceid** | [**java.util.UUID**](.md)| The id of the service. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailSetavailability"></a>
# **staffavailSetavailability**
> staffavailSetavailability(userid, availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val userid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user whose specific availability has to be set.
val availablefor : kotlin.String = availablefor_example // kotlin.String | Specific availability to set.
try {
    apiInstance.staffavailSetavailability(userid, availablefor)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailSetavailability")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailSetavailability")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**java.util.UUID**](.md)| The id of the user whose specific availability has to be set. |
 **availablefor** | **kotlin.String**| Specific availability to set. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="staffavailSetmyavailability"></a>
# **staffavailSetmyavailability**
> staffavailSetmyavailability(availablefor)

Change current user&#39;s availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = StaffavailApi()
val availablefor : kotlin.String = availablefor_example // kotlin.String | Specific availability to set.
try {
    apiInstance.staffavailSetmyavailability(availablefor)
} catch (e: ClientException) {
    println("4xx response calling StaffavailApi#staffavailSetmyavailability")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling StaffavailApi#staffavailSetmyavailability")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **kotlin.String**| Specific availability to set. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

