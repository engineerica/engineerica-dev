# WWW::OpenAPIClient::HolidayApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::HolidayApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**holiday_list**](HolidayApi.md#holiday_list) | **GET** /holiday/list | View a list of entered holidays
[**holiday_save**](HolidayApi.md#holiday_save) | **POST** /holiday/save | Create or edit a list of holidays
[**holiday_suggest**](HolidayApi.md#holiday_suggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term


# **holiday_list**
> holiday_list(term => $term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::HolidayApi;
my $api_instance = WWW::OpenAPIClient::HolidayApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $term = null; # string | The term to get holidays from.

eval { 
    $api_instance->holiday_list(term => $term);
};
if ($@) {
    warn "Exception when calling HolidayApi->holiday_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**string**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **holiday_save**
> holiday_save(unknown_base_type => $unknown_base_type)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::HolidayApi;
my $api_instance = WWW::OpenAPIClient::HolidayApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->holiday_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling HolidayApi->holiday_save: $@\n";
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

# **holiday_suggest**
> holiday_suggest(term => $term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::HolidayApi;
my $api_instance = WWW::OpenAPIClient::HolidayApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $term = null; # string | The term to get holidays from.

eval { 
    $api_instance->holiday_suggest(term => $term);
};
if ($@) {
    warn "Exception when calling HolidayApi->holiday_suggest: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**string**](.md)| The term to get holidays from. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

