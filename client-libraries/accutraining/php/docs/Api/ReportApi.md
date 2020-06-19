# OpenAPI\Client\ReportApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**reportList**](ReportApi.md#reportList) | **GET** /report/list | View a list of available reports
[**reportPermissionsbyuser**](ReportApi.md#reportPermissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**reportPrepare**](ReportApi.md#reportPrepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**reportQuery**](ReportApi.md#reportQuery) | **GET** /report/query | Query and load a specified report



## reportList

> reportList()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ReportApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->reportList();
} catch (Exception $e) {
    echo 'Exception when calling ReportApi->reportList: ', $e->getMessage(), PHP_EOL;
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


## reportPermissionsbyuser

> reportPermissionsbyuser($params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ReportApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

try {
    $apiInstance->reportPermissionsbyuser($params);
} catch (Exception $e) {
    echo 'Exception when calling ReportApi->reportPermissionsbyuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

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


## reportPrepare

> reportPrepare($reportname, $params, $repformat, $fillgroupid, $groupby, $refreshgroup, $filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ReportApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reportname = 'reportname_example'; // string | The name of the report to execute
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
$repformat = 'repformat_example'; // string | The format of the resulting report. Json, pdf, csv, ...
$fillgroupid = 'fillgroupid_example'; // string | If specified, the result is used to fill the group with the given ID
$groupby = 'groupby_example'; // string | How to group the records. In the format 'col1+col2|col3+col4
$refreshgroup = 'refreshgroup_example'; // string | The ID of the group to check (and refresh) before processing the report.
$filtertext = 'filtertext_example'; // string | The user friendly text of the applied filters.

try {
    $apiInstance->reportPrepare($reportname, $params, $repformat, $fillgroupid, $groupby, $refreshgroup, $filtertext);
} catch (Exception $e) {
    echo 'Exception when calling ReportApi->reportPrepare: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute |
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional]
 **fillgroupid** | [**string**](../Model/.md)| If specified, the result is used to fill the group with the given ID | [optional]
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional]
 **refreshgroup** | [**string**](../Model/.md)| The ID of the group to check (and refresh) before processing the report. | [optional]
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional]

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


## reportQuery

> reportQuery($reportname, $params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ReportApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$reportname = 'reportname_example'; // string | The name of the report to execute
$params = 'params_example'; // string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

try {
    $apiInstance->reportQuery($reportname, $params);
} catch (Exception $e) {
    echo 'Exception when calling ReportApi->reportQuery: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute |
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional]

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

