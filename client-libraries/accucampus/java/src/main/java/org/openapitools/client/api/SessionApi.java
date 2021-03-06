/*
 * AccuCampus OpenAPI 3
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.api;

import org.openapitools.client.ApiCallback;
import org.openapitools.client.ApiClient;
import org.openapitools.client.ApiException;
import org.openapitools.client.ApiResponse;
import org.openapitools.client.Configuration;
import org.openapitools.client.Pair;
import org.openapitools.client.ProgressRequestBody;
import org.openapitools.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import org.threeten.bp.OffsetDateTime;
import java.util.UUID;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class SessionApi {
    private ApiClient localVarApiClient;

    public SessionApi() {
        this(Configuration.getDefaultApiClient());
    }

    public SessionApi(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return localVarApiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.localVarApiClient = apiClient;
    }

    /**
     * Build call for sessionBulkupdate
     * @param eventid The id of the event to bulk update. (required)
     * @param sessions A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionBulkupdateCall(UUID eventid, String sessions, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/session/bulkupdate";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (eventid != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("eventid", eventid));
        }

        if (sessions != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("sessions", sessions));
        }

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return localVarApiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call sessionBulkupdateValidateBeforeCall(UUID eventid, String sessions, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'eventid' is set
        if (eventid == null) {
            throw new ApiException("Missing the required parameter 'eventid' when calling sessionBulkupdate(Async)");
        }
        
        // verify the required parameter 'sessions' is set
        if (sessions == null) {
            throw new ApiException("Missing the required parameter 'sessions' when calling sessionBulkupdate(Async)");
        }
        

        okhttp3.Call localVarCall = sessionBulkupdateCall(eventid, sessions, _callback);
        return localVarCall;

    }

    /**
     * Bulk update event sessions
     * Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
     * @param eventid The id of the event to bulk update. (required)
     * @param sessions A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. (required)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public void sessionBulkupdate(UUID eventid, String sessions) throws ApiException {
        sessionBulkupdateWithHttpInfo(eventid, sessions);
    }

    /**
     * Bulk update event sessions
     * Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
     * @param eventid The id of the event to bulk update. (required)
     * @param sessions A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. (required)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> sessionBulkupdateWithHttpInfo(UUID eventid, String sessions) throws ApiException {
        okhttp3.Call localVarCall = sessionBulkupdateValidateBeforeCall(eventid, sessions, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * Bulk update event sessions (asynchronously)
     * Allows the user to bulk update event sessions by setting multiple attendees as present, absent, tardy, etc.
     * @param eventid The id of the event to bulk update. (required)
     * @param sessions A JSON-formatted array, with all the sessions to update, create or delete. Each item must contain an action (set/remove) and the session properties. (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionBulkupdateAsync(UUID eventid, String sessions, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = sessionBulkupdateValidateBeforeCall(eventid, sessions, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
    /**
     * Build call for sessionGet
     * @param id The id of the session to get. (required)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionGetCall(UUID id, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/session/{id}"
            .replaceAll("\\{" + "id" + "\\}", localVarApiClient.escapeString(id.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return localVarApiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call sessionGetValidateBeforeCall(UUID id, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling sessionGet(Async)");
        }
        

        okhttp3.Call localVarCall = sessionGetCall(id, _callback);
        return localVarCall;

    }

    /**
     * View details of a session
     * Allows the user to view a session in order to take attendance.
     * @param id The id of the session to get. (required)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public void sessionGet(UUID id) throws ApiException {
        sessionGetWithHttpInfo(id);
    }

    /**
     * View details of a session
     * Allows the user to view a session in order to take attendance.
     * @param id The id of the session to get. (required)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> sessionGetWithHttpInfo(UUID id) throws ApiException {
        okhttp3.Call localVarCall = sessionGetValidateBeforeCall(id, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * View details of a session (asynchronously)
     * Allows the user to view a session in order to take attendance.
     * @param id The id of the session to get. (required)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionGetAsync(UUID id, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = sessionGetValidateBeforeCall(id, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
    /**
     * Build call for sessionGetschedule
     * @param day The day to return. It will also return the whole week for that day. (optional)
     * @param attendee The id of the attendee to get the schedule. (optional)
     * @param location The id of the location to get the schedule. (optional)
     * @param instructor The id of the instructor to get the schedule. (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionGetscheduleCall(OffsetDateTime day, UUID attendee, UUID location, UUID instructor, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/session/getschedule";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (day != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("day", day));
        }

        if (attendee != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("attendee", attendee));
        }

        if (location != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("location", location));
        }

        if (instructor != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("instructor", instructor));
        }

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return localVarApiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call sessionGetscheduleValidateBeforeCall(OffsetDateTime day, UUID attendee, UUID location, UUID instructor, final ApiCallback _callback) throws ApiException {
        

        okhttp3.Call localVarCall = sessionGetscheduleCall(day, attendee, location, instructor, _callback);
        return localVarCall;

    }

    /**
     * Gets the schedule for a location, instructor or attendees
     * 
     * @param day The day to return. It will also return the whole week for that day. (optional)
     * @param attendee The id of the attendee to get the schedule. (optional)
     * @param location The id of the location to get the schedule. (optional)
     * @param instructor The id of the instructor to get the schedule. (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public void sessionGetschedule(OffsetDateTime day, UUID attendee, UUID location, UUID instructor) throws ApiException {
        sessionGetscheduleWithHttpInfo(day, attendee, location, instructor);
    }

    /**
     * Gets the schedule for a location, instructor or attendees
     * 
     * @param day The day to return. It will also return the whole week for that day. (optional)
     * @param attendee The id of the attendee to get the schedule. (optional)
     * @param location The id of the location to get the schedule. (optional)
     * @param instructor The id of the instructor to get the schedule. (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> sessionGetscheduleWithHttpInfo(OffsetDateTime day, UUID attendee, UUID location, UUID instructor) throws ApiException {
        okhttp3.Call localVarCall = sessionGetscheduleValidateBeforeCall(day, attendee, location, instructor, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * Gets the schedule for a location, instructor or attendees (asynchronously)
     * 
     * @param day The day to return. It will also return the whole week for that day. (optional)
     * @param attendee The id of the attendee to get the schedule. (optional)
     * @param location The id of the location to get the schedule. (optional)
     * @param instructor The id of the instructor to get the schedule. (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionGetscheduleAsync(OffsetDateTime day, UUID attendee, UUID location, UUID instructor, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = sessionGetscheduleValidateBeforeCall(day, attendee, location, instructor, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
    /**
     * Build call for sessionList
     * @param from The first record to return. (required)
     * @param count The max number of records to return. (required)
     * @param startdate The start date to filter the sessions (optional)
     * @param enddate The end date to filter the sessions. (optional)
     * @param _callback Callback for upload/download progress
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionListCall(Integer from, Integer count, OffsetDateTime startdate, OffsetDateTime enddate, final ApiCallback _callback) throws ApiException {
        Object localVarPostBody = null;

        // create path and map variables
        String localVarPath = "/session/list";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (from != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("from", from));
        }

        if (count != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("count", count));
        }

        if (startdate != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("startdate", startdate));
        }

        if (enddate != null) {
            localVarQueryParams.addAll(localVarApiClient.parameterToPair("enddate", enddate));
        }

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();
        Map<String, String> localVarCookieParams = new HashMap<String, String>();
        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        final String[] localVarAccepts = {
            
        };
        final String localVarAccept = localVarApiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) {
            localVarHeaderParams.put("Accept", localVarAccept);
        }

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = localVarApiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return localVarApiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarCookieParams, localVarFormParams, localVarAuthNames, _callback);
    }

    @SuppressWarnings("rawtypes")
    private okhttp3.Call sessionListValidateBeforeCall(Integer from, Integer count, OffsetDateTime startdate, OffsetDateTime enddate, final ApiCallback _callback) throws ApiException {
        
        // verify the required parameter 'from' is set
        if (from == null) {
            throw new ApiException("Missing the required parameter 'from' when calling sessionList(Async)");
        }
        
        // verify the required parameter 'count' is set
        if (count == null) {
            throw new ApiException("Missing the required parameter 'count' when calling sessionList(Async)");
        }
        

        okhttp3.Call localVarCall = sessionListCall(from, count, startdate, enddate, _callback);
        return localVarCall;

    }

    /**
     * Gets all future sessions of the current semester
     * 
     * @param from The first record to return. (required)
     * @param count The max number of records to return. (required)
     * @param startdate The start date to filter the sessions (optional)
     * @param enddate The end date to filter the sessions. (optional)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public void sessionList(Integer from, Integer count, OffsetDateTime startdate, OffsetDateTime enddate) throws ApiException {
        sessionListWithHttpInfo(from, count, startdate, enddate);
    }

    /**
     * Gets all future sessions of the current semester
     * 
     * @param from The first record to return. (required)
     * @param count The max number of records to return. (required)
     * @param startdate The start date to filter the sessions (optional)
     * @param enddate The end date to filter the sessions. (optional)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public ApiResponse<Void> sessionListWithHttpInfo(Integer from, Integer count, OffsetDateTime startdate, OffsetDateTime enddate) throws ApiException {
        okhttp3.Call localVarCall = sessionListValidateBeforeCall(from, count, startdate, enddate, null);
        return localVarApiClient.execute(localVarCall);
    }

    /**
     * Gets all future sessions of the current semester (asynchronously)
     * 
     * @param from The first record to return. (required)
     * @param count The max number of records to return. (required)
     * @param startdate The start date to filter the sessions (optional)
     * @param enddate The end date to filter the sessions. (optional)
     * @param _callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     * @http.response.details
     <table summary="Response Details" border="1">
        <tr><td> Status Code </td><td> Description </td><td> Response Headers </td></tr>
        <tr><td> 200 </td><td>  </td><td>  -  </td></tr>
     </table>
     */
    public okhttp3.Call sessionListAsync(Integer from, Integer count, OffsetDateTime startdate, OffsetDateTime enddate, final ApiCallback<Void> _callback) throws ApiException {

        okhttp3.Call localVarCall = sessionListValidateBeforeCall(from, count, startdate, enddate, _callback);
        localVarApiClient.executeAsync(localVarCall, _callback);
        return localVarCall;
    }
}
