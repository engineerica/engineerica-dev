# OpenAPI\Client\RatingApi

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

> ratingFlag($id, $comment)

Flags one rating for moderation

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The rating to flag.
$comment = 'comment_example'; // string | Comment why should this should be removed.

try {
    $apiInstance->ratingFlag($id, $comment);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingFlag: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The rating to flag. |
 **comment** | **string**| Comment why should this should be removed. | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingFlagcomment

> ratingFlagcomment($id, $comment)

Flags one comment for moderation

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The comment to flag.
$comment = 'comment_example'; // string | Comment why should this should be removed.

try {
    $apiInstance->ratingFlagcomment($id, $comment);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingFlagcomment: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The comment to flag. |
 **comment** | **string**| Comment why should this should be removed. | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingGet

> ratingGet($type, $entityids)

Get rating for one or more entities

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$type = 'type_example'; // string | The entity type to get the rating.
$entityids = 'entityids_example'; // string | List of ids to get the ratings.

try {
    $apiInstance->ratingGet($type, $entityids);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to get the rating. |
 **entityids** | **string**| List of ids to get the ratings. |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingGetall

> ratingGetall($type, $entityid, $mostrecentfirst)

Gets the full ratings and comments for a specific entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$type = 'type_example'; // string | The entity type to get the rating.
$entityid = 'entityid_example'; // string | Id of the entity to get the ratings.
$mostrecentfirst = True; // bool | True to show most recent first, otherwise most helpful first.

try {
    $apiInstance->ratingGetall($type, $entityid, $mostrecentfirst);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingGetall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to get the rating. |
 **entityid** | **string**| Id of the entity to get the ratings. |
 **mostrecentfirst** | **bool**| True to show most recent first, otherwise most helpful first. | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingGetcomments

> ratingGetcomments($ratingid)

Gets all the comments for a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ratingid = 'ratingid_example'; // string | The ID of the rating to get all comments.

try {
    $apiInstance->ratingGetcomments($ratingid);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingGetcomments: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to get all comments. |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingGetpending

> ratingGetpending($getgroup, $rateid, $rateval)

Gets info of pre-saved and pre-approved ratings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$getgroup = 'getgroup_example'; // string | The ID of the group of pending ratings to get.
$rateid = 'rateid_example'; // string | Rate this before returning.
$rateval = 56; // int | The value used to rate the item specified in rateid.

try {
    $apiInstance->ratingGetpending($getgroup, $rateid, $rateval);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingGetpending: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **getgroup** | [**string**](../Model/.md)| The ID of the group of pending ratings to get. |
 **rateid** | [**string**](../Model/.md)| Rate this before returning. | [optional]
 **rateval** | **int**| The value used to rate the item specified in rateid. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingGetpendingmoderation

> ratingGetpendingmoderation()

Shows a list of the ratings and comments that are pending for moderation

Allows the user to view the list of pending ratings and comments.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->ratingGetpendingmoderation();
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingGetpendingmoderation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingModerate

> ratingModerate($type, $id, $approve)

Allows the user to accept or reject a comment

Allows the user to approve or reject a comment or rating.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$type = 'type_example'; // string | Either 'rating' or 'comment' depending on what you want to moderate.
$id = 'id_example'; // string | Id of the rating or comment, as specified in type.
$approve = True; // bool | True to approve, false to reject.

try {
    $apiInstance->ratingModerate($type, $id, $approve);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingModerate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate. |
 **id** | [**string**](../Model/.md)| Id of the rating or comment, as specified in type. |
 **approve** | **bool**| True to approve, false to reject. |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingPostcomment

> ratingPostcomment($ratingid, $comment, $annonymous)

Posts a comments for in a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ratingid = 'ratingid_example'; // string | The ID of the rating to post the comment.
$comment = 'comment_example'; // string | Text of the comment to post.
$annonymous = True; // bool | True to post the comment annonymously.

try {
    $apiInstance->ratingPostcomment($ratingid, $comment, $annonymous);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingPostcomment: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to post the comment. |
 **comment** | **string**| Text of the comment to post. |
 **annonymous** | **bool**| True to post the comment annonymously. |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingRate

> ratingRate($type, $entityid, $annonymous, $value, $comment, $updatecomment)

Rates one entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$type = 'type_example'; // string | The entity type to rate.
$entityid = 'entityid_example'; // string | Id of the entity to rate.
$annonymous = True; // bool | Whether to post as annonymous.
$value = 56; // int | Value from 0 to 100 with the rating.
$comment = 'comment_example'; // string | Comment associated with this review. Comment can be updated later on another request too.
$updatecomment = True; // bool | Whether to update the comments. Defaults to true.

try {
    $apiInstance->ratingRate($type, $entityid, $annonymous, $value, $comment, $updatecomment);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingRate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The entity type to rate. |
 **entityid** | **string**| Id of the entity to rate. |
 **annonymous** | **bool**| Whether to post as annonymous. |
 **value** | **int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingRatepending

> ratingRatepending($group, $annonymous, $rateid, $value, $comment, $updatecomment)

Rates a pre-saved and pre-approved entity

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$group = 'group_example'; // string | The ID of the group of with pre-approved ratings.
$annonymous = True; // bool | Whether to post as annonymous.
$rateid = 'rateid_example'; // string | Rate this before returning.
$value = 56; // int | Value from 0 to 100 with the rating.
$comment = 'comment_example'; // string | Comment associated with this review. Comment can be updated later on another request too.
$updatecomment = True; // bool | Whether to update the comments. Defaults to true.

try {
    $apiInstance->ratingRatepending($group, $annonymous, $rateid, $value, $comment, $updatecomment);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingRatepending: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **group** | [**string**](../Model/.md)| The ID of the group of with pre-approved ratings. |
 **annonymous** | **bool**| Whether to post as annonymous. |
 **rateid** | [**string**](../Model/.md)| Rate this before returning. | [optional]
 **value** | **int**| Value from 0 to 100 with the rating. | [optional]
 **comment** | **string**| Comment associated with this review. Comment can be updated later on another request too. | [optional]
 **updatecomment** | **bool**| Whether to update the comments. Defaults to true. | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## ratingVote

> ratingVote($ratingid, $vote)

Votes up or down a rating

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\RatingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$ratingid = 'ratingid_example'; // string | The ID of the rating to vote on.
$vote = 56; // int | 1 to vote up, -1 to vote down.

try {
    $apiInstance->ratingVote($ratingid, $vote);
} catch (Exception $e) {
    echo 'Exception when calling RatingApi->ratingVote: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ratingid** | [**string**](../Model/.md)| The ID of the rating to vote on. |
 **vote** | **int**| 1 to vote up, -1 to vote down. |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)

