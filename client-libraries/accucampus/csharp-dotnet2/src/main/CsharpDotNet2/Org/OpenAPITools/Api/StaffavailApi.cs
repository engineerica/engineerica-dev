using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStaffavailApi
    {
        /// <summary>
        /// Associate current user to all services Allows the user to associate themselves to all services, provided they have a staff role.
        /// </summary>
        /// <returns></returns>
        void StaffavailAddmetoallservices ();
        /// <summary>
        /// Associate current user to a service Allows the user to associate themselves to a service, provided they have a staff role.
        /// </summary>
        /// <param name="serviceid">The id of the service.</param>
        /// <returns></returns>
        void StaffavailAddmetoservice (Guid? serviceid);
        /// <summary>
        /// Associate a staff member to all services Allows the user to make a staff member available for all services.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <returns></returns>
        void StaffavailAddusertoallservices (Guid? userid);
        /// <summary>
        /// Associate a staff member to a service Allows the user to make a staff member available for a service.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param>
        /// <param name="serviceid">The id of the service.</param>
        /// <returns></returns>
        void StaffavailAddusertoservice (Guid? userid, Guid? serviceid);
        /// <summary>
        /// View the services the current user is available for Allows the user to view a list of services that they are associated with.
        /// </summary>
        /// <returns></returns>
        void StaffavailGetmyservices ();
        /// <summary>
        /// View a list of services that a staff member is available for Allows the user to view the list of services that a staff member is available for.
        /// </summary>
        /// <param name="userid">The user id to list services.</param>
        /// <returns></returns>
        void StaffavailGetservices (Guid? userid);
        /// <summary>
        /// View a list of staff members that are available for a specific service Allows the user to view all staff members who are available for a service.
        /// </summary>
        /// <param name="serviceid">The service id to list users.</param>
        /// <returns></returns>
        void StaffavailGetusersforservice (Guid? serviceid);
        /// <summary>
        /// View all the availability types 
        /// </summary>
        /// <returns></returns>
        void StaffavailListtypes ();
        /// <summary>
        /// Remove current user from all services Allows the user to disassociate themselves from all services, provided they have a staff role.
        /// </summary>
        /// <returns></returns>
        void StaffavailRemovemefromallservices ();
        /// <summary>
        /// Remove current user from a service Allows the user to disassociate themselves from a service, provided they have a staff role.
        /// </summary>
        /// <param name="serviceid">The id of the service.</param>
        /// <returns></returns>
        void StaffavailRemovemefromservice (Guid? serviceid);
        /// <summary>
        /// Removes a staff member from the registration to all services Allows the user to remove a staff member&#39;s availability to all services.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <returns></returns>
        void StaffavailRemoveuserfromallservices (Guid? userid);
        /// <summary>
        /// Remove a staff member from a service Allows the user to remove a staff member&#39;s service availability.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param>
        /// <param name="serviceid">The id of the service.</param>
        /// <returns></returns>
        void StaffavailRemoveuserfromservice (Guid? userid, Guid? serviceid);
        /// <summary>
        /// Make a staff member available for a specific availability type Allows the user to set a staff member as available for walk ins, appointments, or both.
        /// </summary>
        /// <param name="userid">The id of the user whose specific availability has to be set.</param>
        /// <param name="availablefor">Specific availability to set.</param>
        /// <returns></returns>
        void StaffavailSetavailability (Guid? userid, string availablefor);
        /// <summary>
        /// Change current user&#39;s availability type Allows the user to make themselves available for walk ins, appointments, or both.
        /// </summary>
        /// <param name="availablefor">Specific availability to set.</param>
        /// <returns></returns>
        void StaffavailSetmyavailability (string availablefor);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StaffavailApi : IStaffavailApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffavailApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StaffavailApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StaffavailApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StaffavailApi(String basePath)
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
        /// Associate current user to all services Allows the user to associate themselves to all services, provided they have a staff role.
        /// </summary>
        /// <returns></returns>            
        public void StaffavailAddmetoallservices ()
        {
            
    
            var path = "/staffavail/addmetoallservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddmetoallservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddmetoallservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Associate current user to a service Allows the user to associate themselves to a service, provided they have a staff role.
        /// </summary>
        /// <param name="serviceid">The id of the service.</param> 
        /// <returns></returns>            
        public void StaffavailAddmetoservice (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling StaffavailAddmetoservice");
            
    
            var path = "/staffavail/addmetoservice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddmetoservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddmetoservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Associate a staff member to all services Allows the user to make a staff member available for all services.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <returns></returns>            
        public void StaffavailAddusertoallservices (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailAddusertoallservices");
            
    
            var path = "/staffavail/addusertoallservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddusertoallservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddusertoallservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Associate a staff member to a service Allows the user to make a staff member available for a service.
        /// </summary>
        /// <param name="userid">The id of the user to add.</param> 
        /// <param name="serviceid">The id of the service.</param> 
        /// <returns></returns>            
        public void StaffavailAddusertoservice (Guid? userid, Guid? serviceid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailAddusertoservice");
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling StaffavailAddusertoservice");
            
    
            var path = "/staffavail/addusertoservice";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddusertoservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailAddusertoservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the services the current user is available for Allows the user to view a list of services that they are associated with.
        /// </summary>
        /// <returns></returns>            
        public void StaffavailGetmyservices ()
        {
            
    
            var path = "/staffavail/getmyservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetmyservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetmyservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of services that a staff member is available for Allows the user to view the list of services that a staff member is available for.
        /// </summary>
        /// <param name="userid">The user id to list services.</param> 
        /// <returns></returns>            
        public void StaffavailGetservices (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailGetservices");
            
    
            var path = "/staffavail/getservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of staff members that are available for a specific service Allows the user to view all staff members who are available for a service.
        /// </summary>
        /// <param name="serviceid">The service id to list users.</param> 
        /// <returns></returns>            
        public void StaffavailGetusersforservice (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling StaffavailGetusersforservice");
            
    
            var path = "/staffavail/getusersforservice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetusersforservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailGetusersforservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View all the availability types 
        /// </summary>
        /// <returns></returns>            
        public void StaffavailListtypes ()
        {
            
    
            var path = "/staffavail/listtypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailListtypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailListtypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove current user from all services Allows the user to disassociate themselves from all services, provided they have a staff role.
        /// </summary>
        /// <returns></returns>            
        public void StaffavailRemovemefromallservices ()
        {
            
    
            var path = "/staffavail/removemefromallservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemovemefromallservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemovemefromallservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove current user from a service Allows the user to disassociate themselves from a service, provided they have a staff role.
        /// </summary>
        /// <param name="serviceid">The id of the service.</param> 
        /// <returns></returns>            
        public void StaffavailRemovemefromservice (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling StaffavailRemovemefromservice");
            
    
            var path = "/staffavail/removemefromservice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemovemefromservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemovemefromservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Removes a staff member from the registration to all services Allows the user to remove a staff member&#39;s availability to all services.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <returns></returns>            
        public void StaffavailRemoveuserfromallservices (Guid? userid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailRemoveuserfromallservices");
            
    
            var path = "/staffavail/removeuserfromallservices";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemoveuserfromallservices: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemoveuserfromallservices: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a staff member from a service Allows the user to remove a staff member&#39;s service availability.
        /// </summary>
        /// <param name="userid">The id of the user to remove.</param> 
        /// <param name="serviceid">The id of the service.</param> 
        /// <returns></returns>            
        public void StaffavailRemoveuserfromservice (Guid? userid, Guid? serviceid)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailRemoveuserfromservice");
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling StaffavailRemoveuserfromservice");
            
    
            var path = "/staffavail/removeuserfromservice";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemoveuserfromservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailRemoveuserfromservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Make a staff member available for a specific availability type Allows the user to set a staff member as available for walk ins, appointments, or both.
        /// </summary>
        /// <param name="userid">The id of the user whose specific availability has to be set.</param> 
        /// <param name="availablefor">Specific availability to set.</param> 
        /// <returns></returns>            
        public void StaffavailSetavailability (Guid? userid, string availablefor)
        {
            
            // verify the required parameter 'userid' is set
            if (userid == null) throw new ApiException(400, "Missing required parameter 'userid' when calling StaffavailSetavailability");
            
    
            var path = "/staffavail/setavailability";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (userid != null) queryParams.Add("userid", ApiClient.ParameterToString(userid)); // query parameter
 if (availablefor != null) queryParams.Add("availablefor", ApiClient.ParameterToString(availablefor)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailSetavailability: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailSetavailability: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Change current user&#39;s availability type Allows the user to make themselves available for walk ins, appointments, or both.
        /// </summary>
        /// <param name="availablefor">Specific availability to set.</param> 
        /// <returns></returns>            
        public void StaffavailSetmyavailability (string availablefor)
        {
            
    
            var path = "/staffavail/setmyavailability";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (availablefor != null) queryParams.Add("availablefor", ApiClient.ParameterToString(availablefor)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailSetmyavailability: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StaffavailSetmyavailability: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
