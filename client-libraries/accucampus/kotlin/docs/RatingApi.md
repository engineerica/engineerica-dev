# RatingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ratingFlag**](RatingApi.md#ratingFlag) | **GET** /rating/flag | Flags one rating for moderation
[**ratingFlagcomment**](RatingApi.md#ratingFlagcomment) | **GET** /rating/flagcomment | Flags one comment for moderation
[**ratingGet**](RatingApi.md#ratingGet) | **GET** /rating/get | Get rating for one or more entities
[**ratingGetall**](RatingApi.md#ratingGetall) | **GET** /rating/getall | Gets the full ratings and comments for a specific entity
[**ratingGetcomments**](RatingApi.md#ratingGetcomments) | **GET** /rating/getcomments | Gets all the comments for a rating
[**ratingGetpending**](RatingApi.md#ratingGetpending) | **GET** /rating/getpending | Gets info of pre-saved and pre-approved ratings
[**ratingGetpendingmoderation**](RatingApi.md#ratingGetpendingmoderation) | **GET** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**ratingModerate**](RatingApi.md#ratingModerate) | **GET** /rating/moderate | Allows the user to accept or reject a comment
[**ratingPostcomment**](RatingApi.md#ratingPostcomment) | **GET** /rating/postcomment | Posts a comments for in a rating
[**ratingRate**](RatingApi.md#ratingRate) | **GET** /rating/rate | Rates one entity
[**ratingRatepending**](RatingApi.md#ratingRatepending) | **GET** /rating/ratepending | Rates a pre-saved and pre-approved entity
[**ratingVote**](RatingApi.md#ratingVote) | **GET** /rating/vote | Votes up or down a rating


<a name="ratingFlag"></a>
# **ratingFlag**
> ratingFlag(id, comment)

Flags one rating for moderation

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The rating to flag.
val comment : kotlin.String = comment_example // kotlin.String | Comment why should this should be removed.
try {
    apiInstance.ratingFlag(id, comment)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingFlag")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingFlag")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The rating to flag. |
 **comment** | **kotlin.String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingFlagcomment"></a>
# **ratingFlagcomment**
> ratingFlagcomment(id, comment)

Flags one comment for moderation

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The comment to flag.
val comment : kotlin.String = comment_example // kotlin.String | Comment why should this should be removed.
try {
    apiInstance.ratingFlagcomment(id, comment)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingFlagcomment")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingFlagcomment")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**java.util.UUID**](.md)| The comment to flag. |
 **comment** | **kotlin.String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingGet"></a>
# **ratingGet**
> ratingGet(type, entityids)

Get rating for one or more entities

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val type : kotlin.String = type_example // kotlin.String | The entity type to get the rating.
val entityids : kotlin.String = entityids_example // kotlin.String | List of ids to get the ratings.
try {
    apiInstance.ratingGet(type, entityids)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingGet")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingGet")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **kotlin.String**| The entity type to get the rating. |
 **entityids** | **kotlin.String**| List of ids to get the ratings. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingGetall"></a>
# **ratingGetall**
> ratingGetall(type, entityid, mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val type : kotlin.String = type_example // kotlin.String | The entity type to get the rating.
val entityid : kotlin.String = entityid_example // kotlin.String | Id of the entity to get the ratings.
val mostrecentfirst : kotlin.Boolean = true // kotlin.Boolean | True to show most recent first, otherwise most helpful first.
try {
    apiInstance.ratingGetall(type, entityid, mostrecentfirst)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingGetall")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingGetall")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **kotlin.String**| The entity type to get the rating. |
 **entityid** | **kotlin.String**| Id of the entity to get the ratings. |
 **mostrecentfirst** | **kotlin.Boolean**| True to show most recent first, otherwise most helpful first. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingGetcomments"></a>
# **ratingGetcomments**
> ratingGetcomments(ratingid)

Gets all the comments for a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to get all comments.
try {
    apiInstance.ratingGetcomments(ratingid)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingGetcomments")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingGetcomments")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to get all comments. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingGetpending"></a>
# **ratingGetpending**
> ratingGetpending(getgroup, rateid, rateval)

Gets info of pre-saved and pre-approved ratings

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val getgroup : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group of pending ratings to get.
val rateid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Rate this before returning.
val rateval : kotlin.Int = 56 // kotlin.Int | The value used to rate the item specified in rateid.
try {
    apiInstance.ratingGetpending(getgroup, rateid, rateval)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingGetpending")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingGetpending")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**java.util.UUID**](.md)| The ID of the group of pending ratings to get. |
 **rateid** | [**java.util.UUID**](.md)| Rate this before returning. | [optional]
 **rateval** | **kotlin.Int**| The value used to rate the item specified in rateid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingGetpendingmoderation"></a>
# **ratingGetpendingmoderation**
> ratingGetpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
try {
    apiInstance.ratingGetpendingmoderation()
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingGetpendingmoderation")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingGetpendingmoderation")
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

<a name="ratingModerate"></a>
# **ratingModerate**
> ratingModerate(type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val type : kotlin.String = type_example // kotlin.String | Either 'rating' or 'comment' depending on what you want to moderate.
val id : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Id of the rating or comment, as specified in type.
val approve : kotlin.Boolean = true // kotlin.Boolean | True to approve, false to reject.
try {
    apiInstance.ratingModerate(type, id, approve)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingModerate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingModerate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **kotlin.String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. |
 **id** | [**java.util.UUID**](.md)| Id of the rating or comment, as specified in type. |
 **approve** | **kotlin.Boolean**| True to approve, false to reject. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingPostcomment"></a>
# **ratingPostcomment**
> ratingPostcomment(ratingid, comment, annonymous)

Posts a comments for in a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to post the comment.
val comment : kotlin.String = comment_example // kotlin.String | Text of the comment to post.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | True to post the comment annonymously.
try {
    apiInstance.ratingPostcomment(ratingid, comment, annonymous)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingPostcomment")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingPostcomment")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to post the comment. |
 **comment** | **kotlin.String**| Text of the comment to post. |
 **annonymous** | **kotlin.Boolean**| True to post the comment annonymously. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingRate"></a>
# **ratingRate**
> ratingRate(type, entityid, annonymous, value, comment, updatecomment)

Rates one entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val type : kotlin.String = type_example // kotlin.String | The entity type to rate.
val entityid : kotlin.String = entityid_example // kotlin.String | Id of the entity to rate.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | Whether to post as annonymous.
val value : kotlin.Int = 56 // kotlin.Int | Value from 0 to 100 with the rating.
val comment : kotlin.String = comment_example // kotlin.String | Comment associated with this review. Comment can be updated later on another request too.
val updatecomment : kotlin.Boolean = true // kotlin.Boolean | Whether to update the comments. Defaults to true.
try {
    apiInstance.ratingRate(type, entityid, annonymous, value, comment, updatecomment)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingRate")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingRate")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **kotlin.String**| The entity type to rate. |
 **entityid** | **kotlin.String**| Id of the entity to rate. |
 **annonymous** | **kotlin.Boolean**| Whether to post as annonymous. |
 **value** | **kotlin.Int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **kotlin.String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **kotlin.Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingRatepending"></a>
# **ratingRatepending**
> ratingRatepending(group, annonymous, rateid, value, comment, updatecomment)

Rates a pre-saved and pre-approved entity

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val group : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the group of with pre-approved ratings.
val annonymous : kotlin.Boolean = true // kotlin.Boolean | Whether to post as annonymous.
val rateid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | Rate this before returning.
val value : kotlin.Int = 56 // kotlin.Int | Value from 0 to 100 with the rating.
val comment : kotlin.String = comment_example // kotlin.String | Comment associated with this review. Comment can be updated later on another request too.
val updatecomment : kotlin.Boolean = true // kotlin.Boolean | Whether to update the comments. Defaults to true.
try {
    apiInstance.ratingRatepending(group, annonymous, rateid, value, comment, updatecomment)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingRatepending")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingRatepending")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**java.util.UUID**](.md)| The ID of the group of with pre-approved ratings. |
 **annonymous** | **kotlin.Boolean**| Whether to post as annonymous. |
 **rateid** | [**java.util.UUID**](.md)| Rate this before returning. | [optional]
 **value** | **kotlin.Int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **kotlin.String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **kotlin.Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

<a name="ratingVote"></a>
# **ratingVote**
> ratingVote(ratingid, vote)

Votes up or down a rating

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = RatingApi()
val ratingid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the rating to vote on.
val vote : kotlin.Int = 56 // kotlin.Int | 1 to vote up, -1 to vote down.
try {
    apiInstance.ratingVote(ratingid, vote)
} catch (e: ClientException) {
    println("4xx response calling RatingApi#ratingVote")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling RatingApi#ratingVote")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**java.util.UUID**](.md)| The ID of the rating to vote on. |
 **vote** | **kotlin.Int**| 1 to vote up, -1 to vote down. |

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

