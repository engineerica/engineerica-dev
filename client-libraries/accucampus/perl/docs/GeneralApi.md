# WWW::OpenAPIClient::GeneralApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::GeneralApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**changelog**](GeneralApi.md#changelog) | **GET** /changelog | Get the application change log
[**doc**](GeneralApi.md#doc) | **GET** /doc | Get the documentation
[**export**](GeneralApi.md#export) | **GET** /export | Export AccuCampus data
[**import**](GeneralApi.md#import) | **GET** /import | Import data into AccuCampus
[**listtimezones**](GeneralApi.md#listtimezones) | **GET** /listtimezones | Lists the available timezones
[**login**](GeneralApi.md#login) | **GET** /login | Login
[**logout**](GeneralApi.md#logout) | **GET** /logout | Logout
[**search**](GeneralApi.md#search) | **GET** /search | Search
[**texttoimage**](GeneralApi.md#texttoimage) | **GET** /texttoimage | Generates a dynamic image from text
[**version**](GeneralApi.md#version) | **GET** /version | Get current version information


# **changelog**
> changelog()

Get the application change log

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->changelog();
};
if ($@) {
    warn "Exception when calling GeneralApi->changelog: $@\n";
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

# **doc**
> doc(excludeanonymous => $excludeanonymous)

Get the documentation

Retrieves the list of actions available in the system.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(
);

my $excludeanonymous = null; # boolean | If true it excludes the anonymous actions from the returned list.

eval { 
    $api_instance->doc(excludeanonymous => $excludeanonymous);
};
if ($@) {
    warn "Exception when calling GeneralApi->doc: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **excludeanonymous** | **boolean**| If true it excludes the anonymous actions from the returned list. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **export**
> export(exporttype => $exporttype, exportformat => $exportformat, filters => $filters)

Export AccuCampus data

Allows the user to export data from AccuCampus into a CSV, HTML, or Excel format.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $exporttype = "exporttype_example"; # string | What to export.
my $exportformat = "exportformat_example"; # string | The format of the resulting file. Valid types are CSV, HTML, XLS.
my $filters = "filters_example"; # string | Pipe separated filters for the export, eg: aaa=val|bbb=val|...

eval { 
    $api_instance->export(exporttype => $exporttype, exportformat => $exportformat, filters => $filters);
};
if ($@) {
    warn "Exception when calling GeneralApi->export: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **exporttype** | **string**| What to export. | 
 **exportformat** | **string**| The format of the resulting file. Valid types are CSV, HTML, XLS. | 
 **filters** | **string**| Pipe separated filters for the export, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **import**
> import(importtype => $importtype, upload => $upload, filename => $filename, parameters => $parameters)

Import data into AccuCampus

Allows the user to import data into AccuCampus via CSV or flat files either manually or automatically using the import utility.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $importtype = "importtype_example"; # string | The kind of data that is being uploaded.
my $upload = "upload_example"; # string | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
my $filename = "filename_example"; # string | The local name of the uploaded file. For later reference.
my $parameters = "parameters_example"; # string | Import parameters, in a key-value pair JSON-serialized object. Eg {'parameter':'value'}.

eval { 
    $api_instance->import(importtype => $importtype, upload => $upload, filename => $filename, parameters => $parameters);
};
if ($@) {
    warn "Exception when calling GeneralApi->import: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **importtype** | **string**| The kind of data that is being uploaded. | 
 **upload** | **string**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **string**| The local name of the uploaded file. For later reference. | [optional] 
 **parameters** | **string**| Import parameters, in a key-value pair JSON-serialized object. Eg {&#39;parameter&#39;:&#39;value&#39;}. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **listtimezones**
> listtimezones()

Lists the available timezones

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(
);


eval { 
    $api_instance->listtimezones();
};
if ($@) {
    warn "Exception when calling GeneralApi->listtimezones: $@\n";
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **login**
> login(domain => $domain, username => $username, password => $password, method => $method, rememberme => $rememberme)

Login

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(
);

my $domain = "domain_example"; # string | The account domain to login.
my $username = "username_example"; # string | The username (email) of the user to login as.
my $password = "password_example"; # string | The password of the user to login as.
my $method = "method_example"; # string | The authentication method. Valid values are 'token' and 'cookie'.
my $rememberme = null; # boolean | If true then the session will not expire.

eval { 
    $api_instance->login(domain => $domain, username => $username, password => $password, method => $method, rememberme => $rememberme);
};
if ($@) {
    warn "Exception when calling GeneralApi->login: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **domain** | **string**| The account domain to login. | 
 **username** | **string**| The username (email) of the user to login as. | 
 **password** | **string**| The password of the user to login as. | 
 **method** | **string**| The authentication method. Valid values are &#39;token&#39; and &#39;cookie&#39;. | 
 **rememberme** | **boolean**| If true then the session will not expire. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logout**
> logout()

Logout

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->logout();
};
if ($@) {
    warn "Exception when calling GeneralApi->logout: $@\n";
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

# **search**
> search(query => $query, page => $page)

Search

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $query = "query_example"; # string | The query to search for.
my $page = 56; # int | Current page to show, zero-based.

eval { 
    $api_instance->search(query => $query, page => $page);
};
if ($@) {
    warn "Exception when calling GeneralApi->search: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **query** | **string**| The query to search for. | 
 **page** | **int**| Current page to show, zero-based. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **texttoimage**
> texttoimage(text => $text, fontcolor => $fontcolor, fontsize => $fontsize, direction => $direction, width => $width)

Generates a dynamic image from text

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $text = "text_example"; # string | The text to convert to an image, use double pipes (||) as a new line.
my $fontcolor = "fontcolor_example"; # string | The color of the text, in hex format, without the #.
my $fontsize = 56; # int | The size of the text, in points.
my $direction = "direction_example"; # string | Either vertical or horizontal, default horizontal.
my $width = 56; # int | The image width in pixels (or height if the direction is vertical).

eval { 
    $api_instance->texttoimage(text => $text, fontcolor => $fontcolor, fontsize => $fontsize, direction => $direction, width => $width);
};
if ($@) {
    warn "Exception when calling GeneralApi->texttoimage: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **text** | **string**| The text to convert to an image, use double pipes (||) as a new line. | 
 **fontcolor** | **string**| The color of the text, in hex format, without the #. | [optional] 
 **fontsize** | **int**| The size of the text, in points. | [optional] 
 **direction** | **string**| Either vertical or horizontal, default horizontal. | [optional] 
 **width** | **int**| The image width in pixels (or height if the direction is vertical). | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **version**
> version()

Get current version information

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::GeneralApi;
my $api_instance = WWW::OpenAPIClient::GeneralApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->version();
};
if ($@) {
    warn "Exception when calling GeneralApi->version: $@\n";
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

