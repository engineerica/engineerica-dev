# OpenAPI\Client\AdvroleApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advroleAddmissing**](AdvroleApi.md#advroleAddmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advroleCheckperm**](AdvroleApi.md#advroleCheckperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**advroleDelete**](AdvroleApi.md#advroleDelete) | **DELETE** /advrole/{id} | Delete a role
[**advroleDeletemapping**](AdvroleApi.md#advroleDeletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**advroleGet**](AdvroleApi.md#advroleGet) | **GET** /advrole/{id} | View details of a role
[**advroleList**](AdvroleApi.md#advroleList) | **GET** /advrole/list | Lists the roles for the current account
[**advroleListmaps**](AdvroleApi.md#advroleListmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**advroleListrolesmapped**](AdvroleApi.md#advroleListrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**advroleListtemplates**](AdvroleApi.md#advroleListtemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**advroleSave**](AdvroleApi.md#advroleSave) | **POST** /advrole/{id} | Create or edit a role
[**advroleSavemapping**](AdvroleApi.md#advroleSavemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**advroleUserupgrade**](AdvroleApi.md#advroleUserupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)



## advroleAddmissing

> advroleAddmissing($roles, $permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$roles = 'roles_example'; // string | CSV list of the role ids to check
$permissions = 'permissions_example'; // string | CSV list of the permissions to check

try {
    $apiInstance->advroleAddmissing($roles, $permissions);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleAddmissing: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check |
 **permissions** | **string**| CSV list of the permissions to check |

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


## advroleCheckperm

> advroleCheckperm($roles, $permissions)

Checks the permissions are assigned for the given roles

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$roles = 'roles_example'; // string | CSV list of the role ids to check
$permissions = 'permissions_example'; // string | CSV list of the permissions to check

try {
    $apiInstance->advroleCheckperm($roles, $permissions);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleCheckperm: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **string**| CSV list of the role ids to check |
 **permissions** | **string**| CSV list of the permissions to check |

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


## advroleDelete

> advroleDelete($id, $body)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the location to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->advroleDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the location to delete. |
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


## advroleDeletemapping

> advroleDeletemapping($unknown_base_type)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->advroleDeletemapping($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleDeletemapping: ', $e->getMessage(), PHP_EOL;
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


## advroleGet

> advroleGet($id)

View details of a role

Allows the user to view a role and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the location to get.

try {
    $apiInstance->advroleGet($id);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the location to get. |

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


## advroleList

> advroleList($includepolicies, $includeinternal, $name)

Lists the roles for the current account

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$includepolicies = True; // bool | True to include the policies, defaults to false.
$includeinternal = True; // bool | True to include the internal roles too.
$name = 'name_example'; // string | Filter by name of the role.

try {
    $apiInstance->advroleList($includepolicies, $includeinternal, $name);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **bool**| True to include the policies, defaults to false. | [optional]
 **includeinternal** | **bool**| True to include the internal roles too. | [optional]
 **name** | **string**| Filter by name of the role. | [optional]

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


## advroleListmaps

> advroleListmaps($roleid)

Lists the maps a roles is mapped to

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$roleid = 'roleid_example'; // string | The id of the role to list the maps.

try {
    $apiInstance->advroleListmaps($roleid);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleListmaps: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**string**](../Model/.md)| The id of the role to list the maps. |

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


## advroleListrolesmapped

> advroleListrolesmapped($map)

Lists the roles mappings

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$map = 'map_example'; // string | List only the roles in the specified map.

try {
    $apiInstance->advroleListrolesmapped($map);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleListrolesmapped: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map** | **string**| List only the roles in the specified map. | [optional]

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


## advroleListtemplates

> advroleListtemplates()

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);

try {
    $apiInstance->advroleListtemplates();
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleListtemplates: ', $e->getMessage(), PHP_EOL;
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


## advroleSave

> advroleSave($id, $unknown_base_type)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the role to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->advroleSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the role to save (leave empty to create a new one). |
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


## advroleSavemapping

> advroleSavemapping($unknown_base_type)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->advroleSavemapping($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleSavemapping: ', $e->getMessage(), PHP_EOL;
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


## advroleUserupgrade

> advroleUserupgrade($userid, $roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\AdvroleApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | Id of the user to upgrade
$roleid = 'roleid_example'; // string | Id of the role to add

try {
    $apiInstance->advroleUserupgrade($userid, $roleid);
} catch (Exception $e) {
    echo 'Exception when calling AdvroleApi->advroleUserupgrade: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| Id of the user to upgrade |
 **roleid** | [**string**](../Model/.md)| Id of the role to add |

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

