using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IServiceassignmentApi
    {
        /// <summary>
        /// Enable a service in a specific location Allows the user to enable a service in a location to which they are scoped.
        /// </summary>
        /// <param name="serviceid">The id of the service to add.</param>
        /// <param name="locationid">The id of the location.</param>
        /// <returns></returns>
        void ServiceassignmentAddservice (Guid? serviceid, Guid? locationid);
        /// <summary>
        /// View a list of services enabled for a specific location Allows the user to view a list of services available in a location to which they are scoped.
        /// </summary>
        /// <param name="locationid">The id of the location to get.</param>
        /// <param name="includegloballyavailable">Specifies whether the services available globally must be returned or not.</param>
        /// <param name="namefilter">Filters the name of the services to return.</param>
        /// <param name="count">The max number of services to return.</param>
        /// <returns></returns>
        void ServiceassignmentGetlocation (Guid? locationid, bool? includegloballyavailable, bool? namefilter, int? count);
        /// <summary>
        /// View a list of locations where a service is available Allows the user to view a list of locations in which a service is available.
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param>
        /// <returns></returns>
        void ServiceassignmentGetservice (Guid? serviceid);
        /// <summary>
        /// Remove a service from a location Allows the user to disable a service from a location to which they are scoped.
        /// </summary>
        /// <param name="serviceid">The id of the service to remove.</param>
        /// <param name="locationid">The id of the location to remove the service from.</param>
        /// <returns></returns>
        void ServiceassignmentRemoveservice (Guid? serviceid, Guid? locationid);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ServiceassignmentApi : IServiceassignmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceassignmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ServiceassignmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceassignmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ServiceassignmentApi(String basePath)
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
        /// Enable a service in a specific location Allows the user to enable a service in a location to which they are scoped.
        /// </summary>
        /// <param name="serviceid">The id of the service to add.</param> 
        /// <param name="locationid">The id of the location.</param> 
        /// <returns></returns>            
        public void ServiceassignmentAddservice (Guid? serviceid, Guid? locationid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling ServiceassignmentAddservice");
            
            // verify the required parameter 'locationid' is set
            if (locationid == null) throw new ApiException(400, "Missing required parameter 'locationid' when calling ServiceassignmentAddservice");
            
    
            var path = "/serviceassignment/addservice";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentAddservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentAddservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of services enabled for a specific location Allows the user to view a list of services available in a location to which they are scoped.
        /// </summary>
        /// <param name="locationid">The id of the location to get.</param> 
        /// <param name="includegloballyavailable">Specifies whether the services available globally must be returned or not.</param> 
        /// <param name="namefilter">Filters the name of the services to return.</param> 
        /// <param name="count">The max number of services to return.</param> 
        /// <returns></returns>            
        public void ServiceassignmentGetlocation (Guid? locationid, bool? includegloballyavailable, bool? namefilter, int? count)
        {
            
            // verify the required parameter 'locationid' is set
            if (locationid == null) throw new ApiException(400, "Missing required parameter 'locationid' when calling ServiceassignmentGetlocation");
            
    
            var path = "/serviceassignment/getlocation";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
 if (includegloballyavailable != null) queryParams.Add("includegloballyavailable", ApiClient.ParameterToString(includegloballyavailable)); // query parameter
 if (namefilter != null) queryParams.Add("namefilter", ApiClient.ParameterToString(namefilter)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentGetlocation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentGetlocation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of locations where a service is available Allows the user to view a list of locations in which a service is available.
        /// </summary>
        /// <param name="serviceid">The id of the service to get its locations.</param> 
        /// <returns></returns>            
        public void ServiceassignmentGetservice (Guid? serviceid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling ServiceassignmentGetservice");
            
    
            var path = "/serviceassignment/getservice";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentGetservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentGetservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Remove a service from a location Allows the user to disable a service from a location to which they are scoped.
        /// </summary>
        /// <param name="serviceid">The id of the service to remove.</param> 
        /// <param name="locationid">The id of the location to remove the service from.</param> 
        /// <returns></returns>            
        public void ServiceassignmentRemoveservice (Guid? serviceid, Guid? locationid)
        {
            
            // verify the required parameter 'serviceid' is set
            if (serviceid == null) throw new ApiException(400, "Missing required parameter 'serviceid' when calling ServiceassignmentRemoveservice");
            
            // verify the required parameter 'locationid' is set
            if (locationid == null) throw new ApiException(400, "Missing required parameter 'locationid' when calling ServiceassignmentRemoveservice");
            
    
            var path = "/serviceassignment/removeservice";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceid != null) queryParams.Add("serviceid", ApiClient.ParameterToString(serviceid)); // query parameter
 if (locationid != null) queryParams.Add("locationid", ApiClient.ParameterToString(locationid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentRemoveservice: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ServiceassignmentRemoveservice: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
