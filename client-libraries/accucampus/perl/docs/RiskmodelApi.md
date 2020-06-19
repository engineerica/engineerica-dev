# WWW::OpenAPIClient::RiskmodelApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::RiskmodelApi;
```

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**riskmodel_checkanalysis**](RiskmodelApi.md#riskmodel_checkanalysis) | **GET** /riskmodel/checkanalysis | Check the status of the analysis of a specified risk assessment model
[**riskmodel_delete**](RiskmodelApi.md#riskmodel_delete) | **DELETE** /riskmodel/{id} | Delete a risk assessment model
[**riskmodel_get**](RiskmodelApi.md#riskmodel_get) | **GET** /riskmodel/{id} | View details of a risk assessment model
[**riskmodel_getscore**](RiskmodelApi.md#riskmodel_getscore) | **GET** /riskmodel/getscore | View the risk score for a specific user
[**riskmodel_list**](RiskmodelApi.md#riskmodel_list) | **GET** /riskmodel/list | View a list of risk assessment models
[**riskmodel_predict**](RiskmodelApi.md#riskmodel_predict) | **GET** /riskmodel/predict | Predict risk based on an assessment model
[**riskmodel_process**](RiskmodelApi.md#riskmodel_process) | **GET** /riskmodel/process | Process a risk assessment model
[**riskmodel_refresh**](RiskmodelApi.md#riskmodel_refresh) | **GET** /riskmodel/refresh | Refresh the information used in a risk assessment model
[**riskmodel_save**](RiskmodelApi.md#riskmodel_save) | **POST** /riskmodel/{id} | Create or edit a risk assessment model
[**riskmodel_termprecedences**](RiskmodelApi.md#riskmodel_termprecedences) | **GET** /riskmodel/termprecedences | View all default term precedences


# **riskmodel_checkanalysis**
> riskmodel_checkanalysis(id => $id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the risk assessment model whose analysis status has to be returned.

eval { 
    $api_instance->riskmodel_checkanalysis(id => $id);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_checkanalysis: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_delete**
> riskmodel_delete(id => $id, body => $body)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the risk assessment model to delete.
my $body = WWW::OpenAPIClient::Object::AnyType->new(); # AnyType | 

eval { 
    $api_instance->riskmodel_delete(id => $id, body => $body);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_delete: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the risk assessment model to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_get**
> riskmodel_get(id => $id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the risk assessment model to get.

eval { 
    $api_instance->riskmodel_get(id => $id);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_get: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the risk assessment model to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_getscore**
> riskmodel_getscore(userid => $userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $userid = null; # string | The id of the user to get the risk score.

eval { 
    $api_instance->riskmodel_getscore(userid => $userid);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_getscore: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**string**](.md)| The id of the user to get the risk score. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_list**
> riskmodel_list(from => $from, count => $count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $from = 56; # int | The first record to return.
my $count = 56; # int | The max number of records to return.

eval { 
    $api_instance->riskmodel_list(from => $from, count => $count);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_list: $@\n";
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

# **riskmodel_predict**
> riskmodel_predict(id => $id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the assessment model to use in order to predict risk.

eval { 
    $api_instance->riskmodel_predict(id => $id);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_predict: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_process**
> riskmodel_process(id => $id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the risk assessment model to process.

eval { 
    $api_instance->riskmodel_process(id => $id);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_process: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the risk assessment model to process. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_refresh**
> riskmodel_refresh(id => $id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the risk assessment model whose information has to be refreshed.

eval { 
    $api_instance->riskmodel_refresh(id => $id);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_refresh: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_save**
> riskmodel_save(id => $id, unknown_base_type => $unknown_base_type)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the department save (leave empty to create a new one).
my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->riskmodel_save(id => $id, unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_save: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the department save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **riskmodel_termprecedences**
> riskmodel_termprecedences()

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::RiskmodelApi;
my $api_instance = WWW::OpenAPIClient::RiskmodelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->riskmodel_termprecedences();
};
if ($@) {
    warn "Exception when calling RiskmodelApi->riskmodel_termprecedences: $@\n";
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

