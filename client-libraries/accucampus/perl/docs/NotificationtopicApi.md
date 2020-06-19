# WWW::OpenAPIClient::NotificationtopicApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::NotificationtopicApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**notificationtopic_delete**](NotificationtopicApi.md#notificationtopic_delete) | **DELETE** /notificationtopic/{id} | Delete a notification topic
[**notificationtopic_get**](NotificationtopicApi.md#notificationtopic_get) | **GET** /notificationtopic/{id} | Search and view details of a notification topic
[**notificationtopic_list**](NotificationtopicApi.md#notificationtopic_list) | **GET** /notificationtopic/list | List all the notification topics
[**notificationtopic_listsubscribe**](NotificationtopicApi.md#notificationtopic_listsubscribe) | **GET** /notificationtopic/listsubscribe | List all the notification topics available to subscribe
[**notificationtopic_save**](NotificationtopicApi.md#notificationtopic_save) | **POST** /notificationtopic/{id} | Create or edit a notification topic


# **notificationtopic_delete**
> notificationtopic_delete(id => $id, body => $body)

Delete a notification topic

Allows the user to delete an existing notification topic.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationtopicApi;
my $api_instance = WWW::OpenAPIClient::NotificationtopicApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification topic to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->notificationtopic_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling NotificationtopicApi->notificationtopic_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification topic to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopic_get**
> notificationtopic_get(id => $id)

Search and view details of a notification topic

Allows the user to view an individual notification topic and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationtopicApi;
my $api_instance = WWW::OpenAPIClient::NotificationtopicApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the notification topic to get.

eval { 
    $api_instance->notificationtopic_get(id => $id);
};
if ($@) {
    warn "Exception when calling NotificationtopicApi->notificationtopic_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the notification topic to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **notificationtopic_list**
> notificationtopic_list(from => $from, count => $count)

List all the notification topics

Allows the user to view the list of all notification topics.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationtopicApi;
my $api_instance = WWW::OpenAPIClient::NotificationtopicApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->notificationtopic_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling NotificationtopicApi->notificationtopic_list: $@\n";
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

# **notificationtopic_listsubscribe**
> notificationtopic_listsubscribe()

List all the notification topics available to subscribe

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationtopicApi;
my $api_instance = WWW::OpenAPIClient::NotificationtopicApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->notificationtopic_listsubscribe();
};
if ($@) {
    warn "Exception when calling NotificationtopicApi->notificationtopic_listsubscribe: $@\n";
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

# **notificationtopic_save**
> notificationtopic_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a notification topic

Allows the user to create and edit a notification topic.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::NotificationtopicApi;
my $api_instance = WWW::OpenAPIClient::NotificationtopicApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the topic to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->notificationtopic_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling NotificationtopicApi->notificationtopic_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the topic to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

