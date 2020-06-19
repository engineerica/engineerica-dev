# WWW::OpenAPIClient::CreditApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CreditApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**credit_delete**](CreditApi.md#credit_delete) | **DELETE** /credit/{id} | Delete a credit
[**credit_discountmethods**](CreditApi.md#credit_discountmethods) | **GET** /credit/discountmethods | Gets the valid discount methods.
[**credit_get**](CreditApi.md#credit_get) | **GET** /credit/{id} | View details of assigned credit
[**credit_getuserbalance**](CreditApi.md#credit_getuserbalance) | **GET** /credit/getuserbalance | Get the total amount of credits of the specified user
[**credit_list**](CreditApi.md#credit_list) | **GET** /credit/list | View a list of credits for a specific user
[**credit_listdetails**](CreditApi.md#credit_listdetails) | **GET** /credit/listdetails | Gets the credit usage details
[**credit_listmine**](CreditApi.md#credit_listmine) | **GET** /credit/listmine | View the list of credits of the current user
[**credit_save**](CreditApi.md#credit_save) | **POST** /credit/{id} | Create or edit credit for a user
[**credit_savedetails**](CreditApi.md#credit_savedetails) | **POST** /credit/savedetails | Create or edit credit details


# **credit_delete**
> credit_delete(id => $id, body => $body)

Delete a credit

Allows the user to delete credits.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->credit_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the credit to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **credit_discountmethods**
> credit_discountmethods()

Gets the valid discount methods.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(
);


eval { 
    $api_instance->credit_discountmethods();
};
if ($@) {
    warn "Exception when calling CreditApi->credit_discountmethods: $@\n";
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

# **credit_get**
> credit_get(id => $id)

View details of assigned credit

Allows the user to view an credit and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit to get.

eval { 
    $api_instance->credit_get(id => $id);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the credit to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **credit_getuserbalance**
> credit_getuserbalance(user => $user)

Get the total amount of credits of the specified user

Allows the user to view the total amount of credits of a specified user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $user = null; # string | The id of the user whose balance has to be returned.

eval { 
    $api_instance->credit_getuserbalance(user => $user);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_getuserbalance: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**string**](.md)| The id of the user whose balance has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **credit_list**
> credit_list(user => $user, from => $from, count => $count)

View a list of credits for a specific user

Allows the user to view the full list of credits for a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $user = null; # string | The id of the user.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->credit_list(user => $user, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | [**string**](.md)| The id of the user. | 
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

# **credit_listdetails**
> credit_listdetails(credit => $credit, from => $from, count => $count)

Gets the credit usage details

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $credit = null; # string | The id of the credit to look up for details.
my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->credit_listdetails(credit => $credit, from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_listdetails: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **credit** | [**string**](.md)| The id of the credit to look up for details. | 
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

# **credit_listmine**
> credit_listmine(from => $from, count => $count)

View the list of credits of the current user

Allows the current user to view his full list of credits.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->credit_listmine(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_listmine: $@\n";
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

# **credit_save**
> credit_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit credit for a user

Allows the user to create or edit credit for a user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the credit save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->credit_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_save: $@\n";
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

# **credit_savedetails**
> credit_savedetails(unknown_base_type => $unknown_base_type)

Create or edit credit details

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CreditApi;
my $api_instance = WWW::OpenAPIClient::CreditApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->credit_savedetails(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling CreditApi->credit_savedetails: $@\n";
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

