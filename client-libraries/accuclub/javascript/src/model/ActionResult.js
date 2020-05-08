/**
 * AccuCampus OpenAPI 3 Documentation
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

import ApiClient from '../ApiClient';

/**
 * The ActionResult model module.
 * @module model/ActionResult
 * @version 1.0.0
 */
class ActionResult {
    /**
     * Constructs a new <code>ActionResult</code>.
     * Default action result
     * @alias module:model/ActionResult
     */
    constructor() { 
        
        ActionResult.initialize(this);
    }

    /**
     * Initializes the fields of this object.
     * This method is used by the constructors of any subclasses, in order to implement multiple inheritance (mix-ins).
     * Only for internal use.
     */
    static initialize(obj) { 
    }

    /**
     * Constructs a <code>ActionResult</code> from a plain JavaScript object, optionally creating a new instance.
     * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
     * @param {Object} data The plain JavaScript object bearing properties of interest.
     * @param {module:model/ActionResult} obj Optional instance to populate.
     * @return {module:model/ActionResult} The populated <code>ActionResult</code> instance.
     */
    static constructFromObject(data, obj) {
        if (data) {
            obj = obj || new ActionResult();

            if (data.hasOwnProperty('success')) {
                obj['success'] = ApiClient.convertToType(data['success'], 'Boolean');
            }
            if (data.hasOwnProperty('results')) {
                obj['results'] = ApiClient.convertToType(data['results'], [Object]);
            }
            if (data.hasOwnProperty('message')) {
                obj['message'] = ApiClient.convertToType(data['message'], 'String');
            }
        }
        return obj;
    }


}

/**
 * Specifies if the execution of the action was successful
 * @member {Boolean} success
 */
ActionResult.prototype['success'] = undefined;

/**
 * Objects returned by the action
 * @member {Array.<Object>} results
 */
ActionResult.prototype['results'] = undefined;

/**
 * Message with context information about the response
 * @member {String} message
 */
ActionResult.prototype['message'] = undefined;






export default ActionResult;
