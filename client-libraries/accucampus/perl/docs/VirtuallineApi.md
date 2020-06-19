# WWW::OpenAPIClient::VirtuallineApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::VirtuallineApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**virtualline_addmyself**](VirtuallineApi.md#virtualline_addmyself) | **GET** /virtualline/addmyself | Add myself to a waiting line
[**virtualline_list**](VirtuallineApi.md#virtualline_list) | **GET** /virtualline/list | Lists waiting lines that have remote access enabled
[**virtualline_removemyself**](VirtuallineApi.md#virtualline_removemyself) | **GET** /virtualline/removemyself | Remove myself from a waiting line


# **virtualline_addmyself**
> virtualline_addmyself(waitinglineid => $waitinglineid)

Add myself to a waiting line

Allows the user to add themselves to a waiting line from the AccuCampus mobile app.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::VirtuallineApi;
my $api_instance = WWW::OpenAPIClient::VirtuallineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $waitinglineid = null; # string | ID of the waiting line to join.

eval { 
    $api_instance->virtualline_addmyself(waitinglineid => $waitinglineid);
};
if ($@) {
    warn "Exception when calling VirtuallineApi->virtualline_addmyself: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitinglineid** | [**string**](.md)| ID of the waiting line to join. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **virtualline_list**
> virtualline_list()

Lists waiting lines that have remote access enabled

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::VirtuallineApi;
my $api_instance = WWW::OpenAPIClient::VirtuallineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->virtualline_list();
};
if ($@) {
    warn "Exception when calling VirtuallineApi->virtualline_list: $@\n";
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

# **virtualline_removemyself**
> virtualline_removemyself()

Remove myself from a waiting line

Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::VirtuallineApi;
my $api_instance = WWW::OpenAPIClient::VirtuallineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->virtualline_removemyself();
};
if ($@) {
    warn "Exception when calling VirtuallineApi->virtualline_removemyself: $@\n";
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

