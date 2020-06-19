# WWW::OpenAPIClient::RatingApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::RatingApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rating_flag**](RatingApi.md#rating_flag) | **GET** /rating/flag | Flags one rating for moderation
[**rating_flagcomment**](RatingApi.md#rating_flagcomment) | **GET** /rating/flagcomment | Flags one comment for moderation
[**rating_get**](RatingApi.md#rating_get) | **GET** /rating/get | Get rating for one or more entities
[**rating_getall**](RatingApi.md#rating_getall) | **GET** /rating/getall | Gets the full ratings and comments for a specific entity
[**rating_getcomments**](RatingApi.md#rating_getcomments) | **GET** /rating/getcomments | Gets all the comments for a rating
[**rating_getpending**](RatingApi.md#rating_getpending) | **GET** /rating/getpending | Gets info of pre-saved and pre-approved ratings
[**rating_getpendingmoderation**](RatingApi.md#rating_getpendingmoderation) | **GET** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**rating_moderate**](RatingApi.md#rating_moderate) | **GET** /rating/moderate | Allows the user to accept or reject a comment
[**rating_postcomment**](RatingApi.md#rating_postcomment) | **GET** /rating/postcomment | Posts a comments for in a rating
[**rating_rate**](RatingApi.md#rating_rate) | **GET** /rating/rate | Rates one entity
[**rating_ratepending**](RatingApi.md#rating_ratepending) | **GET** /rating/ratepending | Rates a pre-saved and pre-approved entity
[**rating_vote**](RatingApi.md#rating_vote) | **GET** /rating/vote | Votes up or down a rating


# **rating_flag**
> rating_flag(id => $id, comment => $comment)

Flags one rating for moderation

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The rating to flag.
my $comment = "comment_example"; # string | Comment why should this should be removed.

eval { 
    $api_instance->rating_flag(id => $id, comment => $comment);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_flag: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The rating to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_flagcomment**
> rating_flagcomment(id => $id, comment => $comment)

Flags one comment for moderation

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The comment to flag.
my $comment = "comment_example"; # string | Comment why should this should be removed.

eval { 
    $api_instance->rating_flagcomment(id => $id, comment => $comment);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_flagcomment: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The comment to flag. | 
 **comment** | **string**| Comment why should this should be removed. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_get**
> rating_get(type => $type, entityids => $entityids)

Get rating for one or more entities

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $type = "type_example"; # string | The entity type to get the rating.
my $entityids = "entityids_example"; # string | List of ids to get the ratings.

eval { 
    $api_instance->rating_get(type => $type, entityids => $entityids);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_get: $@\n";
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

# **rating_getall**
> rating_getall(type => $type, entityid => $entityid, mostrecentfirst => $mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $type = "type_example"; # string | The entity type to get the rating.
my $entityid = "entityid_example"; # string | Id of the entity to get the ratings.
my $mostrecentfirst = null; # boolean | True to show most recent first, otherwise most helpful first.

eval { 
    $api_instance->rating_getall(type => $type, entityid => $entityid, mostrecentfirst => $mostrecentfirst);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_getall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to get the rating. | 
 **entityid** | **string**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **boolean**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_getcomments**
> rating_getcomments(ratingid => $ratingid)

Gets all the comments for a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $ratingid = null; # string | The ID of the rating to get all comments.

eval { 
    $api_instance->rating_getcomments(ratingid => $ratingid);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_getcomments: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](.md)| The ID of the rating to get all comments. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_getpending**
> rating_getpending(getgroup => $getgroup, rateid => $rateid, rateval => $rateval)

Gets info of pre-saved and pre-approved ratings

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(
);

my $getgroup = null; # string | The ID of the group of pending ratings to get.
my $rateid = null; # string | Rate this before returning.
my $rateval = 56; # int | The value used to rate the item specified in rateid.

eval { 
    $api_instance->rating_getpending(getgroup => $getgroup, rateid => $rateid, rateval => $rateval);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_getpending: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**string**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**string**](.md)| Rate this before returning. | [optional] 
 **rateval** | **int**| The value used to rate the item specified in rateid. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_getpendingmoderation**
> rating_getpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->rating_getpendingmoderation();
};
if ($@) {
    warn "Exception when calling RatingApi->rating_getpendingmoderation: $@\n";
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

# **rating_moderate**
> rating_moderate(type => $type, id => $id, approve => $approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $type = "type_example"; # string | Either 'rating' or 'comment' depending on what you want to moderate.
my $id = null; # string | Id of the rating or comment, as specified in type.
my $approve = null; # boolean | True to approve, false to reject.

eval { 
    $api_instance->rating_moderate(type => $type, id => $id, approve => $approve);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_moderate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**string**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **boolean**| True to approve, false to reject. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_postcomment**
> rating_postcomment(ratingid => $ratingid, comment => $comment, annonymous => $annonymous)

Posts a comments for in a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $ratingid = null; # string | The ID of the rating to post the comment.
my $comment = "comment_example"; # string | Text of the comment to post.
my $annonymous = null; # boolean | True to post the comment annonymously.

eval { 
    $api_instance->rating_postcomment(ratingid => $ratingid, comment => $comment, annonymous => $annonymous);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_postcomment: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](.md)| The ID of the rating to post the comment. | 
 **comment** | **string**| Text of the comment to post. | 
 **annonymous** | **boolean**| True to post the comment annonymously. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_rate**
> rating_rate(type => $type, entityid => $entityid, annonymous => $annonymous, value => $value, comment => $comment, updatecomment => $updatecomment)

Rates one entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $type = "type_example"; # string | The entity type to rate.
my $entityid = "entityid_example"; # string | Id of the entity to rate.
my $annonymous = null; # boolean | Whether to post as annonymous.
my $value = 56; # int | Value from 0 to 100 with the rating.
my $comment = "comment_example"; # string | Comment associated with this review. Comment can be updated later on another request too.
my $updatecomment = null; # boolean | Whether to update the comments. Defaults to true.

eval { 
    $api_instance->rating_rate(type => $type, entityid => $entityid, annonymous => $annonymous, value => $value, comment => $comment, updatecomment => $updatecomment);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_rate: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to rate. | 
 **entityid** | **string**| Id of the entity to rate. | 
 **annonymous** | **boolean**| Whether to post as annonymous. | 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_ratepending**
> rating_ratepending(group => $group, annonymous => $annonymous, rateid => $rateid, value => $value, comment => $comment, updatecomment => $updatecomment)

Rates a pre-saved and pre-approved entity

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(
);

my $group = null; # string | The ID of the group of with pre-approved ratings.
my $annonymous = null; # boolean | Whether to post as annonymous.
my $rateid = null; # string | Rate this before returning.
my $value = 56; # int | Value from 0 to 100 with the rating.
my $comment = "comment_example"; # string | Comment associated with this review. Comment can be updated later on another request too.
my $updatecomment = null; # boolean | Whether to update the comments. Defaults to true.

eval { 
    $api_instance->rating_ratepending(group => $group, annonymous => $annonymous, rateid => $rateid, value => $value, comment => $comment, updatecomment => $updatecomment);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_ratepending: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **boolean**| Whether to post as annonymous. | 
 **rateid** | [**string**](.md)| Rate this before returning. | [optional] 
 **value** | **int**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rating_vote**
> rating_vote(ratingid => $ratingid, vote => $vote)

Votes up or down a rating

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RatingApi;
my $api_instance = WWW::OpenAPIClient::RatingApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $ratingid = null; # string | The ID of the rating to vote on.
my $vote = 56; # int | 1 to vote up, -1 to vote down.

eval { 
    $api_instance->rating_vote(ratingid => $ratingid, vote => $vote);
};
if ($@) {
    warn "Exception when calling RatingApi->rating_vote: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](.md)| The ID of the rating to vote on. | 
 **vote** | **int**| 1 to vote up, -1 to vote down. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

