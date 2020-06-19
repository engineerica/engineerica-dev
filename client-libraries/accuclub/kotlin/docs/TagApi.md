# TagApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tagDelete**](TagApi.md#tagDelete) | **DELETE** /tag/{id} | Delete a tag
[**tagGet**](TagApi.md#tagGet) | **GET** /tag/{id} | View details of a specified tag
[**tagList**](TagApi.md#tagList) | **GET** /tag/list | View a list of tags
[**tagListgroups**](TagApi.md#tagListgroups) | **GET** /tag/listgroups | View a list of entities that can be tagged
[**tagSave**](TagApi.md#tagSave) | **POST** /tag/{id} | Create or edit a tag
[**tagSearch**](TagApi.md#tagSearch) | **GET** /tag/search | Search for tags in the account


<a name="tagDelete"></a>
# **tagDelete**
> tagDelete(id, body)

Delete a tag

Allows the user to delete an existing tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the tag to delete.
val body : AnyType =  // AnyType | 
try {
    apiInstance.tagDelete(id, body)
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagDelete")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagDelete")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the tag to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="tagGet"></a>
# **tagGet**
> tagGet(id)

View details of a specified tag

Allows the user to click on and view the settings for a tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the tag to get.
try {
    apiInstance.tagGet(id)
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the tag to get. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="tagList"></a>
# **tagList**
> tagList(group, from, count)

View a list of tags

Allows the user to view the list of tags.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
val group : kotlin.String = group_example // kotlin.String | The group of the tags to return.
val from : kotlin.Int = 56 // kotlin.Int | The first record to return.
val count : kotlin.Int = 56 // kotlin.Int | The max number of records to return.
try {
    apiInstance.tagList(group, from, count)
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagList")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagList")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | **kotlin.String**| The group of the tags to return. |
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

<a name="tagListgroups"></a>
# **tagListgroups**
> tagListgroups()

View a list of entities that can be tagged

Allows the user to view the list of user roles that can be tagged, according to that tag&#39;s settings.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
try {
    apiInstance.tagListgroups()
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagListgroups")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagListgroups")
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

<a name="tagSave"></a>
# **tagSave**
> tagSave(id, UNKNOWN_BASE_TYPE)

Create or edit a tag

Allows the user to create or edit a tag.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The id of the tag save (leave empty to create a new one).
val UNKNOWN_BASE_TYPE : UNKNOWN_BASE_TYPE =  // UNKNOWN_BASE_TYPE | 
try {
    apiInstance.tagSave(id, UNKNOWN_BASE_TYPE)
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagSave")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagSave")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The id of the tag save (leave empty to create a new one). |
 **UNKNOWN_BASE_TYPE** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

<a name="tagSearch"></a>
# **tagSearch**
> tagSearch(query, allowcreatingnew)

Search for tags in the account

Allows the user to search for tags.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = TagApi()
val query : kotlin.String = query_example // kotlin.String | The query to search tags. Use group:<group> to search in a specific group (mandatory).
val allowcreatingnew : kotlin.Boolean = true // kotlin.Boolean | Specifies whether an option to create a new tag should be retrieved.
try {
    apiInstance.tagSearch(query, allowcreatingnew)
} catch (e: ClientException) {
    println("4xx response calling TagApi#tagSearch")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling TagApi#tagSearch")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **kotlin.String**| The query to search tags. Use group:&lt;group&gt; to search in a specific group (mandatory). |
 **allowcreatingnew** | **kotlin.Boolean**| Specifies whether an option to create a new tag should be retrieved. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

