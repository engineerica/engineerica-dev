# WWW::OpenAPIClient::QuickpanelApi

## Load the API package
```perl
use WWW::OpenAPIClient::Object::QuickpanelApi;
```

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**quickpanel_deletewidget**](QuickpanelApi.md#quickpanel_deletewidget) | **DELETE** /quickpanel/deletewidget | Deletes a widget from the Quick Panel
[**quickpanel_fetchwidget**](QuickpanelApi.md#quickpanel_fetchwidget) | **GET** /quickpanel/fetchwidget | Fetches the information for a specific widget.
[**quickpanel_getwidget**](QuickpanelApi.md#quickpanel_getwidget) | **GET** /quickpanel/getwidget | View details of a widget included in the Quick Panel
[**quickpanel_init**](QuickpanelApi.md#quickpanel_init) | **GET** /quickpanel/init | Returns the initial information required to show the quick panels
[**quickpanel_listwidgets**](QuickpanelApi.md#quickpanel_listwidgets) | **GET** /quickpanel/listwidgets | Lists all the widgets that are added in the Quick Panel
[**quickpanel_listwidgettypes**](QuickpanelApi.md#quickpanel_listwidgettypes) | **GET** /quickpanel/listwidgettypes | Lists all the widget types available in the system
[**quickpanel_reorderwidgets**](QuickpanelApi.md#quickpanel_reorderwidgets) | **GET** /quickpanel/reorderwidgets | Reorders the widgets and moves them to a specific column
[**quickpanel_savewidget**](QuickpanelApi.md#quickpanel_savewidget) | **POST** /quickpanel/savewidget | Saves a widget for the Quick Panel


# **quickpanel_deletewidget**
> quickpanel_deletewidget(unknown_base_type => $unknown_base_type)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->quickpanel_deletewidget(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_deletewidget: $@\n";
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

# **quickpanel_fetchwidget**
> quickpanel_fetchwidget(widgetid => $widgetid)

Fetches the information for a specific widget.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $widgetid = null; # string | The ID of the data to fetch it's data.

eval { 
    $api_instance->quickpanel_fetchwidget(widgetid => $widgetid);
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_fetchwidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **widgetid** | [**string**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanel_getwidget**
> quickpanel_getwidget(id => $id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $id = null; # string | The id of the widget to get.

eval { 
    $api_instance->quickpanel_getwidget(id => $id);
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_getwidget: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**string**](.md)| The id of the widget to get. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanel_init**
> quickpanel_init()

Returns the initial information required to show the quick panels

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->quickpanel_init();
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_init: $@\n";
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

# **quickpanel_listwidgets**
> quickpanel_listwidgets()

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->quickpanel_listwidgets();
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_listwidgets: $@\n";
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

# **quickpanel_listwidgettypes**
> quickpanel_listwidgettypes()

Lists all the widget types available in the system

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);


eval { 
    $api_instance->quickpanel_listwidgettypes();
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_listwidgettypes: $@\n";
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

# **quickpanel_reorderwidgets**
> quickpanel_reorderwidgets(sectionname => $sectionname, orderids => $orderids)

Reorders the widgets and moves them to a specific column

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $sectionname = "sectionname_example"; # string | The section name where to sort the widgets.
my $orderids = "orderids_example"; # string | CSV list of the widgets to reorder.

eval { 
    $api_instance->quickpanel_reorderwidgets(sectionname => $sectionname, orderids => $orderids);
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_reorderwidgets: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionname** | **string**| The section name where to sort the widgets. | 
 **orderids** | **string**| CSV list of the widgets to reorder. | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **quickpanel_savewidget**
> quickpanel_savewidget(unknown_base_type => $unknown_base_type)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example 
```perl
use Data::Dumper;
use WWW::OpenAPIClient::QuickpanelApi;
my $api_instance = WWW::OpenAPIClient::QuickpanelApi->new(

    # Configure HTTP basic authorization: bearerAuth
    # Configure bearer access token for authorization: bearerAuth
    access_token => 'YOUR_BEARER_TOKEN',
    
);

my $unknown_base_type = WWW::OpenAPIClient::Object::UNKNOWN_BASE_TYPE->new(); # UNKNOWN_BASE_TYPE | 

eval { 
    $api_instance->quickpanel_savewidget(unknown_base_type => $unknown_base_type);
};
if ($@) {
    warn "Exception when calling QuickpanelApi->quickpanel_savewidget: $@\n";
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

