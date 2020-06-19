# WWW::OpenAPIClient::ClientApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ClientApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**client_get**](ClientApi.md#client_get) | **GET** /client/get | Get client
[**client_list**](ClientApi.md#client_list) | **GET** /client/list | Gets the clients of the specified conference
[**client_save**](ClientApi.md#client_save) | **POST** /client/save | Saves a client
[**client_sendmessage**](ClientApi.md#client_sendmessage) | **GET** /client/sendmessage | Send a message to a client


# **client_get**
> client_get(client => $client, clientname => $clientname)

Get client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ClientApi;
my $api_instance = WWW::OpenAPIClient::ClientApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $client = "client_example"; # string | The unique id of the client.
my $clientname = "clientname_example"; # string | The custom name of the client.

eval { 
    $api_instance->client_get(client => $client, clientname => $clientname);
};
if ($@) {
    warn "Exception when calling ClientApi->client_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **client** | **string**| The unique id of the client. | 
 **clientname** | **string**| The custom name of the client. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **client_list**
> client_list(from => $from, count => $count)

Gets the clients of the specified conference

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ClientApi;
my $api_instance = WWW::OpenAPIClient::ClientApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->client_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ClientApi->client_list: $@\n";
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

# **client_save**
> client_save(unknown_base_type => $unknown_base_type)

Saves a client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ClientApi;
my $api_instance = WWW::OpenAPIClient::ClientApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->client_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ClientApi->client_save: $@\n";
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

# **client_sendmessage**
> client_sendmessage(uniqueclientid => $uniqueclientid, message => $message)

Send a message to a client

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ClientApi;
my $api_instance = WWW::OpenAPIClient::ClientApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $uniqueclientid = null; # string | The unique id of the client.
my $message = "message_example"; # string | The body of the message to send.

eval { 
    $api_instance->client_sendmessage(uniqueclientid => $uniqueclientid, message => $message);
};
if ($@) {
    warn "Exception when calling ClientApi->client_sendmessage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uniqueclientid** | [**string**](.md)| The unique id of the client. | 
 **message** | **string**| The body of the message to send. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

