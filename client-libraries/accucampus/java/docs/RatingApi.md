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
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID id = new UUID(); // UUID | The rating to flag.
    String comment = "comment_example"; // String | Comment why should this should be removed.
    try {
      apiInstance.ratingFlag(id, comment);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingFlag");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The rating to flag. |
 **comment** | **String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingFlagcomment"></a>
# **ratingFlagcomment**
> ratingFlagcomment(id, comment)

Flags one comment for moderation

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID id = new UUID(); // UUID | The comment to flag.
    String comment = "comment_example"; // String | Comment why should this should be removed.
    try {
      apiInstance.ratingFlagcomment(id, comment);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingFlagcomment");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**UUID**](.md)| The comment to flag. |
 **comment** | **String**| Comment why should this should be removed. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingGet"></a>
# **ratingGet**
> ratingGet(type, entityids)

Get rating for one or more entities

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    String type = "type_example"; // String | The entity type to get the rating.
    String entityids = "entityids_example"; // String | List of ids to get the ratings.
    try {
      apiInstance.ratingGet(type, entityids);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingGet");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to get the rating. |
 **entityids** | **String**| List of ids to get the ratings. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingGetall"></a>
# **ratingGetall**
> ratingGetall(type, entityid, mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    String type = "type_example"; // String | The entity type to get the rating.
    String entityid = "entityid_example"; // String | Id of the entity to get the ratings.
    Boolean mostrecentfirst = true; // Boolean | True to show most recent first, otherwise most helpful first.
    try {
      apiInstance.ratingGetall(type, entityid, mostrecentfirst);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingGetall");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to get the rating. |
 **entityid** | **String**| Id of the entity to get the ratings. |
 **mostrecentfirst** | **Boolean**| True to show most recent first, otherwise most helpful first. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingGetcomments"></a>
# **ratingGetcomments**
> ratingGetcomments(ratingid)

Gets all the comments for a rating

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID ratingid = new UUID(); // UUID | The ID of the rating to get all comments.
    try {
      apiInstance.ratingGetcomments(ratingid);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingGetcomments");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**UUID**](.md)| The ID of the rating to get all comments. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingGetpending"></a>
# **ratingGetpending**
> ratingGetpending(getgroup, rateid, rateval)

Gets info of pre-saved and pre-approved ratings

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID getgroup = new UUID(); // UUID | The ID of the group of pending ratings to get.
    UUID rateid = new UUID(); // UUID | Rate this before returning.
    Integer rateval = 56; // Integer | The value used to rate the item specified in rateid.
    try {
      apiInstance.ratingGetpending(getgroup, rateid, rateval);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingGetpending");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**UUID**](.md)| The ID of the group of pending ratings to get. |
 **rateid** | [**UUID**](.md)| Rate this before returning. | [optional]
 **rateval** | **Integer**| The value used to rate the item specified in rateid. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingGetpendingmoderation"></a>
# **ratingGetpendingmoderation**
> ratingGetpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    try {
      apiInstance.ratingGetpendingmoderation();
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingGetpendingmoderation");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingModerate"></a>
# **ratingModerate**
> ratingModerate(type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    String type = "type_example"; // String | Either 'rating' or 'comment' depending on what you want to moderate.
    UUID id = new UUID(); // UUID | Id of the rating or comment, as specified in type.
    Boolean approve = true; // Boolean | True to approve, false to reject.
    try {
      apiInstance.ratingModerate(type, id, approve);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingModerate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. |
 **id** | [**UUID**](.md)| Id of the rating or comment, as specified in type. |
 **approve** | **Boolean**| True to approve, false to reject. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingPostcomment"></a>
# **ratingPostcomment**
> ratingPostcomment(ratingid, comment, annonymous)

Posts a comments for in a rating

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID ratingid = new UUID(); // UUID | The ID of the rating to post the comment.
    String comment = "comment_example"; // String | Text of the comment to post.
    Boolean annonymous = true; // Boolean | True to post the comment annonymously.
    try {
      apiInstance.ratingPostcomment(ratingid, comment, annonymous);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingPostcomment");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**UUID**](.md)| The ID of the rating to post the comment. |
 **comment** | **String**| Text of the comment to post. |
 **annonymous** | **Boolean**| True to post the comment annonymously. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingRate"></a>
# **ratingRate**
> ratingRate(type, entityid, annonymous, value, comment, updatecomment)

Rates one entity

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    String type = "type_example"; // String | The entity type to rate.
    String entityid = "entityid_example"; // String | Id of the entity to rate.
    Boolean annonymous = true; // Boolean | Whether to post as annonymous.
    Integer value = 56; // Integer | Value from 0 to 100 with the rating.
    String comment = "comment_example"; // String | Comment associated with this review. Comment can be updated later on another request too.
    Boolean updatecomment = true; // Boolean | Whether to update the comments. Defaults to true.
    try {
      apiInstance.ratingRate(type, entityid, annonymous, value, comment, updatecomment);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingRate");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to rate. |
 **entityid** | **String**| Id of the entity to rate. |
 **annonymous** | **Boolean**| Whether to post as annonymous. |
 **value** | **Integer**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingRatepending"></a>
# **ratingRatepending**
> ratingRatepending(group, annonymous, rateid, value, comment, updatecomment)

Rates a pre-saved and pre-approved entity

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID group = new UUID(); // UUID | The ID of the group of with pre-approved ratings.
    Boolean annonymous = true; // Boolean | Whether to post as annonymous.
    UUID rateid = new UUID(); // UUID | Rate this before returning.
    Integer value = 56; // Integer | Value from 0 to 100 with the rating.
    String comment = "comment_example"; // String | Comment associated with this review. Comment can be updated later on another request too.
    Boolean updatecomment = true; // Boolean | Whether to update the comments. Defaults to true.
    try {
      apiInstance.ratingRatepending(group, annonymous, rateid, value, comment, updatecomment);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingRatepending");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**UUID**](.md)| The ID of the group of with pre-approved ratings. |
 **annonymous** | **Boolean**| Whether to post as annonymous. |
 **rateid** | [**UUID**](.md)| Rate this before returning. | [optional]
 **value** | **Integer**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

<a name="ratingVote"></a>
# **ratingVote**
> ratingVote(ratingid, vote)

Votes up or down a rating

### Example
```java
// Import classes:
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.Configuration;
import org.openapitools.client.auth.*;
import org.openapitools.client.models.*;
import org.openapitools.client.api.RatingApi;

public class Example {
  public static void main(String[] args) {
    ApiClient defaultClient = Configuration.getDefaultApiClient();
    defaultClient.setBasePath("https://accucampus.net:443/api/v1");
    
    // Configure HTTP bearer authorization: bearerAuth
    HttpBearerAuth bearerAuth = (HttpBearerAuth) defaultClient.getAuthentication("bearerAuth");
    bearerAuth.setBearerToken("BEARER TOKEN");

    RatingApi apiInstance = new RatingApi(defaultClient);
    UUID ratingid = new UUID(); // UUID | The ID of the rating to vote on.
    Integer vote = 56; // Integer | 1 to vote up, -1 to vote down.
    try {
      apiInstance.ratingVote(ratingid, vote);
    } catch (ApiException e) {
      System.err.println("Exception when calling RatingApi#ratingVote");
      System.err.println("Status code: " + e.getCode());
      System.err.println("Reason: " + e.getResponseBody());
      System.err.println("Response headers: " + e.getResponseHeaders());
      e.printStackTrace();
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**UUID**](.md)| The ID of the rating to vote on. |
 **vote** | **Integer**| 1 to vote up, -1 to vote down. |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
**200** |  |  -  |

