# OpenAPI\Client\LicenseApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**licenseAcceptagreement**](LicenseApi.md#licenseAcceptagreement) | **GET** /license/acceptagreement | Accept the license agreement
[**licenseGetagreementstatus**](LicenseApi.md#licenseGetagreementstatus) | **GET** /license/getagreementstatus | Check if license agreement has been accepted
[**licenseGetcurrent**](LicenseApi.md#licenseGetcurrent) | **GET** /license/getcurrent | Gets the current license information
[**licenseRenew**](LicenseApi.md#licenseRenew) | **GET** /license/renew | Contact Engineerica in order to renew the AccuCampus subscription



## licenseAcceptagreement

> licenseAcceptagreement()

Accept the license agreement

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\LicenseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->licenseAcceptagreement();
} catch (Exception $e) {
    echo 'Exception when calling LicenseApi->licenseAcceptagreement: ', $e->getMessage(), PHP_EOL;
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


## licenseGetagreementstatus

> licenseGetagreementstatus()

Check if license agreement has been accepted

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\LicenseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->licenseGetagreementstatus();
} catch (Exception $e) {
    echo 'Exception when calling LicenseApi->licenseGetagreementstatus: ', $e->getMessage(), PHP_EOL;
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


## licenseGetcurrent

> licenseGetcurrent()

Gets the current license information

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\LicenseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->licenseGetcurrent();
} catch (Exception $e) {
    echo 'Exception when calling LicenseApi->licenseGetcurrent: ', $e->getMessage(), PHP_EOL;
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


## licenseRenew

> licenseRenew($email, $phonenumber, $jobtitle, $institution, $comments)

Contact Engineerica in order to renew the AccuCampus subscription

Allows the user to select the option to contact Engineerica when the AccuCampus account is nearing its renewal date.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\LicenseApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$email = 'email_example'; // string | The e-mail of the user sending the request.
$phonenumber = 'phonenumber_example'; // string | The phone number of the user sending the request.
$jobtitle = 'jobtitle_example'; // string | The job title of the user sending the request.
$institution = 'institution_example'; // string | The institution of the user sending the request.
$comments = 'comments_example'; // string | Comments entered by the user sending the request.

try {
    $apiInstance->licenseRenew($email, $phonenumber, $jobtitle, $institution, $comments);
} catch (Exception $e) {
    echo 'Exception when calling LicenseApi->licenseRenew: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| The e-mail of the user sending the request. |
 **phonenumber** | **string**| The phone number of the user sending the request. |
 **jobtitle** | **string**| The job title of the user sending the request. | [optional]
 **institution** | **string**| The institution of the user sending the request. | [optional]
 **comments** | **string**| Comments entered by the user sending the request. | [optional]

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

