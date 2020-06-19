# Org.OpenAPITools.Api.RatingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RatingFlag**](RatingApi.md#ratingflag) | **GET** /rating/flag | Flags one rating for moderation
[**RatingFlagcomment**](RatingApi.md#ratingflagcomment) | **GET** /rating/flagcomment | Flags one comment for moderation
[**RatingGet**](RatingApi.md#ratingget) | **GET** /rating/get | Get rating for one or more entities
[**RatingGetall**](RatingApi.md#ratinggetall) | **GET** /rating/getall | Gets the full ratings and comments for a specific entity
[**RatingGetcomments**](RatingApi.md#ratinggetcomments) | **GET** /rating/getcomments | Gets all the comments for a rating
[**RatingGetpending**](RatingApi.md#ratinggetpending) | **GET** /rating/getpending | Gets info of pre-saved and pre-approved ratings
[**RatingGetpendingmoderation**](RatingApi.md#ratinggetpendingmoderation) | **GET** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**RatingModerate**](RatingApi.md#ratingmoderate) | **GET** /rating/moderate | Allows the user to accept or reject a comment
[**RatingPostcomment**](RatingApi.md#ratingpostcomment) | **GET** /rating/postcomment | Posts a comments for in a rating
[**RatingRate**](RatingApi.md#ratingrate) | **GET** /rating/rate | Rates one entity
[**RatingRatepending**](RatingApi.md#ratingratepending) | **GET** /rating/ratepending | Rates a pre-saved and pre-approved entity
[**RatingVote**](RatingApi.md#ratingvote) | **GET** /rating/vote | Votes up or down a rating


<a name="ratingflag"></a>
# **RatingFlag**
> void RatingFlag (Guid? id, string comment)

Flags one rating for moderation

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingFlagExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var id = new Guid?(); // Guid? | The rating to flag.
            var comment = comment_example;  // string | Comment why should this should be removed. (optional) 

            try
            {
                // Flags one rating for moderation
                apiInstance.RatingFlag(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingFlag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The rating to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingflagcomment"></a>
# **RatingFlagcomment**
> void RatingFlagcomment (Guid? id, string comment)

Flags one comment for moderation

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingFlagcommentExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var id = new Guid?(); // Guid? | The comment to flag.
            var comment = comment_example;  // string | Comment why should this should be removed. (optional) 

            try
            {
                // Flags one comment for moderation
                apiInstance.RatingFlagcomment(id, comment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingFlagcomment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](.md)| The comment to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingget"></a>
# **RatingGet**
> void RatingGet (string type, string entityids)

Get rating for one or more entities

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingGetExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var type = type_example;  // string | The entity type to get the rating.
            var entityids = entityids_example;  // string | List of ids to get the ratings.

            try
            {
                // Get rating for one or more entities
                apiInstance.RatingGet(type, entityids);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to get the rating. | 
 **entityids** | **string**| List of ids to get the ratings. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetall"></a>
# **RatingGetall**
> void RatingGetall (string type, string entityid, bool? mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingGetallExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var type = type_example;  // string | The entity type to get the rating.
            var entityid = entityid_example;  // string | Id of the entity to get the ratings.
            var mostrecentfirst = true;  // bool? | True to show most recent first, otherwise most helpful first. (optional) 

            try
            {
                // Gets the full ratings and comments for a specific entity
                apiInstance.RatingGetall(type, entityid, mostrecentfirst);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingGetall: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to get the rating. | 
 **entityid** | **string**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **bool?**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetcomments"></a>
# **RatingGetcomments**
> void RatingGetcomments (Guid? ratingid)

Gets all the comments for a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingGetcommentsExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var ratingid = new Guid?(); // Guid? | The ID of the rating to get all comments.

            try
            {
                // Gets all the comments for a rating
                apiInstance.RatingGetcomments(ratingid);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingGetcomments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**Guid?**](.md)| The ID of the rating to get all comments. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetpending"></a>
# **RatingGetpending**
> void RatingGetpending (Guid? getgroup, Guid? rateid, int? rateval)

Gets info of pre-saved and pre-approved ratings

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingGetpendingExample
    {
        public void main()
        {
            var apiInstance = new RatingApi();
            var getgroup = new Guid?(); // Guid? | The ID of the group of pending ratings to get.
            var rateid = new Guid?(); // Guid? | Rate this before returning. (optional) 
            var rateval = 56;  // int? | The value used to rate the item specified in rateid. (optional) 

            try
            {
                // Gets info of pre-saved and pre-approved ratings
                apiInstance.RatingGetpending(getgroup, rateid, rateval);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingGetpending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**Guid?**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**Guid?**](.md)| Rate this before returning. | [optional] 
 **rateval** | **int?**| The value used to rate the item specified in rateid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratinggetpendingmoderation"></a>
# **RatingGetpendingmoderation**
> void RatingGetpendingmoderation ()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingGetpendingmoderationExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();

            try
            {
                // Shows a list of the ratings and comments that are pending for moderation
                apiInstance.RatingGetpendingmoderation();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingGetpendingmoderation: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingmoderate"></a>
# **RatingModerate**
> void RatingModerate (string type, Guid? id, bool? approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingModerateExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var type = type_example;  // string | Either 'rating' or 'comment' depending on what you want to moderate.
            var id = new Guid?(); // Guid? | Id of the rating or comment, as specified in type.
            var approve = true;  // bool? | True to approve, false to reject.

            try
            {
                // Allows the user to accept or reject a comment
                apiInstance.RatingModerate(type, id, approve);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingModerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**Guid?**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **bool?**| True to approve, false to reject. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingpostcomment"></a>
# **RatingPostcomment**
> void RatingPostcomment (Guid? ratingid, string comment, bool? annonymous)

Posts a comments for in a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingPostcommentExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var ratingid = new Guid?(); // Guid? | The ID of the rating to post the comment.
            var comment = comment_example;  // string | Text of the comment to post.
            var annonymous = true;  // bool? | True to post the comment annonymously.

            try
            {
                // Posts a comments for in a rating
                apiInstance.RatingPostcomment(ratingid, comment, annonymous);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingPostcomment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**Guid?**](.md)| The ID of the rating to post the comment. | 
 **comment** | **string**| Text of the comment to post. | 
 **annonymous** | **bool?**| True to post the comment annonymously. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingrate"></a>
# **RatingRate**
> void RatingRate (string type, string entityid, bool? annonymous, int? value, string comment, bool? updatecomment)

Rates one entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingRateExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var type = type_example;  // string | The entity type to rate.
            var entityid = entityid_example;  // string | Id of the entity to rate.
            var annonymous = true;  // bool? | Whether to post as annonymous.
            var value = 56;  // int? | Value from 0 to 100 with the rating. (optional) 
            var comment = comment_example;  // string | Comment associated with this review. Comment can be updated later on another request too. (optional) 
            var updatecomment = true;  // bool? | Whether to update the comments. Defaults to true. (optional) 

            try
            {
                // Rates one entity
                apiInstance.RatingRate(type, entityid, annonymous, value, comment, updatecomment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to rate. | 
 **entityid** | **string**| Id of the entity to rate. | 
 **annonymous** | **bool?**| Whether to post as annonymous. | 
 **value** | **int?**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool?**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingratepending"></a>
# **RatingRatepending**
> void RatingRatepending (Guid? group, bool? annonymous, Guid? rateid, int? value, string comment, bool? updatecomment)

Rates a pre-saved and pre-approved entity

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingRatependingExample
    {
        public void main()
        {
            var apiInstance = new RatingApi();
            var group = new Guid?(); // Guid? | The ID of the group of with pre-approved ratings.
            var annonymous = true;  // bool? | Whether to post as annonymous.
            var rateid = new Guid?(); // Guid? | Rate this before returning. (optional) 
            var value = 56;  // int? | Value from 0 to 100 with the rating. (optional) 
            var comment = comment_example;  // string | Comment associated with this review. Comment can be updated later on another request too. (optional) 
            var updatecomment = true;  // bool? | Whether to update the comments. Defaults to true. (optional) 

            try
            {
                // Rates a pre-saved and pre-approved entity
                apiInstance.RatingRatepending(group, annonymous, rateid, value, comment, updatecomment);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingRatepending: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**Guid?**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **bool?**| Whether to post as annonymous. | 
 **rateid** | [**Guid?**](.md)| Rate this before returning. | [optional] 
 **value** | **int?**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **bool?**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratingvote"></a>
# **RatingVote**
> void RatingVote (Guid? ratingid, int? vote)

Votes up or down a rating

### Example
```csharp
using System;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RatingVoteExample
    {
        public void main()
        {
            // Configure Bearer access token: bearerAuth
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new RatingApi();
            var ratingid = new Guid?(); // Guid? | The ID of the rating to vote on.
            var vote = 56;  // int? | 1 to vote up, -1 to vote down.

            try
            {
                // Votes up or down a rating
                apiInstance.RatingVote(ratingid, vote);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RatingApi.RatingVote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**Guid?**](.md)| The ID of the rating to vote on. | 
 **vote** | **int?**| 1 to vote up, -1 to vote down. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

