/*
 * AccuCampus OpenAPI 3
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
	"strings"
	"github.com/antihax/optional"
	"time"
)

// Linger please
var (
	_ _context.Context
)

// WaitinglineApiService WaitinglineApi service
type WaitinglineApiService service

// WaitinglineAdduserOpts Optional parameters for the method 'WaitinglineAdduser'
type WaitinglineAdduserOpts struct {
    Locationid optional.Interface
    Time optional.Time
    Signinrole optional.String
    Roleid optional.Interface
    Services optional.String
    Eventid optional.Interface
    Staff optional.Interface
    Photosize optional.Int32
}

/*
WaitinglineAdduser Put user in a waiting line
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param station The id of the sign-in station.
 * @param user The user's card number.
 * @param optional nil or *WaitinglineAdduserOpts - Optional Parameters:
 * @param "Locationid" (optional.Interface of string) -  The location's id where the swipe must be saved.
 * @param "Time" (optional.Time) -  The date and time of the swipe.
 * @param "Signinrole" (optional.String) -  Specifies if the sign-in is for an attendee or a staff member
 * @param "Roleid" (optional.Interface of string) -  Specifies the role the user has selected in order to sign-in
 * @param "Services" (optional.String) -  The services ids the user has selected.
 * @param "Eventid" (optional.Interface of string) -  The id of the event the user selected.
 * @param "Staff" (optional.Interface of string) -  The id of the staff member the user selected.
 * @param "Photosize" (optional.Int32) -  The swiping user's photo size.
*/
func (a *WaitinglineApiService) WaitinglineAdduser(ctx _context.Context, station string, user string, localVarOptionals *WaitinglineAdduserOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/adduser"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	localVarQueryParams.Add("station", parameterToString(station, ""))
	if localVarOptionals != nil && localVarOptionals.Locationid.IsSet() {
		localVarQueryParams.Add("locationid", parameterToString(localVarOptionals.Locationid.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Time.IsSet() {
		localVarQueryParams.Add("time", parameterToString(localVarOptionals.Time.Value(), ""))
	}
	localVarQueryParams.Add("user", parameterToString(user, ""))
	if localVarOptionals != nil && localVarOptionals.Signinrole.IsSet() {
		localVarQueryParams.Add("signinrole", parameterToString(localVarOptionals.Signinrole.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Roleid.IsSet() {
		localVarQueryParams.Add("roleid", parameterToString(localVarOptionals.Roleid.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Services.IsSet() {
		localVarQueryParams.Add("services", parameterToString(localVarOptionals.Services.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Eventid.IsSet() {
		localVarQueryParams.Add("eventid", parameterToString(localVarOptionals.Eventid.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Staff.IsSet() {
		localVarQueryParams.Add("staff", parameterToString(localVarOptionals.Staff.Value(), ""))
	}
	if localVarOptionals != nil && localVarOptionals.Photosize.IsSet() {
		localVarQueryParams.Add("photosize", parameterToString(localVarOptionals.Photosize.Value(), ""))
	}
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

// WaitinglineDeleteOpts Optional parameters for the method 'WaitinglineDelete'
type WaitinglineDeleteOpts struct {
    Body optional.Interface{}
}

/*
WaitinglineDelete Delete a waiting line
Allows the user to delete an existing waiting line, provided it is in a location that the user is scoped to.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param id The id of the line to delete.
 * @param optional nil or *WaitinglineDeleteOpts - Optional Parameters:
 * @param "Body" (optional.Interface{}) - 
*/
func (a *WaitinglineApiService) WaitinglineDelete(ctx _context.Context, id string, localVarOptionals *WaitinglineDeleteOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodDelete
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/{id}"
	localVarPath = strings.Replace(localVarPath, "{"+"id"+"}", _neturl.QueryEscape(parameterToString(id, "")) , -1)

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{"application/json"}

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
	// body params
	if localVarOptionals != nil && localVarOptionals.Body.IsSet() {
		localVarPostBody = localVarOptionals.Body.Value()
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

// WaitinglineGetOpts Optional parameters for the method 'WaitinglineGet'
type WaitinglineGetOpts struct {
    Photosize optional.Int32
}

/*
WaitinglineGet View details of a waiting line
Allows the user to view the details of a waiting line in a location to which they are scoped.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param id The id of the waiting line to get.
 * @param optional nil or *WaitinglineGetOpts - Optional Parameters:
 * @param "Photosize" (optional.Int32) -  The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
*/
func (a *WaitinglineApiService) WaitinglineGet(ctx _context.Context, id string, localVarOptionals *WaitinglineGetOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/{id}"
	localVarPath = strings.Replace(localVarPath, "{"+"id"+"}", _neturl.QueryEscape(parameterToString(id, "")) , -1)

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	if localVarOptionals != nil && localVarOptionals.Photosize.IsSet() {
		localVarQueryParams.Add("photosize", parameterToString(localVarOptionals.Photosize.Value(), ""))
	}
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

// WaitinglineIsuserinOpts Optional parameters for the method 'WaitinglineIsuserin'
type WaitinglineIsuserinOpts struct {
    Location optional.Interface
}

/*
WaitinglineIsuserin Check whether a user is in a waiting line, signed-in or is not in the area
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param station The id of the sign-in station.
 * @param time The date and time of the swipe.
 * @param user The card number of the user.
 * @param optional nil or *WaitinglineIsuserinOpts - Optional Parameters:
 * @param "Location" (optional.Interface of string) -  The id of the location the user picked.
*/
func (a *WaitinglineApiService) WaitinglineIsuserin(ctx _context.Context, station string, time time.Time, user string, localVarOptionals *WaitinglineIsuserinOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/isuserin"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	localVarQueryParams.Add("station", parameterToString(station, ""))
	localVarQueryParams.Add("time", parameterToString(time, ""))
	localVarQueryParams.Add("user", parameterToString(user, ""))
	if localVarOptionals != nil && localVarOptionals.Location.IsSet() {
		localVarQueryParams.Add("location", parameterToString(localVarOptionals.Location.Value(), ""))
	}
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

/*
WaitinglineList View a list of waiting lines
Allows the user to view the list of waiting lines in locations to which they are scoped.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param from The first record to return.
 * @param count The max number of records to return.
*/
func (a *WaitinglineApiService) WaitinglineList(ctx _context.Context, from int32, count int32) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/list"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

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

/*
WaitinglineRemoveuser Remove a user from a waiting line
Allows the user to remove a user from a waiting line, provided they have permission to access that waiting line.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param waitingline The id of the waiting line whose item has to be removed.
 * @param itemid The ID of the item that has to be removed.
*/
func (a *WaitinglineApiService) WaitinglineRemoveuser(ctx _context.Context, waitingline string, itemid string) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/removeuser"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	localVarQueryParams.Add("waitingline", parameterToString(waitingline, ""))
	localVarQueryParams.Add("itemid", parameterToString(itemid, ""))
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

// WaitinglineSaveOpts Optional parameters for the method 'WaitinglineSave'
type WaitinglineSaveOpts struct {
    UNKNOWNBASETYPE optional.Interface
}

/*
WaitinglineSave Create or edit a waiting line
Allows the user to create or edit a waiting line in a location to which they are scoped.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param id The id of the waiting line save (leave empty to create a new one).
 * @param optional nil or *WaitinglineSaveOpts - Optional Parameters:
 * @param "UNKNOWNBASETYPE" (optional.Interface of UNKNOWN_BASE_TYPE) - 
*/
func (a *WaitinglineApiService) WaitinglineSave(ctx _context.Context, id string, localVarOptionals *WaitinglineSaveOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodPost
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/{id}"
	localVarPath = strings.Replace(localVarPath, "{"+"id"+"}", _neturl.QueryEscape(parameterToString(id, "")) , -1)

	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	// to determine the Content-Type header
	localVarHTTPContentTypes := []string{"application/json"}

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
	// body params
	if localVarOptionals != nil && localVarOptionals.UNKNOWNBASETYPE.IsSet() {
		localVarOptionalUNKNOWNBASETYPE, localVarOptionalUNKNOWNBASETYPEok := localVarOptionals.UNKNOWNBASETYPE.Value().(UNKNOWN_BASE_TYPE)
		if !localVarOptionalUNKNOWNBASETYPEok {
			return nil, reportError("uNKNOWNBASETYPE should be UNKNOWN_BASE_TYPE")
		}
		localVarPostBody = &localVarOptionalUNKNOWNBASETYPE
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

// WaitinglineSigninuserOpts Optional parameters for the method 'WaitinglineSigninuser'
type WaitinglineSigninuserOpts struct {
    Photosize optional.Int32
}

/*
WaitinglineSigninuser Sign a user in from a waiting line
Allows the user to sign a user in from a waiting line, provided they have permission to access that waiting line.
 * @param ctx _context.Context - for authentication, logging, cancellation, deadlines, tracing, etc. Passed from http.Request or context.Background().
 * @param waitingline The id of the waiting line whose item needs to be signed-in.
 * @param itemid The ID of the item that has to be signed-in.
 * @param staff The id of the staff member selected to sign-in.
 * @param optional nil or *WaitinglineSigninuserOpts - Optional Parameters:
 * @param "Photosize" (optional.Int32) -  The swiping user's photo size.
*/
func (a *WaitinglineApiService) WaitinglineSigninuser(ctx _context.Context, waitingline string, itemid string, staff string, localVarOptionals *WaitinglineSigninuserOpts) (*_nethttp.Response, error) {
	var (
		localVarHTTPMethod   = _nethttp.MethodGet
		localVarPostBody     interface{}
		localVarFormFileName string
		localVarFileName     string
		localVarFileBytes    []byte
	)

	// create path and map variables
	localVarPath := a.client.cfg.BasePath + "/waitingline/signinuser"
	localVarHeaderParams := make(map[string]string)
	localVarQueryParams := _neturl.Values{}
	localVarFormParams := _neturl.Values{}

	localVarQueryParams.Add("waitingline", parameterToString(waitingline, ""))
	localVarQueryParams.Add("itemid", parameterToString(itemid, ""))
	localVarQueryParams.Add("staff", parameterToString(staff, ""))
	if localVarOptionals != nil && localVarOptionals.Photosize.IsSet() {
		localVarQueryParams.Add("photosize", parameterToString(localVarOptionals.Photosize.Value(), ""))
	}
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