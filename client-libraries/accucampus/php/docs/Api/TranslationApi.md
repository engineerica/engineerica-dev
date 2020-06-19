# OpenAPI\Client\TranslationApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translationGet**](TranslationApi.md#translationGet) | **GET** /translation/get | Gets the translations of the specified values
[**translationGetcachefile**](TranslationApi.md#translationGetcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**translationList**](TranslationApi.md#translationList) | **GET** /translation/list | Lists all the available translations in the system
[**translationSave**](TranslationApi.md#translationSave) | **POST** /translation/{id} | Edit a translation



## translationGet

> translationGet($universal)

Gets the translations of the specified values

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TranslationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$universal = 'universal_example'; // string | Pipe separated list of universal text to be translated.

try {
    $apiInstance->translationGet($universal);
} catch (Exception $e) {
    echo 'Exception when calling TranslationApi->translationGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **universal** | **string**| Pipe separated list of universal text to be translated. |

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


## translationGetcachefile

> translationGetcachefile($account)

Get the file containing the translations

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TranslationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$account = 'account_example'; // string | The id of the account whose translations file has to be retrieved.

try {
    $apiInstance->translationGetcachefile($account);
} catch (Exception $e) {
    echo 'Exception when calling TranslationApi->translationGetcachefile: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **string**| The id of the account whose translations file has to be retrieved. | [optional]

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


## translationList

> translationList($filter, $nondefaultonly, $appdefaultasuniversal)

Lists all the available translations in the system

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TranslationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$filter = 'filter_example'; // string | Text to search/filter translations.
$nondefaultonly = True; // bool | If true then it returns only the terms translated. Otherwise, it returns all.
$appdefaultasuniversal = True; // bool | If true then it uses the app default translation as the universal term.

try {
    $apiInstance->translationList($filter, $nondefaultonly, $appdefaultasuniversal);
} catch (Exception $e) {
    echo 'Exception when calling TranslationApi->translationList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to search/filter translations. | [optional]
 **nondefaultonly** | **bool**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional]
 **appdefaultasuniversal** | **bool**| If true then it uses the app default translation as the universal term. | [optional]

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


## translationSave

> translationSave($id, $unknown_base_type)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TranslationApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the translation as returned by translation.list.
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->translationSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling TranslationApi->translationSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the translation as returned by translation.list. |
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

