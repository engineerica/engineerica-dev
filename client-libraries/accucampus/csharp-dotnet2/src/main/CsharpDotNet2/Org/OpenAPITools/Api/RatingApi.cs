using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRatingApi
    {
        /// <summary>
        /// Flags one rating for moderation 
        /// </summary>
        /// <param name="id">The rating to flag.</param>
        /// <param name="comment">Comment why should this should be removed.</param>
        /// <returns></returns>
        void RatingFlag (Guid? id, string comment);
        /// <summary>
        /// Flags one comment for moderation 
        /// </summary>
        /// <param name="id">The comment to flag.</param>
        /// <param name="comment">Comment why should this should be removed.</param>
        /// <returns></returns>
        void RatingFlagcomment (Guid? id, string comment);
        /// <summary>
        /// Get rating for one or more entities 
        /// </summary>
        /// <param name="type">The entity type to get the rating.</param>
        /// <param name="entityids">List of ids to get the ratings.</param>
        /// <returns></returns>
        void RatingGet (string type, string entityids);
        /// <summary>
        /// Gets the full ratings and comments for a specific entity 
        /// </summary>
        /// <param name="type">The entity type to get the rating.</param>
        /// <param name="entityid">Id of the entity to get the ratings.</param>
        /// <param name="mostrecentfirst">True to show most recent first, otherwise most helpful first.</param>
        /// <returns></returns>
        void RatingGetall (string type, string entityid, bool? mostrecentfirst);
        /// <summary>
        /// Gets all the comments for a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to get all comments.</param>
        /// <returns></returns>
        void RatingGetcomments (Guid? ratingid);
        /// <summary>
        /// Gets info of pre-saved and pre-approved ratings 
        /// </summary>
        /// <param name="getgroup">The ID of the group of pending ratings to get.</param>
        /// <param name="rateid">Rate this before returning.</param>
        /// <param name="rateval">The value used to rate the item specified in rateid.</param>
        /// <returns></returns>
        void RatingGetpending (Guid? getgroup, Guid? rateid, int? rateval);
        /// <summary>
        /// Shows a list of the ratings and comments that are pending for moderation Allows the user to view the list of pending ratings and comments.
        /// </summary>
        /// <returns></returns>
        void RatingGetpendingmoderation ();
        /// <summary>
        /// Allows the user to accept or reject a comment Allows the user to approve or reject a comment or rating.
        /// </summary>
        /// <param name="type">Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate.</param>
        /// <param name="id">Id of the rating or comment, as specified in type.</param>
        /// <param name="approve">True to approve, false to reject.</param>
        /// <returns></returns>
        void RatingModerate (string type, Guid? id, bool? approve);
        /// <summary>
        /// Posts a comments for in a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to post the comment.</param>
        /// <param name="comment">Text of the comment to post.</param>
        /// <param name="annonymous">True to post the comment annonymously.</param>
        /// <returns></returns>
        void RatingPostcomment (Guid? ratingid, string comment, bool? annonymous);
        /// <summary>
        /// Rates one entity 
        /// </summary>
        /// <param name="type">The entity type to rate.</param>
        /// <param name="entityid">Id of the entity to rate.</param>
        /// <param name="annonymous">Whether to post as annonymous.</param>
        /// <param name="value">Value from 0 to 100 with the rating.</param>
        /// <param name="comment">Comment associated with this review. Comment can be updated later on another request too.</param>
        /// <param name="updatecomment">Whether to update the comments. Defaults to true.</param>
        /// <returns></returns>
        void RatingRate (string type, string entityid, bool? annonymous, int? value, string comment, bool? updatecomment);
        /// <summary>
        /// Rates a pre-saved and pre-approved entity 
        /// </summary>
        /// <param name="group">The ID of the group of with pre-approved ratings.</param>
        /// <param name="annonymous">Whether to post as annonymous.</param>
        /// <param name="rateid">Rate this before returning.</param>
        /// <param name="value">Value from 0 to 100 with the rating.</param>
        /// <param name="comment">Comment associated with this review. Comment can be updated later on another request too.</param>
        /// <param name="updatecomment">Whether to update the comments. Defaults to true.</param>
        /// <returns></returns>
        void RatingRatepending (Guid? group, bool? annonymous, Guid? rateid, int? value, string comment, bool? updatecomment);
        /// <summary>
        /// Votes up or down a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to vote on.</param>
        /// <param name="vote">1 to vote up, -1 to vote down.</param>
        /// <returns></returns>
        void RatingVote (Guid? ratingid, int? vote);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RatingApi : IRatingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RatingApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RatingApi(String basePath)
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
        /// Flags one rating for moderation 
        /// </summary>
        /// <param name="id">The rating to flag.</param> 
        /// <param name="comment">Comment why should this should be removed.</param> 
        /// <returns></returns>            
        public void RatingFlag (Guid? id, string comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RatingFlag");
            
    
            var path = "/rating/flag";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (comment != null) queryParams.Add("comment", ApiClient.ParameterToString(comment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingFlag: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingFlag: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Flags one comment for moderation 
        /// </summary>
        /// <param name="id">The comment to flag.</param> 
        /// <param name="comment">Comment why should this should be removed.</param> 
        /// <returns></returns>            
        public void RatingFlagcomment (Guid? id, string comment)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RatingFlagcomment");
            
    
            var path = "/rating/flagcomment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (comment != null) queryParams.Add("comment", ApiClient.ParameterToString(comment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingFlagcomment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingFlagcomment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get rating for one or more entities 
        /// </summary>
        /// <param name="type">The entity type to get the rating.</param> 
        /// <param name="entityids">List of ids to get the ratings.</param> 
        /// <returns></returns>            
        public void RatingGet (string type, string entityids)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling RatingGet");
            
            // verify the required parameter 'entityids' is set
            if (entityids == null) throw new ApiException(400, "Missing required parameter 'entityids' when calling RatingGet");
            
    
            var path = "/rating/get";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (entityids != null) queryParams.Add("entityids", ApiClient.ParameterToString(entityids)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets the full ratings and comments for a specific entity 
        /// </summary>
        /// <param name="type">The entity type to get the rating.</param> 
        /// <param name="entityid">Id of the entity to get the ratings.</param> 
        /// <param name="mostrecentfirst">True to show most recent first, otherwise most helpful first.</param> 
        /// <returns></returns>            
        public void RatingGetall (string type, string entityid, bool? mostrecentfirst)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling RatingGetall");
            
            // verify the required parameter 'entityid' is set
            if (entityid == null) throw new ApiException(400, "Missing required parameter 'entityid' when calling RatingGetall");
            
    
            var path = "/rating/getall";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (entityid != null) queryParams.Add("entityid", ApiClient.ParameterToString(entityid)); // query parameter
 if (mostrecentfirst != null) queryParams.Add("mostrecentfirst", ApiClient.ParameterToString(mostrecentfirst)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetall: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetall: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets all the comments for a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to get all comments.</param> 
        /// <returns></returns>            
        public void RatingGetcomments (Guid? ratingid)
        {
            
            // verify the required parameter 'ratingid' is set
            if (ratingid == null) throw new ApiException(400, "Missing required parameter 'ratingid' when calling RatingGetcomments");
            
    
            var path = "/rating/getcomments";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ratingid != null) queryParams.Add("ratingid", ApiClient.ParameterToString(ratingid)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetcomments: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetcomments: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Gets info of pre-saved and pre-approved ratings 
        /// </summary>
        /// <param name="getgroup">The ID of the group of pending ratings to get.</param> 
        /// <param name="rateid">Rate this before returning.</param> 
        /// <param name="rateval">The value used to rate the item specified in rateid.</param> 
        /// <returns></returns>            
        public void RatingGetpending (Guid? getgroup, Guid? rateid, int? rateval)
        {
            
            // verify the required parameter 'getgroup' is set
            if (getgroup == null) throw new ApiException(400, "Missing required parameter 'getgroup' when calling RatingGetpending");
            
    
            var path = "/rating/getpending";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (getgroup != null) queryParams.Add("getgroup", ApiClient.ParameterToString(getgroup)); // query parameter
 if (rateid != null) queryParams.Add("rateid", ApiClient.ParameterToString(rateid)); // query parameter
 if (rateval != null) queryParams.Add("rateval", ApiClient.ParameterToString(rateval)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetpending: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetpending: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Shows a list of the ratings and comments that are pending for moderation Allows the user to view the list of pending ratings and comments.
        /// </summary>
        /// <returns></returns>            
        public void RatingGetpendingmoderation ()
        {
            
    
            var path = "/rating/getpendingmoderation";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetpendingmoderation: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingGetpendingmoderation: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Allows the user to accept or reject a comment Allows the user to approve or reject a comment or rating.
        /// </summary>
        /// <param name="type">Either &#39;rating&#39; or &#39;comment&#39; depending on what you want to moderate.</param> 
        /// <param name="id">Id of the rating or comment, as specified in type.</param> 
        /// <param name="approve">True to approve, false to reject.</param> 
        /// <returns></returns>            
        public void RatingModerate (string type, Guid? id, bool? approve)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling RatingModerate");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling RatingModerate");
            
            // verify the required parameter 'approve' is set
            if (approve == null) throw new ApiException(400, "Missing required parameter 'approve' when calling RatingModerate");
            
    
            var path = "/rating/moderate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (approve != null) queryParams.Add("approve", ApiClient.ParameterToString(approve)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingModerate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingModerate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Posts a comments for in a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to post the comment.</param> 
        /// <param name="comment">Text of the comment to post.</param> 
        /// <param name="annonymous">True to post the comment annonymously.</param> 
        /// <returns></returns>            
        public void RatingPostcomment (Guid? ratingid, string comment, bool? annonymous)
        {
            
            // verify the required parameter 'ratingid' is set
            if (ratingid == null) throw new ApiException(400, "Missing required parameter 'ratingid' when calling RatingPostcomment");
            
            // verify the required parameter 'comment' is set
            if (comment == null) throw new ApiException(400, "Missing required parameter 'comment' when calling RatingPostcomment");
            
            // verify the required parameter 'annonymous' is set
            if (annonymous == null) throw new ApiException(400, "Missing required parameter 'annonymous' when calling RatingPostcomment");
            
    
            var path = "/rating/postcomment";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ratingid != null) queryParams.Add("ratingid", ApiClient.ParameterToString(ratingid)); // query parameter
 if (comment != null) queryParams.Add("comment", ApiClient.ParameterToString(comment)); // query parameter
 if (annonymous != null) queryParams.Add("annonymous", ApiClient.ParameterToString(annonymous)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingPostcomment: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingPostcomment: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Rates one entity 
        /// </summary>
        /// <param name="type">The entity type to rate.</param> 
        /// <param name="entityid">Id of the entity to rate.</param> 
        /// <param name="annonymous">Whether to post as annonymous.</param> 
        /// <param name="value">Value from 0 to 100 with the rating.</param> 
        /// <param name="comment">Comment associated with this review. Comment can be updated later on another request too.</param> 
        /// <param name="updatecomment">Whether to update the comments. Defaults to true.</param> 
        /// <returns></returns>            
        public void RatingRate (string type, string entityid, bool? annonymous, int? value, string comment, bool? updatecomment)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling RatingRate");
            
            // verify the required parameter 'entityid' is set
            if (entityid == null) throw new ApiException(400, "Missing required parameter 'entityid' when calling RatingRate");
            
            // verify the required parameter 'annonymous' is set
            if (annonymous == null) throw new ApiException(400, "Missing required parameter 'annonymous' when calling RatingRate");
            
    
            var path = "/rating/rate";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (entityid != null) queryParams.Add("entityid", ApiClient.ParameterToString(entityid)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (annonymous != null) queryParams.Add("annonymous", ApiClient.ParameterToString(annonymous)); // query parameter
 if (comment != null) queryParams.Add("comment", ApiClient.ParameterToString(comment)); // query parameter
 if (updatecomment != null) queryParams.Add("updatecomment", ApiClient.ParameterToString(updatecomment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingRate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingRate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Rates a pre-saved and pre-approved entity 
        /// </summary>
        /// <param name="group">The ID of the group of with pre-approved ratings.</param> 
        /// <param name="annonymous">Whether to post as annonymous.</param> 
        /// <param name="rateid">Rate this before returning.</param> 
        /// <param name="value">Value from 0 to 100 with the rating.</param> 
        /// <param name="comment">Comment associated with this review. Comment can be updated later on another request too.</param> 
        /// <param name="updatecomment">Whether to update the comments. Defaults to true.</param> 
        /// <returns></returns>            
        public void RatingRatepending (Guid? group, bool? annonymous, Guid? rateid, int? value, string comment, bool? updatecomment)
        {
            
            // verify the required parameter 'group' is set
            if (group == null) throw new ApiException(400, "Missing required parameter 'group' when calling RatingRatepending");
            
            // verify the required parameter 'annonymous' is set
            if (annonymous == null) throw new ApiException(400, "Missing required parameter 'annonymous' when calling RatingRatepending");
            
    
            var path = "/rating/ratepending";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (group != null) queryParams.Add("group", ApiClient.ParameterToString(group)); // query parameter
 if (rateid != null) queryParams.Add("rateid", ApiClient.ParameterToString(rateid)); // query parameter
 if (value != null) queryParams.Add("value", ApiClient.ParameterToString(value)); // query parameter
 if (annonymous != null) queryParams.Add("annonymous", ApiClient.ParameterToString(annonymous)); // query parameter
 if (comment != null) queryParams.Add("comment", ApiClient.ParameterToString(comment)); // query parameter
 if (updatecomment != null) queryParams.Add("updatecomment", ApiClient.ParameterToString(updatecomment)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingRatepending: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingRatepending: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Votes up or down a rating 
        /// </summary>
        /// <param name="ratingid">The ID of the rating to vote on.</param> 
        /// <param name="vote">1 to vote up, -1 to vote down.</param> 
        /// <returns></returns>            
        public void RatingVote (Guid? ratingid, int? vote)
        {
            
            // verify the required parameter 'ratingid' is set
            if (ratingid == null) throw new ApiException(400, "Missing required parameter 'ratingid' when calling RatingVote");
            
            // verify the required parameter 'vote' is set
            if (vote == null) throw new ApiException(400, "Missing required parameter 'vote' when calling RatingVote");
            
    
            var path = "/rating/vote";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (ratingid != null) queryParams.Add("ratingid", ApiClient.ParameterToString(ratingid)); // query parameter
 if (vote != null) queryParams.Add("vote", ApiClient.ParameterToString(vote)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingVote: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RatingVote: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
    }
}
