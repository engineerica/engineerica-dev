# OpenAPI\Client\WaitinglineApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitinglineAdduser**](WaitinglineApi.md#waitinglineAdduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitinglineDelete**](WaitinglineApi.md#waitinglineDelete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitinglineGet**](WaitinglineApi.md#waitinglineGet) | **GET** /waitingline/{id} | View details of a waiting line
[**waitinglineIsuserin**](WaitinglineApi.md#waitinglineIsuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitinglineList**](WaitinglineApi.md#waitinglineList) | **GET** /waitingline/list | View a list of waiting lines
[**waitinglineRemoveuser**](WaitinglineApi.md#waitinglineRemoveuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitinglineSave**](WaitinglineApi.md#waitinglineSave) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitinglineSigninuser**](WaitinglineApi.md#waitinglineSigninuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line



## waitinglineAdduser

> waitinglineAdduser($station, $user, $locationid, $time, $signinrole, $roleid, $services, $eventid, $staff, $photosize)

Put user in a waiting line

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station.
$user = 'user_example'; // string | The user's card number.
$locationid = 'locationid_example'; // string | The location's id where the swipe must be saved.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$signinrole = 'signinrole_example'; // string | Specifies if the sign-in is for an attendee or a staff member
$roleid = 'roleid_example'; // string | Specifies the role the user has selected in order to sign-in
$services = 'services_example'; // string | The services ids the user has selected.
$eventid = 'eventid_example'; // string | The id of the event the user selected.
$staff = 'staff_example'; // string | The id of the staff member the user selected.
$photosize = 56; // int | The swiping user's photo size.

try {
    $apiInstance->waitinglineAdduser($station, $user, $locationid, $time, $signinrole, $roleid, $services, $eventid, $staff, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineAdduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station. |
 **user** | **string**| The user&#39;s card number. |
 **locationid** | [**string**](../Model/.md)| The location&#39;s id where the swipe must be saved. | [optional]
 **time** | **\DateTime**| The date and time of the swipe. | [optional]
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional]
 **roleid** | [**string**](../Model/.md)| Specifies the role the user has selected in order to sign-in | [optional]
 **services** | **string**| The services ids the user has selected. | [optional]
 **eventid** | [**string**](../Model/.md)| The id of the event the user selected. | [optional]
 **staff** | [**string**](../Model/.md)| The id of the staff member the user selected. | [optional]
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional]

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


## waitinglineDelete

> waitinglineDelete($id, $body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the line to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->waitinglineDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the line to delete. |
 **body** | **AnyType**|  | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineGet

> waitinglineGet($id, $photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the waiting line to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->waitinglineGet($id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the waiting line to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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


## waitinglineIsuserin

> waitinglineIsuserin($station, $time, $user, $location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$station = 'station_example'; // string | The id of the sign-in station.
$time = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date and time of the swipe.
$user = 'user_example'; // string | The card number of the user.
$location = 'location_example'; // string | The id of the location the user picked.

try {
    $apiInstance->waitinglineIsuserin($station, $time, $user, $location);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineIsuserin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](../Model/.md)| The id of the sign-in station. |
 **time** | **\DateTime**| The date and time of the swipe. |
 **user** | **string**| The card number of the user. |
 **location** | [**string**](../Model/.md)| The id of the location the user picked. | [optional]

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


## waitinglineList

> waitinglineList($from, $count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.

try {
    $apiInstance->waitinglineList($from, $count);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |

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


## waitinglineRemoveuser

> waitinglineRemoveuser($waitingline, $itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$waitingline = 'waitingline_example'; // string | The id of the waiting line whose item has to be removed.
$itemid = 'itemid_example'; // string | The ID of the item that has to be removed.

try {
    $apiInstance->waitinglineRemoveuser($waitingline, $itemid);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineRemoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**string**](../Model/.md)| The id of the waiting line whose item has to be removed. |
 **itemid** | [**string**](../Model/.md)| The ID of the item that has to be removed. |

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


## waitinglineSave

> waitinglineSave($id, $unknown_base_type)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the waiting line save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->waitinglineSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the waiting line save (leave empty to create a new one). |
 **unknown_base_type** | [**\OpenAPI\Client\Model\UNKNOWN_BASE_TYPE**](../Model/UNKNOWN_BASE_TYPE.md)|  | [optional]

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../../README.md#documentation-for-models)
[[Back to README]](../../README.md)


## waitinglineSigninuser

> waitinglineSigninuser($waitingline, $itemid, $staff, $photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\WaitinglineApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$waitingline = 'waitingline_example'; // string | The id of the waiting line whose item needs to be signed-in.
$itemid = 'itemid_example'; // string | The ID of the item that has to be signed-in.
$staff = 'staff_example'; // string | The id of the staff member selected to sign-in.
$photosize = 56; // int | The swiping user's photo size.

try {
    $apiInstance->waitinglineSigninuser($waitingline, $itemid, $staff, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling WaitinglineApi->waitinglineSigninuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**string**](../Model/.md)| The id of the waiting line whose item needs to be signed-in. |
 **itemid** | [**string**](../Model/.md)| The ID of the item that has to be signed-in. |
 **staff** | [**string**](../Model/.md)| The id of the staff member selected to sign-in. |
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional]

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

