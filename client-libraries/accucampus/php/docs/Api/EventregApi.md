# OpenAPI\Client\EventregApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventregAddme**](EventregApi.md#eventregAddme) | **GET** /eventreg/addme | Register current user to a course
[**eventregAddmetoall**](EventregApi.md#eventregAddmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventregAddmetogroup**](EventregApi.md#eventregAddmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventregAdduser**](EventregApi.md#eventregAdduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventregAddusertoall**](EventregApi.md#eventregAddusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventregAddusertogroup**](EventregApi.md#eventregAddusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventregGetevents**](EventregApi.md#eventregGetevents) | **GET** /eventreg/getevents | View course registration by user
[**eventregGetgroups**](EventregApi.md#eventregGetgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventregGetmyevents**](EventregApi.md#eventregGetmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventregGetmygroups**](EventregApi.md#eventregGetmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventregGetusers**](EventregApi.md#eventregGetusers) | **GET** /eventreg/getusers | View course registration
[**eventregGetusersfromgroup**](EventregApi.md#eventregGetusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventregGetuserstoall**](EventregApi.md#eventregGetuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventregRemoveme**](EventregApi.md#eventregRemoveme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventregRemovemefromall**](EventregApi.md#eventregRemovemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventregRemovemefromgroup**](EventregApi.md#eventregRemovemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventregRemoveuser**](EventregApi.md#eventregRemoveuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventregRemoveuserfromall**](EventregApi.md#eventregRemoveuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventregRemoveuserfromgroup**](EventregApi.md#eventregRemoveuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group



## eventregAddme

> eventregAddme($eventid, $listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAddme($eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAddme: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregAddmetoall

> eventregAddmetoall($listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAddmetoall($listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAddmetoall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregAddmetogroup

> eventregAddmetogroup($codegroup, $listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codegroup = 'codegroup_example'; // string | The code used to group events.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAddmetogroup($codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAddmetogroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **string**| The code used to group events. |
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregAdduser

> eventregAdduser($userid, $eventid, $listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAdduser($userid, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAdduser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregAddusertoall

> eventregAddusertoall($userid, $listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAddusertoall($userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAddusertoall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregAddusertogroup

> eventregAddusertogroup($userid, $codegroup, $listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to add.
$codegroup = 'codegroup_example'; // string | The code used to group events.
$listname = 'listname_example'; // string | The name of the list where the user has to be registered.

try {
    $apiInstance->eventregAddusertogroup($userid, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregAddusertogroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to add. |
 **codegroup** | **string**| The code used to group events. |
 **listname** | **string**| The name of the list where the user has to be registered. |

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


## eventregGetevents

> eventregGetevents($userid, $listname, $termid, $namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The user id to list events.
$listname = 'listname_example'; // string | The name of the list where the user is registered.
$termid = 'termid_example'; // string | The term id to list events.
$namefilter = 'namefilter_example'; // string | The value used to filter the events by name.

try {
    $apiInstance->eventregGetevents($userid, $listname, $termid, $namefilter);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The user id to list events. |
 **listname** | **string**| The name of the list where the user is registered. |
 **termid** | [**string**](../Model/.md)| The term id to list events. | [optional]
 **namefilter** | **string**| The value used to filter the events by name. | [optional]

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


## eventregGetgroups

> eventregGetgroups($userid, $listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The user id to list events.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregGetgroups($userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetgroups: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The user id to list events. |
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregGetmyevents

> eventregGetmyevents($listname, $termid, $namefilter)

View the event registrations of the current user

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$listname = 'listname_example'; // string | The name of the list where the user is registered.
$termid = 'termid_example'; // string | The term id to list events.
$namefilter = 'namefilter_example'; // string | The value used to filter the events by name.

try {
    $apiInstance->eventregGetmyevents($listname, $termid, $namefilter);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetmyevents: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. |
 **termid** | [**string**](../Model/.md)| The term id to list events. | [optional]
 **namefilter** | **string**| The value used to filter the events by name. | [optional]

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


## eventregGetmygroups

> eventregGetmygroups($listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregGetmygroups($listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetmygroups: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregGetusers

> eventregGetusers($eventid, $listname, $photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The event id to list users.
$listname = 'listname_example'; // string | The name of the list to get.
$photosize = 56; // int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

try {
    $apiInstance->eventregGetusers($eventid, $listname, $photosize);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetusers: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The event id to list users. |
 **listname** | **string**| The name of the list to get. |
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional]

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


## eventregGetusersfromgroup

> eventregGetusersfromgroup($codegroup, $listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codegroup = 'codegroup_example'; // string | The code group to list users.
$listname = 'listname_example'; // string | The name of the list to get.

try {
    $apiInstance->eventregGetusersfromgroup($codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetusersfromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**string**](../Model/.md)| The code group to list users. |
 **listname** | **string**| The name of the list to get. |

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


## eventregGetuserstoall

> eventregGetuserstoall($listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$listname = 'listname_example'; // string | The name of the list to get.

try {
    $apiInstance->eventregGetuserstoall($listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregGetuserstoall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list to get. |

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


## eventregRemoveme

> eventregRemoveme($eventid, $listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemoveme($eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemoveme: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregRemovemefromall

> eventregRemovemefromall($listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemovemefromall($listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemovemefromall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregRemovemefromgroup

> eventregRemovemefromgroup($codegroup, $listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$codegroup = 'codegroup_example'; // string | The code group of the events/courses.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemovemefromgroup($codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemovemefromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**string**](../Model/.md)| The code group of the events/courses. |
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregRemoveuser

> eventregRemoveuser($userid, $eventid, $listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$eventid = 'eventid_example'; // string | The id of the event.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemoveuser($userid, $eventid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemoveuser: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **eventid** | [**string**](../Model/.md)| The id of the event. |
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregRemoveuserfromall

> eventregRemoveuserfromall($userid, $listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemoveuserfromall($userid, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemoveuserfromall: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **listname** | **string**| The name of the list where the user is registered. |

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


## eventregRemoveuserfromgroup

> eventregRemoveuserfromgroup($userid, $codegroup, $listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\EventregApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$userid = 'userid_example'; // string | The id of the user to remove.
$codegroup = 'codegroup_example'; // string | The code group of the events/courses.
$listname = 'listname_example'; // string | The name of the list where the user is registered.

try {
    $apiInstance->eventregRemoveuserfromgroup($userid, $codegroup, $listname);
} catch (Exception $e) {
    echo 'Exception when calling EventregApi->eventregRemoveuserfromgroup: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](../Model/.md)| The id of the user to remove. |
 **codegroup** | [**string**](../Model/.md)| The code group of the events/courses. |
 **listname** | **string**| The name of the list where the user is registered. |

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

