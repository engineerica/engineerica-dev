# \RatingApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RatingFlag**](RatingApi.md#RatingFlag) | **Get** /rating/flag | Flags one rating for moderation
[**RatingFlagcomment**](RatingApi.md#RatingFlagcomment) | **Get** /rating/flagcomment | Flags one comment for moderation
[**RatingGet**](RatingApi.md#RatingGet) | **Get** /rating/get | Get rating for one or more entities
[**RatingGetall**](RatingApi.md#RatingGetall) | **Get** /rating/getall | Gets the full ratings and comments for a specific entity
[**RatingGetcomments**](RatingApi.md#RatingGetcomments) | **Get** /rating/getcomments | Gets all the comments for a rating
[**RatingGetpending**](RatingApi.md#RatingGetpending) | **Get** /rating/getpending | Gets info of pre-saved and pre-approved ratings
[**RatingGetpendingmoderation**](RatingApi.md#RatingGetpendingmoderation) | **Get** /rating/getpendingmoderation | Shows a list of the ratings and comments that are pending for moderation
[**RatingModerate**](RatingApi.md#RatingModerate) | **Get** /rating/moderate | Allows the user to accept or reject a comment
[**RatingPostcomment**](RatingApi.md#RatingPostcomment) | **Get** /rating/postcomment | Posts a comments for in a rating
[**RatingRate**](RatingApi.md#RatingRate) | **Get** /rating/rate | Rates one entity
[**RatingRatepending**](RatingApi.md#RatingRatepending) | **Get** /rating/ratepending | Rates a pre-saved and pre-approved entity
[**RatingVote**](RatingApi.md#RatingVote) | **Get** /rating/vote | Votes up or down a rating



## RatingFlag

> RatingFlag(ctx, id, optional)

Flags one rating for moderation

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The rating to flag. | 
 **optional** | ***RatingFlagOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingFlagOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **comment** | **optional.String**| Comment why should this should be removed. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingFlagcomment

> RatingFlagcomment(ctx, id, optional)

Flags one comment for moderation

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The comment to flag. | 
 **optional** | ***RatingFlagcommentOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingFlagcommentOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **comment** | **optional.String**| Comment why should this should be removed. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingGet

> RatingGet(ctx, type_, entityids)

Get rating for one or more entities

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**type_** | **string**| The entity type to get the rating. | 
**entityids** | **string**| List of ids to get the ratings. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingGetall

> RatingGetall(ctx, type_, entityid, optional)

Gets the full ratings and comments for a specific entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**type_** | **string**| The entity type to get the rating. | 
**entityid** | **string**| Id of the entity to get the ratings. | 
 **optional** | ***RatingGetallOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingGetallOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **mostrecentfirst** | **optional.Bool**| True to show most recent first, otherwise most helpful first. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingGetcomments

> RatingGetcomments(ctx, ratingid)

Gets all the comments for a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**ratingid** | [**string**](.md)| The ID of the rating to get all comments. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingGetpending

> RatingGetpending(ctx, getgroup, optional)

Gets info of pre-saved and pre-approved ratings

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**getgroup** | [**string**](.md)| The ID of the group of pending ratings to get. | 
 **optional** | ***RatingGetpendingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingGetpendingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **rateid** | [**optional.Interface of string**](.md)| Rate this before returning. | 
 **rateval** | **optional.Int32**| The value used to rate the item specified in rateid. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingGetpendingmoderation

> RatingGetpendingmoderation(ctx, )

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingModerate

> RatingModerate(ctx, type_, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**type_** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
**id** | [**string**](.md)| Id of the rating or comment, as specified in type. | 
**approve** | **bool**| True to approve, false to reject. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingPostcomment

> RatingPostcomment(ctx, ratingid, comment, annonymous)

Posts a comments for in a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**ratingid** | [**string**](.md)| The ID of the rating to post the comment. | 
**comment** | **string**| Text of the comment to post. | 
**annonymous** | **bool**| True to post the comment annonymously. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingRate

> RatingRate(ctx, type_, entityid, annonymous, optional)

Rates one entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**type_** | **string**| The entity type to rate. | 
**entityid** | **string**| Id of the entity to rate. | 
**annonymous** | **bool**| Whether to post as annonymous. | 
 **optional** | ***RatingRateOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingRateOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------



 **value** | **optional.Int32**| Value from 0 to 100 with the rating. | 
 **comment** | **optional.String**| Comment associated with this review. Comment can be updated later on another request too. | 
 **updatecomment** | **optional.Bool**| Whether to update the comments. Defaults to true. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingRatepending

> RatingRatepending(ctx, group, annonymous, optional)

Rates a pre-saved and pre-approved entity

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**group** | [**string**](.md)| The ID of the group of with pre-approved ratings. | 
**annonymous** | **bool**| Whether to post as annonymous. | 
 **optional** | ***RatingRatependingOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RatingRatependingOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------


 **rateid** | [**optional.Interface of string**](.md)| Rate this before returning. | 
 **value** | **optional.Int32**| Value from 0 to 100 with the rating. | 
 **comment** | **optional.String**| Comment associated with this review. Comment can be updated later on another request too. | 
 **updatecomment** | **optional.Bool**| Whether to update the comments. Defaults to true. | 

### Return type

 (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RatingVote

> RatingVote(ctx, ratingid, vote)

Votes up or down a rating

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**ratingid** | [**string**](.md)| The ID of the rating to vote on. | 
**vote** | **int32**| 1 to vote up, -1 to vote down. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

