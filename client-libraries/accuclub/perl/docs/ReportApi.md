# WWW::OpenAPIClient::ReportApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::ReportApi;
```

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**report_list**](ReportApi.md#report_list) | **GET** /report/list | View a list of available reports
[**report_permissionsbyuser**](ReportApi.md#report_permissionsbyuser) | **GET** /report/permissionsbyuser | Permissions by user report
[**report_prepare**](ReportApi.md#report_prepare) | **GET** /report/prepare | Queries and loads the specified report, in background.
[**report_query**](ReportApi.md#report_query) | **GET** /report/query | Query and load a specified report


# **report_list**
> report_list()

View a list of available reports

Allows the user to view the complete list of available, canned reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportApi;
my $api_instance = WWW::OpenAPIClient::ReportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->report_list();
};
if ($@) {
    warn "Exception when calling ReportApi->report_list: $@\n";
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

# **report_permissionsbyuser**
> report_permissionsbyuser(params => $params)

Permissions by user report

Lists all the users in the system including their corresponding permissions.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportApi;
my $api_instance = WWW::OpenAPIClient::ReportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

eval { 
    $api_instance->report_permissionsbyuser(params => $params);
};
if ($@) {
    warn "Exception when calling ReportApi->report_permissionsbyuser: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_prepare**
> report_prepare(reportname => $reportname, params => $params, repformat => $repformat, fillgroupid => $fillgroupid, groupby => $groupby, refreshgroup => $refreshgroup, filtertext => $filtertext)

Queries and loads the specified report, in background.

Allows the user to run reports, in background, with the exception of attendance analytics reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportApi;
my $api_instance = WWW::OpenAPIClient::ReportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $reportname = "reportname_example"; # string | The name of the report to execute
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3
my $repformat = "repformat_example"; # string | The format of the resulting report. Json, pdf, csv, ...
my $fillgroupid = null; # string | If specified, the result is used to fill the group with the given ID
my $groupby = "groupby_example"; # string | How to group the records. In the format 'col1+col2|col3+col4
my $refreshgroup = null; # string | The ID of the group to check (and refresh) before processing the report.
my $filtertext = "filtertext_example"; # string | The user friendly text of the applied filters.

eval { 
    $api_instance->report_prepare(reportname => $reportname, params => $params, repformat => $repformat, fillgroupid => $fillgroupid, groupby => $groupby, refreshgroup => $refreshgroup, filtertext => $filtertext);
};
if ($@) {
    warn "Exception when calling ReportApi->report_prepare: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 
 **repformat** | **string**| The format of the resulting report. Json, pdf, csv, ... | [optional] 
 **fillgroupid** | [**string**](.md)| If specified, the result is used to fill the group with the given ID | [optional] 
 **groupby** | **string**| How to group the records. In the format &#39;col1+col2|col3+col4 | [optional] 
 **refreshgroup** | [**string**](.md)| The ID of the group to check (and refresh) before processing the report. | [optional] 
 **filtertext** | **string**| The user friendly text of the applied filters. | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **report_query**
> report_query(reportname => $reportname, params => $params)

Query and load a specified report

Allows the user to run reports with the exception of attendance analytics reports.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::ReportApi;
my $api_instance = WWW::OpenAPIClient::ReportApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $reportname = "reportname_example"; # string | The name of the report to execute
my $params = "params_example"; # string | A pipe separated list of the parameters. Example: key1=value1|key2=value2|key3=value3

eval { 
    $api_instance->report_query(reportname => $reportname, params => $params);
};
if ($@) {
    warn "Exception when calling ReportApi->report_query: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **reportname** | **string**| The name of the report to execute | 
 **params** | **string**| A pipe separated list of the parameters. Example: key1&#x3D;value1|key2&#x3D;value2|key3&#x3D;value3 | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

