# OpenapiClient::AdvroleApi

All URIs are relative to *https://accuclub.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**advrole_addmissing**](AdvroleApi.md#advrole_addmissing) | **GET** /advrole/addmissing | Adds the missing permissions to a role. Requires access to advrole.save
[**advrole_checkperm**](AdvroleApi.md#advrole_checkperm) | **GET** /advrole/checkperm | Checks the permissions are assigned for the given roles
[**advrole_delete**](AdvroleApi.md#advrole_delete) | **DELETE** /advrole/{id} | Delete a role
[**advrole_deletemapping**](AdvroleApi.md#advrole_deletemapping) | **DELETE** /advrole/deletemapping | Delete a role mapping
[**advrole_get**](AdvroleApi.md#advrole_get) | **GET** /advrole/{id} | View details of a role
[**advrole_list**](AdvroleApi.md#advrole_list) | **GET** /advrole/list | Lists the roles for the current account
[**advrole_listmaps**](AdvroleApi.md#advrole_listmaps) | **GET** /advrole/listmaps | Lists the maps a roles is mapped to
[**advrole_listrolesmapped**](AdvroleApi.md#advrole_listrolesmapped) | **GET** /advrole/listrolesmapped | Lists the roles mappings
[**advrole_listtemplates**](AdvroleApi.md#advrole_listtemplates) | **GET** /advrole/listtemplates | View a list of role templates
[**advrole_save**](AdvroleApi.md#advrole_save) | **POST** /advrole/{id} | Create or edit a role
[**advrole_savemapping**](AdvroleApi.md#advrole_savemapping) | **POST** /advrole/savemapping | Saves a role mapping
[**advrole_userupgrade**](AdvroleApi.md#advrole_userupgrade) | **GET** /advrole/userupgrade | Upgrade a user to another role (requires permission to edit those roles)



## advrole_addmissing

> advrole_addmissing(roles, permissions)

Adds the missing permissions to a role. Requires access to advrole.save

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
roles = 'roles_example' # String | CSV list of the role ids to check
permissions = 'permissions_example' # String | CSV list of the permissions to check

begin
  #Adds the missing permissions to a role. Requires access to advrole.save
  api_instance.advrole_addmissing(roles, permissions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_addmissing: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_checkperm

> advrole_checkperm(roles, permissions)

Checks the permissions are assigned for the given roles

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
roles = 'roles_example' # String | CSV list of the role ids to check
permissions = 'permissions_example' # String | CSV list of the permissions to check

begin
  #Checks the permissions are assigned for the given roles
  api_instance.advrole_checkperm(roles, permissions)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_checkperm: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roles** | **String**| CSV list of the role ids to check | 
 **permissions** | **String**| CSV list of the permissions to check | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_delete

> advrole_delete(id, opts)

Delete a role

Allows the user to delete a role from the list of available roles.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
id = 'id_example' # String | The id of the location to delete.
opts = {
  body: OpenapiClient::AnyType.new # AnyType | 
}

begin
  #Delete a role
  api_instance.advrole_delete(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_delete: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the location to delete. | 
 **body** | **AnyType**|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrole_deletemapping

> advrole_deletemapping(opts)

Delete a role mapping

Allows the user to delete a role from its mapped categories on the 'Role Mapping' page.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Delete a role mapping
  api_instance.advrole_deletemapping(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_deletemapping: #{e}"
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


## advrole_get

> advrole_get(id)

View details of a role

Allows the user to view a role and its details.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
id = 'id_example' # String | The id of the location to get.

begin
  #View details of a role
  api_instance.advrole_get(id)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_get: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the location to get. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_list

> advrole_list(opts)

Lists the roles for the current account

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
opts = {
  includepolicies: true, # Boolean | True to include the policies, defaults to false.
  includeinternal: true, # Boolean | True to include the internal roles too.
  name: 'name_example' # String | Filter by name of the role.
}

begin
  #Lists the roles for the current account
  api_instance.advrole_list(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_list: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **includepolicies** | **Boolean**| True to include the policies, defaults to false. | [optional] 
 **includeinternal** | **Boolean**| True to include the internal roles too. | [optional] 
 **name** | **String**| Filter by name of the role. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_listmaps

> advrole_listmaps(roleid)

Lists the maps a roles is mapped to

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
roleid = 'roleid_example' # String | The id of the role to list the maps.

begin
  #Lists the maps a roles is mapped to
  api_instance.advrole_listmaps(roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_listmaps: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **roleid** | [**String**](.md)| The id of the role to list the maps. | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_listrolesmapped

> advrole_listrolesmapped(opts)

Lists the roles mappings

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
opts = {
  map: 'map_example' # String | List only the roles in the specified map.
}

begin
  #Lists the roles mappings
  api_instance.advrole_listrolesmapped(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_listrolesmapped: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **map** | **String**| List only the roles in the specified map. | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## advrole_listtemplates

> advrole_listtemplates

View a list of role templates

Allows the user to view the full list of available role templates.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new

begin
  #View a list of role templates
  api_instance.advrole_listtemplates
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_listtemplates: #{e}"
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


## advrole_save

> advrole_save(id, opts)

Create or edit a role

Allows the user to create or edit a role's permissions.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
id = 'id_example' # String | The id of the role to save (leave empty to create a new one).
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Create or edit a role
  api_instance.advrole_save(id, opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_save: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**String**](.md)| The id of the role to save (leave empty to create a new one). | 
 **unknown_base_type** | [**UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | [optional] 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined


## advrole_savemapping

> advrole_savemapping(opts)

Saves a role mapping

Allows the user to add a role to a mapped category on the 'Role Mapping' page.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
opts = {
  unknown_base_type: OpenapiClient::UNKNOWN_BASE_TYPE.new # UNKNOWN_BASE_TYPE | 
}

begin
  #Saves a role mapping
  api_instance.advrole_savemapping(opts)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_savemapping: #{e}"
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


## advrole_userupgrade

> advrole_userupgrade(userid, roleid)

Upgrade a user to another role (requires permission to edit those roles)

Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.

### Example

```ruby
# load the gem
require 'openapi_client'
# setup authorization
OpenapiClient.configure do |config|
  # Configure Bearer authorization (string): bearerAuth
  config.access_token = 'YOUR_BEARER_TOKEN'
end

api_instance = OpenapiClient::AdvroleApi.new
userid = 'userid_example' # String | Id of the user to upgrade
roleid = 'roleid_example' # String | Id of the role to add

begin
  #Upgrade a user to another role (requires permission to edit those roles)
  api_instance.advrole_userupgrade(userid, roleid)
rescue OpenapiClient::ApiError => e
  puts "Exception when calling AdvroleApi->advrole_userupgrade: #{e}"
end
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **userid** | [**String**](.md)| Id of the user to upgrade | 
 **roleid** | [**String**](.md)| Id of the role to add | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

