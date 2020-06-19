# WWW::OpenAPIClient::UsertaskApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::UsertaskApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usertask_deleteplan**](UsertaskApi.md#usertask_deleteplan) | **DELETE** /usertask/deleteplan | Deletes a task plan
[**usertask_getmine**](UsertaskApi.md#usertask_getmine) | **GET** /usertask/getmine | Lists the task plans of the logged user
[**usertask_getplan**](UsertaskApi.md#usertask_getplan) | **GET** /usertask/getplan | Gets a task plan by Id
[**usertask_listdefs**](UsertaskApi.md#usertask_listdefs) | **GET** /usertask/listdefs | Lists task types or definitions
[**usertask_listplan**](UsertaskApi.md#usertask_listplan) | **GET** /usertask/listplan | Lists task plans
[**usertask_saveplan**](UsertaskApi.md#usertask_saveplan) | **POST** /usertask/saveplan | Saves a task plan


# **usertask_deleteplan**
> usertask_deleteplan(unknown_base_type => $unknown_base_type)

Deletes a task plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usertask_deleteplan(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_deleteplan: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertask_getmine**
> usertask_getmine()

Lists the task plans of the logged user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->usertask_getmine();
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_getmine: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertask_getplan**
> usertask_getplan(id => $id)

Gets a task plan by Id

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the task plan to get.

eval { 
    $api_instance->usertask_getplan(id => $id);
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_getplan: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the task plan to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertask_listdefs**
> usertask_listdefs()

Lists task types or definitions

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(
);


eval { 
    $api_instance->usertask_listdefs();
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_listdefs: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **usertask_listplan**
> usertask_listplan(from => $from, count => $count)

Lists task plans

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->usertask_listplan(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_listplan: $@\n";
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

# **usertask_saveplan**
> usertask_saveplan(unknown_base_type => $unknown_base_type)

Saves a task plan

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UsertaskApi;
my $api_instance = WWW::OpenAPIClient::UsertaskApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->usertask_saveplan(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UsertaskApi->usertask_saveplan: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

