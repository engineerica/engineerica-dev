# SessionswipeApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionswipeDelete**](SessionswipeApi.md#sessionswipeDelete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
[**sessionswipeGet**](SessionswipeApi.md#sessionswipeGet) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
[**sessionswipeListunresolved**](SessionswipeApi.md#sessionswipeListunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
[**sessionswipeResolve**](SessionswipeApi.md#sessionswipeResolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
[**sessionswipeSave**](SessionswipeApi.md#sessionswipeSave) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
[**sessionswipeSaveanonym**](SessionswipeApi.md#sessionswipeSaveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


<a name="sessionswipeDelete"></a>
# **sessionswipeDelete**
> sessionswipeDelete(id, body)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session swipe to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.sessionswipeDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the session swipe to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="sessionswipeGet"></a>
# **sessionswipeGet**
> sessionswipeGet(id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to get.
try {
    apiInstance.sessionswipeGet(id)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the swipe to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswipeListunresolved"></a>
# **sessionswipeListunresolved**
> sessionswipeListunresolved(from, count)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.sessionswipeListunresolved(from, count)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeListunresolved")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeListunresolved")
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

<a name="sessionswipeResolve"></a>
# **sessionswipeResolve**
> sessionswipeResolve(id, session, user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the swipe to resolve.
val session : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the session whose swipe has to be saved.
val user : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user who signed-in.
try {
    apiInstance.sessionswipeResolve(id, session, user)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeResolve")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeResolve")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the swipe to resolve. |
 **session** | [**java.util.UUID**](.md)| The id of the session whose swipe has to be saved. | [optional]
 **user** | [**java.util.UUID**](.md)| The id of the user who signed-in. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="sessionswipeSave"></a>
# **sessionswipeSave**
> sessionswipeSave(UNKNOWN_BASE_TYPE)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionswipeSave(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeSave")
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

<a name="sessionswipeSaveanonym"></a>
# **sessionswipeSaveanonym**
> sessionswipeSaveanonym(UNKNOWN_BASE_TYPE)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = SessionswipeApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.sessionswipeSaveanonym(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling SessionswipeApi#sessionswipeSaveanonym")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling SessionswipeApi#sessionswipeSaveanonym")
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

