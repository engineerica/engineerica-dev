/**
 * AccuClub OpenAPI 3
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
import UNKNOWN_BASE_TYPE from '../model/UNKNOWN_BASE_TYPE';

/**
* Credit service.
* @module api/CreditApi
* @version 1.0.0
*/
export default class CreditApi {

    /**
    * Constructs a new CreditApi. 
    * @alias module:api/CreditApi
    * @class
    * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
    * default to {@link module:ApiClient#instance} if unspecified.
    */
    constructor(apiClient) {
        this.apiClient = apiClient || ApiClient.instance;
    }


    /**
     * Callback function to receive the result of the creditDelete operation.
     * @callback module:api/CreditApi~creditDeleteCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Delete a credit
     * Allows the user to delete credits.
     * @param {String} id The id of the credit to delete.
     * @param {Object} opts Optional parameters
     * @param {module:model/AnyType} opts.body 
     * @param {module:api/CreditApi~creditDeleteCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditDelete(id, opts, callback) {
      opts = opts || {};
      let postBody = opts['body'];
      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling creditDelete");
      }

      let pathParams = {
        'id': id
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = ['application/json'];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/credit/{id}', 'DELETE',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditDiscountmethods operation.
     * @callback module:api/CreditApi~creditDiscountmethodsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets the valid discount methods.
     * @param {module:api/CreditApi~creditDiscountmethodsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditDiscountmethods(callback) {
      let postBody = null;

      let pathParams = {
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = [];
      let contentTypes = [];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/credit/discountmethods', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditGet operation.
     * @callback module:api/CreditApi~creditGetCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View details of assigned credit
     * Allows the user to view an credit and its details.
     * @param {String} id The id of the credit to get.
     * @param {module:api/CreditApi~creditGetCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditGet(id, callback) {
      let postBody = null;
      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling creditGet");
      }

      let pathParams = {
        'id': id
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
        '/credit/{id}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditGetuserbalance operation.
     * @callback module:api/CreditApi~creditGetuserbalanceCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get the total amount of credits of the specified user
     * Allows the user to view the total amount of credits of a specified user.
     * @param {String} user The id of the user whose balance has to be returned.
     * @param {module:api/CreditApi~creditGetuserbalanceCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditGetuserbalance(user, callback) {
      let postBody = null;
      // verify the required parameter 'user' is set
      if (user === undefined || user === null) {
        throw new Error("Missing the required parameter 'user' when calling creditGetuserbalance");
      }

      let pathParams = {
      };
      let queryParams = {
        'user': user
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
        '/credit/getuserbalance', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditList operation.
     * @callback module:api/CreditApi~creditListCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View a list of credits for a specific user
     * Allows the user to view the full list of credits for a user.
     * @param {String} user The id of the user.
     * @param {Number} from The first record to return.
     * @param {Number} count The max number of records to return.
     * @param {module:api/CreditApi~creditListCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditList(user, from, count, callback) {
      let postBody = null;
      // verify the required parameter 'user' is set
      if (user === undefined || user === null) {
        throw new Error("Missing the required parameter 'user' when calling creditList");
      }
      // verify the required parameter 'from' is set
      if (from === undefined || from === null) {
        throw new Error("Missing the required parameter 'from' when calling creditList");
      }
      // verify the required parameter 'count' is set
      if (count === undefined || count === null) {
        throw new Error("Missing the required parameter 'count' when calling creditList");
      }

      let pathParams = {
      };
      let queryParams = {
        'user': user,
        'from': from,
        'count': count
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
        '/credit/list', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditListdetails operation.
     * @callback module:api/CreditApi~creditListdetailsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Gets the credit usage details
     * @param {String} credit The id of the credit to look up for details.
     * @param {Number} from The first record to return.
     * @param {Number} count The max number of records to return.
     * @param {module:api/CreditApi~creditListdetailsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditListdetails(credit, from, count, callback) {
      let postBody = null;
      // verify the required parameter 'credit' is set
      if (credit === undefined || credit === null) {
        throw new Error("Missing the required parameter 'credit' when calling creditListdetails");
      }
      // verify the required parameter 'from' is set
      if (from === undefined || from === null) {
        throw new Error("Missing the required parameter 'from' when calling creditListdetails");
      }
      // verify the required parameter 'count' is set
      if (count === undefined || count === null) {
        throw new Error("Missing the required parameter 'count' when calling creditListdetails");
      }

      let pathParams = {
      };
      let queryParams = {
        'credit': credit,
        'from': from,
        'count': count
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
        '/credit/listdetails', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditListmine operation.
     * @callback module:api/CreditApi~creditListmineCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * View the list of credits of the current user
     * Allows the current user to view his full list of credits.
     * @param {Number} from The first record to return.
     * @param {Number} count The max number of records to return.
     * @param {module:api/CreditApi~creditListmineCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditListmine(from, count, callback) {
      let postBody = null;
      // verify the required parameter 'from' is set
      if (from === undefined || from === null) {
        throw new Error("Missing the required parameter 'from' when calling creditListmine");
      }
      // verify the required parameter 'count' is set
      if (count === undefined || count === null) {
        throw new Error("Missing the required parameter 'count' when calling creditListmine");
      }

      let pathParams = {
      };
      let queryParams = {
        'from': from,
        'count': count
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
        '/credit/listmine', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditSave operation.
     * @callback module:api/CreditApi~creditSaveCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create or edit credit for a user
     * Allows the user to create or edit credit for a user
     * @param {String} id The id of the credit save (leave empty to create a new one).
     * @param {Object} opts Optional parameters
     * @param {module:model/UNKNOWN_BASE_TYPE} opts.UNKNOWN_BASE_TYPE 
     * @param {module:api/CreditApi~creditSaveCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditSave(id, opts, callback) {
      opts = opts || {};
      let postBody = opts['UNKNOWN_BASE_TYPE'];
      // verify the required parameter 'id' is set
      if (id === undefined || id === null) {
        throw new Error("Missing the required parameter 'id' when calling creditSave");
      }

      let pathParams = {
        'id': id
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = ['application/json'];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/credit/{id}', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }

    /**
     * Callback function to receive the result of the creditSavedetails operation.
     * @callback module:api/CreditApi~creditSavedetailsCallback
     * @param {String} error Error message, if any.
     * @param data This operation does not return a value.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create or edit credit details
     * @param {Object} opts Optional parameters
     * @param {module:model/UNKNOWN_BASE_TYPE} opts.UNKNOWN_BASE_TYPE 
     * @param {module:api/CreditApi~creditSavedetailsCallback} callback The callback function, accepting three arguments: error, data, response
     */
    creditSavedetails(opts, callback) {
      opts = opts || {};
      let postBody = opts['UNKNOWN_BASE_TYPE'];

      let pathParams = {
      };
      let queryParams = {
      };
      let headerParams = {
      };
      let formParams = {
      };

      let authNames = ['bearerAuth'];
      let contentTypes = ['application/json'];
      let accepts = [];
      let returnType = null;
      return this.apiClient.callApi(
        '/credit/savedetails', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, null, callback
      );
    }


}
