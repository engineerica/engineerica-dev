# WWW::OpenAPIClient::DepartmentApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::DepartmentApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**department_delete**](DepartmentApi.md#department_delete) | **DELETE** /department/{id} | Delete a college department
[**department_get**](DepartmentApi.md#department_get) | **GET** /department/{id} | Search and view details of a college department
[**department_list**](DepartmentApi.md#department_list) | **GET** /department/list | View a list of college departments
[**department_save**](DepartmentApi.md#department_save) | **POST** /department/{id} | Create or edit a college department


# **department_delete**
> department_delete(id => $id, body => $body)

Delete a college department

Allows the user to delete an existing college department.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DepartmentApi;
my $api_instance = WWW::OpenAPIClient::DepartmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the department to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->department_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling DepartmentApi->department_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the department to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **department_get**
> department_get(id => $id)

Search and view details of a college department

Allows the user to view an individual college department and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DepartmentApi;
my $api_instance = WWW::OpenAPIClient::DepartmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the department to get.

eval { 
    $api_instance->department_get(id => $id);
};
if ($@) {
    warn "Exception when calling DepartmentApi->department_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the department to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **department_list**
> department_list(from => $from, count => $count)

View a list of college departments

Allows the user to view the full list of college departments.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DepartmentApi;
my $api_instance = WWW::OpenAPIClient::DepartmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->department_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling DepartmentApi->department_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **department_save**
> department_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a college department

Allows the user to create or edit a college department.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::DepartmentApi;
my $api_instance = WWW::OpenAPIClient::DepartmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the department save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->department_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling DepartmentApi->department_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the department save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

