# WWW::OpenAPIClient::SocialApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::SocialApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**social_contacts**](SocialApi.md#social_contacts) | **GET** /social/contacts | Gets the list of contacts in the network


# **social_contacts**
> social_contacts(filter => $filter, showdefaultphoto => $showdefaultphoto)

Gets the list of contacts in the network

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::SocialApi;
my $api_instance = WWW::OpenAPIClient::SocialApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $filter = "filter_example"; # string | Text to filter results.
my $showdefaultphoto = null; # boolean | If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.

eval { 
    $api_instance->social_contacts(filter => $filter, showdefaultphoto => $showdefaultphoto);
};
if ($@) {
    warn "Exception when calling SocialApi->social_contacts: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Text to filter results. | [optional] 
 **showdefaultphoto** | **boolean**| If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

