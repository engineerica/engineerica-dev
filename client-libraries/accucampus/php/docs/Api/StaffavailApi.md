# OpenAPI\Client\StaffavailApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**staffavailAddmetoallservices**](StaffavailApi.md#staffavailAddmetoallservices) | **GET** /staffavail/addmetoallservices | Associate current user to all services
[**staffavailAddmetoservice**](StaffavailApi.md#staffavailAddmetoservice) | **GET** /staffavail/addmetoservice | Associate current user to a service
[**staffavailAddusertoallservices**](StaffavailApi.md#staffavailAddusertoallservices) | **GET** /staffavail/addusertoallservices | Associate a staff member to all services
[**staffavailAddusertoservice**](StaffavailApi.md#staffavailAddusertoservice) | **GET** /staffavail/addusertoservice | Associate a staff member to a service
[**staffavailGetmyservices**](StaffavailApi.md#staffavailGetmyservices) | **GET** /staffavail/getmyservices | View the services the current user is available for
[**staffavailGetservices**](StaffavailApi.md#staffavailGetservices) | **GET** /staffavail/getservices | View a list of services that a staff member is available for
[**staffavailGetusersforservice**](StaffavailApi.md#staffavailGetusersforservice) | **GET** /staffavail/getusersforservice | View a list of staff members that are available for a specific service
[**staffavailListtypes**](StaffavailApi.md#staffavailListtypes) | **GET** /staffavail/listtypes | View all the availability types
[**staffavailRemovemefromallservices**](StaffavailApi.md#staffavailRemovemefromallservices) | **GET** /staffavail/removemefromallservices | Remove current user from all services
[**staffavailRemovemefromservice**](StaffavailApi.md#staffavailRemovemefromservice) | **GET** /staffavail/removemefromservice | Remove current user from a service
[**staffavailRemoveuserfromallservices**](StaffavailApi.md#staffavailRemoveuserfromallservices) | **GET** /staffavail/removeuserfromallservices | Removes a staff member from the registration to all services
[**staffavailRemoveuserfromservice**](StaffavailApi.md#staffavailRemoveuserfromservice) | **GET** /staffavail/removeuserfromservice | Remove a staff member from a service
[**staffavailSetavailability**](StaffavailApi.md#staffavailSetavailability) | **GET** /staffavail/setavailability | Make a staff member available for a specific availability type
[**staffavailSetmyavailability**](StaffavailApi.md#staffavailSetmyavailability) | **GET** /staffavail/setmyavailability | Change current user&#39;s availability type



## staffavailAddmetoallservices

> staffavailAddmetoallservices()

Associate current user to all services

Allows the user to associate themselves to all services, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->staffavailAddmetoallservices();
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailAddmetoallservices: ', $e->getMessage(), PHP_EOL;
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


## staffavailAddmetoservice

> staffavailAddmetoservice($serviceid)

Associate current user to a service

Allows the user to associate themselves to a service, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailAddmetoservice($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailAddmetoservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

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


## staffavailAddusertoallservices

> staffavailAddusertoallservices($userid)

Associate a staff member to all services

Allows the user to make a staff member available for all services.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.

try {
    $apiInstance->staffavailAddusertoallservices($userid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailAddusertoallservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |

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


## staffavailAddusertoservice

> staffavailAddusertoservice($userid, $serviceid)

Associate a staff member to a service

Allows the user to make a staff member available for a service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailAddusertoservice($userid, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailAddusertoservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

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


## staffavailGetmyservices

> staffavailGetmyservices()

View the services the current user is available for

Allows the user to view a list of services that they are associated with.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->staffavailGetmyservices();
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailGetmyservices: ', $e->getMessage(), PHP_EOL;
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


## staffavailGetservices

> staffavailGetservices($userid)

View a list of services that a staff member is available for

Allows the user to view the list of services that a staff member is available for.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The user id to list services.

try {
    $apiInstance->staffavailGetservices($userid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailGetservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The user id to list services. |

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


## staffavailGetusersforservice

> staffavailGetusersforservice($serviceid)

View a list of staff members that are available for a specific service

Allows the user to view all staff members who are available for a service.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The service id to list users.

try {
    $apiInstance->staffavailGetusersforservice($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailGetusersforservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The service id to list users. |

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


## staffavailListtypes

> staffavailListtypes()

View all the availability types

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->staffavailListtypes();
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailListtypes: ', $e->getMessage(), PHP_EOL;
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


## staffavailRemovemefromallservices

> staffavailRemovemefromallservices()

Remove current user from all services

Allows the user to disassociate themselves from all services, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->staffavailRemovemefromallservices();
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailRemovemefromallservices: ', $e->getMessage(), PHP_EOL;
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


## staffavailRemovemefromservice

> staffavailRemovemefromservice($serviceid)

Remove current user from a service

Allows the user to disassociate themselves from a service, provided they have a staff role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailRemovemefromservice($serviceid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailRemovemefromservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

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


## staffavailRemoveuserfromallservices

> staffavailRemoveuserfromallservices($userid)

Removes a staff member from the registration to all services

Allows the user to remove a staff member's availability to all services.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.

try {
    $apiInstance->staffavailRemoveuserfromallservices($userid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailRemoveuserfromallservices: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |

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


## staffavailRemoveuserfromservice

> staffavailRemoveuserfromservice($userid, $serviceid)

Remove a staff member from a service

Allows the user to remove a staff member's service availability.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$serviceid = 'serviceid_example'; // string | The id of the service.

try {
    $apiInstance->staffavailRemoveuserfromservice($userid, $serviceid);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailRemoveuserfromservice: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **serviceid** | [**string**](../Model/.md)| The id of the service. |

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


## staffavailSetavailability

> staffavailSetavailability($userid, $availablefor)

Make a staff member available for a specific availability type

Allows the user to set a staff member as available for walk ins, appointments, or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user whose specific availability has to be set.
$availablefor = 'availablefor_example'; // string | Specific availability to set.

try {
    $apiInstance->staffavailSetavailability($userid, $availablefor);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailSetavailability: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user whose specific availability has to be set. |
 **availablefor** | **string**| Specific availability to set. | [optional]

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


## staffavailSetmyavailability

> staffavailSetmyavailability($availablefor)

Change current user's availability type

Allows the user to make themselves available for walk ins, appointments, or both.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\StaffavailApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$availablefor = 'availablefor_example'; // string | Specific availability to set.

try {
    $apiInstance->staffavailSetmyavailability($availablefor);
} catch (Exception $e) {
    echo 'Exception when calling StaffavailApi->staffavailSetmyavailability: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **availablefor** | **string**| Specific availability to set. | [optional]

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

