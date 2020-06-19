# BgjobApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bgjobGetstatus**](BgjobApi.md#bgjobGetstatus) | **GET** /bgjob/getstatus | Get background job status


<a name="bgjobGetstatus"></a>
# **bgjobGetstatus**
> bgjobGetstatus(jobid, jobtype)

Get background job status

### Example
```kotlin
// Import classes:
//import org.openapitools.client.infrastructure.*
//import org.openapitools.client.models.*

val apiInstance = BgjobApi()
val jobid : java.util.UUID = 38400000-8cf0-11bd-b23e-10b96e4ef00d // java.util.UUID | The ID of the job to get the status. 10 most recent will be returned if not specified.
val jobtype : kotlin.String = jobtype_example // kotlin.String | The job type to filter by.
try {
    apiInstance.bgjobGetstatus(jobid, jobtype)
} catch (e: ClientException) {
    println("4xx response calling BgjobApi#bgjobGetstatus")
    e.printStackTrace()
} catch (e: ServerException) {
    println("5xx response calling BgjobApi#bgjobGetstatus")
    e.printStackTrace()
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | [**java.util.UUID**](.md)| The ID of the job to get the status. 10 most recent will be returned if not specified. | [optional]
 **jobtype** | **kotlin.String**| The job type to filter by. | [optional]

### Return type

null (empty response body)

### Authorization


Configure bearerAuth:
    ApiClient.accessToken = ""

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

