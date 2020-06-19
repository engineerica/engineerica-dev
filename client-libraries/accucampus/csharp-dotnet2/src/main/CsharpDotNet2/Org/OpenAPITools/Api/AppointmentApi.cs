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
    public interface IAppointmentApi
    {
        /// <summary>
        /// Cancel an appointment Allows the user to cancel an appointment.
        /// </summary>
        /// <param name="id">The id of the appointment to cancel.</param>
        /// <returns></returns>
        void AppointmentCancel (Guid? id);
        /// <summary>
        /// Check if an appointment is valid or not 
        /// </summary>
        /// <param name="id">The id of the appointment to check.</param>
        /// <param name="editing">Specifies whether the check is for a new appointment or an existing one.</param>
        /// <returns></returns>
        void AppointmentCheckisvalid (Guid? id, bool? editing);
        /// <summary>
        /// Edit an appointment even if it breaks activated rules Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.
        /// </summary>
        /// <param name="id">The id of the appointment to edit.</param>
        /// <param name="attendee">The id of the attendee involved in the appointment.</param>
        /// <param name="staff">The id of the staff member involved in the appointment.</param>
        /// <param name="location">The id of the location where the appointment will take place.</param>
        /// <param name="start">The appointment&#39;s start date &amp; time.</param>
        /// <param name="end">The appointment&#39;s end date &amp; time.</param>
        /// <param name="term">The id of the term when the appointment takes place.</param>
        /// <param name="_event">The id of the event of the appointment.</param>
        /// <param name="services">Comma-separated string containing the ids of the services of the appointment.</param>
        /// <param name="notes">The notes of the appointment.</param>
        /// <returns></returns>
        void AppointmentEditanyway (Guid? id, Guid? attendee, Guid? staff, Guid? location, DateTime? start, DateTime? end, Guid? term, Guid? _event, string services, string notes);
        /// <summary>
        /// Edit the no-show status of an appointment Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.
        /// </summary>
        /// <param name="id">The id of the appointment to edit its presence.</param>
        /// <param name="showedup">Specifies whether the attendee was showed-up or not in the appointment.</param>
        /// <returns></returns>
        void AppointmentEditpresence (Guid? id, bool? showedup);
        /// <summary>
        /// Finds all staff available slots filtered by service, date, etc Allows the user to view available appointment slots when creating an appointment.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param>
        /// <param name="locationid">The id of the service to filter by.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void AppointmentFindallstaffslots (DateTime? starttime, DateTime? endtime, string serviceids, Guid? locationid, Guid? eventid, int? photosize);
        /// <summary>
        /// Finds available slots filtered by service, date, staff, etc Allows the user to view available appointment slots when creating an appointment.
        /// </summary>
        /// <param name="staffid">The id of the staff to filter by.</param>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="locationid">The id of the service to filter by.</param>
        /// <returns></returns>
        void AppointmentFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid);
        /// <summary>
        /// Finds staff available by service, date, event, etc Allows the user to view staff availability when creating an appointment.
        /// </summary>
        /// <param name="serviceids">CSV list of the service ids to filter by.</param>
        /// <param name="starttime">The start time of the range to look for slots.</param>
        /// <param name="endtime">The end time of the range to look for slots.</param>
        /// <param name="eventid">The id of the event to filter by.</param>
        /// <param name="locationid">The id of the service to filter by.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void AppointmentFindstaff (string serviceids, DateTime? starttime, DateTime? endtime, Guid? eventid, Guid? locationid, int? photosize);
        /// <summary>
        /// Search and view details of an appointment Allows the user to view an individual appointment and its details.
        /// </summary>
        /// <param name="id">The id of the appointment to get.</param>
        /// <returns></returns>
        void AppointmentGet (Guid? id);
        /// <summary>
        /// Get the current appointments for the user that is about to sign-in via the specified sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <param name="location">The id of the location where the user wants to sign-in.</param>
        /// <returns></returns>
        void AppointmentGetcurrent (Guid? station, string user, Guid? location);
        /// <summary>
        /// Find locations where a service is available Allows the user to search for appointment availability by location or service.
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param>
        /// <returns></returns>
        void AppointmentGetlocations (Guid? serviceid);
        /// <summary>
        /// View a list of appointments Allows the user to view all upcoming appointments for the location or locations they are scoped to.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="startdate">The start date of the period to filter the appointments.</param>
        /// <param name="enddate">The end date of the period to filter the appointments.</param>
        /// <param name="userid">The attendee id to filter the appointments.</param>
        /// <returns></returns>
        void AppointmentList (int? from, int? count, DateTime? startdate, DateTime? enddate, Guid? userid);
        /// <summary>
        /// View all my upcoming appointments 
        /// </summary>
        /// <param name="start">If specified, only appointments that start after the specified date will be returned.</param>
        /// <param name="modifiedafter">If specified, only appointments modified after the specified date will be returned.</param>
        /// <returns></returns>
        void AppointmentListmine (DateTime? start, DateTime? modifiedafter);
        /// <summary>
        /// Search and view details of all my upcoming appointments Allows the user to view all of their own upcoming appointments.
        /// </summary>
        /// <param name="start">If specified, only appointments that start after the specified date will be returned.</param>
        /// <param name="modifiedafter">If specified, only appointments modified after the specified date will be returned.</param>
        /// <returns></returns>
        void AppointmentListupcoming (DateTime? start, DateTime? modifiedafter);
        /// <summary>
        /// Reschedule an appointment from MS Outlook. Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.
        /// </summary>
        /// <param name="id">The id of the appointment to edit.</param>
        /// <param name="start">The appointment&#39;s start date &amp; time.</param>
        /// <param name="end">The appointment&#39;s end date &amp; time.</param>
        /// <returns></returns>
        void AppointmentRescheduleoutlook (Guid? id, DateTime? start, DateTime? end);
        /// <summary>
        /// Restore an appointment Allows the user to restore a canceled appointment.
        /// </summary>
        /// <param name="id">The id of the appointment to restore.</param>
        /// <returns></returns>
        void AppointmentRestore (Guid? id);
        /// <summary>
        /// Restore an appointment even if it breaks activated rules Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.
        /// </summary>
        /// <param name="id">The id of the appointment to restore.</param>
        /// <returns></returns>
        void AppointmentRestoreanyway (Guid? id);
        /// <summary>
        /// Schedule an appointment Allows the user to schedule an appointment within the rules of the location and the availability of staff members.
        /// </summary>
        /// <param name="id">The id of the appointment to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void AppointmentSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Schedule an appointment even if it breaks activated rules Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.
        /// </summary>
        /// <param name="id">The id of the appointment to set as valid.</param>
        /// <returns></returns>
        void AppointmentSetasvalid (Guid? id);
        /// <summary>
        /// View the locations with most appointments Allows the user to view suggestions for the most popular locations in which to make appointments
        /// </summary>
        /// <returns></returns>
        void AppointmentSuggestlocations ();
        /// <summary>
        /// View the services with most appointments Allows the user to view suggestions for the most popular services for which to make appointments.
        /// </summary>
        /// <returns></returns>
        void AppointmentSuggestservices ();
        /// <summary>
        /// Void an appointment Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.
        /// </summary>
        /// <param name="id">The id of the appointment to cancel.</param>
        /// <returns></returns>
        void AppointmentVoid (Guid? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AppointmentApi : IAppointmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AppointmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AppointmentApi(String basePath)
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
        /// Cancel an appointment Allows the user to cancel an appointment.
        /// </summary>
        /// <param name="id">The id of the appointment to cancel.</param> 
        /// <returns></returns>            
        public void AppointmentCancel (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentCancel");
            
    
            var path = "/appointment/cancel";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentCancel: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentCancel: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Check if an appointment is valid or not 
        /// </summary>
        /// <param name="id">The id of the appointment to check.</param> 
        /// <param name="editing">Specifies whether the check is for a new appointment or an existing one.</param> 
        /// <returns></returns>            
        public void AppointmentCheckisvalid (Guid? id, bool? editing)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentCheckisvalid");
            
    
            var path = "/appointment/checkisvalid";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (editing != null) queryParams.Add("editing", ApiClient.ParameterToString(editing)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentCheckisvalid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentCheckisvalid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit an appointment even if it breaks activated rules Allows the user to edit an existing appointment even if it breaks the rules or settings of that location.
        /// </summary>
        /// <param name="id">The id of the appointment to edit.</param> 
        /// <param name="attendee">The id of the attendee involved in the appointment.</param> 
        /// <param name="staff">The id of the staff member involved in the appointment.</param> 
        /// <param name="location">The id of the location where the appointment will take place.</param> 
        /// <param name="start">The appointment&#39;s start date &amp; time.</param> 
        /// <param name="end">The appointment&#39;s end date &amp; time.</param> 
        /// <param name="term">The id of the term when the appointment takes place.</param> 
        /// <param name="_event">The id of the event of the appointment.</param> 
        /// <param name="services">Comma-separated string containing the ids of the services of the appointment.</param> 
        /// <param name="notes">The notes of the appointment.</param> 
        /// <returns></returns>            
        public void AppointmentEditanyway (Guid? id, Guid? attendee, Guid? staff, Guid? location, DateTime? start, DateTime? end, Guid? term, Guid? _event, string services, string notes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentEditanyway");
            
            // verify the required parameter 'attendee' is set
            if (attendee == null) throw new ApiException(400, "Missing required parameter 'attendee' when calling AppointmentEditanyway");
            
            // verify the required parameter 'staff' is set
            if (staff == null) throw new ApiException(400, "Missing required parameter 'staff' when calling AppointmentEditanyway");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AppointmentEditanyway");
            
            // verify the required parameter 'start' is set
            if (start == null) throw new ApiException(400, "Missing required parameter 'start' when calling AppointmentEditanyway");
            
            // verify the required parameter 'end' is set
            if (end == null) throw new ApiException(400, "Missing required parameter 'end' when calling AppointmentEditanyway");
            
    
            var path = "/appointment/editanyway";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (term != null) queryParams.Add("term", ApiClient.ParameterToString(term)); // query parameter
 if (attendee != null) queryParams.Add("attendee", ApiClient.ParameterToString(attendee)); // query parameter
 if (staff != null) queryParams.Add("staff", ApiClient.ParameterToString(staff)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
 if (_event != null) queryParams.Add("event", ApiClient.ParameterToString(_event)); // query parameter
 if (services != null) queryParams.Add("services", ApiClient.ParameterToString(services)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentEditanyway: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentEditanyway: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Edit the no-show status of an appointment Allows the user to edit the no-show status of an appointment by marking it as Voided, Restored, or as a Show.
        /// </summary>
        /// <param name="id">The id of the appointment to edit its presence.</param> 
        /// <param name="showedup">Specifies whether the attendee was showed-up or not in the appointment.</param> 
        /// <returns></returns>            
        public void AppointmentEditpresence (Guid? id, bool? showedup)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentEditpresence");
            
            // verify the required parameter 'showedup' is set
            if (showedup == null) throw new ApiException(400, "Missing required parameter 'showedup' when calling AppointmentEditpresence");
            
    
            var path = "/appointment/editpresence";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (showedup != null) queryParams.Add("showedup", ApiClient.ParameterToString(showedup)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentEditpresence: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentEditpresence: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Finds all staff available slots filtered by service, date, etc Allows the user to view available appointment slots when creating an appointment.
        /// </summary>
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param> 
        /// <param name="locationid">The id of the service to filter by.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void AppointmentFindallstaffslots (DateTime? starttime, DateTime? endtime, string serviceids, Guid? locationid, Guid? eventid, int? photosize)
        {
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling AppointmentFindallstaffslots");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling AppointmentFindallstaffslots");
            
            // verify the required parameter 'serviceids' is set
            if (serviceids == null) throw new ApiException(400, "Missing required parameter 'serviceids' when calling AppointmentFindallstaffslots");
            
            // verify the required parameter 'locationid' is set
            if (locationid == null) throw new ApiException(400, "Missing required parameter 'locationid' when calling AppointmentFindallstaffslots");
            
    
            var path = "/appointment/findallstaffslots";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (starttime != null) queryParams.Add("starttime", ApiClient.ParameterToString(starttime)); // query parameter
 if (endtime != null) queryParams.Add("endtime", ApiClient.ParameterToString(endtime)); // query parameter
 if (serviceids != null) queryParams.Add("serviceids", ApiClient.ParameterToString(serviceids)); // query parameter
 if (eventid != null) queryParams.Add("eventid", ApiClient.ParameterToString(eventid)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindallstaffslots: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindallstaffslots: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Finds available slots filtered by service, date, staff, etc Allows the user to view available appointment slots when creating an appointment.
        /// </summary>
        /// <param name="staffid">The id of the staff to filter by.</param> 
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="serviceids">CSV list of the service Ids to filter by.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="locationid">The id of the service to filter by.</param> 
        /// <returns></returns>            
        public void AppointmentFindslots (Guid? staffid, DateTime? starttime, DateTime? endtime, string serviceids, Guid? eventid, Guid? locationid)
        {
            
            // verify the required parameter 'staffid' is set
            if (staffid == null) throw new ApiException(400, "Missing required parameter 'staffid' when calling AppointmentFindslots");
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling AppointmentFindslots");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling AppointmentFindslots");
            
            // verify the required parameter 'serviceids' is set
            if (serviceids == null) throw new ApiException(400, "Missing required parameter 'serviceids' when calling AppointmentFindslots");
            
    
            var path = "/appointment/findslots";
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
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindslots: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindslots: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Finds staff available by service, date, event, etc Allows the user to view staff availability when creating an appointment.
        /// </summary>
        /// <param name="serviceids">CSV list of the service ids to filter by.</param> 
        /// <param name="starttime">The start time of the range to look for slots.</param> 
        /// <param name="endtime">The end time of the range to look for slots.</param> 
        /// <param name="eventid">The id of the event to filter by.</param> 
        /// <param name="locationid">The id of the service to filter by.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void AppointmentFindstaff (string serviceids, DateTime? starttime, DateTime? endtime, Guid? eventid, Guid? locationid, int? photosize)
        {
            
            // verify the required parameter 'serviceids' is set
            if (serviceids == null) throw new ApiException(400, "Missing required parameter 'serviceids' when calling AppointmentFindstaff");
            
            // verify the required parameter 'starttime' is set
            if (starttime == null) throw new ApiException(400, "Missing required parameter 'starttime' when calling AppointmentFindstaff");
            
            // verify the required parameter 'endtime' is set
            if (endtime == null) throw new ApiException(400, "Missing required parameter 'endtime' when calling AppointmentFindstaff");
            
    
            var path = "/appointment/findstaff";
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
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindstaff: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentFindstaff: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an appointment Allows the user to view an individual appointment and its details.
        /// </summary>
        /// <param name="id">The id of the appointment to get.</param> 
        /// <returns></returns>            
        public void AppointmentGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentGet");
            
    
            var path = "/appointment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the current appointments for the user that is about to sign-in via the specified sign-in station. 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <param name="location">The id of the location where the user wants to sign-in.</param> 
        /// <returns></returns>            
        public void AppointmentGetcurrent (Guid? station, string user, Guid? location)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling AppointmentGetcurrent");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling AppointmentGetcurrent");
            
            // verify the required parameter 'location' is set
            if (location == null) throw new ApiException(400, "Missing required parameter 'location' when calling AppointmentGetcurrent");
            
    
            var path = "/appointment/getcurrent";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (location != null) queryParams.Add("location", ApiClient.ParameterToString(location)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGetcurrent: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGetcurrent: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Find locations where a service is available Allows the user to search for appointment availability by location or service.
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param> 
        /// <returns></returns>            
        public void AppointmentGetlocations (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling AppointmentGetlocations");
            
    
            var path = "/appointment/getlocations";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGetlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentGetlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of appointments Allows the user to view all upcoming appointments for the location or locations they are scoped to.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="startdate">The start date of the period to filter the appointments.</param> 
        /// <param name="enddate">The end date of the period to filter the appointments.</param> 
        /// <param name="userid">The attendee id to filter the appointments.</param> 
        /// <returns></returns>            
        public void AppointmentList (int? from, int? count, DateTime? startdate, DateTime? enddate, Guid? userid)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling AppointmentList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling AppointmentList");
            
    
            var path = "/appointment/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all my upcoming appointments 
        /// </summary>
        /// <param name="start">If specified, only appointments that start after the specified date will be returned.</param> 
        /// <param name="modifiedafter">If specified, only appointments modified after the specified date will be returned.</param> 
        /// <returns></returns>            
        public void AppointmentListmine (DateTime? start, DateTime? modifiedafter)
        {
            
    
            var path = "/appointment/listmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (modifiedafter != null) queryParams.Add("modifiedafter", ApiClient.ParameterToString(modifiedafter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentListmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentListmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of all my upcoming appointments Allows the user to view all of their own upcoming appointments.
        /// </summary>
        /// <param name="start">If specified, only appointments that start after the specified date will be returned.</param> 
        /// <param name="modifiedafter">If specified, only appointments modified after the specified date will be returned.</param> 
        /// <returns></returns>            
        public void AppointmentListupcoming (DateTime? start, DateTime? modifiedafter)
        {
            
    
            var path = "/appointment/listupcoming";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (modifiedafter != null) queryParams.Add("modifiedafter", ApiClient.ParameterToString(modifiedafter)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentListupcoming: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentListupcoming: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Reschedule an appointment from MS Outlook. Allows the user to reschedule, edit, or cancel appointments via MS Outlook if the user has the AccuCampus add-on installed on their Outlook.
        /// </summary>
        /// <param name="id">The id of the appointment to edit.</param> 
        /// <param name="start">The appointment&#39;s start date &amp; time.</param> 
        /// <param name="end">The appointment&#39;s end date &amp; time.</param> 
        /// <returns></returns>            
        public void AppointmentRescheduleoutlook (Guid? id, DateTime? start, DateTime? end)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentRescheduleoutlook");
            
            // verify the required parameter 'start' is set
            if (start == null) throw new ApiException(400, "Missing required parameter 'start' when calling AppointmentRescheduleoutlook");
            
            // verify the required parameter 'end' is set
            if (end == null) throw new ApiException(400, "Missing required parameter 'end' when calling AppointmentRescheduleoutlook");
            
    
            var path = "/appointment/rescheduleoutlook";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (start != null) queryParams.Add("start", ApiClient.ParameterToString(start)); // query parameter
 if (end != null) queryParams.Add("end", ApiClient.ParameterToString(end)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRescheduleoutlook: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRescheduleoutlook: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Restore an appointment Allows the user to restore a canceled appointment.
        /// </summary>
        /// <param name="id">The id of the appointment to restore.</param> 
        /// <returns></returns>            
        public void AppointmentRestore (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentRestore");
            
    
            var path = "/appointment/restore";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRestore: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRestore: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Restore an appointment even if it breaks activated rules Allows the user to restore a canceled appointment even if that appointment breaks the rules or settings of that location.
        /// </summary>
        /// <param name="id">The id of the appointment to restore.</param> 
        /// <returns></returns>            
        public void AppointmentRestoreanyway (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentRestoreanyway");
            
    
            var path = "/appointment/restoreanyway";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRestoreanyway: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentRestoreanyway: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Schedule an appointment Allows the user to schedule an appointment within the rules of the location and the availability of staff members.
        /// </summary>
        /// <param name="id">The id of the appointment to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void AppointmentSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentSave");
            
    
            var path = "/appointment/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Schedule an appointment even if it breaks activated rules Allows the user to schedule an appointment even if it breaks the rules or settings of that location or if it goes against the availability of the staff member.
        /// </summary>
        /// <param name="id">The id of the appointment to set as valid.</param> 
        /// <returns></returns>            
        public void AppointmentSetasvalid (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentSetasvalid");
            
    
            var path = "/appointment/setasvalid";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSetasvalid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSetasvalid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the locations with most appointments Allows the user to view suggestions for the most popular locations in which to make appointments
        /// </summary>
        /// <returns></returns>            
        public void AppointmentSuggestlocations ()
        {
            
    
            var path = "/appointment/suggestlocations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSuggestlocations: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSuggestlocations: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the services with most appointments Allows the user to view suggestions for the most popular services for which to make appointments.
        /// </summary>
        /// <returns></returns>            
        public void AppointmentSuggestservices ()
        {
            
    
            var path = "/appointment/suggestservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSuggestservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentSuggestservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Void an appointment Allows the user to void an appointment that has been marked as a no-show so that it does not count against the student&#39;s restrictions.
        /// </summary>
        /// <param name="id">The id of the appointment to cancel.</param> 
        /// <returns></returns>            
        public void AppointmentVoid (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling AppointmentVoid");
            
    
            var path = "/appointment/void";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentVoid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AppointmentVoid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
