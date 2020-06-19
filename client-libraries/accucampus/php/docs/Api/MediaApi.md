# OpenAPI\Client\MediaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mediaCheckin**](MediaApi.md#mediaCheckin) | **GET** /media/checkin | Check in media item
[**mediaCheckout**](MediaApi.md#mediaCheckout) | **GET** /media/checkout | Check out media item
[**mediaCheckoutlist**](MediaApi.md#mediaCheckoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**mediaDelete**](MediaApi.md#mediaDelete) | **DELETE** /media/{id} | Delete a media item
[**mediaDeletecheckoutlog**](MediaApi.md#mediaDeletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**mediaGet**](MediaApi.md#mediaGet) | **GET** /media/{id} | Search and view details of a media item
[**mediaGetbycode**](MediaApi.md#mediaGetbycode) | **GET** /media/getbycode | Search media item by unique code
[**mediaGetcheckout**](MediaApi.md#mediaGetcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**mediaGetcheckoutlog**](MediaApi.md#mediaGetcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**mediaList**](MediaApi.md#mediaList) | **GET** /media/list | View a list of media items
[**mediaSave**](MediaApi.md#mediaSave) | **POST** /media/{id} | Create or edit a media item



## mediaCheckin

> mediaCheckin($media, $checkindate, $notes)

Check in media item

Allows the user to check in a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$media = 'media_example'; // string | The id of the media item to checkin.
$checkindate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The checkout date.
$notes = 'notes_example'; // string | The notes of the checkout.

try {
    $apiInstance->mediaCheckin($media, $checkindate, $notes);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaCheckin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**string**](../Model/.md)| The id of the media item to checkin. |
 **checkindate** | **\DateTime**| The checkout date. |
 **notes** | **string**| The notes of the checkout. | [optional]

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


## mediaCheckout

> mediaCheckout($media, $user, $checkoutdate, $duedate, $staff, $event, $notes)

Check out media item

Allows the user to check out a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$media = 'media_example'; // string | The id of the media item to checkout.
$user = 'user_example'; // string | The id of the user that is checking the item out.
$checkoutdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The checkout date.
$duedate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The date when the checkout is due.
$staff = 'staff_example'; // string | The id of the staff member related to the checkout.
$event = 'event_example'; // string | The id of the event related to the checkout.
$notes = 'notes_example'; // string | The notes of the checkout.

try {
    $apiInstance->mediaCheckout($media, $user, $checkoutdate, $duedate, $staff, $event, $notes);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaCheckout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**string**](../Model/.md)| The id of the media item to checkout. |
 **user** | [**string**](../Model/.md)| The id of the user that is checking the item out. |
 **checkoutdate** | **\DateTime**| The checkout date. |
 **duedate** | **\DateTime**| The date when the checkout is due. |
 **staff** | [**string**](../Model/.md)| The id of the staff member related to the checkout. | [optional]
 **event** | [**string**](../Model/.md)| The id of the event related to the checkout. | [optional]
 **notes** | **string**| The notes of the checkout. | [optional]

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


## mediaCheckoutlist

> mediaCheckoutlist($from, $count, $media, $user, $photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$media = 'media_example'; // string | Used to filter the checkouts of a specific media item.
$user = 'user_example'; // string | Used to filter the checkouts made by a specific user.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediaCheckoutlist($from, $count, $media, $user, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaCheckoutlist: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **media** | [**string**](../Model/.md)| Used to filter the checkouts of a specific media item. | [optional]
 **user** | [**string**](../Model/.md)| Used to filter the checkouts made by a specific user. | [optional]
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


## mediaDelete

> mediaDelete($id, $body)

Delete a media item

Allows the user to delete an existing media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the media item to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->mediaDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the media item to delete. |
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


## mediaDeletecheckoutlog

> mediaDeletecheckoutlog($unknown_base_type)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->mediaDeletecheckoutlog($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaDeletecheckoutlog: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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


## mediaGet

> mediaGet($id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the media item to get.

try {
    $apiInstance->mediaGet($id);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the media item to get. |

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


## mediaGetbycode

> mediaGetbycode($code, $location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$code = 'code_example'; // string | The code of the media item to get.
$location = 'location_example'; // string | The location where to look for the media item.

try {
    $apiInstance->mediaGetbycode($code, $location);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaGetbycode: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the media item to get. |
 **location** | [**string**](../Model/.md)| The location where to look for the media item. | [optional]

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


## mediaGetcheckout

> mediaGetcheckout($id, $photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the media item whose checkout information has to be retrieved.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediaGetcheckout($id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaGetcheckout: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the media item whose checkout information has to be retrieved. |
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


## mediaGetcheckoutlog

> mediaGetcheckoutlog($id, $photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the media item whose checkout information has to be retrieved.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->mediaGetcheckoutlog($id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaGetcheckoutlog: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the media item whose checkout information has to be retrieved. |
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


## mediaList

> mediaList($from, $count, $status, $user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$status = 56; // int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
$user = 'user_example'; // string | Used to filter the media items that are checked-out by a specific user.

try {
    $apiInstance->mediaList($from, $count, $status, $user);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **status** | **int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional]
 **user** | [**string**](../Model/.md)| Used to filter the media items that are checked-out by a specific user. | [optional]

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


## mediaSave

> mediaSave($id, $unknown_base_type)

Create or edit a media item

Allows the user to create or edit a media item.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\MediaApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the media item save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->mediaSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling MediaApi->mediaSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the media item save (leave empty to create a new one). |
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

