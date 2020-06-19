# WWW::OpenAPIClient::WaitinglineApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::WaitinglineApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**waitingline_adduser**](WaitinglineApi.md#waitingline_adduser) | **GET** /waitingline/adduser | Put user in a waiting line
[**waitingline_delete**](WaitinglineApi.md#waitingline_delete) | **DELETE** /waitingline/{id} | Delete a waiting line
[**waitingline_get**](WaitinglineApi.md#waitingline_get) | **GET** /waitingline/{id} | View details of a waiting line
[**waitingline_isuserin**](WaitinglineApi.md#waitingline_isuserin) | **GET** /waitingline/isuserin | Check whether a user is in a waiting line, signed-in or is not in the area
[**waitingline_list**](WaitinglineApi.md#waitingline_list) | **GET** /waitingline/list | View a list of waiting lines
[**waitingline_removeuser**](WaitinglineApi.md#waitingline_removeuser) | **GET** /waitingline/removeuser | Remove a user from a waiting line
[**waitingline_save**](WaitinglineApi.md#waitingline_save) | **POST** /waitingline/{id} | Create or edit a waiting line
[**waitingline_signinuser**](WaitinglineApi.md#waitingline_signinuser) | **GET** /waitingline/signinuser | Sign a user in from a waiting line


# **waitingline_adduser**
> waitingline_adduser(station => $station, user => $user, locationid => $locationid, time => $time, signinrole => $signinrole, roleid => $roleid, services => $services, eventid => $eventid, staff => $staff, photosize => $photosize)

Put user in a waiting line

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(
);

my $station = null; # string | The id of the sign-in station.
my $user = "user_example"; # string | The user's card number.
my $locationid = null; # string | The location's id where the swipe must be saved.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $signinrole = "signinrole_example"; # string | Specifies if the sign-in is for an attendee or a staff member
my $roleid = null; # string | Specifies the role the user has selected in order to sign-in
my $services = "services_example"; # string | The services ids the user has selected.
my $eventid = null; # string | The id of the event the user selected.
my $staff = null; # string | The id of the staff member the user selected.
my $photosize = 56; # int | The swiping user's photo size.

eval { 
    $api_instance->waitingline_adduser(station => $station, user => $user, locationid => $locationid, time => $time, signinrole => $signinrole, roleid => $roleid, services => $services, eventid => $eventid, staff => $staff, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_adduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station. | 
 **user** | **string**| The user&#39;s card number. | 
 **locationid** | [**string**](.md)| The location&#39;s id where the swipe must be saved. | [optional] 
 **time** | **DateTime**| The date and time of the swipe. | [optional] 
 **signinrole** | **string**| Specifies if the sign-in is for an attendee or a staff member | [optional] 
 **roleid** | [**string**](.md)| Specifies the role the user has selected in order to sign-in | [optional] 
 **services** | **string**| The services ids the user has selected. | [optional] 
 **eventid** | [**string**](.md)| The id of the event the user selected. | [optional] 
 **staff** | [**string**](.md)| The id of the staff member the user selected. | [optional] 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_delete**
> waitingline_delete(id => $id, body => $body)

Delete a waiting line

Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the line to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->waitingline_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the line to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_get**
> waitingline_get(id => $id, photosize => $photosize)

View details of a waiting line

Allows the user to view the details of a waiting line in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the waiting line to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->waitingline_get(id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the waiting line to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_isuserin**
> waitingline_isuserin(station => $station, time => $time, user => $user, location => $location)

Check whether a user is in a waiting line, signed-in or is not in the area

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(
);

my $station = null; # string | The id of the sign-in station.
my $time = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date and time of the swipe.
my $user = "user_example"; # string | The card number of the user.
my $location = null; # string | The id of the location the user picked.

eval { 
    $api_instance->waitingline_isuserin(station => $station, time => $time, user => $user, location => $location);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_isuserin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **station** | [**string**](.md)| The id of the sign-in station. | 
 **time** | **DateTime**| The date and time of the swipe. | 
 **user** | **string**| The card number of the user. | 
 **location** | [**string**](.md)| The id of the location the user picked. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_list**
> waitingline_list(from => $from, count => $count)

View a list of waiting lines

Allows the user to view the list of waiting lines in locations to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->waitingline_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_list: $@\n";
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

# **waitingline_removeuser**
> waitingline_removeuser(waitingline => $waitingline, itemid => $itemid)

Remove a user from a waiting line

Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $waitingline = null; # string | The id of the waiting line whose item has to be removed.
my $itemid = null; # string | The ID of the item that has to be removed.

eval { 
    $api_instance->waitingline_removeuser(waitingline => $waitingline, itemid => $itemid);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_removeuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**string**](.md)| The id of the waiting line whose item has to be removed. | 
 **itemid** | [**string**](.md)| The ID of the item that has to be removed. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_save**
> waitingline_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a waiting line

Allows the user to create or edit a waiting line in a location to which they are scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the waiting line save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->waitingline_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the waiting line save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **waitingline_signinuser**
> waitingline_signinuser(waitingline => $waitingline, itemid => $itemid, staff => $staff, photosize => $photosize)

Sign a user in from a waiting line

Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::WaitinglineApi;
my $api_instance = WWW::OpenAPIClient::WaitinglineApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $waitingline = null; # string | The id of the waiting line whose item needs to be signed-in.
my $itemid = null; # string | The ID of the item that has to be signed-in.
my $staff = null; # string | The id of the staff member selected to sign-in.
my $photosize = 56; # int | The swiping user's photo size.

eval { 
    $api_instance->waitingline_signinuser(waitingline => $waitingline, itemid => $itemid, staff => $staff, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling WaitinglineApi->waitingline_signinuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **waitingline** | [**string**](.md)| The id of the waiting line whose item needs to be signed-in. | 
 **itemid** | [**string**](.md)| The ID of the item that has to be signed-in. | 
 **staff** | [**string**](.md)| The id of the staff member selected to sign-in. | 
 **photosize** | **int**| The swiping user&#39;s photo size. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

