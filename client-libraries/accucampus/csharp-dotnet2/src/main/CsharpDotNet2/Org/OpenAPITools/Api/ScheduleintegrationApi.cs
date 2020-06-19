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
    public interface IScheduleintegrationApi
    {
        /// <summary>
        /// Clear all third party IDs from specified staff member&#39;s schedule items. 
        /// </summary>
        /// <param name="staff">The ID of the staff member whose schedule items third party IDs must be cleared.</param>
        /// <returns></returns>
        void ScheduleintegrationClearids (Guid? staff);
        /// <summary>
        /// Delete a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleintegrationDeleteitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Delete multiple schedule items looking up by a third party master ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleintegrationDeleteitemsbymasterid (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Get a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="thirdpartyid">The third party id to search for the schedule item.</param>
        /// <returns></returns>
        void ScheduleintegrationGetitem (string thirdpartyid);
        /// <summary>
        /// Save a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ScheduleintegrationSaveitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Set a 3rd party ID on a specific schedule item 
        /// </summary>
        /// <param name="id">The id of the schedule block / appointment.</param>
        /// <param name="thirdpartyid">The 3rd party ID to set.</param>
        /// <param name="thirdpartymasterid">The 3rd party master ID to set (useful to handle recurring items).</param>
        /// <returns></returns>
        void ScheduleintegrationSetid (Guid? id, string thirdpartyid, string thirdpartymasterid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ScheduleintegrationApi : IScheduleintegrationApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleintegrationApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ScheduleintegrationApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleintegrationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ScheduleintegrationApi(String basePath)
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
        /// Clear all third party IDs from specified staff member&#39;s schedule items. 
        /// </summary>
        /// <param name="staff">The ID of the staff member whose schedule items third party IDs must be cleared.</param> 
        /// <returns></returns>            
        public void ScheduleintegrationClearids (Guid? staff)
        {
            
            // verify the required parameter 'staff' is set
            if (staff == null) throw new ApiException(400, "Missing required parameter 'staff' when calling ScheduleintegrationClearids");
            
    
            var path = "/scheduleintegration/clearids";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (staff != null) queryParams.Add("staff", ApiClient.ParameterToString(staff)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationClearids: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationClearids: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleintegrationDeleteitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/scheduleintegration/deleteitem";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationDeleteitem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationDeleteitem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete multiple schedule items looking up by a third party master ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleintegrationDeleteitemsbymasterid (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/scheduleintegration/deleteitemsbymasterid";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationDeleteitemsbymasterid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationDeleteitemsbymasterid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="thirdpartyid">The third party id to search for the schedule item.</param> 
        /// <returns></returns>            
        public void ScheduleintegrationGetitem (string thirdpartyid)
        {
            
            // verify the required parameter 'thirdpartyid' is set
            if (thirdpartyid == null) throw new ApiException(400, "Missing required parameter 'thirdpartyid' when calling ScheduleintegrationGetitem");
            
    
            var path = "/scheduleintegration/getitem";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (thirdpartyid != null) queryParams.Add("thirdpartyid", ApiClient.ParameterToString(thirdpartyid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationGetitem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationGetitem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save a schedule item looking up by a third party ID 
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ScheduleintegrationSaveitem (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/scheduleintegration/saveitem";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationSaveitem: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationSaveitem: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Set a 3rd party ID on a specific schedule item 
        /// </summary>
        /// <param name="id">The id of the schedule block / appointment.</param> 
        /// <param name="thirdpartyid">The 3rd party ID to set.</param> 
        /// <param name="thirdpartymasterid">The 3rd party master ID to set (useful to handle recurring items).</param> 
        /// <returns></returns>            
        public void ScheduleintegrationSetid (Guid? id, string thirdpartyid, string thirdpartymasterid)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ScheduleintegrationSetid");
            
            // verify the required parameter 'thirdpartyid' is set
            if (thirdpartyid == null) throw new ApiException(400, "Missing required parameter 'thirdpartyid' when calling ScheduleintegrationSetid");
            
    
            var path = "/scheduleintegration/setid";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (thirdpartyid != null) queryParams.Add("thirdpartyid", ApiClient.ParameterToString(thirdpartyid)); // query parameter
 if (thirdpartymasterid != null) queryParams.Add("thirdpartymasterid", ApiClient.ParameterToString(thirdpartymasterid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationSetid: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ScheduleintegrationSetid: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
