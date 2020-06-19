# \RiskmodelApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RiskmodelCheckanalysis**](RiskmodelApi.md#RiskmodelCheckanalysis) | **Get** /riskmodel/checkanalysis | Check the status of the analysis of a specified risk assessment model
[**RiskmodelDelete**](RiskmodelApi.md#RiskmodelDelete) | **Delete** /riskmodel/{id} | Delete a risk assessment model
[**RiskmodelGet**](RiskmodelApi.md#RiskmodelGet) | **Get** /riskmodel/{id} | View details of a risk assessment model
[**RiskmodelGetscore**](RiskmodelApi.md#RiskmodelGetscore) | **Get** /riskmodel/getscore | View the risk score for a specific user
[**RiskmodelList**](RiskmodelApi.md#RiskmodelList) | **Get** /riskmodel/list | View a list of risk assessment models
[**RiskmodelPredict**](RiskmodelApi.md#RiskmodelPredict) | **Get** /riskmodel/predict | Predict risk based on an assessment model
[**RiskmodelProcess**](RiskmodelApi.md#RiskmodelProcess) | **Get** /riskmodel/process | Process a risk assessment model
[**RiskmodelRefresh**](RiskmodelApi.md#RiskmodelRefresh) | **Get** /riskmodel/refresh | Refresh the information used in a risk assessment model
[**RiskmodelSave**](RiskmodelApi.md#RiskmodelSave) | **Post** /riskmodel/{id} | Create or edit a risk assessment model
[**RiskmodelTermprecedences**](RiskmodelApi.md#RiskmodelTermprecedences) | **Get** /riskmodel/termprecedences | View all default term precedences



## RiskmodelCheckanalysis

> RiskmodelCheckanalysis(ctx, id)

Check the status of the analysis of a specified risk assessment model

Allows the user to check the status of a risk assessment model as it is being processed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the risk assessment model whose analysis status has to be returned. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelDelete

> RiskmodelDelete(ctx, id, optional)

Delete a risk assessment model

Allows the user to delete a previously created risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the risk assessment model to delete. | 
 **optional** | ***RiskmodelDeleteOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RiskmodelDeleteOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **body** | **optional.Interface{}**|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelGet

> RiskmodelGet(ctx, id)

View details of a risk assessment model

Allows the user to view an individual risk assessment model and its details.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the risk assessment model to get. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelGetscore

> RiskmodelGetscore(ctx, userid)

View the risk score for a specific user

Allows the user to view the risk score of another user.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**userid** | [**string**](.md)| The id of the user to get the risk score. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelList

> RiskmodelList(ctx, from, count)

View a list of risk assessment models

Allows the user to view the full list of risk assessment models.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**from** | **int32**| The first record to return. | 
**count** | **int32**| The max number of records to return. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelPredict

> RiskmodelPredict(ctx, id)

Predict risk based on an assessment model

Allows a user to process a risk prediction from a risk assessment model that has processed.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the assessment model to use in order to predict risk. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelProcess

> RiskmodelProcess(ctx, id)

Process a risk assessment model

Allows the user to process a risk assessment model once it has been created.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the risk assessment model to process. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelRefresh

> RiskmodelRefresh(ctx, id)

Refresh the information used in a risk assessment model

Allows the user to refresh a risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the risk assessment model whose information has to be refreshed. | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelSave

> RiskmodelSave(ctx, id, optional)

Create or edit a risk assessment model

Allows the user to create or edit a risk assessment model.

### Required Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
**id** | [**string**](.md)| The id of the department save (leave empty to create a new one). | 
 **optional** | ***RiskmodelSaveOpts** | optional parameters | nil if no parameters

### Optional Parameters

Optional parameters are passed through a pointer to a RiskmodelSaveOpts struct


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------

 **uNKNOWNBASETYPE** | [**optional.Interface of UNKNOWN_BASE_TYPE**](UNKNOWN_BASE_TYPE.md)|  | 

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## RiskmodelTermprecedences

> RiskmodelTermprecedences(ctx, )

View all default term precedences

Allows the user to view the default term precedences used in a model.

### Required Parameters

This endpoint does not need any parameter.

### Return type

 (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

