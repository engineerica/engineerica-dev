# OpenapiClient::TranslationApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**translation_get**](TranslationApi.md#translation_get) | **GET** /translation/get | Gets the translations of the specified values
[**translation_getcachefile**](TranslationApi.md#translation_getcachefile) | **GET** /translation/getcachefile | Get the file containing the translations
[**translation_list**](TranslationApi.md#translation_list) | **GET** /translation/list | Lists all the available translations in the system
[**translation_save**](TranslationApi.md#translation_save) | **POST** /translation/{id} | Edit a translation



## translation_get

> translation_get(universal)

Gets the translations of the specified values

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TranslationApi.new
universal = 'universal_example' # String | Pipe separated list of universal text to be translated.

begin
  #Gets the translations of the specified values
  api_instance.translation_get(universal)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TranslationApi->translation_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **universal** | **String**| Pipe separated list of universal text to be translated. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translation_getcachefile

> translation_getcachefile(opts)

Get the file containing the translations

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TranslationApi.new
opts = {
  account: 'account_example' # String | The id of the account whose translations file has to be retrieved.
}

begin
  #Get the file containing the translations
  api_instance.translation_getcachefile(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TranslationApi->translation_getcachefile: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account** | **String**| The id of the account whose translations file has to be retrieved. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translation_list

> translation_list(opts)

Lists all the available translations in the system

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TranslationApi.new
opts = {
  filter: 'filter_example', # String | Text to search/filter translations.
  nondefaultonly: true, # Boolean | If true then it returns only the terms translated. Otherwise, it returns all.
  appdefaultasuniversal: true # Boolean | If true then it uses the app default translation as the universal term.
}

begin
  #Lists all the available translations in the system
  api_instance.translation_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TranslationApi->translation_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **String**| Text to search/filter translations. | [optional] 
 **nondefaultonly** | **Boolean**| If true then it returns only the terms translated. Otherwise, it returns all. | [optional] 
 **appdefaultasuniversal** | **Boolean**| If true then it uses the app default translation as the universal term. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## translation_save

> translation_save(id, opts)

Edit a translation

Allows the user to edit a translation for the entire account.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TranslationApi.new
id = 'id_example' # String | The id of the translation as returned by translation.list.
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Edit a translation
  api_instance.translation_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TranslationApi->translation_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| The id of the translation as returned by translation.list. | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

