# OpenAPI\Client\UserApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**userChangepwd**](UserApi.md#userChangepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**userChangepwdbyreq**](UserApi.md#userChangepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**userDelete**](UserApi.md#userDelete) | **DELETE** /user/{id} | Delete a user
[**userFindsimilar**](UserApi.md#userFindsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**userGet**](UserApi.md#userGet) | **GET** /user/{id} | Search and view details of a user
[**userGetbycard**](UserApi.md#userGetbycard) | **GET** /user/getbycard | Search user by card number
[**userList**](UserApi.md#userList) | **GET** /user/list | View a list of users
[**userLoadphoto**](UserApi.md#userLoadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**userMovedata**](UserApi.md#userMovedata) | **GET** /user/movedata | Move data between users
[**userRequestpwdchange**](UserApi.md#userRequestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**userSave**](UserApi.md#userSave) | **POST** /user/{id} | Create or edit a user
[**userSavepwdchange**](UserApi.md#userSavepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords



## userChangepwd

> userChangepwd($oldpass, $newpass)

Change user's own password

Allows the user to change their own password.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$oldpass = 'oldpass_example'; // string | The old password of the authenticated user.
$newpass = 'newpass_example'; // string | The new password of the authenticated user.

try {
    $apiInstance->userChangepwd($oldpass, $newpass);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userChangepwd: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**string**](../Model/.md)| The old password of the authenticated user. |
 **newpass** | [**string**](../Model/.md)| The new password of the authenticated user. |

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


## userChangepwdbyreq

> userChangepwdbyreq($changereq, $newpass)

Changes the user password using a change password request id

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$changereq = 'changereq_example'; // string | The change password request ID sent by email to the user.
$newpass = 'newpass_example'; // string | The new password of the user.

try {
    $apiInstance->userChangepwdbyreq($changereq, $newpass);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userChangepwdbyreq: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **string**| The change password request ID sent by email to the user. |
 **newpass** | **string**| The new password of the user. |

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


## userDelete

> userDelete($id, $body)

Delete a user

Allows the user to delete a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the user to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->userDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the user to delete. |
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


## userFindsimilar

> userFindsimilar($currentid, $phonenumber, $cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$currentid = 'currentid_example'; // string | The id of the current user.
$phonenumber = 'phonenumber_example'; // string | A phone number to search for similar users.
$cardnumber = 'cardnumber_example'; // string | A card number to search for similar users.

try {
    $apiInstance->userFindsimilar($currentid, $phonenumber, $cardnumber);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userFindsimilar: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**string**](../Model/.md)| The id of the current user. | [optional]
 **phonenumber** | **string**| A phone number to search for similar users. | [optional]
 **cardnumber** | **string**| A card number to search for similar users. | [optional]

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


## userGet

> userGet($id, $photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the user to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->userGet($id, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the user to get. |
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


## userGetbycard

> userGetbycard($card, $photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$card = 'card_example'; // string | The card number of the user to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->userGetbycard($card, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userGetbycard: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **string**| The card number of the user to get. |
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


## userList

> userList($from, $count, $roleid, $onlywithoutcard, $photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$roleid = 'roleid_example'; // string | The id of the role to filter users by, or empty to return all users.
$onlywithoutcard = 'onlywithoutcard_example'; // string | If is 1 then only the users without a card are returned, otherwise all users are returned.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->userList($from, $count, $roleid, $onlywithoutcard, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **roleid** | [**string**](../Model/.md)| The id of the role to filter users by, or empty to return all users. | [optional]
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional]
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


## userLoadphoto

> userLoadphoto($upload, $filename, $userid, $automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The local name of the uploaded file. For later reference.
$userid = 'userid_example'; // string | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
$automatch = True; // bool | Set this to true to find the specific user based on the file name.

try {
    $apiInstance->userLoadphoto($upload, $filename, $userid, $automatch);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userLoadphoto: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional]
 **userid** | [**string**](../Model/.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional]
 **automatch** | **bool**| Set this to true to find the specific user based on the file name. | [optional]

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


## userMovedata

> userMovedata($source, $destination)

Move data between users

Allows administrators to move data between users.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$source = 'source_example'; // string | The id of the user that is the source of the data.
$destination = 'destination_example'; // string | The id of the user that is the destination of the data.

try {
    $apiInstance->userMovedata($source, $destination);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userMovedata: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**string**](../Model/.md)| The id of the user that is the source of the data. |
 **destination** | [**string**](../Model/.md)| The id of the user that is the destination of the data. |

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


## userRequestpwdchange

> userRequestpwdchange($domain, $email)

Requests a password change

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$domain = 'domain_example'; // string | The domain of the account where the user exists.
$email = 'email_example'; // string | The email of the user.

try {
    $apiInstance->userRequestpwdchange($domain, $email);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userRequestpwdchange: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The domain of the account where the user exists. |
 **email** | **string**| The email of the user. |

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


## userSave

> userSave($id, $unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the user to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->userSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the user to save (leave empty to create a new one). |
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


## userSavepwdchange

> userSavepwdchange($unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\UserApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->userSavepwdchange($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling UserApi->userSavepwdchange: ', $e->getMessage(), PHP_EOL;
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

