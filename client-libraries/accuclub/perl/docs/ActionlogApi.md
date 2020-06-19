# WWW::OpenAPIClient::ActionlogApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ActionlogApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**actionlog_list**](ActionlogApi.md#actionlog_list) | **GET** /actionlog/list | View a list of users action logs


# **actionlog_list**
> actionlog_list(from => $from, count => $count, user => $user, startdate => $startdate, enddate => $enddate, resource => $resource, actionfilter => $actionfilter, argument => $argument)

View a list of users action logs

Allows the user to view the audit logs for the account.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ActionlogApi;
my $api_instance = WWW::OpenAPIClient::ActionlogApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.
my $user = null; # string | The id of the user whose action logs have to be returned.
my $startdate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The start date of the period to filter the logs.
my $enddate = DateTime->from_epoch(epoch => str2time('null')); # DateTime | The end date of the period to filter the logs.
my $resource = "resource_example"; # string | The resource to filter the action logs.
my $actionfilter = "actionfilter_example"; # string | The action to filter the action logs.
my $argument = "argument_example"; # string | The id of the entity that was the argument of the executed action.

eval { 
    $api_instance->actionlog_list(from => $from, count => $count, user => $user, startdate => $startdate, enddate => $enddate, resource => $resource, actionfilter => $actionfilter, argument => $argument);
};
if ($@) {
    warn "Exception when calling ActionlogApi->actionlog_list: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **int**| The first record to return. | 
 **count** | **int**| The max number of records to return. | 
 **user** | [**string**](.md)| The id of the user whose action logs have to be returned. | [optional] 
 **startdate** | **DateTime**| The start date of the period to filter the logs. | [optional] 
 **enddate** | **DateTime**| The end date of the period to filter the logs. | [optional] 
 **resource** | **string**| The resource to filter the action logs. | [optional] 
 **actionfilter** | **string**| The action to filter the action logs. | [optional] 
 **argument** | **string**| The id of the entity that was the argument of the executed action. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

