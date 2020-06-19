# WWW::OpenAPIClient::CommunityApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::CommunityApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**community_invite**](CommunityApi.md#community_invite) | **GET** /community/invite | Sends an invitation to everyone to AccuCampus Communities
[**community_join**](CommunityApi.md#community_join) | **GET** /community/join | Sends an invitation for myself to AccuCampus Communities


# **community_invite**
> community_invite()

Sends an invitation to everyone to AccuCampus Communities

Allows the user to invite all other users to the AccuCampus Communities.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CommunityApi;
my $api_instance = WWW::OpenAPIClient::CommunityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->community_invite();
};
if ($@) {
    warn "Exception when calling CommunityApi->community_invite: $@\n";
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

# **community_join**
> community_join()

Sends an invitation for myself to AccuCampus Communities

Allows the user to access the AccuCampus Communities.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::CommunityApi;
my $api_instance = WWW::OpenAPIClient::CommunityApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->community_join();
};
if ($@) {
    warn "Exception when calling CommunityApi->community_join: $@\n";
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

