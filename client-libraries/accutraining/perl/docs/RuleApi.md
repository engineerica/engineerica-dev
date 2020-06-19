# WWW::OpenAPIClient::RuleApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::RuleApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**rule_delete**](RuleApi.md#rule_delete) | **DELETE** /rule/{id} | Delete a rule
[**rule_get**](RuleApi.md#rule_get) | **GET** /rule/{id} | View details of a rule
[**rule_geteventtype**](RuleApi.md#rule_geteventtype) | **GET** /rule/geteventtype | View details of a rule event type
[**rule_list**](RuleApi.md#rule_list) | **GET** /rule/list | View a list of user rules
[**rule_listactions**](RuleApi.md#rule_listactions) | **GET** /rule/listactions | View a list of rule actions available
[**rule_listeventtypes**](RuleApi.md#rule_listeventtypes) | **GET** /rule/listeventtypes | View a list of rule event types
[**rule_listhttprequests**](RuleApi.md#rule_listhttprequests) | **GET** /rule/listhttprequests | View all the http requests sent as a result of a rule
[**rule_save**](RuleApi.md#rule_save) | **POST** /rule/{id} | Create or edit a rule


# **rule_delete**
> rule_delete(id => $id, body => $body)

Delete a rule

Allows the user to delete an existing rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the rule to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->rule_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the rule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rule_get**
> rule_get(id => $id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the rule to get.

eval { 
    $api_instance->rule_get(id => $id);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the rule to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rule_geteventtype**
> rule_geteventtype(event => $event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $event = "event_example"; # string | The name of the event to refresh.

eval { 
    $api_instance->rule_geteventtype(event => $event);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_geteventtype: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **event** | **string**| The name of the event to refresh. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rule_list**
> rule_list(from => $from, count => $count)

View a list of user rules

Allows the user to view the list of all rules.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->rule_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_list: $@\n";
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

# **rule_listactions**
> rule_listactions()

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->rule_listactions();
};
if ($@) {
    warn "Exception when calling RuleApi->rule_listactions: $@\n";
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

# **rule_listeventtypes**
> rule_listeventtypes()

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->rule_listeventtypes();
};
if ($@) {
    warn "Exception when calling RuleApi->rule_listeventtypes: $@\n";
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

# **rule_listhttprequests**
> rule_listhttprequests(from => $from, count => $count, failed => $failed, status => $status)

View all the http requests sent as a result of a rule

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $failed = null; # boolean | If true only failed requests will be returned
my $status = 56; # int | The http status to filter the requests

eval { 
    $api_instance->rule_listhttprequests(from => $from, count => $count, failed => $failed, status => $status);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_listhttprequests: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **failed** | **boolean**| If true only failed requests will be returned | [optional] 
 **status** | **int**| The http status to filter the requests | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **rule_save**
> rule_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a rule

Allows the user to create or edit a rule.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RuleApi;
my $api_instance = WWW::OpenAPIClient::RuleApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the rule to save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->rule_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling RuleApi->rule_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the rule to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

