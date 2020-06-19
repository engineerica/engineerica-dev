# OpenapiClient::TemplateApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**template_addimage**](TemplateApi.md#template_addimage) | **GET** /template/addimage | Add an image to a template
[**template_delete**](TemplateApi.md#template_delete) | **DELETE** /template/{id} | Delete a template
[**template_email**](TemplateApi.md#template_email) | **GET** /template/email | Send generated templates by email
[**template_generate**](TemplateApi.md#template_generate) | **GET** /template/generate | Generate specified templates
[**template_get**](TemplateApi.md#template_get) | **GET** /template/{id} | View details of a template
[**template_getgenerated**](TemplateApi.md#template_getgenerated) | **GET** /template/getgenerated | View generated templates
[**template_list**](TemplateApi.md#template_list) | **GET** /template/list | View a list of defined templates
[**template_listsources**](TemplateApi.md#template_listsources) | **GET** /template/listsources | View a list of templates&#39; data sources
[**template_save**](TemplateApi.md#template_save) | **POST** /template/{id} | Create or edit a template
[**template_savelayout**](TemplateApi.md#template_savelayout) | **POST** /template/savelayout | Save the layout of a template



## template_addimage

> template_addimage(template, upload, opts)

Add an image to a template

Allows the user to add an image to a badge or certificate template.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
template = 'template_example' # String | The id of the template where the image has to be added
upload = 'upload_example' # String | Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).
opts = {
  filename: 'filename_example' # String | The local name of the uploaded file. For later reference.
}

begin
  #Add an image to a template
  api_instance.template_addimage(template, upload, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_addimage: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**String**](.md)| The id of the template where the image has to be added | 
 **upload** | **String**| Set &#39;file&#39; as value to indicate that a file is being submitted in the body (instead of a JSON object). | 
 **filename** | **String**| The local name of the uploaded file. For later reference. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_delete

> template_delete(id, opts)

Delete a template

Allows the user to delete an existing template.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
id = 'id_example' # String | The id of the template to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a template
  api_instance.template_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## template_email

> template_email(jobid, emailsubject, emailbody, opts)

Send generated templates by email

Allows the user to send generated templates via email through AccuTraining.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
jobid = 'jobid_example' # String | The id of the job that is creating the templates.
emailsubject = 'emailsubject_example' # String | Args depending on the send-to flag.
emailbody = 'emailbody_example' # String | Args depending on the send-to flag.
opts = {
  templatekind: 'templatekind_example', # String | The kind of the template you're sending. It must be included in (badge, certificate).
  emailfrom: 'emailfrom_example', # String | The name of the sender to be displayed in the receipients inbox
  emailreplyto: 'emailreplyto_example' # String | The reply-to field for the emails.
}

begin
  #Send generated templates by email
  api_instance.template_email(jobid, emailsubject, emailbody, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_email: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. | 
 **emailsubject** | **String**| Args depending on the send-to flag. | 
 **emailbody** | **String**| Args depending on the send-to flag. | 
 **templatekind** | **String**| The kind of the template you&#39;re sending. It must be included in (badge, certificate). | [optional] 
 **emailfrom** | **String**| The name of the sender to be displayed in the receipients inbox | [optional] 
 **emailreplyto** | **String**| The reply-to field for the emails. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_generate

> template_generate(template, source, singlefile, opts)

Generate specified templates

Allows the user to generate an existing template as badges or certificates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
template = 'template_example' # String | The id of the template to generate.
source = 'source_example' # String | The source key of the selected template data source.
singlefile = true # Boolean | True if all the templates should be placed in the same file, false if each one shoud be in its own file.
opts = {
  userid: 'userid_example', # String | Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.
  forsending: true, # Boolean | It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading
  role: 'role_example', # String | When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor
  filters: 'filters_example' # String | Pipe separated filters for the generation, eg: aaa=val|bbb=val|...
}

begin
  #Generate specified templates
  api_instance.template_generate(template, source, singlefile, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_generate: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **template** | [**String**](.md)| The id of the template to generate. | 
 **source** | [**String**](.md)| The source key of the selected template data source. | 
 **singlefile** | **Boolean**| True if all the templates should be placed in the same file, false if each one shoud be in its own file. | 
 **userid** | **String**| Only the template for these users is created (and emailed if &#39;email&#39; is true), enter multiple separated by commas. | [optional] 
 **forsending** | **Boolean**| It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading | [optional] 
 **role** | [**String**](.md)| When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor | [optional] 
 **filters** | **String**| Pipe separated filters for the generation, eg: aaa&#x3D;val|bbb&#x3D;val|... | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_get

> template_get(id)

View details of a template

Allows the user to view a template and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
id = 'id_example' # String | The id of the template to get.

begin
  #View details of a template
  api_instance.template_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_getgenerated

> template_getgenerated(jobid)

View generated templates

Allows the user to view templates which have been generated as badges or certificates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
jobid = 'jobid_example' # String | The id of the job that is creating the templates.

begin
  #View generated templates
  api_instance.template_getgenerated(jobid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_getgenerated: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| The id of the job that is creating the templates. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_list

> template_list(from, count, kind, opts)

View a list of defined templates

Allows the user to view the full list of created templates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
from = 56 # Integer | The first record to return.
count = 56 # Integer | The max number of records to return.
kind = 'kind_example' # String | The kind of the templates to return. It must be included in (badge, certificate).
opts = {
  designedonly: true # Boolean | If true then it only returns the templates that were designed. Otherwise, it returns all.
}

begin
  #View a list of defined templates
  api_instance.template_list(from, count, kind, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **Integer**| The first record to return. | 
 **count** | **Integer**| The max number of records to return. | 
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 
 **designedonly** | **Boolean**| If true then it only returns the templates that were designed. Otherwise, it returns all. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_listsources

> template_listsources(kind)

View a list of templates' data sources

Allows the user to see tokens to be used in the template

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
kind = 'kind_example' # String | The kind of the templates to return. It must be included in (badge, certificate).

begin
  #View a list of templates' data sources
  api_instance.template_listsources(kind)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_listsources: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **String**| The kind of the templates to return. It must be included in (badge, certificate). | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## template_save

> template_save(id, opts)

Create or edit a template

Allows the user to create or edit a template.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
id = 'id_example' # String | The id of the template to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a template
  api_instance.template_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the template to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## template_savelayout

> template_savelayout(opts)

Save the layout of a template

Allows the user to edit a template's layout.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::TemplateApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Save the layout of a template
  api_instance.template_savelayout(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling TemplateApi->template_savelayout: #{e}"
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

