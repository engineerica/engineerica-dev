using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScheduleApi
    {
        /// <summary>
        /// Delete a schedule slot Allows the user to delete a schedule slot from another user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleDelete (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete a specific block from a user&#39;s own schedule Allows the user to delete a schedule block from their own availability.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleDeletemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Enable or disable the schedule for a specific person Allows the user to enable or disable a schedule for another user.
        /// </summary>
        /// <param name="userid">The id of the user to enable or disable the schedule.</param>
        /// <param name="enable">True to enable schedules, false to disable.</param>
        /// <returns></returns>
        void ScheduleEnable (Guid? userid, bool? enable);
        /// <summary>
        /// Enable or disable current user&#39;s schedule Allows the user to enable or disable a schedule for himself.
        /// </summary>
        /// <param name="enable">True to enable schedules, false to disable.</param>
        /// <returns></returns>
        void ScheduleEnablemine (bool? enable);
        /// <summary>
        /// Search available schedule slots by service, event, date Allows users to search available slots.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="staffid">The id of the staff to filter by.</param>
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="locationid">The id of the location to filter by.</param>
        /// <param name="staffroleids">CSV list of the staff member role ids to filter by.</param>
        /// <param name="availablefor">The specific availability type to filter by.</param>
        /// <returns></returns>
        void ScheduleFindallstaffslots (DateTime? starttime, DateTime? endtime, Guid? staffid, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor);
        /// <summary>
        /// Search available schedule slots by service, event, date and/or staff Allows users to search available slots when making appointments.
        /// </summary>
        /// <param name="staffid">The id of the staff to filter by.</param>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="locationid">The id of the service to filter by.</param>
        /// <param name="availablefor">The specific availability type to filter by.</param>
        /// <returns></returns>
        void ScheduleFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string availablefor);
        /// <summary>
        /// Search available staff members slots by service, event, and/or date Allows users to search available staff.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="serviceids">CSV list of the service ids to filter by.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="locationid">The id of the service to filter by.</param>
        /// <param name="staffroleids">CSV list of the staff member role ids to filter by.</param>
        /// <param name="availablefor">Filter slots by a specific availability type.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void ScheduleFindstaffavail (DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor, int? photosize);
        /// <summary>
        /// Search and view details of a specific schedule slot Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
        /// </summary>
        /// <param name="scheduleid">The id of the schedule.</param>
        /// <returns></returns>
        void ScheduleGet (Guid? scheduleid);
        /// <summary>
        /// View details of a specific schedule block, for current user Allows the user to view the details of their own schedule shifts.
        /// </summary>
        /// <param name="scheduleid">The id of the schedule.</param>
        /// <returns></returns>
        void ScheduleGetmine (Guid? scheduleid);
        /// <summary>
        /// View a list of schedule information of a specified person Allows the user to view the schedule shifts for user roles that the user has permission to access.
        /// </summary>
        /// <param name="userid">The id of the user to get info.</param>
        /// <returns></returns>
        void ScheduleGetstaff (Guid? userid);
        /// <summary>
        /// View current user&#39;s schedule information Allows the user to view their own schedule.
        /// </summary>
        /// <returns></returns>
        void ScheduleGetstaffmine ();
        /// <summary>
        /// View current user&#39;s schedule exceptions Allows the user to view their own schedule exceptions.
        /// </summary>
        /// <param name="includedeleted">If true the deleted offtimes are also returned.</param>
        /// <param name="onlyupcoming">If true then only upcoming offtimes are returned.</param>
        /// <param name="modifiedafter">If specified, only offtimes modified after the specified date will be returned.</param>
        /// <returns></returns>
        void ScheduleMyofftimes (bool? includedeleted, bool? onlyupcoming, DateTime? modifiedafter);
        /// <summary>
        /// Create or edit a schedule slot Allows the user to create or edit a schedule slot of another user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Create or edit a block in current user&#39;s schedule Allows the user to create or edit a schedule shift in their own availability.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleSavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScheduleApi : IScheduleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScheduleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduleApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Delete a schedule slot Allows the user to delete a schedule slot from another user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleDelete (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/schedule/delete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a specific block from a user&#39;s own schedule Allows the user to delete a schedule block from their own availability.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleDeletemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/schedule/deletemine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleDeletemine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleDeletemine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Enable or disable the schedule for a specific person Allows the user to enable or disable a schedule for another user.
        /// </summary>
        /// <param name="userid">The id of the user to enable or disable the schedule.</param> 
        /// <param name="enable">True to enable schedules, false to disable.</param> 
        /// <returns></returns>            
        public void ScheduleEnable (Guid? userid, bool? enable)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling ScheduleEnable");
            
            // verify the required parameter 'enable' is set
            if (enable == null) throw new ApiException(400, "Missing required parameter 'enable' when calling ScheduleEnable");
            
    
            var path = "/schedule/enable";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (enable != null) queryParams.Add("enable", ApiClient.ParameterToString(enable)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleEnable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleEnable: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Enable or disable current user&#39;s schedule Allows the user to enable or disable a schedule for himself.
        /// </summary>
        /// <param name="enable">True to enable schedules, false to disable.</param> 
        /// <returns></returns>            
        public void ScheduleEnablemine (bool? enable)
        {
            
            // verify the required parameter 'enable' is set
            if (enable == null) throw new ApiException(400, "Missing required parameter 'enable' when calling ScheduleEnablemine");
            
    
            var path = "/schedule/enablemine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (enable != null) queryParams.Add("enable", ApiClient.ParameterToString(enable)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleEnablemine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleEnablemine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search available schedule slots by service, event, date Allows users to search available slots.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="staffid">The id of the staff to filter by.</param> 
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="locationid">The id of the location to filter by.</param> 
        /// <param name="staffroleids">CSV list of the staff member role ids to filter by.</param> 
        /// <param name="availablefor">The specific availability type to filter by.</param> 
        /// <returns></returns>            
        public void ScheduleFindallstaffslots (DateTime? starttime, DateTime? endtime, Guid? staffid, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor)
        {
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling ScheduleFindallstaffslots");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling ScheduleFindallstaffslots");
            
    
            var path = "/schedule/findallstaffslots";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (starttime != null) queryParams.Add("starttime", ApiClient.ParameterToString(starttime)); // query parameter
 if (endtime != null) queryParams.Add("endtime", ApiClient.ParameterToString(endtime)); // query parameter
 if (staffid != null) queryParams.Add("staffid", ApiClient.ParameterToString(staffid)); // query parameter
 if (serviceids != null) queryParams.Add("serviceids", ApiClient.ParameterToString(serviceids)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (staffroleids != null) queryParams.Add("staffroleids", ApiClient.ParameterToString(staffroleids)); // query parameter
 if (availablefor != null) queryParams.Add("availablefor", ApiClient.ParameterToString(availablefor)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindallstaffslots: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindallstaffslots: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search available schedule slots by service, event, date and/or staff Allows users to search available slots when making appointments.
        /// </summary>
        /// <param name="staffid">The id of the staff to filter by.</param> 
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="locationid">The id of the service to filter by.</param> 
        /// <param name="availablefor">The specific availability type to filter by.</param> 
        /// <returns></returns>            
        public void ScheduleFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string availablefor)
        {
            
            // verify the required parameter 'staffid' is set
            if (staffid == null) throw new ApiException(400, "Missing required parameter 'staffid' when calling ScheduleFindslots");
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling ScheduleFindslots");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling ScheduleFindslots");
            
    
            var path = "/schedule/findslots";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (staffid != null) queryParams.Add("staffid", ApiClient.ParameterToString(staffid)); // query parameter
 if (starttime != null) queryParams.Add("starttime", ApiClient.ParameterToString(starttime)); // query parameter
 if (endtime != null) queryParams.Add("endtime", ApiClient.ParameterToString(endtime)); // query parameter
 if (serviceids != null) queryParams.Add("serviceids", ApiClient.ParameterToString(serviceids)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (availablefor != null) queryParams.Add("availablefor", ApiClient.ParameterToString(availablefor)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindslots: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindslots: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search available staff members slots by service, event, and/or date Allows users to search available staff.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="serviceids">CSV list of the service ids to filter by.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="locationid">The id of the service to filter by.</param> 
        /// <param name="staffroleids">CSV list of the staff member role ids to filter by.</param> 
        /// <param name="availablefor">Filter slots by a specific availability type.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void ScheduleFindstaffavail (DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid, string staffroleids, string availablefor, int? photosize)
        {
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling ScheduleFindstaffavail");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling ScheduleFindstaffavail");
            
    
            var path = "/schedule/findstaffavail";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceids != null) queryParams.Add("serviceids", ApiClient.ParameterToString(serviceids)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (starttime != null) queryParams.Add("starttime", ApiClient.ParameterToString(starttime)); // query parameter
 if (endtime != null) queryParams.Add("endtime", ApiClient.ParameterToString(endtime)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (staffroleids != null) queryParams.Add("staffroleids", ApiClient.ParameterToString(staffroleids)); // query parameter
 if (availablefor != null) queryParams.Add("availablefor", ApiClient.ParameterToString(availablefor)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindstaffavail: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleFindstaffavail: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of a specific schedule slot Allows the user to view the details of schedule shifts for any user role that the user has permission to view.
        /// </summary>
        /// <param name="scheduleid">The id of the schedule.</param> 
        /// <returns></returns>            
        public void ScheduleGet (Guid? scheduleid)
        {
            
            // verify the required parameter 'scheduleid' is set
            if (scheduleid == null) throw new ApiException(400, "Missing required parameter 'scheduleid' when calling ScheduleGet");
            
    
            var path = "/schedule/get";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scheduleid != null) queryParams.Add("scheduleid", ApiClient.ParameterToString(scheduleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of a specific schedule block, for current user Allows the user to view the details of their own schedule shifts.
        /// </summary>
        /// <param name="scheduleid">The id of the schedule.</param> 
        /// <returns></returns>            
        public void ScheduleGetmine (Guid? scheduleid)
        {
            
            // verify the required parameter 'scheduleid' is set
            if (scheduleid == null) throw new ApiException(400, "Missing required parameter 'scheduleid' when calling ScheduleGetmine");
            
    
            var path = "/schedule/getmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scheduleid != null) queryParams.Add("scheduleid", ApiClient.ParameterToString(scheduleid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of schedule information of a specified person Allows the user to view the schedule shifts for user roles that the user has permission to access.
        /// </summary>
        /// <param name="userid">The id of the user to get info.</param> 
        /// <returns></returns>            
        public void ScheduleGetstaff (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling ScheduleGetstaff");
            
    
            var path = "/schedule/getstaff";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetstaff: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetstaff: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View current user&#39;s schedule information Allows the user to view their own schedule.
        /// </summary>
        /// <returns></returns>            
        public void ScheduleGetstaffmine ()
        {
            
    
            var path = "/schedule/getstaffmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetstaffmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleGetstaffmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View current user&#39;s schedule exceptions Allows the user to view their own schedule exceptions.
        /// </summary>
        /// <param name="includedeleted">If true the deleted offtimes are also returned.</param> 
        /// <param name="onlyupcoming">If true then only upcoming offtimes are returned.</param> 
        /// <param name="modifiedafter">If specified, only offtimes modified after the specified date will be returned.</param> 
        /// <returns></returns>            
        public void ScheduleMyofftimes (bool? includedeleted, bool? onlyupcoming, DateTime? modifiedafter)
        {
            
    
            var path = "/schedule/myofftimes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includedeleted != null) queryParams.Add("includedeleted", ApiClient.ParameterToString(includedeleted)); // query parameter
 if (onlyupcoming != null) queryParams.Add("onlyupcoming", ApiClient.ParameterToString(onlyupcoming)); // query parameter
 if (modifiedafter != null) queryParams.Add("modifiedafter", ApiClient.ParameterToString(modifiedafter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleMyofftimes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleMyofftimes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a schedule slot Allows the user to create or edit a schedule slot of another user.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/schedule/save";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit a block in current user&#39;s schedule Allows the user to create or edit a schedule shift in their own availability.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleSavemine (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/schedule/savemine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(UNKNOWN_BASE_TYPE); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleSavemine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleSavemine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
