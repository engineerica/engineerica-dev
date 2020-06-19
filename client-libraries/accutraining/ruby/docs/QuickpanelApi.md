# OpenapiClient::QuickpanelApi

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



## quickpanel_deletewidget

> quickpanel_deletewidget(opts)

Deletes a widget from the Quick Panel

Allows the user to delete a widget that has been added to the Quick Panel.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Deletes a widget from the Quick Panel
  api_instance.quickpanel_deletewidget(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_deletewidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## quickpanel_fetchwidget

> quickpanel_fetchwidget(widgetid)

Fetches the information for a specific widget.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new
widgetid = 'widgetid_example' # String | The ID of the data to fetch it's data.

begin
  #Fetches the information for a specific widget.
  api_instance.quickpanel_fetchwidget(widgetid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_fetchwidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **widgetid** | [**String**](.md)| The ID of the data to fetch it&#39;s data. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_getwidget

> quickpanel_getwidget(id)

View details of a widget included in the Quick Panel

Allows the user to view a widget added in as Quick Panel.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new
id = 'id_example' # String | The id of the widget to get.

begin
  #View details of a widget included in the Quick Panel
  api_instance.quickpanel_getwidget(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_getwidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the widget to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_init

> quickpanel_init

Returns the initial information required to show the quick panels

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new

begin
  #Returns the initial information required to show the quick panels
  api_instance.quickpanel_init
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_init: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_listwidgets

> quickpanel_listwidgets

Lists all the widgets that are added in the Quick Panel

Allows the user to view the widgets that have been added to the Quick Panel.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new

begin
  #Lists all the widgets that are added in the Quick Panel
  api_instance.quickpanel_listwidgets
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_listwidgets: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_listwidgettypes

> quickpanel_listwidgettypes

Lists all the widget types available in the system

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new

begin
  #Lists all the widget types available in the system
  api_instance.quickpanel_listwidgettypes
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_listwidgettypes: #{e}"
end
```

### Parameters

This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_reorderwidgets

> quickpanel_reorderwidgets(sectionname, orderids)

Reorders the widgets and moves them to a specific column

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new
sectionname = 'sectionname_example' # String | The section name where to sort the widgets.
orderids = 'orderids_example' # String | CSV list of the widgets to reorder.

begin
  #Reorders the widgets and moves them to a specific column
  api_instance.quickpanel_reorderwidgets(sectionname, orderids)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_reorderwidgets: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sectionname** | **String**| The section name where to sort the widgets. | 
 **orderids** | **String**| CSV list of the widgets to reorder. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## quickpanel_savewidget

> quickpanel_savewidget(opts)

Saves a widget for the Quick Panel

Allows the user to save a widget to the Quick Panel.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::QuickpanelApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a widget for the Quick Panel
  api_instance.quickpanel_savewidget(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling QuickpanelApi->quickpanel_savewidget: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

