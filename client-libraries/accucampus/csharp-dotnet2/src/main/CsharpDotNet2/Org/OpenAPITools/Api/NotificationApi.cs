using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationApi
    {
        /// <summary>
        /// Delete a notification Allows the user to delete an existing notification.
        /// </summary>
        /// <param name="id">The id of the notification to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void NotificationDelete (Guid? id, AnyType body);
        /// <summary>
        /// View a notification 
        /// </summary>
        /// <param name="id">The id of the notification to get.</param>
        /// <returns></returns>
        void NotificationGet (Guid? id);
        /// <summary>
        /// Gets all public (in station) notifications for the specific user 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param>
        /// <param name="user">The card of the user.</param>
        /// <returns></returns>
        void NotificationGetforstation (Guid? station, string user);
        /// <summary>
        /// Get the number of unread notifications 
        /// </summary>
        /// <returns></returns>
        void NotificationGetunreadcount ();
        /// <summary>
        /// View a list of all sent notifications Allows the user to view the list of all sent notifications.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="recipient">The recipient whose notifications have to be listed.</param>
        /// <param name="status">The status of the notifications to list. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <param name="sentonscreen">Specifies whether to list the notifications that were sent on-screen or not.</param>
        /// <param name="sentemail">Specifies whether to list the notifications that were sent via e-mail or not.</param>
        /// <param name="sentsms">Specifies whether to list the notifications that were sent via sms or not.</param>
        /// <returns></returns>
        void NotificationList (int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms);
        /// <summary>
        /// View all the notifications sent to the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="status">Specifies the status of the notifications to list. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void NotificationListmine (int? from, int? count, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Mark a notification as read 
        /// </summary>
        /// <param name="id">The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.</param>
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void NotificationMarkasread (Guid? id, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Mark a notification as unread 
        /// </summary>
        /// <param name="id">The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.</param>
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param>
        /// <param name="startdate">The start date of the period to filter the notifications.</param>
        /// <param name="enddate">The end date of the period to filter the notifications.</param>
        /// <returns></returns>
        void NotificationMarkasunread (Guid? id, int? status, DateTime? startdate, DateTime? enddate);
        /// <summary>
        /// Send notifications on screen, via email or text to users Allows the user to send notifications to other users through the Send Message link.
        /// </summary>
        /// <param name="emailenabled">Whether send the notification via email.</param>
        /// <param name="onscreenenabled">Whether to display the notification on screen.</param>
        /// <param name="smsenabled">Whether to send the notification via text message.</param>
        /// <param name="title">Notification title.</param>
        /// <param name="tousers">Comma-separated Ids of users to send the notification.</param>
        /// <param name="togroups">Comma-separated Ids of user groups to send the notification.</param>
        /// <param name="onscreenbody">Body of the message for on-screen display.</param>
        /// <param name="onscreenclick">What to do when the notification is clicked. Valid values: hide, view, url.</param>
        /// <param name="onscreenurl">Url to redirect the user, if onscreenclick&#x3D;url.</param>
        /// <param name="onscreenclass">How to display the notification. Valid values: info, success, warning, error</param>
        /// <param name="onscreenduration">Time in seconds to display the notification.</param>
        /// <param name="showonstation">Whether to show the notification in the sign-in station.</param>
        /// <param name="emailfromname">Name of the email sender.</param>
        /// <param name="emailfrom">Reply-to email.</param>
        /// <param name="emailsubject">Subject of the email.</param>
        /// <param name="emailbody">Body of the email.</param>
        /// <param name="textmessagebody">Message for SMS. Max 160 characters.</param>
        /// <returns></returns>
        void NotificationSend (bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody);
        /// <summary>
        /// Send on-screen notifications 
        /// </summary>
        /// <param name="notification">The ID of the notification to send.</param>
        /// <returns></returns>
        void NotificationSendonscreen (Guid? notification);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class NotificationApi : INotificationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public NotificationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi(String basePath)
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
        /// Delete a notification Allows the user to delete an existing notification.
        /// </summary>
        /// <param name="id">The id of the notification to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void NotificationDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling NotificationDelete");
            
    
            var path = "/notification/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter
    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a notification 
        /// </summary>
        /// <param name="id">The id of the notification to get.</param> 
        /// <returns></returns>            
        public void NotificationGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling NotificationGet");
            
    
            var path = "/notification/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all public (in station) notifications for the specific user 
        /// </summary>
        /// <param name="station">The id of the sign-in station to get.</param> 
        /// <param name="user">The card of the user.</param> 
        /// <returns></returns>            
        public void NotificationGetforstation (Guid? station, string user)
        {
            
            // verify the required parameter 'station' is set
            if (station == null) throw new ApiException(400, "Missing required parameter 'station' when calling NotificationGetforstation");
            
            // verify the required parameter 'user' is set
            if (user == null) throw new ApiException(400, "Missing required parameter 'user' when calling NotificationGetforstation");
            
    
            var path = "/notification/getforstation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (station != null) queryParams.Add("station", ApiClient.ParameterToString(station)); // query parameter
 if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGetforstation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGetforstation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the number of unread notifications 
        /// </summary>
        /// <returns></returns>            
        public void NotificationGetunreadcount ()
        {
            
    
            var path = "/notification/getunreadcount";
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
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGetunreadcount: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationGetunreadcount: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of all sent notifications Allows the user to view the list of all sent notifications.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="recipient">The recipient whose notifications have to be listed.</param> 
        /// <param name="status">The status of the notifications to list. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <param name="sentonscreen">Specifies whether to list the notifications that were sent on-screen or not.</param> 
        /// <param name="sentemail">Specifies whether to list the notifications that were sent via e-mail or not.</param> 
        /// <param name="sentsms">Specifies whether to list the notifications that were sent via sms or not.</param> 
        /// <returns></returns>            
        public void NotificationList (int? from, int? count, Guid? recipient, int? status, DateTime? startdate, DateTime? enddate, bool? sentonscreen, bool? sentemail, bool? sentsms)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling NotificationList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling NotificationList");
            
    
            var path = "/notification/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (recipient != null) queryParams.Add("recipient", ApiClient.ParameterToString(recipient)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (sentonscreen != null) queryParams.Add("sentonscreen", ApiClient.ParameterToString(sentonscreen)); // query parameter
 if (sentemail != null) queryParams.Add("sentemail", ApiClient.ParameterToString(sentemail)); // query parameter
 if (sentsms != null) queryParams.Add("sentsms", ApiClient.ParameterToString(sentsms)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the notifications sent to the current user 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="status">Specifies the status of the notifications to list. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void NotificationListmine (int? from, int? count, int? status, DateTime? startdate, DateTime? enddate)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling NotificationListmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling NotificationListmine");
            
    
            var path = "/notification/listmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationListmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationListmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mark a notification as read 
        /// </summary>
        /// <param name="id">The id of the notification to mark as read. If not specified all notifications of the logged user will be marked as read.</param> 
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void NotificationMarkasread (Guid? id, int? status, DateTime? startdate, DateTime? enddate)
        {
            
    
            var path = "/notification/markasread";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationMarkasread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationMarkasread: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Mark a notification as unread 
        /// </summary>
        /// <param name="id">The id of the notification to mark as unread. If not specified all notifications of the logged user will be marked as unread.</param> 
        /// <param name="status">Specifies the status to filter the notifications. Read, Unread or All.</param> 
        /// <param name="startdate">The start date of the period to filter the notifications.</param> 
        /// <param name="enddate">The end date of the period to filter the notifications.</param> 
        /// <returns></returns>            
        public void NotificationMarkasunread (Guid? id, int? status, DateTime? startdate, DateTime? enddate)
        {
            
    
            var path = "/notification/markasunread";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationMarkasunread: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationMarkasunread: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send notifications on screen, via email or text to users Allows the user to send notifications to other users through the Send Message link.
        /// </summary>
        /// <param name="emailenabled">Whether send the notification via email.</param> 
        /// <param name="onscreenenabled">Whether to display the notification on screen.</param> 
        /// <param name="smsenabled">Whether to send the notification via text message.</param> 
        /// <param name="title">Notification title.</param> 
        /// <param name="tousers">Comma-separated Ids of users to send the notification.</param> 
        /// <param name="togroups">Comma-separated Ids of user groups to send the notification.</param> 
        /// <param name="onscreenbody">Body of the message for on-screen display.</param> 
        /// <param name="onscreenclick">What to do when the notification is clicked. Valid values: hide, view, url.</param> 
        /// <param name="onscreenurl">Url to redirect the user, if onscreenclick&#x3D;url.</param> 
        /// <param name="onscreenclass">How to display the notification. Valid values: info, success, warning, error</param> 
        /// <param name="onscreenduration">Time in seconds to display the notification.</param> 
        /// <param name="showonstation">Whether to show the notification in the sign-in station.</param> 
        /// <param name="emailfromname">Name of the email sender.</param> 
        /// <param name="emailfrom">Reply-to email.</param> 
        /// <param name="emailsubject">Subject of the email.</param> 
        /// <param name="emailbody">Body of the email.</param> 
        /// <param name="textmessagebody">Message for SMS. Max 160 characters.</param> 
        /// <returns></returns>            
        public void NotificationSend (bool? emailenabled, bool? onscreenenabled, bool? smsenabled, string title, string tousers, string togroups, string onscreenbody, string onscreenclick, string onscreenurl, string onscreenclass, int? onscreenduration, int? showonstation, string emailfromname, string emailfrom, string emailsubject, string emailbody, string textmessagebody)
        {
            
            // verify the required parameter 'emailenabled' is set
            if (emailenabled == null) throw new ApiException(400, "Missing required parameter 'emailenabled' when calling NotificationSend");
            
            // verify the required parameter 'onscreenenabled' is set
            if (onscreenenabled == null) throw new ApiException(400, "Missing required parameter 'onscreenenabled' when calling NotificationSend");
            
            // verify the required parameter 'smsenabled' is set
            if (smsenabled == null) throw new ApiException(400, "Missing required parameter 'smsenabled' when calling NotificationSend");
            
            // verify the required parameter 'title' is set
            if (title == null) throw new ApiException(400, "Missing required parameter 'title' when calling NotificationSend");
            
    
            var path = "/notification/send";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tousers != null) queryParams.Add("tousers", ApiClient.ParameterToString(tousers)); // query parameter
 if (togroups != null) queryParams.Add("togroups", ApiClient.ParameterToString(togroups)); // query parameter
 if (emailenabled != null) queryParams.Add("emailenabled", ApiClient.ParameterToString(emailenabled)); // query parameter
 if (onscreenenabled != null) queryParams.Add("onscreenenabled", ApiClient.ParameterToString(onscreenenabled)); // query parameter
 if (smsenabled != null) queryParams.Add("smsenabled", ApiClient.ParameterToString(smsenabled)); // query parameter
 if (title != null) queryParams.Add("title", ApiClient.ParameterToString(title)); // query parameter
 if (onscreenbody != null) queryParams.Add("onscreenbody", ApiClient.ParameterToString(onscreenbody)); // query parameter
 if (onscreenclick != null) queryParams.Add("onscreenclick", ApiClient.ParameterToString(onscreenclick)); // query parameter
 if (onscreenurl != null) queryParams.Add("onscreenurl", ApiClient.ParameterToString(onscreenurl)); // query parameter
 if (onscreenclass != null) queryParams.Add("onscreenclass", ApiClient.ParameterToString(onscreenclass)); // query parameter
 if (onscreenduration != null) queryParams.Add("onscreenduration", ApiClient.ParameterToString(onscreenduration)); // query parameter
 if (showonstation != null) queryParams.Add("showonstation", ApiClient.ParameterToString(showonstation)); // query parameter
 if (emailfromname != null) queryParams.Add("emailfromname", ApiClient.ParameterToString(emailfromname)); // query parameter
 if (emailfrom != null) queryParams.Add("emailfrom", ApiClient.ParameterToString(emailfrom)); // query parameter
 if (emailsubject != null) queryParams.Add("emailsubject", ApiClient.ParameterToString(emailsubject)); // query parameter
 if (emailbody != null) queryParams.Add("emailbody", ApiClient.ParameterToString(emailbody)); // query parameter
 if (textmessagebody != null) queryParams.Add("textmessagebody", ApiClient.ParameterToString(textmessagebody)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationSend: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationSend: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Send on-screen notifications 
        /// </summary>
        /// <param name="notification">The ID of the notification to send.</param> 
        /// <returns></returns>            
        public void NotificationSendonscreen (Guid? notification)
        {
            
            // verify the required parameter 'notification' is set
            if (notification == null) throw new ApiException(400, "Missing required parameter 'notification' when calling NotificationSendonscreen");
            
    
            var path = "/notification/sendonscreen";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (notification != null) queryParams.Add("notification", ApiClient.ParameterToString(notification)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationSendonscreen: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling NotificationSendonscreen: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
