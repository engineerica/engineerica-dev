# AccuTrainingOpenApi3.MenuApi

All URIs are relative to *https://accutraining.net:443/api/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**menuGetitems**](MenuApi.md#menuGetitems) | **GET** /menu/getitems | Gets the items on the menu



## menuGetitems

> menuGetitems(menuid)

Gets the items on the menu

### Example

```javascript
import AccuTrainingOpenApi3 from 'accu_training_open_api_3';

let apiInstance = new AccuTrainingOpenApi3.MenuApi();
let menuid = "menuid_example"; // String | The Id of the menu to get.
apiInstance.menuGetitems(menuid, (error, data, response) => {
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
 **menuid** | **String**| The Id of the menu to get. | 

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: Not defined

