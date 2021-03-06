/**
 * AccuCampus OpenAPI 3
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */


import ApiClient from "../ApiClient";

/**
* Virtualline service.
* @module api/VirtuallineApi
* @version 1.0.0
*/
export default class VirtuallineApi {

    /**
    * Constructs a new VirtuallineApi. 
    * @alias module:api/VirtuallineApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instance} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }


    /**
     * Callback function to receive the result of the virtuallineAddmyself operation.
     * @callback module:api/VirtuallineApi~virtuallineAddmyselfCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Add myself to a waiting line
     * Allows the user to add themselves to a waiting line from the AccuCampus mobile app.
     * @param {String} waitinglineid ID of the waiting line to join.
     * @param {module:api/VirtuallineApi~virtuallineAddmyselfCallback} callback The callback function, accepting three arguments: error, data, response
     */
    virtuallineAddmyself(waitinglineid, callback) {
      let postBody = null;
      // verify the required parameter 'waitinglineid' is set
      if (waitinglineid === undefined || waitinglineid === null) {
        throw new Error("Missing the required parameter 'waitinglineid' when calling virtuallineAddmyself");
      }

      let pathParams = {
      };
      let queryParams = {
        'waitinglineid': waitinglineid
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/virtualline/addmyself', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the virtuallineList operation.
     * @callback module:api/VirtuallineApi~virtuallineListCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Lists waiting lines that have remote access enabled
     * @param {module:api/VirtuallineApi~virtuallineListCallback} callback The callback function, accepting three arguments: error, data, response
     */
    virtuallineList(callback) {
      let postBody = null;

      let pathParams = {
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/virtualline/list', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the virtuallineRemovemyself operation.
     * @callback module:api/VirtuallineApi~virtuallineRemovemyselfCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Remove myself from a waiting line
     * Allows the user to remove themselves from a waiting line in the AccuCampus mobile app.
     * @param {module:api/VirtuallineApi~virtuallineRemovemyselfCallback} callback The callback function, accepting three arguments: error, data, response
     */
    virtuallineRemovemyself(callback) {
      let postBody = null;

      let pathParams = {
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/virtualline/removemyself', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }


}
