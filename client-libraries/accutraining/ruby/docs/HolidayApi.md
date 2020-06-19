# OpenapiClient::HolidayApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**holiday_list**](HolidayApi.md#holiday_list) | **GET** /holiday/list | View a list of entered holidays
[**holiday_save**](HolidayApi.md#holiday_save) | **POST** /holiday/save | Create or edit a list of holidays
[**holiday_suggest**](HolidayApi.md#holiday_suggest) | **GET** /holiday/suggest | View the holiday suggestions in the given term



## holiday_list

> holiday_list(term)

View a list of entered holidays

Allows the user to view all holidays entered.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::HolidayApi.new
term = 'term_example' # String | The term to get holidays from.

begin
  #View a list of entered holidays
  api_instance.holiday_list(term)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling HolidayApi->holiday_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## holiday_save

> holiday_save(opts)

Create or edit a list of holidays

Allows the user to create or edit holidays.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::HolidayApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a list of holidays
  api_instance.holiday_save(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling HolidayApi->holiday_save: #{e}"
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


## holiday_suggest

> holiday_suggest(term)

View the holiday suggestions in the given term

Allows the user to view the holiday suggestions for each term.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::HolidayApi.new
term = 'term_example' # String | The term to get holidays from.

begin
  #View the holiday suggestions in the given term
  api_instance.holiday_suggest(term)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling HolidayApi->holiday_suggest: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | [**String**](.md)| The term to get holidays from. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

