# OpenAPI\Client\TemplateApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**templateAddimage**](TemplateApi.md#templateAddimage) | **GET** /template/addimage | Add an image to a template
[**templateDelete**](TemplateApi.md#templateDelete) | **DELETE** /template/{id} | Delete a template
[**templateEmail**](TemplateApi.md#templateEmail) | **GET** /template/email | Send generated templates by email
[**templateGenerate**](TemplateApi.md#templateGenerate) | **GET** /template/generate | Generate specified templates
[**templateGet**](TemplateApi.md#templateGet) | **GET** /template/{id} | View details of a template
[**templateGetgenerated**](TemplateApi.md#templateGetgenerated) | **GET** /template/getgenerated | View generated templates
[**templateList**](TemplateApi.md#templateList) | **GET** /template/list | View a list of defined templates
[**templateListsources**](TemplateApi.md#templateListsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**templateSave**](TemplateApi.md#templateSave) | **POST** /template/{id} | Create or edit a template
[**templateSavelayout**](TemplateApi.md#templateSavelayout) | **POST** /template/savelayout | Save the layout of a template



## templateAddimage

> templateAddimage($template, $upload, $filename)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$template = 'template_example'; // string | The id of the template where the image has to be added
$upload = 'upload_example'; // string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
$filename = 'filename_example'; // string | The local name of the uploaded file. For later reference.

try {
    $apiInstance->templateAddimage($template, $upload, $filename);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateAddimage: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**string**](../Model/.md)| The id of the template where the image has to be added |
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). |
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional]

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


## templateDelete

> templateDelete($id, $body)

Delete a template

Allows the user to delete an existing template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the template to delete.
$body = new \OpenAPI\Client\Model\AnyType(); // AnyType | 

try {
    $apiInstance->templateDelete($id, $body);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the template to delete. |
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


## templateEmail

> templateEmail($jobid, $emailsubject, $emailbody, $templatekind, $emailfrom, $emailreplyto)

Send generated templates by email

Allows the user to send generated templates via email through AccuCampus.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$jobid = 'jobid_example'; // string | The id of the job that is creating the templates.
$emailsubject = 'emailsubject_example'; // string | Args depending on the send-to flag.
$emailbody = 'emailbody_example'; // string | Args depending on the send-to flag.
$templatekind = 'templatekind_example'; // string | The kind of the template you're sending. It must be included in (badge, certificate).
$emailfrom = 'emailfrom_example'; // string | The name of the sender to be displayed in the receipients inbox
$emailreplyto = 'emailreplyto_example'; // string | The reply-to field for the emails.

try {
    $apiInstance->templateEmail($jobid, $emailsubject, $emailbody, $templatekind, $emailfrom, $emailreplyto);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateEmail: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| The id of the job that is creating the templates. |
 **emailsubject** | **string**| Args depending on the send-to flag. |
 **emailbody** | **string**| Args depending on the send-to flag. |
 **templatekind** | **string**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional]
 **emailfrom** | **string**| The name of the sender to be displayed in the receipients inbox | [optional]
 **emailreplyto** | **string**| The reply-to field for the emails. | [optional]

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


## templateGenerate

> templateGenerate($template, $source, $singlefile, $userid, $forsending, $role, $filters)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$template = 'template_example'; // string | The id of the template to generate.
$source = 'source_example'; // string | The source key of the selected template data source.
$singlefile = True; // bool | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
$userid = 'userid_example'; // string | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
$forsending = True; // bool | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
$role = 'role_example'; // string | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
$filters = 'filters_example'; // string | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...

try {
    $apiInstance->templateGenerate($template, $source, $singlefile, $userid, $forsending, $role, $filters);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateGenerate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**string**](../Model/.md)| The id of the template to generate. |
 **source** | [**string**](../Model/.md)| The source key of the selected template data source. |
 **singlefile** | **bool**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. |
 **userid** | **string**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional]
 **forsending** | **bool**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional]
 **role** | [**string**](../Model/.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional]
 **filters** | **string**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional]

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


## templateGet

> templateGet($id)

View details of a template

Allows the user to view a template and its details.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the template to get.

try {
    $apiInstance->templateGet($id);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the template to get. |

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


## templateGetgenerated

> templateGetgenerated($jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$jobid = 'jobid_example'; // string | The id of the job that is creating the templates.

try {
    $apiInstance->templateGetgenerated($jobid);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateGetgenerated: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| The id of the job that is creating the templates. |

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


## templateList

> templateList($from, $count, $kind, $designedonly)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$from = 56; // int | The first record to return.
$count = 56; // int | The max number of records to return.
$kind = 'kind_example'; // string | The kind of the templates to return. It must be included in (badge, certificate).
$designedonly = True; // bool | If true then it only returns the templates that were designed. Otherwise, it returns all.

try {
    $apiInstance->templateList($from, $count, $kind, $designedonly);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateList: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. |
 **count** | **int**| The max number of records to return. |
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). |
 **designedonly** | **bool**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional]

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


## templateListsources

> templateListsources($kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$kind = 'kind_example'; // string | The kind of the templates to return. It must be included in (badge, certificate).

try {
    $apiInstance->templateListsources($kind);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateListsources: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **string**| The kind of the templates to return. It must be included in (badge, certificate). |

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


## templateSave

> templateSave($id, $unknown_base_type)

Create or edit a template

Allows the user to create or edit a template.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = 'id_example'; // string | The id of the template to save (leave empty to create a new one).
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->templateSave($id, $unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateSave: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](../Model/.md)| The id of the template to save (leave empty to create a new one). |
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


## templateSavelayout

> templateSavelayout($unknown_base_type)

Save the layout of a template

Allows the user to edit a template's layout.

### Example

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');


// Configure Bearer (string) authorization: bearerAuth
$config = OpenAPI\Client\Configuration::getDefaultConfiguration()->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new OpenAPI\Client\Api\TemplateApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$unknown_base_type = new \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE(); // \OpenAPI\Client\Model\UNKNOWN_BASE_TYPE | 

try {
    $apiInstance->templateSavelayout($unknown_base_type);
} catch (Exception $e) {
    echo 'Exception when calling TemplateApi->templateSavelayout: ', $e->getMessage(), PHP_EOL;
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

