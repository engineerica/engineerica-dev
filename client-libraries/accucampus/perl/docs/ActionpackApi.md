# WWW::OpenAPIClient::ActionpackApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ActionpackApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionpack_assign**](ActionpackApi.md#actionpack_assign) | **GET** /actionpack/assign | Assign an action item pack to a user
[**actionpack_delete**](ActionpackApi.md#actionpack_delete) | **DELETE** /actionpack/{id} | Delete an action item pack
[**actionpack_get**](ActionpackApi.md#actionpack_get) | **GET** /actionpack/{id} | View details of an action item pack
[**actionpack_list**](ActionpackApi.md#actionpack_list) | **GET** /actionpack/list | View a list of action item packs
[**actionpack_save**](ActionpackApi.md#actionpack_save) | **POST** /actionpack/{id} | Create or edit an action item pack


# **actionpack_assign**
> actionpack_assign(pack => $pack, itemsdata => $itemsdata, assignee => $assignee, group => $group, notes => $notes)

Assign an action item pack to a user

Allows the user to assign an action pack to a user or group of users.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionpackApi;
my $api_instance = WWW::OpenAPIClient::ActionpackApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $pack = null; # string | The id of the action pack to assign.
my $itemsdata = null; # boolean | A JSON array containing the action items' data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).
my $assignee = null; # string | The assignee of the pack.
my $group = null; # string | The group to assign the pack.
my $notes = "notes_example"; # string | The assignment's notes.

eval { 
    $api_instance->actionpack_assign(pack => $pack, itemsdata => $itemsdata, assignee => $assignee, group => $group, notes => $notes);
};
if ($@) {
    warn "Exception when calling ActionpackApi->actionpack_assign: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pack** | [**string**](.md)| The id of the action pack to assign. | 
 **itemsdata** | **boolean**| A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne). | 
 **assignee** | [**string**](.md)| The assignee of the pack. | [optional] 
 **group** | [**string**](.md)| The group to assign the pack. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpack_delete**
> actionpack_delete(id => $id, body => $body)

Delete an action item pack

Allows the user to delete an action item pack.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionpackApi;
my $api_instance = WWW::OpenAPIClient::ActionpackApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action pack to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->actionpack_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ActionpackApi->actionpack_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action pack to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpack_get**
> actionpack_get(id => $id)

View details of an action item pack

Allows the user to view an individual action pack and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionpackApi;
my $api_instance = WWW::OpenAPIClient::ActionpackApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action pack to get.

eval { 
    $api_instance->actionpack_get(id => $id);
};
if ($@) {
    warn "Exception when calling ActionpackApi->actionpack_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action pack to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionpack_list**
> actionpack_list(from => $from, count => $count)

View a list of action item packs

Allows the user to view the full list of action item packs.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionpackApi;
my $api_instance = WWW::OpenAPIClient::ActionpackApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->actionpack_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling ActionpackApi->actionpack_list: $@\n";
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

# **actionpack_save**
> actionpack_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an action item pack

Allows the user to edit an action item pack.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionpackApi;
my $api_instance = WWW::OpenAPIClient::ActionpackApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action pack to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionpack_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ActionpackApi->actionpack_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action pack to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

