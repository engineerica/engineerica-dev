# WWW::OpenAPIClient::SessionswipeApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SessionswipeApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sessionswipe_delete**](SessionswipeApi.md#sessionswipe_delete) | **DELETE** /sessionswipe/{id} | Delete a session swipe
[**sessionswipe_get**](SessionswipeApi.md#sessionswipe_get) | **GET** /sessionswipe/{id} | View details of a class attendance swipe
[**sessionswipe_listunresolved**](SessionswipeApi.md#sessionswipe_listunresolved) | **GET** /sessionswipe/listunresolved | View a list of unresolved swipes
[**sessionswipe_resolve**](SessionswipeApi.md#sessionswipe_resolve) | **GET** /sessionswipe/resolve | Resolve a swipe and create the corresponding attendance log
[**sessionswipe_save**](SessionswipeApi.md#sessionswipe_save) | **POST** /sessionswipe/save | Creates a new swipe, and if possible, creates the attendance log
[**sessionswipe_saveanonym**](SessionswipeApi.md#sessionswipe_saveanonym) | **POST** /sessionswipe/saveanonym | Creates a new swipe from a sign-in station, and if possible, creates the attendance log


# **sessionswipe_delete**
> sessionswipe_delete(id => $id, body => $body)

Delete a session swipe

Allows the user to delete an existing class attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the session swipe to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->sessionswipe_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the session swipe to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipe_get**
> sessionswipe_get(id => $id)

View details of a class attendance swipe

Allows the user to view an individual class attendance swipe.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the swipe to get.

eval { 
    $api_instance->sessionswipe_get(id => $id);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the swipe to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipe_listunresolved**
> sessionswipe_listunresolved(from => $from, count => $count)

View a list of unresolved swipes

Allows the user to view all unresolved swipes.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->sessionswipe_listunresolved(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_listunresolved: $@\n";
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

# **sessionswipe_resolve**
> sessionswipe_resolve(id => $id, session => $session, user => $user)

Resolve a swipe and create the corresponding attendance log

Allows the user to resolve an unresolved swipe, which would result in the creation of an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the swipe to resolve.
my $session = null; # string | The id of the session whose swipe has to be saved.
my $user = null; # string | The id of the user who signed-in.

eval { 
    $api_instance->sessionswipe_resolve(id => $id, session => $session, user => $user);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_resolve: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the swipe to resolve. | 
 **session** | [**string**](.md)| The id of the session whose swipe has to be saved. | [optional] 
 **user** | [**string**](.md)| The id of the user who signed-in. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **sessionswipe_save**
> sessionswipe_save(unknown_base_type => $unknown_base_type)

Creates a new swipe, and if possible, creates the attendance log

Allows the user to create a new swipe, which would usually result in an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionswipe_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_save: $@\n";
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

# **sessionswipe_saveanonym**
> sessionswipe_saveanonym(unknown_base_type => $unknown_base_type)

Creates a new swipe from a sign-in station, and if possible, creates the attendance log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SessionswipeApi;
my $api_instance = WWW::OpenAPIClient::SessionswipeApi->new(
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->sessionswipe_saveanonym(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling SessionswipeApi->sessionswipe_saveanonym: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

