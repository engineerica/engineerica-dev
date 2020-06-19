# OpenapiClient::RatingApi

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



## rating_flag

> rating_flag(id, opts)

Flags one rating for moderation

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
id = 'id_example' # String | The rating to flag.
opts = {
  comment: 'comment_example' # String | Comment why should this should be removed.
}

begin
  #Flags one rating for moderation
  api_instance.rating_flag(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_flag: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The rating to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_flagcomment

> rating_flagcomment(id, opts)

Flags one comment for moderation

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
id = 'id_example' # String | The comment to flag.
opts = {
  comment: 'comment_example' # String | Comment why should this should be removed.
}

begin
  #Flags one comment for moderation
  api_instance.rating_flagcomment(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_flagcomment: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The comment to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_get

> rating_get(type, entityids)

Get rating for one or more entities

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
type = 'type_example' # String | The entity type to get the rating.
entityids = 'entityids_example' # String | List of ids to get the ratings.

begin
  #Get rating for one or more entities
  api_instance.rating_get(type, entityids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to get the rating. | 
 **entityids** | **String**| List of ids to get the ratings. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_getall

> rating_getall(type, entityid, opts)

Gets the full ratings and comments for a specific entity

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
type = 'type_example' # String | The entity type to get the rating.
entityid = 'entityid_example' # String | Id of the entity to get the ratings.
opts = {
  mostrecentfirst: true # Boolean | True to show most recent first, otherwise most helpful first.
}

begin
  #Gets the full ratings and comments for a specific entity
  api_instance.rating_getall(type, entityid, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_getall: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to get the rating. | 
 **entityid** | **String**| Id of the entity to get the ratings. | 
 **mostrecentfirst** | **Boolean**| True to show most recent first, otherwise most helpful first. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_getcomments

> rating_getcomments(ratingid)

Gets all the comments for a rating

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
ratingid = 'ratingid_example' # String | The ID of the rating to get all comments.

begin
  #Gets all the comments for a rating
  api_instance.rating_getcomments(ratingid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_getcomments: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to get all comments. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_getpending

> rating_getpending(getgroup, opts)

Gets info of pre-saved and pre-approved ratings

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::RatingApi.new
getgroup = 'getgroup_example' # String | The ID of the group of pending ratings to get.
opts = {
  rateid: 'rateid_example', # String | Rate this before returning.
  rateval: 56 # Integer | The value used to rate the item specified in rateid.
}

begin
  #Gets info of pre-saved and pre-approved ratings
  api_instance.rating_getpending(getgroup, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_getpending: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**String**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **rateval** | **Integer**| The value used to rate the item specified in rateid. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_getpendingmoderation

> rating_getpendingmoderation

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new

begin
  #Shows a list of the ratings and comments that are pending for moderation
  api_instance.rating_getpendingmoderation
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_getpendingmoderation: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_moderate

> rating_moderate(type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
type = 'type_example' # String | Either 'rating' or 'comment' depending on what you want to moderate.
id = 'id_example' # String | Id of the rating or comment, as specified in type.
approve = true # Boolean | True to approve, false to reject.

begin
  #Allows the user to accept or reject a comment
  api_instance.rating_moderate(type, id, approve)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_moderate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**String**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **Boolean**| True to approve, false to reject. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_postcomment

> rating_postcomment(ratingid, comment, annonymous)

Posts a comments for in a rating

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
ratingid = 'ratingid_example' # String | The ID of the rating to post the comment.
comment = 'comment_example' # String | Text of the comment to post.
annonymous = true # Boolean | True to post the comment annonymously.

begin
  #Posts a comments for in a rating
  api_instance.rating_postcomment(ratingid, comment, annonymous)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_postcomment: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to post the comment. | 
 **comment** | **String**| Text of the comment to post. | 
 **annonymous** | **Boolean**| True to post the comment annonymously. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_rate

> rating_rate(type, entityid, annonymous, opts)

Rates one entity

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
type = 'type_example' # String | The entity type to rate.
entityid = 'entityid_example' # String | Id of the entity to rate.
annonymous = true # Boolean | Whether to post as annonymous.
opts = {
  value: 56, # Integer | Value from 0 to 100 with the rating.
  comment: 'comment_example', # String | Comment associated with this review. Comment can be updated later on another request too.
  updatecomment: true # Boolean | Whether to update the comments. Defaults to true.
}

begin
  #Rates one entity
  api_instance.rating_rate(type, entityid, annonymous, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_rate: #{e}"
end
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

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_ratepending

> rating_ratepending(group, annonymous, opts)

Rates a pre-saved and pre-approved entity

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::RatingApi.new
group = 'group_example' # String | The ID of the group of with pre-approved ratings.
annonymous = true # Boolean | Whether to post as annonymous.
opts = {
  rateid: 'rateid_example', # String | Rate this before returning.
  value: 56, # Integer | Value from 0 to 100 with the rating.
  comment: 'comment_example', # String | Comment associated with this review. Comment can be updated later on another request too.
  updatecomment: true # Boolean | Whether to update the comments. Defaults to true.
}

begin
  #Rates a pre-saved and pre-approved entity
  api_instance.rating_ratepending(group, annonymous, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_ratepending: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**String**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **value** | **Integer**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rating_vote

> rating_vote(ratingid, vote)

Votes up or down a rating

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RatingApi.new
ratingid = 'ratingid_example' # String | The ID of the rating to vote on.
vote = 56 # Integer | 1 to vote up, -1 to vote down.

begin
  #Votes up or down a rating
  api_instance.rating_vote(ratingid, vote)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RatingApi->rating_vote: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to vote on. | 
 **vote** | **Integer**| 1 to vote up, -1 to vote down. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

