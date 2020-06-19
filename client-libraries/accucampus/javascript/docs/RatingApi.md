# AccuCampusOpenApi3.RatingApi

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



## ratingFlag

> ratingFlag(id, opts)

Flags one rating for moderation

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let id = null; // String | The rating to flag.
let opts = {
  'comment': "comment_example" // String | Comment why should this should be removed.
};
apiInstance.ratingFlag(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The rating to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingFlagcomment

> ratingFlagcomment(id, opts)

Flags one comment for moderation

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let id = null; // String | The comment to flag.
let opts = {
  'comment': "comment_example" // String | Comment why should this should be removed.
};
apiInstance.ratingFlagcomment(id, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The comment to flag. | 
 **comment** | **String**| Comment why should this should be removed. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingGet

> ratingGet(type, entityids)

Get rating for one or more entities

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let type = "type_example"; // String | The entity type to get the rating.
let entityids = "entityids_example"; // String | List of ids to get the ratings.
apiInstance.ratingGet(type, entityids, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
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


## ratingGetall

> ratingGetall(type, entityid, opts)

Gets the full ratings and comments for a specific entity

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let type = "type_example"; // String | The entity type to get the rating.
let entityid = "entityid_example"; // String | Id of the entity to get the ratings.
let opts = {
  'mostrecentfirst': true // Boolean | True to show most recent first, otherwise most helpful first.
};
apiInstance.ratingGetall(type, entityid, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
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


## ratingGetcomments

> ratingGetcomments(ratingid)

Gets all the comments for a rating

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let ratingid = null; // String | The ID of the rating to get all comments.
apiInstance.ratingGetcomments(ratingid, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to get all comments. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingGetpending

> ratingGetpending(getgroup, opts)

Gets info of pre-saved and pre-approved ratings

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let getgroup = null; // String | The ID of the group of pending ratings to get.
let opts = {
  'rateid': null, // String | Rate this before returning.
  'rateval': 56 // Number | The value used to rate the item specified in rateid.
};
apiInstance.ratingGetpending(getgroup, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**String**](.md)| The ID of the group of pending ratings to get. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **rateval** | **Number**| The value used to rate the item specified in rateid. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingGetpendingmoderation

> ratingGetpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
apiInstance.ratingGetpendingmoderation((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
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


## ratingModerate

> ratingModerate(type, id, approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let type = "type_example"; // String | Either 'rating' or 'comment' depending on what you want to moderate.
let id = null; // String | Id of the rating or comment, as specified in type.
let approve = true; // Boolean | True to approve, false to reject.
apiInstance.ratingModerate(type, id, approve, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. | 
 **id** | [**String**](.md)| Id of the rating or comment, as specified in type. | 
 **approve** | **Boolean**| True to approve, false to reject. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingPostcomment

> ratingPostcomment(ratingid, comment, annonymous)

Posts a comments for in a rating

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let ratingid = null; // String | The ID of the rating to post the comment.
let comment = "comment_example"; // String | Text of the comment to post.
let annonymous = true; // Boolean | True to post the comment annonymously.
apiInstance.ratingPostcomment(ratingid, comment, annonymous, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to post the comment. | 
 **comment** | **String**| Text of the comment to post. | 
 **annonymous** | **Boolean**| True to post the comment annonymously. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingRate

> ratingRate(type, entityid, annonymous, opts)

Rates one entity

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let type = "type_example"; // String | The entity type to rate.
let entityid = "entityid_example"; // String | Id of the entity to rate.
let annonymous = true; // Boolean | Whether to post as annonymous.
let opts = {
  'value': 56, // Number | Value from 0 to 100 with the rating.
  'comment': "comment_example", // String | Comment associated with this review. Comment can be updated later on another request too.
  'updatecomment': true // Boolean | Whether to update the comments. Defaults to true.
};
apiInstance.ratingRate(type, entityid, annonymous, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **String**| The entity type to rate. | 
 **entityid** | **String**| Id of the entity to rate. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **value** | **Number**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingRatepending

> ratingRatepending(group, annonymous, opts)

Rates a pre-saved and pre-approved entity

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let group = null; // String | The ID of the group of with pre-approved ratings.
let annonymous = true; // Boolean | Whether to post as annonymous.
let opts = {
  'rateid': null, // String | Rate this before returning.
  'value': 56, // Number | Value from 0 to 100 with the rating.
  'comment': "comment_example", // String | Comment associated with this review. Comment can be updated later on another request too.
  'updatecomment': true // Boolean | Whether to update the comments. Defaults to true.
};
apiInstance.ratingRatepending(group, annonymous, opts, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**String**](.md)| The ID of the group of with pre-approved ratings. | 
 **annonymous** | **Boolean**| Whether to post as annonymous. | 
 **rateid** | [**String**](.md)| Rate this before returning. | [optional] 
 **value** | **Number**| Value from 0 to 100 with the rating. | [optional] 
 **comment** | **String**| Comment associated with this review. Comment can be updated later on another request too. | [optional] 
 **updatecomment** | **Boolean**| Whether to update the comments. Defaults to true. | [optional] 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## ratingVote

> ratingVote(ratingid, vote)

Votes up or down a rating

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';
let defaultClient = AccuCampusOpenApi3.ApiClient.instance;
// Configure Bearer (string) access token for authorization: bearerAuth
let bearerAuth = defaultClient.authentications['bearerAuth'];
bearerAuth.accessToken = "YOUR ACCESS TOKEN"

let apiInstance = new AccuCampusOpenApi3.RatingApi();
let ratingid = null; // String | The ID of the rating to vote on.
let vote = 56; // Number | 1 to vote up, -1 to vote down.
apiInstance.ratingVote(ratingid, vote, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**String**](.md)| The ID of the rating to vote on. | 
 **vote** | **Number**| 1 to vote up, -1 to vote down. | 

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

