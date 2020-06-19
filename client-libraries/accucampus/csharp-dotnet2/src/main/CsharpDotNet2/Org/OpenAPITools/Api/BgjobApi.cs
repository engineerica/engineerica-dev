using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBgjobApi
    {
        /// <summary>
        /// Get background job status 
        /// </summary>
        /// <param name="jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param>
        /// <param name="jobtype">The job type to filter by.</param>
        /// <returns></returns>
        void BgjobGetstatus (Guid? jobid, string jobtype);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BgjobApi : IBgjobApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BgjobApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BgjobApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BgjobApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BgjobApi(String basePath)
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
        /// Get background job status 
        /// </summary>
        /// <param name="jobid">The ID of the job to get the status. 10 most recent will be returned if not specified.</param> 
        /// <param name="jobtype">The job type to filter by.</param> 
        /// <returns></returns>            
        public void BgjobGetstatus (Guid? jobid, string jobtype)
        {
            
    
            var path = "/bgjob/getstatus";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (jobid != null) queryParams.Add("jobid", ApiClient.ParameterToString(jobid)); // query parameter
 if (jobtype != null) queryParams.Add("jobtype", ApiClient.ParameterToString(jobtype)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BgjobGetstatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BgjobGetstatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
