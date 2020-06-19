# OpenAPI\Client\EasyloginApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**easyloginAddbgimage**](EasyloginApi.md#easyloginAddbgimage) | **GET** /easylogin/addbgimage | Adds background image for the login



## easyloginAddbgimage

> easyloginAddbgimage($upload, $filename)

Adds background image for the login

Allows the user to set the background image that all users will see when logging into an AccuClub account not using SSO.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EasyloginApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The original filename, needed to process the file.

try {
    $apiInstance->easyloginAddbgimage($upload, $filename);
} catch (Exception $e) {
    echo 'Exception when calling EasyloginApi->easyloginAddbgimage: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **string**| The original filename, needed to process the file. |

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

