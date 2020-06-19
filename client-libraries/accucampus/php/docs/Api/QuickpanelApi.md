# OpenAPI\Client\QuickpanelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**quickpanelDeletewidget**](QuickpanelApi.md#quickpanelDeletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
[**quickpanelFetchwidget**](QuickpanelApi.md#quickpanelFetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
[**quickpanelGetwidget**](QuickpanelApi.md#quickpanelGetwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
[**quickpanelInit**](QuickpanelApi.md#quickpanelInit) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
[**quickpanelListwidgets**](QuickpanelApi.md#quickpanelListwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
[**quickpanelListwidgettypes**](QuickpanelApi.md#quickpanelListwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
[**quickpanelReorderwidgets**](QuickpanelApi.md#quickpanelReorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
[**quickpanelSavewidget**](QuickpanelApi.md#quickpanelSavewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel



## quickpanelDeletewidget

> quickpanelDeletewidget($unknown_base_type)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->quickpanelDeletewidget($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelDeletewidget: ', $e->getMessage(), PHP_EOL;
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


## quickpanelFetchwidget

> quickpanelFetchwidget($widgetid)

Fetches the information for a specific widget.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$widgetid = 'widgetid_example'; // string | The ID of the data to fetch it's data.

try {
    $apiInstance->quickpanelFetchwidget($widgetid);
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelFetchwidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **widgetid** | [**string**](../Model/.md)| The ID of the data to fetch it&#39;s data. |

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


## quickpanelGetwidget

> quickpanelGetwidget($id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the widget to get.

try {
    $apiInstance->quickpanelGetwidget($id);
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelGetwidget: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the widget to get. |

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


## quickpanelInit

> quickpanelInit()

Returns the initial information required to show the quick panels

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->quickpanelInit();
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelInit: ', $e->getMessage(), PHP_EOL;
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


## quickpanelListwidgets

> quickpanelListwidgets()

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->quickpanelListwidgets();
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelListwidgets: ', $e->getMessage(), PHP_EOL;
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


## quickpanelListwidgettypes

> quickpanelListwidgettypes()

Lists all the widget types available in the system

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->quickpanelListwidgettypes();
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelListwidgettypes: ', $e->getMessage(), PHP_EOL;
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


## quickpanelReorderwidgets

> quickpanelReorderwidgets($sectionname, $orderids)

Reorders the widgets and moves them to a specific column

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$sectionname = 'sectionname_example'; // string | The section name where to sort the widgets.
$orderids = 'orderids_example'; // string | CSV list of the widgets to reorder.

try {
    $apiInstance->quickpanelReorderwidgets($sectionname, $orderids);
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelReorderwidgets: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionname** | **string**| The section name where to sort the widgets. |
 **orderids** | **string**| CSV list of the widgets to reorder. |

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


## quickpanelSavewidget

> quickpanelSavewidget($unknown_base_type)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\QuickpanelApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->quickpanelSavewidget($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling QuickpanelApi->quickpanelSavewidget: ', $e->getMessage(), PHP_EOL;
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

