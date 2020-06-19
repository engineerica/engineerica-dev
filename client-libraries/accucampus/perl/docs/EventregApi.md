# WWW::OpenAPIClient::EventregApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::EventregApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventreg_addme**](EventregApi.md#eventreg_addme) | **GET** /eventreg/addme | Register current user to a course
[**eventreg_addmetoall**](EventregApi.md#eventreg_addmetoall) | **GET** /eventreg/addmetoall | Register current user to all courses
[**eventreg_addmetogroup**](EventregApi.md#eventreg_addmetogroup) | **GET** /eventreg/addmetogroup | Register current user to a course group
[**eventreg_adduser**](EventregApi.md#eventreg_adduser) | **GET** /eventreg/adduser | Register a user to a course for attendance
[**eventreg_addusertoall**](EventregApi.md#eventreg_addusertoall) | **GET** /eventreg/addusertoall | Register a user to assist with all courses
[**eventreg_addusertogroup**](EventregApi.md#eventreg_addusertogroup) | **GET** /eventreg/addusertogroup | Register a user to an course group
[**eventreg_getevents**](EventregApi.md#eventreg_getevents) | **GET** /eventreg/getevents | View course registration by user
[**eventreg_getgroups**](EventregApi.md#eventreg_getgroups) | **GET** /eventreg/getgroups | Lists the course group registrations of a user
[**eventreg_getmyevents**](EventregApi.md#eventreg_getmyevents) | **GET** /eventreg/getmyevents | View the event registrations of the current user
[**eventreg_getmygroups**](EventregApi.md#eventreg_getmygroups) | **GET** /eventreg/getmygroups | View all current user registrations to course groups
[**eventreg_getusers**](EventregApi.md#eventreg_getusers) | **GET** /eventreg/getusers | View course registration
[**eventreg_getusersfromgroup**](EventregApi.md#eventreg_getusersfromgroup) | **GET** /eventreg/getusersfromgroup | Lists the registrations for a course group
[**eventreg_getuserstoall**](EventregApi.md#eventreg_getuserstoall) | **GET** /eventreg/getuserstoall | View the users that are registered to all courses
[**eventreg_removeme**](EventregApi.md#eventreg_removeme) | **GET** /eventreg/removeme | Unregister current user from a course
[**eventreg_removemefromall**](EventregApi.md#eventreg_removemefromall) | **GET** /eventreg/removemefromall | Remove current user from the registration to all courses
[**eventreg_removemefromgroup**](EventregApi.md#eventreg_removemefromgroup) | **GET** /eventreg/removemefromgroup | Remove current user from a course group
[**eventreg_removeuser**](EventregApi.md#eventreg_removeuser) | **GET** /eventreg/removeuser | Remove a user from a course
[**eventreg_removeuserfromall**](EventregApi.md#eventreg_removeuserfromall) | **GET** /eventreg/removeuserfromall | Remove a user from the registration to all courses
[**eventreg_removeuserfromgroup**](EventregApi.md#eventreg_removeuserfromgroup) | **GET** /eventreg/removeuserfromgroup | Remove a user from a course group


# **eventreg_addme**
> eventreg_addme(eventid => $eventid, listname => $listname)

Register current user to a course

Allows the user to make themselves available for individual courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_addme(eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_addme: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_addmetoall**
> eventreg_addmetoall(listname => $listname)

Register current user to all courses

Allows the user to make themselves available for all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_addmetoall(listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_addmetoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_addmetogroup**
> eventreg_addmetogroup(codegroup => $codegroup, listname => $listname)

Register current user to a course group

Allows the user to make themselves available for a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $codegroup = "codegroup_example"; # string | The code used to group events.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_addmetogroup(codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_addmetogroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_adduser**
> eventreg_adduser(userid => $userid, eventid => $eventid, listname => $listname)

Register a user to a course for attendance

Allows the user to register a user to a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_adduser(userid => $userid, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_adduser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_addusertoall**
> eventreg_addusertoall(userid => $userid, listname => $listname)

Register a user to assist with all courses

Allows the user to make a staff member available to assist with all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_addusertoall(userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_addusertoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_addusertogroup**
> eventreg_addusertogroup(userid => $userid, codegroup => $codegroup, listname => $listname)

Register a user to an course group

Allows the user to make a staff member available for a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to add.
my $codegroup = "codegroup_example"; # string | The code used to group events.
my $listname = "listname_example"; # string | The name of the list where the user has to be registered.

eval { 
    $api_instance->eventreg_addusertogroup(userid => $userid, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_addusertogroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to add. | 
 **codegroup** | **string**| The code used to group events. | 
 **listname** | **string**| The name of the list where the user has to be registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getevents**
> eventreg_getevents(userid => $userid, listname => $listname, termid => $termid, namefilter => $namefilter)

View course registration by user

Allows the user to view all courses a given user is registered to, provided they have permission to view that user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The user id to list events.
my $listname = "listname_example"; # string | The name of the list where the user is registered.
my $termid = null; # string | The term id to list events.
my $namefilter = "namefilter_example"; # string | The value used to filter the events by name.

eval { 
    $api_instance->eventreg_getevents(userid => $userid, listname => $listname, termid => $termid, namefilter => $namefilter);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getevents: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**string**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getgroups**
> eventreg_getgroups(userid => $userid, listname => $listname)

Lists the course group registrations of a user

Allows the user to view the course groups a staff member is available for.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The user id to list events.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_getgroups(userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getgroups: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The user id to list events. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getmyevents**
> eventreg_getmyevents(listname => $listname, termid => $termid, namefilter => $namefilter)

View the event registrations of the current user

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $listname = "listname_example"; # string | The name of the list where the user is registered.
my $termid = null; # string | The term id to list events.
my $namefilter = "namefilter_example"; # string | The value used to filter the events by name.

eval { 
    $api_instance->eventreg_getmyevents(listname => $listname, termid => $termid, namefilter => $namefilter);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getmyevents: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 
 **termid** | [**string**](.md)| The term id to list events. | [optional] 
 **namefilter** | **string**| The value used to filter the events by name. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getmygroups**
> eventreg_getmygroups(listname => $listname)

View all current user registrations to course groups

Allows the user to view all his registrations to course groups.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_getmygroups(listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getmygroups: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getusers**
> eventreg_getusers(eventid => $eventid, listname => $listname, photosize => $photosize)

View course registration

Allows the user to view all users registered for an individual course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The event id to list users.
my $listname = "listname_example"; # string | The name of the list to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->eventreg_getusers(eventid => $eventid, listname => $listname, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getusers: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The event id to list users. | 
 **listname** | **string**| The name of the list to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getusersfromgroup**
> eventreg_getusersfromgroup(codegroup => $codegroup, listname => $listname)

Lists the registrations for a course group

Allows the user the get the staff members registered to a specific course group

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $codegroup = null; # string | The code group to list users.
my $listname = "listname_example"; # string | The name of the list to get.

eval { 
    $api_instance->eventreg_getusersfromgroup(codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getusersfromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**string**](.md)| The code group to list users. | 
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_getuserstoall**
> eventreg_getuserstoall(listname => $listname)

View the users that are registered to all courses

Allows the user to view all staff members available for all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $listname = "listname_example"; # string | The name of the list to get.

eval { 
    $api_instance->eventreg_getuserstoall(listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_getuserstoall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removeme**
> eventreg_removeme(eventid => $eventid, listname => $listname)

Unregister current user from a course

Allows the user to remove themselves from registration to a course.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removeme(eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removeme: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removemefromall**
> eventreg_removemefromall(listname => $listname)

Remove current user from the registration to all courses

Allows the user to remove themselves from availability to all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removemefromall(listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removemefromall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removemefromgroup**
> eventreg_removemefromgroup(codegroup => $codegroup, listname => $listname)

Remove current user from a course group

Allows the user to remove themselves from availability to a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $codegroup = null; # string | The code group of the events/courses.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removemefromgroup(codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removemefromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **codegroup** | [**string**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removeuser**
> eventreg_removeuser(userid => $userid, eventid => $eventid, listname => $listname)

Remove a user from a course

Allows the user to remove a user from a course's registration.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $eventid = null; # string | The id of the event.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removeuser(userid => $userid, eventid => $eventid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removeuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **eventid** | [**string**](.md)| The id of the event. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removeuserfromall**
> eventreg_removeuserfromall(userid => $userid, listname => $listname)

Remove a user from the registration to all courses

Allows the user to remove a staff member from availability to all courses.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removeuserfromall(userid => $userid, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removeuserfromall: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **eventreg_removeuserfromgroup**
> eventreg_removeuserfromgroup(userid => $userid, codegroup => $codegroup, listname => $listname)

Remove a user from a course group

Allows the user to remove a staff member from availability to a course group.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::EventregApi;
my $api_instance = WWW::OpenAPIClient::EventregApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to remove.
my $codegroup = null; # string | The code group of the events/courses.
my $listname = "listname_example"; # string | The name of the list where the user is registered.

eval { 
    $api_instance->eventreg_removeuserfromgroup(userid => $userid, codegroup => $codegroup, listname => $listname);
};
if ($@) {
    warn "Exception when calling EventregApi->eventreg_removeuserfromgroup: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to remove. | 
 **codegroup** | [**string**](.md)| The code group of the events/courses. | 
 **listname** | **string**| The name of the list where the user is registered. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

