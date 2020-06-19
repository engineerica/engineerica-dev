# ComputerlabApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**computerlabDeletecomputer**](ComputerlabApi.md#computerlabDeletecomputer) | **DELETE** /computerlab/deletecomputer | Delete a computer
[**computerlabGetcomputer**](ComputerlabApi.md#computerlabGetcomputer) | **GET** /computerlab/getcomputer | Search and view details of a computer
[**computerlabGetsettings**](ComputerlabApi.md#computerlabGetsettings) | **GET** /computerlab/getsettings | Loads the settings for a computer lab
[**computerlabIssignedin**](ComputerlabApi.md#computerlabIssignedin) | **GET** /computerlab/issignedin | Gets whether a user is signed-in or not.
[**computerlabListcomputers**](ComputerlabApi.md#computerlabListcomputers) | **GET** /computerlab/listcomputers | View a list of computers
[**computerlabListlabs**](ComputerlabApi.md#computerlabListlabs) | **GET** /computerlab/listlabs | View a list of the locations that use the Computer Lab add-on
[**computerlabListstations**](ComputerlabApi.md#computerlabListstations) | **GET** /computerlab/liststations | View a list of sign-in stations available for computer labs.
[**computerlabSavecomputer**](ComputerlabApi.md#computerlabSavecomputer) | **POST** /computerlab/savecomputer | Create or edit a computer
[**computerlabSavesettings**](ComputerlabApi.md#computerlabSavesettings) | **POST** /computerlab/savesettings | Saves the settings for a computer lab
[**computerlabSaveswipe**](ComputerlabApi.md#computerlabSaveswipe) | **POST** /computerlab/saveswipe | Save a new swipe from a computer in a computer lab.


<a name="computerlabDeletecomputer"></a>
# **computerlabDeletecomputer**
> computerlabDeletecomputer(UNKNOWN_BASE_TYPE)

Delete a computer

Allows the user to delete an existing computer.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabDeletecomputer(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabDeletecomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabDeletecomputer")
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

<a name="computerlabGetcomputer"></a>
# **computerlabGetcomputer**
> computerlabGetcomputer(id)

Search and view details of a computer

Allows the user to search and view an individual computer and its details.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val id : kotlin.String = id_example // kotlin.String | The unique device id of the computer to get.
try {
    apiInstance.computerlabGetcomputer(id)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabGetcomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabGetcomputer")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **kotlin.String**| The unique device id of the computer to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabGetsettings"></a>
# **computerlabGetsettings**
> computerlabGetsettings(id)

Loads the settings for a computer lab

Loads the settings for a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the computer lab/location.
try {
    apiInstance.computerlabGetsettings(id)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabGetsettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabGetsettings")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the computer lab/location. |

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabIssignedin"></a>
# **computerlabIssignedin**
> computerlabIssignedin(station, user)

Gets whether a user is signed-in or not.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val station : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the sign-in station to get.
val user : kotlin.String = user_example // kotlin.String | The card of the user.
try {
    apiInstance.computerlabIssignedin(station, user)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabIssignedin")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabIssignedin")
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

<a name="computerlabListcomputers"></a>
# **computerlabListcomputers**
> computerlabListcomputers(from, count, location, freeonly)

View a list of computers

Allows the user to view the list of all computers.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
val location : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the location whose computers have to be returned.
val freeonly : kotlin.Boolean = true // kotlin.Boolean | If true, only free computers will be returned.
try {
    apiInstance.computerlabListcomputers(from, count, location, freeonly)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabListcomputers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabListcomputers")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. |
 **count** | **kotlin.Int**| The max number of records to return. |
 **location** | [**java.util.UUID**](.md)| The id of the location whose computers have to be returned. | [optional]
 **freeonly** | **kotlin.Boolean**| If true, only free computers will be returned. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="computerlabListlabs"></a>
# **computerlabListlabs**
> computerlabListlabs()

View a list of the locations that use the Computer Lab add-on

Allows the user to view the list of all labs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
try {
    apiInstance.computerlabListlabs()
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabListlabs")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabListlabs")
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

<a name="computerlabListstations"></a>
# **computerlabListstations**
> computerlabListstations()

View a list of sign-in stations available for computer labs.

Allows the user to view the list of sign-in stations that are available for computer labs.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
try {
    apiInstance.computerlabListstations()
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabListstations")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabListstations")
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

<a name="computerlabSavecomputer"></a>
# **computerlabSavecomputer**
> computerlabSavecomputer(UNKNOWN_BASE_TYPE)

Create or edit a computer

Allows the user to create or edit a computer.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabSavecomputer(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabSavecomputer")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabSavecomputer")
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

<a name="computerlabSavesettings"></a>
# **computerlabSavesettings**
> computerlabSavesettings(UNKNOWN_BASE_TYPE)

Saves the settings for a computer lab

Saves the settings for a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabSavesettings(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabSavesettings")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabSavesettings")
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

<a name="computerlabSaveswipe"></a>
# **computerlabSaveswipe**
> computerlabSaveswipe(UNKNOWN_BASE_TYPE)

Save a new swipe from a computer in a computer lab.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = ComputerlabApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.computerlabSaveswipe(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling ComputerlabApi#computerlabSaveswipe")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling ComputerlabApi#computerlabSaveswipe")
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

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

