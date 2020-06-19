# WWW::OpenAPIClient::AttendancelogApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::AttendancelogApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**attendancelog_delete**](AttendancelogApi.md#attendancelog_delete) | **DELETE** /attendancelog/{id} | Delete an attendance log
[**attendancelog_get**](AttendancelogApi.md#attendancelog_get) | **GET** /attendancelog/{id} | Search and view details of an attendance log
[**attendancelog_getchangehistory**](AttendancelogApi.md#attendancelog_getchangehistory) | **GET** /attendancelog/getchangehistory | Search and view details of an attendance log&#39;s swipe history
[**attendancelog_list**](AttendancelogApi.md#attendancelog_list) | **GET** /attendancelog/list | View a list of attendance logs
[**attendancelog_listmine**](AttendancelogApi.md#attendancelog_listmine) | **GET** /attendancelog/listmine | Gets the attendance logs of the current user
[**attendancelog_liststaff**](AttendancelogApi.md#attendancelog_liststaff) | **GET** /attendancelog/liststaff | Gets the attendance logs that the current user is involved in as staff
[**attendancelog_save**](AttendancelogApi.md#attendancelog_save) | **POST** /attendancelog/{id} | Create or edit an attendance log
[**attendancelog_signout**](AttendancelogApi.md#attendancelog_signout) | **GET** /attendancelog/signout | Sign out an attendance log
[**attendancelog_whosin**](AttendancelogApi.md#attendancelog_whosin) | **GET** /attendancelog/whosin | View who&#39;s in a location


# **attendancelog_delete**
> attendancelog_delete(id => $id, body => $body)

Delete an attendance log

Allows the user to delete an existing attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->attendancelog_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_get**
> attendancelog_get(id => $id)

Search and view details of an attendance log

Allows the user to view an individual attendance log and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log to get.

eval { 
    $api_instance->attendancelog_get(id => $id);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_getchangehistory**
> attendancelog_getchangehistory(id => $id)

Search and view details of an attendance log's swipe history

Allows the user to view the swipes of an individual attendance logs (sign ins and sign outs).

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log to get.

eval { 
    $api_instance->attendancelog_getchangehistory(id => $id);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_getchangehistory: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_list**
> attendancelog_list(from => $from, count => $count, filter => $filter, userid => $userid)

View a list of attendance logs

Allows the user to view the list of all attendance logs in the location or locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.
my $userid = null; # string | The user ID of the user to get the logs.

eval { 
    $api_instance->attendancelog_list(from => $from, count => $count, filter => $filter, userid => $userid);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 
 **userid** | [**string**](.md)| The user ID of the user to get the logs. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_listmine**
> attendancelog_listmine(from => $from, count => $count, filter => $filter)

Gets the attendance logs of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

eval { 
    $api_instance->attendancelog_listmine(from => $from, count => $count, filter => $filter);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_listmine: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_liststaff**
> attendancelog_liststaff(from => $from, count => $count, filter => $filter)

Gets the attendance logs that the current user is involved in as staff

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $filter = "filter_example"; # string | Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid.

eval { 
    $api_instance->attendancelog_liststaff(from => $from, count => $count, filter => $filter);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_liststaff: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **filter** | **string**| Filter the logs, valid values are: invalid, not-signed-in, not-signed-out, stayed-less-than-required, out-of-event, valid. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_save**
> attendancelog_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit an attendance log

Allows the user to create or edit an attendance log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the room to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->attendancelog_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the room to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_signout**
> attendancelog_signout(id => $id, location => $location, event => $event, datetime => $datetime)

Sign out an attendance log

Allows the user to sign out am attendance log from the Who's In page.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the attendance log to sign-out.
my $location = null; # string | The id of the location to filter the users to sign out.
my $event = null; # string | The id of the event to filter the users to sign out.
my $datetime = DateTime->from_epoch(epoch => str2time('null')); # DateTime | Specifies the date and time when the specified logs have to be signed out.

eval { 
    $api_instance->attendancelog_signout(id => $id, location => $location, event => $event, datetime => $datetime);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_signout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the attendance log to sign-out. | [optional] 
 **location** | [**string**](.md)| The id of the location to filter the users to sign out. | [optional] 
 **event** | [**string**](.md)| The id of the event to filter the users to sign out. | [optional] 
 **datetime** | **DateTime**| Specifies the date and time when the specified logs have to be signed out. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **attendancelog_whosin**
> attendancelog_whosin(from => $from, count => $count, location => $location, event => $event, sorting => $sorting, roles => $roles, photosize => $photosize, extensions => $extensions, export => $export)

View who's in a location

Allows the user to view the Who's In page and view all users who are logged into locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::AttendancelogApi;
my $api_instance = WWW::OpenAPIClient::AttendancelogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $location = null; # string | The id of the location to search for users that are in.
my $event = null; # string | The id of the event to search for users that are in.
my $sorting = "sorting_example"; # string | Field to sort by. Either first-name, last-name or sign-in-time.
my $roles = "roles_example"; # string | The comma-separated list of ids of the roles to search for users that are in.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
my $extensions = "extensions_example"; # string | A JSON array containing the extension filters (i.e [{name: 'nametofilter', value: 'valuetofilter'}]).
my $export = null; # boolean | True to export the results as CSV

eval { 
    $api_instance->attendancelog_whosin(from => $from, count => $count, location => $location, event => $event, sorting => $sorting, roles => $roles, photosize => $photosize, extensions => $extensions, export => $export);
};
if ($@) {
    warn "Exception when calling AttendancelogApi->attendancelog_whosin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **location** | [**string**](.md)| The id of the location to search for users that are in. | [optional] 
 **event** | [**string**](.md)| The id of the event to search for users that are in. | [optional] 
 **sorting** | **string**| Field to sort by. Either first-name, last-name or sign-in-time. | [optional] 
 **roles** | **string**| The comma-separated list of ids of the roles to search for users that are in. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 
 **extensions** | **string**| A JSON array containing the extension filters (i.e [{name: &#39;nametofilter&#39;, value: &#39;valuetofilter&#39;}]). | [optional] 
 **export** | **boolean**| True to export the results as CSV | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

