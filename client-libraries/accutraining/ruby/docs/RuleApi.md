# OpenapiClient::RuleApi

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



## rule_delete

> rule_delete(id, opts)

Delete a rule

Allows the user to delete an existing rule.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
id = 'id_example' # String | The id of the rule to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a rule
  api_instance.rule_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the rule to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## rule_get

> rule_get(id)

View details of a rule

Allows the user to view an individual rule and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
id = 'id_example' # String | The id of the rule to get.

begin
  #View details of a rule
  api_instance.rule_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the rule to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rule_geteventtype

> rule_geteventtype(event)

View details of a rule event type

Allows the user to view the trigger and its available conditions for the rule.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
event = 'event_example' # String | The name of the event to refresh.

begin
  #View details of a rule event type
  api_instance.rule_geteventtype(event)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_geteventtype: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **event** | **String**| The name of the event to refresh. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rule_list

> rule_list(from, count)

View a list of user rules

Allows the user to view the list of all rules.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of user rules
  api_instance.rule_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rule_listactions

> rule_listactions

View a list of rule actions available

Allows the user to view all the available rule actions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new

begin
  #View a list of rule actions available
  api_instance.rule_listactions
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_listactions: #{e}"
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


## rule_listeventtypes

> rule_listeventtypes

View a list of rule event types

Allows the user to view a list of available triggers for rules.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new

begin
  #View a list of rule event types
  api_instance.rule_listeventtypes
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_listeventtypes: #{e}"
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


## rule_listhttprequests

> rule_listhttprequests(from, count, opts)

View all the http requests sent as a result of a rule

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
opts = {
  failed: true, # Boolean | If true only failed requests will be returned
  status: 56 # Integer | The http status to filter the requests
}

begin
  #View all the http requests sent as a result of a rule
  api_instance.rule_listhttprequests(from, count, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_listhttprequests: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **failed** | **Boolean**| If true only failed requests will be returned | [optional] 
 **status** | **Integer**| The http status to filter the requests | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## rule_save

> rule_save(id, opts)

Create or edit a rule

Allows the user to create or edit a rule.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RuleApi.new
id = 'id_example' # String | The id of the rule to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a rule
  api_instance.rule_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RuleApi->rule_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the rule to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

