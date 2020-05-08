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
 */

import { RequestFile } from '../api';

/**
* Default action result
*/
export class ActionResult {
    /**
    * Specifies if the execution of the action was successful
    */
    'success'?: boolean;
    /**
    * Objects returned by the action
    */
    'results'?: Array<object>;
    /**
    * Message with context information about the response
    */
    'message'?: string;

    static discriminator: string | undefined = undefined;

    static attributeTypeMap: Array<{name: string, baseName: string, type: string}> = [
        {
            "name": "success",
            "baseName": "success",
            "type": "boolean"
        },
        {
            "name": "results",
            "baseName": "results",
            "type": "Array<object>"
        },
        {
            "name": "message",
            "baseName": "message",
            "type": "string"
        }    ];

    static getAttributeTypeMap() {
        return ActionResult.attributeTypeMap;
    }
}

