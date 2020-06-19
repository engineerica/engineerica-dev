# WWW::OpenAPIClient::UserApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::UserApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**user_changepwd**](UserApi.md#user_changepwd) | **GET** /user/changepwd | Change user&#39;s own password
[**user_changepwdbyreq**](UserApi.md#user_changepwdbyreq) | **GET** /user/changepwdbyreq | Changes the user password using a change password request id
[**user_delete**](UserApi.md#user_delete) | **DELETE** /user/{id} | Delete a user
[**user_findsimilar**](UserApi.md#user_findsimilar) | **GET** /user/findsimilar | Finds similar users to prevent duplicates
[**user_get**](UserApi.md#user_get) | **GET** /user/{id} | Search and view details of a user
[**user_getbycard**](UserApi.md#user_getbycard) | **GET** /user/getbycard | Search user by card number
[**user_list**](UserApi.md#user_list) | **GET** /user/list | View a list of users
[**user_loadphoto**](UserApi.md#user_loadphoto) | **GET** /user/loadphoto | Upload a photo for a specific user
[**user_movedata**](UserApi.md#user_movedata) | **GET** /user/movedata | Move data between users
[**user_requestpwdchange**](UserApi.md#user_requestpwdchange) | **GET** /user/requestpwdchange | Requests a password change
[**user_save**](UserApi.md#user_save) | **POST** /user/{id} | Create or edit a user
[**user_savepwdchange**](UserApi.md#user_savepwdchange) | **POST** /user/savepwdchange | Send email to the specified user(s) to set/change their passwords


# **user_changepwd**
> user_changepwd(oldpass => $oldpass, newpass => $newpass)

Change user's own password

Allows the user to change their own password.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $oldpass = null; # string | The old password of the authenticated user.
my $newpass = null; # string | The new password of the authenticated user.

eval { 
    $api_instance->user_changepwd(oldpass => $oldpass, newpass => $newpass);
};
if ($@) {
    warn "Exception when calling UserApi->user_changepwd: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **oldpass** | [**string**](.md)| The old password of the authenticated user. | 
 **newpass** | [**string**](.md)| The new password of the authenticated user. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_changepwdbyreq**
> user_changepwdbyreq(changereq => $changereq, newpass => $newpass)

Changes the user password using a change password request id

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(
);

my $changereq = "changereq_example"; # string | The change password request ID sent by email to the user.
my $newpass = "newpass_example"; # string | The new password of the user.

eval { 
    $api_instance->user_changepwdbyreq(changereq => $changereq, newpass => $newpass);
};
if ($@) {
    warn "Exception when calling UserApi->user_changepwdbyreq: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **changereq** | **string**| The change password request ID sent by email to the user. | 
 **newpass** | **string**| The new password of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_delete**
> user_delete(id => $id, body => $body)

Delete a user

Allows the user to delete a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->user_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling UserApi->user_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_findsimilar**
> user_findsimilar(currentid => $currentid, phonenumber => $phonenumber, cardnumber => $cardnumber)

Finds similar users to prevent duplicates

Allows the user to be warned if a user they are creating has the same card number as another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $currentid = null; # string | The id of the current user.
my $phonenumber = "phonenumber_example"; # string | A phone number to search for similar users.
my $cardnumber = "cardnumber_example"; # string | A card number to search for similar users.

eval { 
    $api_instance->user_findsimilar(currentid => $currentid, phonenumber => $phonenumber, cardnumber => $cardnumber);
};
if ($@) {
    warn "Exception when calling UserApi->user_findsimilar: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currentid** | [**string**](.md)| The id of the current user. | [optional] 
 **phonenumber** | **string**| A phone number to search for similar users. | [optional] 
 **cardnumber** | **string**| A card number to search for similar users. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_get**
> user_get(id => $id, photosize => $photosize)

Search and view details of a user

Allows the user to search and view a user and their details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->user_get(id => $id, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling UserApi->user_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_getbycard**
> user_getbycard(card => $card, photosize => $photosize)

Search user by card number

Allows the user to search for a user by their card number.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $card = "card_example"; # string | The card number of the user to get.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->user_getbycard(card => $card, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling UserApi->user_getbycard: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **card** | **string**| The card number of the user to get. | 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_list**
> user_list(from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize)

View a list of users

Allows the user to view the full list of users and is based on role permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $roleid = null; # string | The id of the role to filter users by, or empty to return all users.
my $onlywithoutcard = "onlywithoutcard_example"; # string | If is 1 then only the users without a card are returned, otherwise all users are returned.
my $photosize = 56; # int | The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.

eval { 
    $api_instance->user_list(from => $from, count => $count, roleid => $roleid, onlywithoutcard => $onlywithoutcard, photosize => $photosize);
};
if ($@) {
    warn "Exception when calling UserApi->user_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **roleid** | [**string**](.md)| The id of the role to filter users by, or empty to return all users. | [optional] 
 **onlywithoutcard** | **string**| If is 1 then only the users without a card are returned, otherwise all users are returned. | [optional] 
 **photosize** | **int**| The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_loadphoto**
> user_loadphoto(upload => $upload, filename => $filename, userid => $userid, automatch => $automatch)

Upload a photo for a specific user

Allows the user to upload a photo for a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.
my $userid = null; # string | The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in 'user.save'.
my $automatch = null; # boolean | Set this to true to find the specific user based on the file name. 

eval { 
    $api_instance->user_loadphoto(upload => $upload, filename => $filename, userid => $userid, automatch => $automatch);
};
if ($@) {
    warn "Exception when calling UserApi->user_loadphoto: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **userid** | [**string**](.md)| The user ID to directly associate the upload photo. If not specified, a temp ID is returned that can be later specified in &#39;user.save&#39;. | [optional] 
 **automatch** | **boolean**| Set this to true to find the specific user based on the file name.  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_movedata**
> user_movedata(source => $source, destination => $destination)

Move data between users

Allows administrators to move data between users.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $source = null; # string | The id of the user that is the source of the data.
my $destination = null; # string | The id of the user that is the destination of the data.

eval { 
    $api_instance->user_movedata(source => $source, destination => $destination);
};
if ($@) {
    warn "Exception when calling UserApi->user_movedata: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | [**string**](.md)| The id of the user that is the source of the data. | 
 **destination** | [**string**](.md)| The id of the user that is the destination of the data. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_requestpwdchange**
> user_requestpwdchange(domain => $domain, email => $email)

Requests a password change

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(
);

my $domain = "domain_example"; # string | The domain of the account where the user exists.
my $email = "email_example"; # string | The email of the user.

eval { 
    $api_instance->user_requestpwdchange(domain => $domain, email => $email);
};
if ($@) {
    warn "Exception when calling UserApi->user_requestpwdchange: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The domain of the account where the user exists. | 
 **email** | **string**| The email of the user. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_save**
> user_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a user

Allows the user to create or edit a user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the user to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->user_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UserApi->user_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the user to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **user_savepwdchange**
> user_savepwdchange(unknown_base_type => $unknown_base_type)

Send email to the specified user(s) to set/change their passwords

Allows the user to trigger an email to another user asking them to set or change their password.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::UserApi;
my $api_instance = WWW::OpenAPIClient::UserApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->user_savepwdchange(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling UserApi->user_savepwdchange: $@\n";
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

