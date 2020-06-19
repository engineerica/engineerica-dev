# WWW::OpenAPIClient::MediaApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::MediaApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**media_checkin**](MediaApi.md#media_checkin) | **GET** /media/checkin | Check in media item
[**media_checkout**](MediaApi.md#media_checkout) | **GET** /media/checkout | Check out media item
[**media_checkoutlist**](MediaApi.md#media_checkoutlist) | **GET** /media/checkoutlist | View a list of past media checkouts
[**media_delete**](MediaApi.md#media_delete) | **DELETE** /media/{id} | Delete a media item
[**media_deletecheckoutlog**](MediaApi.md#media_deletecheckoutlog) | **DELETE** /media/deletecheckoutlog | Delete a media checkout log
[**media_get**](MediaApi.md#media_get) | **GET** /media/{id} | Search and view details of a media item
[**media_getbycode**](MediaApi.md#media_getbycode) | **GET** /media/getbycode | Search media item by unique code
[**media_getcheckout**](MediaApi.md#media_getcheckout) | **GET** /media/getcheckout | View details of a media item checkout information
[**media_getcheckoutlog**](MediaApi.md#media_getcheckoutlog) | **GET** /media/getcheckoutlog | View details of a media checkout log
[**media_list**](MediaApi.md#media_list) | **GET** /media/list | View a list of media items
[**media_save**](MediaApi.md#media_save) | **POST** /media/{id} | Create or edit a media item


# **media_checkin**
> media_checkin(media => $media, checkindate => $checkindate, notes => $notes)

Check in media item

Allows the user to check in a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $media = null; # string | The id of the media item to checkin.
my $checkindate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The checkout date.
my $notes = "notes_example"; # string | The notes of the checkout.

eval { 
    $api_instance->media_checkin(media => $media, checkindate => $checkindate, notes => $notes);
};
if ($@) {
    warn "Exception when calling MediaApi->media_checkin: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**string**](.md)| The id of the media item to checkin. | 
 **checkindate** | **DateTime**| The checkout date. | 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_checkout**
> media_checkout(media => $media, user => $user, checkoutdate => $checkoutdate, duedate => $duedate, staff => $staff, event => $event, notes => $notes)

Check out media item

Allows the user to check out a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $media = null; # string | The id of the media item to checkout.
my $user = null; # string | The id of the user that is checking the item out.
my $checkoutdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The checkout date.
my $duedate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The date when the checkout is due.
my $staff = null; # string | The id of the staff member related to the checkout.
my $event = null; # string | The id of the event related to the checkout.
my $notes = "notes_example"; # string | The notes of the checkout.

eval { 
    $api_instance->media_checkout(media => $media, user => $user, checkoutdate => $checkoutdate, duedate => $duedate, staff => $staff, event => $event, notes => $notes);
};
if ($@) {
    warn "Exception when calling MediaApi->media_checkout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **media** | [**string**](.md)| The id of the media item to checkout. | 
 **user** | [**string**](.md)| The id of the user that is checking the item out. | 
 **checkoutdate** | **DateTime**| The checkout date. | 
 **duedate** | **DateTime**| The date when the checkout is due. | 
 **staff** | [**string**](.md)| The id of the staff member related to the checkout. | [optional] 
 **event** | [**string**](.md)| The id of the event related to the checkout. | [optional] 
 **notes** | **string**| The notes of the checkout. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_checkoutlist**
> media_checkoutlist(from => $from, count => $count, media => $media, user => $user, photosize => $photosize)

View a list of past media checkouts

Allows the user to view a list of all past checkouts

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $media = null; # string | Used to filter the checkouts of a specific media item.
my $user = null; # string | Used to filter the checkouts made by a specific user.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->media_checkoutlist(from => $from, count => $count, media => $media, user => $user, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling MediaApi->media_checkoutlist: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **media** | [**string**](.md)| Used to filter the checkouts of a specific media item. | [optional] 
 **user** | [**string**](.md)| Used to filter the checkouts made by a specific user. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_delete**
> media_delete(id => $id, body => $body)

Delete a media item

Allows the user to delete an existing media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the media item to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->media_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling MediaApi->media_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the media item to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_deletecheckoutlog**
> media_deletecheckoutlog(unknown_base_type => $unknown_base_type)

Delete a media checkout log

Allows the user to delete a media item's checkout log.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->media_deletecheckoutlog(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling MediaApi->media_deletecheckoutlog: $@\n";
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

# **media_get**
> media_get(id => $id)

Search and view details of a media item

Allows the user to view an individual media item and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the media item to get.

eval { 
    $api_instance->media_get(id => $id);
};
if ($@) {
    warn "Exception when calling MediaApi->media_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the media item to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_getbycode**
> media_getbycode(code => $code, location => $location)

Search media item by unique code

Allows the user to search for media items by their unique code.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $code = "code_example"; # string | The code of the media item to get.
my $location = null; # string | The location where to look for the media item.

eval { 
    $api_instance->media_getbycode(code => $code, location => $location);
};
if ($@) {
    warn "Exception when calling MediaApi->media_getbycode: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| The code of the media item to get. | 
 **location** | [**string**](.md)| The location where to look for the media item. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_getcheckout**
> media_getcheckout(id => $id, photosize => $photosize)

View details of a media item checkout information

Allows the user to view a media item's checkout information.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the media item whose checkout information has to be retrieved.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->media_getcheckout(id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling MediaApi->media_getcheckout: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_getcheckoutlog**
> media_getcheckoutlog(id => $id, photosize => $photosize)

View details of a media checkout log

Allows the user to view a media item's checkout history.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the media item whose checkout information has to be retrieved.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->media_getcheckoutlog(id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling MediaApi->media_getcheckoutlog: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the media item whose checkout information has to be retrieved. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_list**
> media_list(from => $from, count => $count, status => $status, user => $user)

View a list of media items

Allows the user to view the list of all media items tied to locations in which the user is scoped.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $status = 56; # int | Used to filter the media items by their checkout status (0 = CheckedIn, 1 = CheckedOut, Unspecified = All).
my $user = null; # string | Used to filter the media items that are checked-out by a specific user.

eval { 
    $api_instance->media_list(from => $from, count => $count, status => $status, user => $user);
};
if ($@) {
    warn "Exception when calling MediaApi->media_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **status** | **int**| Used to filter the media items by their checkout status (0 &#x3D; CheckedIn, 1 &#x3D; CheckedOut, Unspecified &#x3D; All). | [optional] 
 **user** | [**string**](.md)| Used to filter the media items that are checked-out by a specific user. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **media_save**
> media_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a media item

Allows the user to create or edit a media item.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::MediaApi;
my $api_instance = WWW::OpenAPIClient::MediaApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the media item save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->media_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling MediaApi->media_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the media item save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

