# OpenAPI\Client\BgjobApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjobGetstatus**](BgjobApi.md#bgjobGetstatus) | **GET** /bgjob/getstatus | Get background job status



## bgjobGetstatus

> bgjobGetstatus($jobid, $jobtype)

Get background job status

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\BgjobApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$jobid = 'jobid_example'; // string | The ID of the job to get the status. 10 most recent will be returned if not specified.
$jobtype = 'jobtype_example'; // string | The job type to filter by.

try {
    $apiInstance->bgjobGetstatus($jobid, $jobtype);
} catch (Exception $e) {
    echo 'Exception when calling BgjobApi->bgjobGetstatus: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**string**](../Model/.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **string**| The job type to filter by. | [optional]

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

