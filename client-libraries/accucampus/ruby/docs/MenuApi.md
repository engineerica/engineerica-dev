# OpenapiClient::MenuApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**menu_getitems**](MenuApi.md#menu_getitems) | **GET** /menu/getitems | Gets the items on the menu



## menu_getitems

> menu_getitems(menuid)

Gets the items on the menu

### Example

```ruby
# load the gem
require 'openapi_client'

api_instance = OpenapiClient::MenuApi.new
menuid = 'menuid_example' # String | The Id of the menu to get.

begin
  #Gets the items on the menu
  api_instance.menu_getitems(menuid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling MenuApi->menu_getitems: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **menuid** | **String**| The Id of the menu to get. | 

### Return type

nil (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

