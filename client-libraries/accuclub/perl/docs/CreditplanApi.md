# WWW::OpenAPIClient::CreditplanApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CreditplanApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**creditplan_delete**](CreditplanApi.md#creditplan_delete) | **DELETE** /creditplan/{id} | Deletes a credit plan
[**creditplan_get**](CreditplanApi.md#creditplan_get) | **GET** /creditplan/{id} | Gets a credit plan
[**creditplan_list**](CreditplanApi.md#creditplan_list) | **GET** /creditplan/list | Gets the credit plans available
[**creditplan_save**](CreditplanApi.md#creditplan_save) | **POST** /creditplan/{id} | Saves a credit plan


# **creditplan_delete**
> creditplan_delete(id => $id, body => $body)

Deletes a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditplanApi;
my $api_instance = WWW::OpenAPIClient::CreditplanApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit plan to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->creditplan_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling CreditplanApi->creditplan_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the credit plan to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditplan_get**
> creditplan_get(id => $id)

Gets a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditplanApi;
my $api_instance = WWW::OpenAPIClient::CreditplanApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit plan to get.

eval { 
    $api_instance->creditplan_get(id => $id);
};
if ($@) {
    warn "Exception when calling CreditplanApi->creditplan_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the credit plan to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **creditplan_list**
> creditplan_list(from => $from, count => $count)

Gets the credit plans available

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditplanApi;
my $api_instance = WWW::OpenAPIClient::CreditplanApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->creditplan_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling CreditplanApi->creditplan_list: $@\n";
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

# **creditplan_save**
> creditplan_save(id => $id, unknown_base_type => $unknown_base_type)

Saves a credit plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditplanApi;
my $api_instance = WWW::OpenAPIClient::CreditplanApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->creditplan_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling CreditplanApi->creditplan_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the credit save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

