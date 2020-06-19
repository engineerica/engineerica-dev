using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IActionlogApi
    {
        /// <summary>
        /// View a list of users action logs Allows the user to view the audit logs for the account.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="user">The id of the user whose action logs have to be returned.</param>
        /// <param name="startdate">The start date of the period to filter the logs.</param>
        /// <param name="enddate">The end date of the period to filter the logs.</param>
        /// <param name="resource">The resource to filter the action logs.</param>
        /// <param name="actionfilter">The action to filter the action logs.</param>
        /// <param name="argument">The id of the entity that was the argument of the executed action.</param>
        /// <returns></returns>
        void ActionlogList (int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionlogApi : IActionlogApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionlogApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionlogApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionlogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionlogApi(String basePath)
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
        /// View a list of users action logs Allows the user to view the audit logs for the account.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="user">The id of the user whose action logs have to be returned.</param> 
        /// <param name="startdate">The start date of the period to filter the logs.</param> 
        /// <param name="enddate">The end date of the period to filter the logs.</param> 
        /// <param name="resource">The resource to filter the action logs.</param> 
        /// <param name="actionfilter">The action to filter the action logs.</param> 
        /// <param name="argument">The id of the entity that was the argument of the executed action.</param> 
        /// <returns></returns>            
        public void ActionlogList (int? from, int? count, Guid? user, DateTime? startdate, DateTime? enddate, string resource, string actionfilter, string argument)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling ActionlogList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling ActionlogList");
            
    
            var path = "/actionlog/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (user != null) queryParams.Add("user", ApiClient.ParameterToString(user)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (enddate != null) queryParams.Add("enddate", ApiClient.ParameterToString(enddate)); // query parameter
 if (resource != null) queryParams.Add("resource", ApiClient.ParameterToString(resource)); // query parameter
 if (actionfilter != null) queryParams.Add("actionfilter", ApiClient.ParameterToString(actionfilter)); // query parameter
 if (argument != null) queryParams.Add("argument", ApiClient.ParameterToString(argument)); // query parameter
 if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionlogList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionlogList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
