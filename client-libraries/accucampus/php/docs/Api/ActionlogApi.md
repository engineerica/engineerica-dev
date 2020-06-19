# OpenAPI\Client\ActionlogApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlogList**](ActionlogApi.md#actionlogList) | **GET** /actionlog/list | View a list of users action logs



## actionlogList

> actionlogList($from, $count, $user, $startdate, $enddate, $resource, $actionfilter, $argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\ActionlogApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$user = 'user_example'; // string | The id of the user whose action logs have to be returned.
$startdate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The start date of the period to filter the logs.
$enddate = new \DateTime("2013-10-20T19:20:30+01:00"); // \DateTime | The end date of the period to filter the logs.
$resource = 'resource_example'; // string | The resource to filter the action logs.
$actionfilter = 'actionfilter_example'; // string | The action to filter the action logs.
$argument = 'argument_example'; // string | The id of the entity that was the argument of the executed action.

try {
    $apiInstance->actionlogList($from, $count, $user, $startdate, $enddate, $resource, $actionfilter, $argument);
} catch (Exception $e) {
    echo 'Exception when calling ActionlogApi->actionlogList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **user** | [**string**](../Model/.md)| The id of the user whose action logs have to be returned. | [optional]
 **startdate** | **\DateTime**| The start date of the period to filter the logs. | [optional]
 **enddate** | **\DateTime**| The end date of the period to filter the logs. | [optional]
 **resource** | **string**| The resource to filter the action logs. | [optional]
 **actionfilter** | **string**| The action to filter the action logs. | [optional]
 **argument** | **string**| The id of the entity that was the argument of the executed action. | [optional]

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

