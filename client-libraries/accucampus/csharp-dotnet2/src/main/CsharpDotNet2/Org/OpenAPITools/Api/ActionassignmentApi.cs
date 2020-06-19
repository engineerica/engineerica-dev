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
    public interface IActionassignmentApi
    {
        /// <summary>
        /// Remove an action item from an action plan Allows a user to remove an action item from a user&#39;s action plan.
        /// </summary>
        /// <param name="id">The id of the action assignment to delete.</param>
        /// <param name="body"></param>
        /// <returns></returns>
        void ActionassignmentDelete (Guid? id, AnyType body);
        /// <summary>
        /// Search and view details of an action item assigned to a user Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.
        /// </summary>
        /// <param name="id">The id of the action assignment to get.</param>
        /// <returns></returns>
        void ActionassignmentGet (Guid? id);
        /// <summary>
        /// View a list of action items in a user&#39;s plan Allows the user to view the list of all action items for a specified user.
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="assignee">The assignee&#39;s id to filter the assignments.</param>
        /// <param name="status">The status to filter the assignments.</param>
        /// <returns></returns>
        void ActionassignmentList (int? from, int? count, int? assignee, int? status);
        /// <summary>
        /// View the history of an action item assigned to a user Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.
        /// </summary>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param>
        /// <returns></returns>
        void ActionassignmentListhistory (Guid? actionassignment);
        /// <summary>
        /// List public action assignments assigned to the logged user 
        /// </summary>
        /// <param name="from">The first record to return.</param>
        /// <param name="count">The max number of records to return.</param>
        /// <param name="status">The status to filter the assignments.</param>
        /// <returns></returns>
        void ActionassignmentListmine (int? from, int? count, int? status);
        /// <summary>
        /// List public action assignment history 
        /// </summary>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param>
        /// <returns></returns>
        void ActionassignmentListpublichistory (Guid? actionassignment);
        /// <summary>
        /// Bulk complete action items Allows the user to bulk complete action items.
        /// </summary>
        /// <param name="item">The action item to assign.</param>
        /// <param name="assignee">The assignee of the item.</param>
        /// <param name="group">The group to assing the item.</param>
        /// <param name="notes">The assignment&#39;s notes.</param>
        /// <returns></returns>
        void ActionassignmentMarkcomplete (string item, Guid? assignee, Guid? group, string notes);
        /// <summary>
        /// Add an action item to a user&#39;s action plan Allows the user to edit or assign an action item to a user
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ActionassignmentSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
        /// <summary>
        /// Update an action item assigned to a user Allows the user to update or mark an action item as complete.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param>
        /// <returns></returns>
        void ActionassignmentSavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ActionassignmentApi : IActionassignmentApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionassignmentApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ActionassignmentApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionassignmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ActionassignmentApi(String basePath)
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
        /// Remove an action item from an action plan Allows a user to remove an action item from a user&#39;s action plan.
        /// </summary>
        /// <param name="id">The id of the action assignment to delete.</param> 
        /// <param name="body"></param> 
        /// <returns></returns>            
        public void ActionassignmentDelete (Guid? id, AnyType body)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionassignmentDelete");
            
    
            var path = "/actionassignment/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Search and view details of an action item assigned to a user Allows the user to view an individual action item and its details, minus all the action item&#39;s updates.
        /// </summary>
        /// <param name="id">The id of the action assignment to get.</param> 
        /// <returns></returns>            
        public void ActionassignmentGet (Guid? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ActionassignmentGet");
            
    
            var path = "/actionassignment/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View a list of action items in a user&#39;s plan Allows the user to view the list of all action items for a specified user.
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="assignee">The assignee&#39;s id to filter the assignments.</param> 
        /// <param name="status">The status to filter the assignments.</param> 
        /// <returns></returns>            
        public void ActionassignmentList (int? from, int? count, int? assignee, int? status)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling ActionassignmentList");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling ActionassignmentList");
            
    
            var path = "/actionassignment/list";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentList: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentList: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// View the history of an action item assigned to a user Allows the user to view an individual action plan and its details, including all the action plan&#39;s updates.
        /// </summary>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param> 
        /// <returns></returns>            
        public void ActionassignmentListhistory (Guid? actionassignment)
        {
            
            // verify the required parameter 'actionassignment' is set
            if (actionassignment == null) throw new ApiException(400, "Missing required parameter 'actionassignment' when calling ActionassignmentListhistory");
            
    
            var path = "/actionassignment/listhistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actionassignment != null) queryParams.Add("actionassignment", ApiClient.ParameterToString(actionassignment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListhistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListhistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List public action assignments assigned to the logged user 
        /// </summary>
        /// <param name="from">The first record to return.</param> 
        /// <param name="count">The max number of records to return.</param> 
        /// <param name="status">The status to filter the assignments.</param> 
        /// <returns></returns>            
        public void ActionassignmentListmine (int? from, int? count, int? status)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling ActionassignmentListmine");
            
            // verify the required parameter 'count' is set
            if (count == null) throw new ApiException(400, "Missing required parameter 'count' when calling ActionassignmentListmine");
            
    
            var path = "/actionassignment/listmine";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (from != null) queryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
 if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
 if (status != null) queryParams.Add("status", ApiClient.ParameterToString(status)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListmine: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListmine: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// List public action assignment history 
        /// </summary>
        /// <param name="actionassignment">The action assignment&#39;s id whose history the user wants to get.</param> 
        /// <returns></returns>            
        public void ActionassignmentListpublichistory (Guid? actionassignment)
        {
            
            // verify the required parameter 'actionassignment' is set
            if (actionassignment == null) throw new ApiException(400, "Missing required parameter 'actionassignment' when calling ActionassignmentListpublichistory");
            
    
            var path = "/actionassignment/listpublichistory";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (actionassignment != null) queryParams.Add("actionassignment", ApiClient.ParameterToString(actionassignment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListpublichistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentListpublichistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Bulk complete action items Allows the user to bulk complete action items.
        /// </summary>
        /// <param name="item">The action item to assign.</param> 
        /// <param name="assignee">The assignee of the item.</param> 
        /// <param name="group">The group to assing the item.</param> 
        /// <param name="notes">The assignment&#39;s notes.</param> 
        /// <returns></returns>            
        public void ActionassignmentMarkcomplete (string item, Guid? assignee, Guid? group, string notes)
        {
            
            // verify the required parameter 'item' is set
            if (item == null) throw new ApiException(400, "Missing required parameter 'item' when calling ActionassignmentMarkcomplete");
            
    
            var path = "/actionassignment/markcomplete";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (assignee != null) queryParams.Add("assignee", ApiClient.ParameterToString(assignee)); // query parameter
 if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (item != null) queryParams.Add("item", ApiClient.ParameterToString(item)); // query parameter
 if (notes != null) queryParams.Add("notes", ApiClient.ParameterToString(notes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentMarkcomplete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentMarkcomplete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Add an action item to a user&#39;s action plan Allows the user to edit or assign an action item to a user
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ActionassignmentSave (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionassignment/save";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentSave: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentSave: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Update an action item assigned to a user Allows the user to update or mark an action item as complete.
        /// </summary>
        /// <param name="UNKNOWN_BASE_TYPE"></param> 
        /// <returns></returns>            
        public void ActionassignmentSavehistory (UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE)
        {
            
    
            var path = "/actionassignment/savehistory";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentSavehistory: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ActionassignmentSavehistory: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
