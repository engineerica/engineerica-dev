# WWW::OpenAPIClient::AdhocqueryApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AdhocqueryApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**adhocquery_checkexecution**](AdhocqueryApi.md#adhocquery_checkexecution) | **GET** /adhocquery/checkexecution | Check the status of an ad hoc query execution
[**adhocquery_delete**](AdhocqueryApi.md#adhocquery_delete) | **DELETE** /adhocquery/{id} | Delete an ad hoc query
[**adhocquery_execute**](AdhocqueryApi.md#adhocquery_execute) | **GET** /adhocquery/execute | Execute an ad hoc query
[**adhocquery_get**](AdhocqueryApi.md#adhocquery_get) | **GET** /adhocquery/{id} | View details of an ad hoc query
[**adhocquery_getschema**](AdhocqueryApi.md#adhocquery_getschema) | **GET** /adhocquery/getschema | View the database schema for making ad hoc queries
[**adhocquery_list**](AdhocqueryApi.md#adhocquery_list) | **GET** /adhocquery/list | View a list of saved ad hoc queries
[**adhocquery_listexecutions**](AdhocqueryApi.md#adhocquery_listexecutions) | **GET** /adhocquery/listexecutions | View a list of ad hoc queries executions
[**adhocquery_save**](AdhocqueryApi.md#adhocquery_save) | **POST** /adhocquery/{id} | Create or edit an ad hoc query
[**adhocquery_stopexecution**](AdhocqueryApi.md#adhocquery_stopexecution) | **GET** /adhocquery/stopexecution | Stops the execution of an ad hoc query


# **adhocquery_checkexecution**
> adhocquery_checkexecution(id => $id)

Check the status of an ad hoc query execution

Allows the user to check whether a query has executed, viewable on the query's execution page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the ad hoc query execution to be checked.

eval { 
    $api_instance->adhocquery_checkexecution(id => $id);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_checkexecution: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the ad hoc query execution to be checked. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_delete**
> adhocquery_delete(id => $id, body => $body)

Delete an ad hoc query

Allows the user to delete a previously created ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the ad hoc query to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->adhocquery_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the ad hoc query to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_execute**
> adhocquery_execute(id => $id, query => $query)

Execute an ad hoc query

Allows the user to execute an ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the query to execute.
my $query = "query_example"; # string | The query to execute.

eval { 
    $api_instance->adhocquery_execute(id => $id, query => $query);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_execute: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the query to execute. | [optional] 
 **query** | **string**| The query to execute. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_get**
> adhocquery_get(id => $id)

View details of an ad hoc query

Allows the user to view an individual ad hoc query with its settings.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the query to get.

eval { 
    $api_instance->adhocquery_get(id => $id);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the query to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_getschema**
> adhocquery_getschema()

View the database schema for making ad hoc queries

Allows the user to view the list of schema for ad hoc queries.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->adhocquery_getschema();
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_getschema: $@\n";
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

# **adhocquery_list**
> adhocquery_list(from => $from, count => $count)

View a list of saved ad hoc queries

Allows the user to view the full list of saved queries.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->adhocquery_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_list: $@\n";
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

# **adhocquery_listexecutions**
> adhocquery_listexecutions(from => $from, count => $count, query => $query)

View a list of ad hoc queries executions

Allows the user to view the full list of past query executions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $query = null; # string | The first record to return.

eval { 
    $api_instance->adhocquery_listexecutions(from => $from, count => $count, query => $query);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_listexecutions: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **query** | [**string**](.md)| The first record to return. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_save**
> adhocquery_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an ad hoc query

Allows the user to edit an ad hoc query.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the query to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->adhocquery_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the query to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **adhocquery_stopexecution**
> adhocquery_stopexecution(id => $id)

Stops the execution of an ad hoc query

Allows the user to halt the execution of a query that is currently being executed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AdhocqueryApi;
my $api_instance = WWW::OpenAPIClient::AdhocqueryApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the ad hoc query execution to be stopped.

eval { 
    $api_instance->adhocquery_stopexecution(id => $id);
};
if ($@) {
    warn "Exception when calling AdhocqueryApi->adhocquery_stopexecution: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the ad hoc query execution to be stopped. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

