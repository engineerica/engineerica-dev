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
    public interface IActionpackApi
    {
        /// <summary>
        /// Assign an action item pack to a user Allows the user to assign an action pack to a user or group of users.
        /// </summary>
        /// <param name="pack">The id of the action pack to assign.</param>
        /// <param name="itemsdata">A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).</param>
        /// <param name="assignee">The assignee of the pack.</param>
        /// <param name="group">The group to assign the pack.</param>
        /// <param name="notes">The assignment&#39;s notes.</param>
        /// <returns></returns>
        void ActionpackAssign (Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes);
        /// <summary>
        /// Delete an action item pack Allows the user to delete an action item pack.
        /// </summary>
        /// <param name="id">The id of the action pack to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ActionpackDelete (Guid? id, AnyType body);
        /// <summary>
        /// View details of an action item pack Allows the user to view an individual action pack and its details.
        /// </summary>
        /// <param name="id">The id of the action pack to get.</param>
        /// <returns></returns>
        void ActionpackGet (Guid? id);
        /// <summary>
        /// View a list of action item packs Allows the user to view the full list of action item packs.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <returns></returns>
        void ActionpackList (int? from, int? count);
        /// <summary>
        /// Create or edit an action item pack Allows the user to edit an action item pack.
        /// </summary>
        /// <param name="id">The id of the action pack to save (leave empty to create a new one).</param>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ActionpackSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionpackApi : IActionpackApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionpackApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionpackApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionpackApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionpackApi(String basePath)
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
        /// Assign an action item pack to a user Allows the user to assign an action pack to a user or group of users.
        /// </summary>
        /// <param name="pack">The id of the action pack to assign.</param> 
        /// <param name="itemsdata">A JSON array containing the action items&#39; data needed to assign them to the assignee (Id, Event, DateDue, DateExpired, NotifyAssigne).</param> 
        /// <param name="assignee">The assignee of the pack.</param> 
        /// <param name="group">The group to assign the pack.</param> 
        /// <param name="notes">The assignment&#39;s notes.</param> 
        /// <returns></returns>            
        public void ActionpackAssign (Guid? pack, bool? itemsdata, Guid? assignee, Guid? group, string notes)
        {
            
            // verify the required parameter 'pack' is set
            if (pack == null) throw new ApiException(400, "Missing required parameter 'pack' when calling ActionpackAssign");
            
            // verify the required parameter 'itemsdata' is set
            if (itemsdata == null) throw new ApiException(400, "Missing required parameter 'itemsdata' when calling ActionpackAssign");
            
    
            var path = "/actionpack/assign";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (pack != null) queryParams.Add("pack", ApiClient.ParameterToString(pack)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (itemsdata != null) queryParams.Add("itemsdata", ApiClient.ParameterToString(itemsdata)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackAssign: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackAssign: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Delete an action item pack Allows the user to delete an action item pack.
        /// </summary>
        /// <param name="id">The id of the action pack to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ActionpackDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionpackDelete");
            
    
            var path = "/actionpack/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View details of an action item pack Allows the user to view an individual action pack and its details.
        /// </summary>
        /// <param name="id">The id of the action pack to get.</param> 
        /// <returns></returns>            
        public void ActionpackGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionpackGet");
            
    
            var path = "/actionpack/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action item packs Allows the user to view the full list of action item packs.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <returns></returns>            
        public void ActionpackList (int? from, int? count)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling ActionpackList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling ActionpackList");
            
    
            var path = "/actionpack/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Create or edit an action item pack Allows the user to edit an action item pack.
        /// </summary>
        /// <param name="id">The id of the action pack to save (leave empty to create a new one).</param> 
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ActionpackSave (Guid? id, UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionpackSave");
            
    
            var path = "/actionpack/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionpackSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
