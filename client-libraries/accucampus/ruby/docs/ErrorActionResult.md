# OpenapiClient::ErrorActionResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**success** | **Boolean** | Specifies if the execution of the action was successful | [optional] 
**message** | **String** | Message with context information about the response | [optional] 
**error_flag** | **String** | Error flag that describes the error in the execution | [optional] 
**domain** | **String** | Contains the domain of the account where the action was applied on | [optional] 
**redirect_url** | **String** | Contains the url to redirect to when an error is found during the execution of the action | [optional] 

## Code Sample

```ruby
require 'OpenapiClient'

instance = OpenapiClient::ErrorActionResult.new(success: null,
                                 message: null,
                                 error_flag: null,
                                 domain: null,
                                 redirect_url: null)
```


