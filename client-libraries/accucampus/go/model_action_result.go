/*
 * AccuCampus OpenAPI 3
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * API version: 1.0.0
 * Generated by: OpenAPI Generator (https://openapi-generator.tech)
 */

package openapi
// ActionResult Default action result
type ActionResult struct {
	// Specifies if the execution of the action was successful
	Success bool `json:"success,omitempty"`
	// Objects returned by the action
	Results []map[string]interface{} `json:"results,omitempty"`
	// Message with context information about the response
	Message string `json:"message,omitempty"`
}
