# OpenapiClient::RiskmodelApi

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



## riskmodel_checkanalysis

> riskmodel_checkanalysis(id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the risk assessment model whose analysis status has to be returned.

begin
  #Check the status of the analysis of a specified risk assessment model
  api_instance.riskmodel_checkanalysis(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_checkanalysis: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_delete

> riskmodel_delete(id, opts)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the risk assessment model to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a risk assessment model
  api_instance.riskmodel_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the risk assessment model to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## riskmodel_get

> riskmodel_get(id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the risk assessment model to get.

begin
  #View details of a risk assessment model
  api_instance.riskmodel_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the risk assessment model to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_getscore

> riskmodel_getscore(userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
userid = 'userid_example' # String | The id of the user to get the risk score.

begin
  #View the risk score for a specific user
  api_instance.riskmodel_getscore(userid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_getscore: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| The id of the user to get the risk score. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_list

> riskmodel_list(from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.

begin
  #View a list of risk assessment models
  api_instance.riskmodel_list(from, count)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_list: #{e}"
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


## riskmodel_predict

> riskmodel_predict(id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the assessment model to use in order to predict risk.

begin
  #Predict risk based on an assessment model
  api_instance.riskmodel_predict(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_predict: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_process

> riskmodel_process(id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the risk assessment model to process.

begin
  #Process a risk assessment model
  api_instance.riskmodel_process(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_process: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the risk assessment model to process. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_refresh

> riskmodel_refresh(id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the risk assessment model whose information has to be refreshed.

begin
  #Refresh the information used in a risk assessment model
  api_instance.riskmodel_refresh(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_refresh: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## riskmodel_save

> riskmodel_save(id, opts)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new
id = 'id_example' # String | The id of the department save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a risk assessment model
  api_instance.riskmodel_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the department save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## riskmodel_termprecedences

> riskmodel_termprecedences

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::RiskmodelApi.new

begin
  #View all default term precedences
  api_instance.riskmodel_termprecedences
rescue OpenapiClient::ApiError => e
  puts "Exception when calling RiskmodelApi->riskmodel_termprecedences: #{e}"
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

