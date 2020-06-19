# AccuCampusOpenApi3.CaptchaApi

All URIs are relative to *https://accucampus.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**captchaGetchallenge**](CaptchaApi.md#captchaGetchallenge) | **GET** /captcha/getchallenge | Gets a captcha challenge that the user must complete to do certain requests.
[**captchaGetimage**](CaptchaApi.md#captchaGetimage) | **GET** /captcha/getimage | Gets a captcha image that the user must complete to do certain requests.



## captchaGetchallenge

> captchaGetchallenge()

Gets a captcha challenge that the user must complete to do certain requests.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.CaptchaApi();
apiInstance.captchaGetchallenge((error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters

This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined


## captchaGetimage

> captchaGetimage(captchatoken)

Gets a captcha image that the user must complete to do certain requests.

### Example

```javascript
import AccuCampusOpenApi3 from 'accu_campus_open_api_3';

let apiInstance = new AccuCampusOpenApi3.CaptchaApi();
let captchatoken = "captchatoken_example"; // String | The captcha token or ID returned by the captcha.getchallenge action
apiInstance.captchaGetimage(captchatoken, (error, data, response) => {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully.');
  }
});
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **captchatoken** | **String**| The captcha token or ID returned by the captcha.getchallenge action | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

