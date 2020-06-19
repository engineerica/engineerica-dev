# UserprofileApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userprofileDelete**](UserprofileApi.md#userprofileDelete) | **DELETE** /userprofile/{id} | Delete a user profile
[**userprofileGet**](UserprofileApi.md#userprofileGet) | **GET** /userprofile/{id} | View a specific user profile
[**userprofileGetallview**](UserprofileApi.md#userprofileGetallview) | **GET** /userprofile/getallview | Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
[**userprofileList**](UserprofileApi.md#userprofileList) | **GET** /userprofile/list | View the list of user profiles
[**userprofileListquestions**](UserprofileApi.md#userprofileListquestions) | **GET** /userprofile/listquestions | Gets the list of all the available user questions
[**userprofilePreparestats**](UserprofileApi.md#userprofilePreparestats) | **GET** /userprofile/preparestats | Gets the statistics of a user group
[**userprofileSave**](UserprofileApi.md#userprofileSave) | **POST** /userprofile/{id} | Create or edit user profile questions
[**userprofileSaveanswers**](UserprofileApi.md#userprofileSaveanswers) | **POST** /userprofile/saveanswers | Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.


<a name="userprofileDelete"></a>
# **userprofileDelete**
> userprofileDelete(id, body)

Delete a user profile

Allows the user to delete a profile from the list of profiles that they have permission to edit.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user profile to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.userprofileDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user profile to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userprofileGet"></a>
# **userprofileGet**
> userprofileGet(id)

View a specific user profile

Allows the user to view individual user profiles and their details, provided they have permission to view that profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the profile question set.
try {
    apiInstance.userprofileGet(id)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the profile question set. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofileGetallview"></a>
# **userprofileGetallview**
> userprofileGetallview(id)

Shows the profile for a specific (or current) user, based on each profile questionnaire questions.

Allows the user to view a profile for a user, provided they have permission to view that user and profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the user to view, or empty for current user.
try {
    apiInstance.userprofileGetallview(id)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileGetallview")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileGetallview")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the user to view, or empty for current user. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofileList"></a>
# **userprofileList**
> userprofileList(from, count)

View the list of user profiles

Allows the user to view the full list of profiles that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.userprofileList(from, count)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **kotlin.Int**| The first record to return. | [optional]
 **count** | **kotlin.Int**| The max number of records to return. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofileListquestions"></a>
# **userprofileListquestions**
> userprofileListquestions()

Gets the list of all the available user questions

Allows the user to view the list of questions in a profile that they have permission to view.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
try {
    apiInstance.userprofileListquestions()
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileListquestions")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileListquestions")
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

<a name="userprofilePreparestats"></a>
# **userprofilePreparestats**
> userprofilePreparestats(params)

Gets the statistics of a user group

Allows the user to view the demographic statistics of a user group.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val params : kotlin.String = params_example // kotlin.String | The ID of the group, specified as 'group=...'
try {
    apiInstance.userprofilePreparestats(params)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofilePreparestats")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofilePreparestats")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **kotlin.String**| The ID of the group, specified as &#39;group&#x3D;...&#39; | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="userprofileSave"></a>
# **userprofileSave**
> userprofileSave(id, UNKNOWN_BASE_TYPE)

Create or edit user profile questions

Allows the user to create or edit a user profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the profile question set.
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userprofileSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the profile question set. |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="userprofileSaveanswers"></a>
# **userprofileSaveanswers**
> userprofileSaveanswers(UNKNOWN_BASE_TYPE)

Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.

Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = UserprofileApi()
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.userprofileSaveanswers(UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling UserprofileApi#userprofileSaveanswers")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling UserprofileApi#userprofileSaveanswers")
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

