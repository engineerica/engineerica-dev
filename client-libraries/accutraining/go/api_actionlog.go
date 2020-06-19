/*
 * AccuTraining OpenAPI 3
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi

import (
	_context "context"
	_ioutil "io/ioutil"
	_nethttp "net/http"
	_neturl "net/url"
	"github.com/antihax/optional"
)

// Linger please
var (
	_ _context.Context
)

// ActionlogApiService ActionlogApi service
type ActionlogApiService service

// ActionlogListOpts Optional parameters for the method 'ActionlogList'
type ActionlogListOpts struct {
    User optional.Interface
    Startdate optional.Time
    Enddate optional.Time
    Resource optional.String
    Actionfilter optional.String
    Argument optional.String
}

/*
ActionlogList View a list of users action logs
Allows the user to view the audit logs for the account.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param from The first record to return.
 * @param count The max number of records to return.
 * @param optional nil or *ActionlogListOpts - Optional Parameters:
 * @param "User" (optional.Interface of string) -  The id of the user whose action logs have to be returned.
 * @param "Startdate" (optional.Time) -  The start date of the period to filter the logs.
 * @param "Enddate" (optional.Time) -  The end date of the period to filter the logs.
 * @param "Resource" (optional.String) -  The resource to filter the action logs.
 * @param "Actionfilter" (optional.String) -  The action to filter the action logs.
 * @param "Argument" (optional.String) -  The id of the entity that was the argument of the executed action.
*/
func (a *ActionlogApiService) ActionlogList(ctx _context.Context, from int32, count int32, localVarOptionals *ActionlogListOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/actionlog/list"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	if localVarOptionals != nil && localVarOptionals.User.IsSet() {
		localVarQueryParams.Add("user", parameterToString(localVarOptionals.User.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Startdate.IsSet() {
		localVarQueryParams.Add("startdate", parameterToString(localVarOptionals.Startdate.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Enddate.IsSet() {
		localVarQueryParams.Add("enddate", parameterToString(localVarOptionals.Enddate.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Resource.IsSet() {
		localVarQueryParams.Add("resource", parameterToString(localVarOptionals.Resource.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Actionfilter.IsSet() {
		localVarQueryParams.Add("actionfilter", parameterToString(localVarOptionals.Actionfilter.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Argument.IsSet() {
		localVarQueryParams.Add("argument", parameterToString(localVarOptionals.Argument.Value(), ""))
	}
	localVarQueryParams.Add("from", parameterToString(from, ""))
	localVarQueryParams.Add("count", parameterToString(count, ""))
	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{}

	// set Content-Type header
	localVarHTTPContentType := selectHeaderContentType(localVarHTTPContentTypes)
	if localVarHTTPContentType != "" {
		localVarHeaderParams["Content-Type"] = localVarHTTPContentType
	}

	// to determine the Accept header
	localVarHTTPHeaderAccepts := []string{}

	// set Accept header
	localVarHTTPHeaderAccept := selectHeaderAccept(localVarHTTPHeaderAccepts)
	if localVarHTTPHeaderAccept != "" {
		localVarHeaderParams["Accept"] = localVarHTTPHeaderAccept
	}
	r, err := a.client.prepareRequest(ctx, localVarPath, localVarHTTPMethod, localVarPostBody, localVarHeaderParams, localVarQueryParams, localVarFormParams, localVarFormFileName, localVarFileName, localVarFileBytes)
	if err != nil {
		return nil, err
	}

	localVarHTTPResponse, err := a.client.callAPI(r)
	if err != nil || localVarHTTPResponse == nil {
		return localVarHTTPResponse, err
	}

	localVarBody, err := _ioutil.ReadAll(localVarHTTPResponse.Body)
	localVarHTTPResponse.Body.Close()
	if err != nil {
		return localVarHTTPResponse, err
	}

	if localVarHTTPResponse.StatusCode >= 300 {
		newErr := GenericOpenAPIError{
			body:  localVarBody,
			error: localVarHTTPResponse.Status,
		}
		return localVarHTTPResponse, newErr
	}

	return localVarHTTPResponse, nil
}