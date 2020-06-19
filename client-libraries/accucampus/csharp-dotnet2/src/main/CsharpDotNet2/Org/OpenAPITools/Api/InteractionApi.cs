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
    public interface IInteractionApi
    {
        /// <summary>
        /// Delete an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void InteractionDelete (Guid? id, AnyType body);
        /// <summary>
        /// Get the interactions feed 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="startdate">If set, only interactions that happened after this date are returned.</param>
        /// <param name="_public">Specifies whether to return public or private interactions.</param>
        /// <param name="contexttype">The type of the context of the interactions to return.</param>
        /// <param name="contextid">The id of the context of the interactions to return.</param>
        /// <param name="types">The  comma separated types of the interactions to return.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param>
        /// <param name="orderdescending">If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.</param>
        /// <returns></returns>
        void InteractionFeed (int? from, int? count, DateTime? startdate, bool? _public, string contexttype, Guid? contextid, string types, int? photosize, bool? showdefaultphoto, bool? orderdescending);
        /// <summary>
        /// View an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction.</param>
        /// <param name="thumbnailmediasize">The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.</param>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <returns></returns>
        void InteractionGet (string id, int? thumbnailmediasize, int? photosize);
        /// <summary>
        /// Get current user&#39;s latest private interactions 
        /// </summary>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param>
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param>
        /// <returns></returns>
        void InteractionListprivatesummary (int? photosize, bool? showdefaultphoto);
        /// <summary>
        /// Save an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void InteractionSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class InteractionApi : IInteractionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public InteractionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public InteractionApi(String basePath)
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
        /// Delete an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void InteractionDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InteractionDelete");
            
    
            var path = "/interaction/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get the interactions feed 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="startdate">If set, only interactions that happened after this date are returned.</param> 
        /// <param name="_public">Specifies whether to return public or private interactions.</param> 
        /// <param name="contexttype">The type of the context of the interactions to return.</param> 
        /// <param name="contextid">The id of the context of the interactions to return.</param> 
        /// <param name="types">The  comma separated types of the interactions to return.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param> 
        /// <param name="orderdescending">If true, last interactions will be shown first. Otherwise, interactions will be ordered ascendantly.</param> 
        /// <returns></returns>            
        public void InteractionFeed (int? from, int? count, DateTime? startdate, bool? _public, string contexttype, Guid? contextid, string types, int? photosize, bool? showdefaultphoto, bool? orderdescending)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling InteractionFeed");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling InteractionFeed");
            
    
            var path = "/interaction/feed";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (startdate != null) queryParams.Add("startdate", ApiClient.ParameterToString(startdate)); // query parameter
 if (_public != null) queryParams.Add("public", ApiClient.ParameterToString(_public)); // query parameter
 if (contexttype != null) queryParams.Add("contexttype", ApiClient.ParameterToString(contexttype)); // query parameter
 if (contextid != null) queryParams.Add("contextid", ApiClient.ParameterToString(contextid)); // query parameter
 if (types != null) queryParams.Add("types", ApiClient.ParameterToString(types)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
 if (showdefaultphoto != null) queryParams.Add("showdefaultphoto", ApiClient.ParameterToString(showdefaultphoto)); // query parameter
 if (orderdescending != null) queryParams.Add("orderdescending", ApiClient.ParameterToString(orderdescending)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionFeed: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionFeed: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction.</param> 
        /// <param name="thumbnailmediasize">The size in pixels of the thumbnail media URLs returned. Defaults to 680. If the size specified is not available, a similar one will be returned.</param> 
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <returns></returns>            
        public void InteractionGet (string id, int? thumbnailmediasize, int? photosize)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InteractionGet");
            
    
            var path = "/interaction/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (thumbnailmediasize != null) queryParams.Add("thumbnailmediasize", ApiClient.ParameterToString(thumbnailmediasize)); // query parameter
 if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get current user&#39;s latest private interactions 
        /// </summary>
        /// <param name="photosize">The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.</param> 
        /// <param name="showdefaultphoto">If true, a default photo will be returned in case the user does not have a photo. Otherwise, no photo will be returned.</param> 
        /// <returns></returns>            
        public void InteractionListprivatesummary (int? photosize, bool? showdefaultphoto)
        {
            
    
            var path = "/interaction/listprivatesummary";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (photosize != null) queryParams.Add("photosize", ApiClient.ParameterToString(photosize)); // query parameter
 if (showdefaultphoto != null) queryParams.Add("showdefaultphoto", ApiClient.ParameterToString(showdefaultphoto)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionListprivatesummary: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionListprivatesummary: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Save an interaction 
        /// </summary>
        /// <param name="id">The id of the interaction to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void InteractionSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling InteractionSave");
            
    
            var path = "/interaction/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling InteractionSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
