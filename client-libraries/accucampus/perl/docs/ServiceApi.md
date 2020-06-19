# WWW::OpenAPIClient::ServiceApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ServiceApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**service_delete**](ServiceApi.md#service_delete) | **DELETE** /service/{id} | Delete a service
[**service_get**](ServiceApi.md#service_get) | **GET** /service/{id} | Search and view details of a service
[**service_list**](ServiceApi.md#service_list) | **GET** /service/list | View a list of services
[**service_save**](ServiceApi.md#service_save) | **POST** /service/{id} | Create or edit a service


# **service_delete**
> service_delete(id => $id, body => $body)

Delete a service

Allows the user to delete a service from the existing list.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceApi;
my $api_instance = WWW::OpenAPIClient::ServiceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the service to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->service_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ServiceApi->service_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the service to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **service_get**
> service_get(id => $id)

Search and view details of a service

Allows the user to view an individual service and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceApi;
my $api_instance = WWW::OpenAPIClient::ServiceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the service to get.

eval { 
    $api_instance->service_get(id => $id);
};
if ($@) {
    warn "Exception when calling ServiceApi->service_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the service to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **service_list**
> service_list(from => $from, count => $count)

View a list of services

Allows the user to view the full list of existing services.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceApi;
my $api_instance = WWW::OpenAPIClient::ServiceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->service_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ServiceApi->service_list: $@\n";
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

# **service_save**
> service_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a service

Allows the user to create or edit a service.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ServiceApi;
my $api_instance = WWW::OpenAPIClient::ServiceApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the service save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->service_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ServiceApi->service_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the service save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

