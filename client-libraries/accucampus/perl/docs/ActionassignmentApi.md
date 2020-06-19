# WWW::OpenAPIClient::ActionassignmentApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ActionassignmentApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionassignment_delete**](ActionassignmentApi.md#actionassignment_delete) | **DELETE** /actionassignment/{id} | Remove an action item from an action plan
[**actionassignment_get**](ActionassignmentApi.md#actionassignment_get) | **GET** /actionassignment/{id} | Search and view details of an action item assigned to a user
[**actionassignment_list**](ActionassignmentApi.md#actionassignment_list) | **GET** /actionassignment/list | View a list of action items in a user&#39;s plan
[**actionassignment_listhistory**](ActionassignmentApi.md#actionassignment_listhistory) | **GET** /actionassignment/listhistory | View the history of an action item assigned to a user
[**actionassignment_listmine**](ActionassignmentApi.md#actionassignment_listmine) | **GET** /actionassignment/listmine | List public action assignments assigned to the logged user
[**actionassignment_listpublichistory**](ActionassignmentApi.md#actionassignment_listpublichistory) | **GET** /actionassignment/listpublichistory | List public action assignment history
[**actionassignment_markcomplete**](ActionassignmentApi.md#actionassignment_markcomplete) | **GET** /actionassignment/markcomplete | Bulk complete action items
[**actionassignment_save**](ActionassignmentApi.md#actionassignment_save) | **POST** /actionassignment/save | Add an action item to a user&#39;s action plan
[**actionassignment_savehistory**](ActionassignmentApi.md#actionassignment_savehistory) | **POST** /actionassignment/savehistory | Update an action item assigned to a user


# **actionassignment_delete**
> actionassignment_delete(id => $id, body => $body)

Remove an action item from an action plan

Allows a user to remove an action item from a user's action plan.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action assignment to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->actionassignment_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action assignment to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_get**
> actionassignment_get(id => $id)

Search and view details of an action item assigned to a user

Allows the user to view an individual action item and its details, minus all the action item's updates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the action assignment to get.

eval { 
    $api_instance->actionassignment_get(id => $id);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the action assignment to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_list**
> actionassignment_list(from => $from, count => $count, assignee => $assignee, status => $status)

View a list of action items in a user's plan

Allows the user to view the list of all action items for a specified user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $assignee = 56; # int | The assignee's id to filter the assignments.
my $status = 56; # int | The status to filter the assignments.

eval { 
    $api_instance->actionassignment_list(from => $from, count => $count, assignee => $assignee, status => $status);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **assignee** | **int**| The assignee&#39;s id to filter the assignments. | [optional] 
 **status** | **int**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_listhistory**
> actionassignment_listhistory(actionassignment => $actionassignment)

View the history of an action item assigned to a user

Allows the user to view an individual action plan and its details, including all the action plan's updates.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $actionassignment = null; # string | The action assignment's id whose history the user wants to get.

eval { 
    $api_instance->actionassignment_listhistory(actionassignment => $actionassignment);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_listhistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_listmine**
> actionassignment_listmine(from => $from, count => $count, status => $status)

List public action assignments assigned to the logged user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | The status to filter the assignments.

eval { 
    $api_instance->actionassignment_listmine(from => $from, count => $count, status => $status);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_listmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| The status to filter the assignments. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_listpublichistory**
> actionassignment_listpublichistory(actionassignment => $actionassignment)

List public action assignment history

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $actionassignment = null; # string | The action assignment's id whose history the user wants to get.

eval { 
    $api_instance->actionassignment_listpublichistory(actionassignment => $actionassignment);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_listpublichistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **actionassignment** | [**string**](.md)| The action assignment&#39;s id whose history the user wants to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_markcomplete**
> actionassignment_markcomplete(item => $item, assignee => $assignee, group => $group, notes => $notes)

Bulk complete action items

Allows the user to bulk complete action items.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $item = "item_example"; # string | The action item to assign.
my $assignee = null; # string | The assignee of the item.
my $group = null; # string | The group to assing the item.
my $notes = "notes_example"; # string | The assignment's notes.

eval { 
    $api_instance->actionassignment_markcomplete(item => $item, assignee => $assignee, group => $group, notes => $notes);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_markcomplete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | **string**| The action item to assign. | 
 **assignee** | [**string**](.md)| The assignee of the item. | [optional] 
 **group** | [**string**](.md)| The group to assing the item. | [optional] 
 **notes** | **string**| The assignment&#39;s notes. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **actionassignment_save**
> actionassignment_save(unknown_base_type => $unknown_base_type)

Add an action item to a user's action plan

Allows the user to edit or assign an action item to a user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionassignment_save(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_save: $@\n";
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

# **actionassignment_savehistory**
> actionassignment_savehistory(unknown_base_type => $unknown_base_type)

Update an action item assigned to a user

Allows the user to update or mark an action item as complete.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionassignmentApi;
my $api_instance = WWW::OpenAPIClient::ActionassignmentApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->actionassignment_savehistory(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling ActionassignmentApi->actionassignment_savehistory: $@\n";
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

