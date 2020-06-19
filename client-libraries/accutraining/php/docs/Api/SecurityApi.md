# OpenAPI\Client\SecurityApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**securityAssesspermission**](SecurityApi.md#securityAssesspermission) | **GET** /security/assesspermission | Returns the list of users for a specific permission
[**securityAssessrole**](SecurityApi.md#securityAssessrole) | **GET** /security/assessrole | Returns the list of permissions for a specific role
[**securityAssessscope**](SecurityApi.md#securityAssessscope) | **GET** /security/assessscope | Returns the list of users for a specific user
[**securityAssessuser**](SecurityApi.md#securityAssessuser) | **GET** /security/assessuser | Returns the list of permissions for a specific user



## securityAssesspermission

> securityAssesspermission($commandname)

Returns the list of users for a specific permission

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SecurityApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$commandname = 'commandname_example'; // string | Name of the action or command to get the roles.

try {
    $apiInstance->securityAssesspermission($commandname);
} catch (Exception $e) {
    echo 'Exception when calling SecurityApi->securityAssesspermission: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **commandname** | **string**| Name of the action or command to get the roles. |

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


## securityAssessrole

> securityAssessrole($roleid)

Returns the list of permissions for a specific role

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SecurityApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$roleid = 'roleid_example'; // string | Role ID to list the effective permissions.

try {
    $apiInstance->securityAssessrole($roleid);
} catch (Exception $e) {
    echo 'Exception when calling SecurityApi->securityAssessrole: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**string**](../Model/.md)| Role ID to list the effective permissions. |

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


## securityAssessscope

> securityAssessscope($locationid)

Returns the list of users for a specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SecurityApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$locationid = 'locationid_example'; // string | Location ID to list the users with that scope.

try {
    $apiInstance->securityAssessscope($locationid);
} catch (Exception $e) {
    echo 'Exception when calling SecurityApi->securityAssessscope: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **locationid** | [**string**](../Model/.md)| Location ID to list the users with that scope. | [optional]

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


## securityAssessuser

> securityAssessuser($userid)

Returns the list of permissions for a specific user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\SecurityApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | User ID to list the effective permissions.

try {
    $apiInstance->securityAssessuser($userid);
} catch (Exception $e) {
    echo 'Exception when calling SecurityApi->securityAssessuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| User ID to list the effective permissions. |

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

