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
*/
package org.openapitools.client.apis


import org.openapitools.client.infrastructure.ApiClient
import org.openapitools.client.infrastructure.ClientException
import org.openapitools.client.infrastructure.ClientError
import org.openapitools.client.infrastructure.ServerException
import org.openapitools.client.infrastructure.ServerError
import org.openapitools.client.infrastructure.MultiValueMap
import org.openapitools.client.infrastructure.RequestConfig
import org.openapitools.client.infrastructure.RequestMethod
import org.openapitools.client.infrastructure.ResponseType
import org.openapitools.client.infrastructure.Success
import org.openapitools.client.infrastructure.toMultiValue

class ActionlogApi(basePath: kotlin.String = defaultBasePath) : ApiClient(basePath) {
    companion object {
        @JvmStatic
        val defaultBasePath: String by lazy {
            System.getProperties().getProperty("org.openapitools.client.baseUrl", "https://accucampus.net:443/api/v1")
        }
    }

    /**
    * View a list of users action logs
    * Allows the user to view the audit logs for the account.
    * @param from The first record to return. 
    * @param count The max number of records to return. 
    * @param user The id of the user whose action logs have to be returned. (optional)
    * @param startdate The start date of the period to filter the logs. (optional)
    * @param enddate The end date of the period to filter the logs. (optional)
    * @param resource The resource to filter the action logs. (optional)
    * @param actionfilter The action to filter the action logs. (optional)
    * @param argument The id of the entity that was the argument of the executed action. (optional)
    * @return void
    * @throws UnsupportedOperationException If the API returns an informational or redirection response
    * @throws ClientException If the API returns a client error response
    * @throws ServerException If the API returns a server error response
    */
    @Throws(UnsupportedOperationException::class, ClientException::class, ServerException::class)
    fun actionlogList(from: kotlin.Int, count: kotlin.Int, user: java.util.UUID?, startdate: java.time.OffsetDateTime?, enddate: java.time.OffsetDateTime?, resource: kotlin.String?, actionfilter: kotlin.String?, argument: kotlin.String?) : Unit {
        val localVariableBody: kotlin.Any? = null
        val localVariableQuery: MultiValueMap = mutableMapOf<kotlin.String, List<kotlin.String>>()
            .apply {
                if (user != null) {
                    put("user", listOf(user.toString()))
                }
                if (startdate != null) {
                    put("startdate", listOf(parseDateToQueryString(startdate)))
                }
                if (enddate != null) {
                    put("enddate", listOf(parseDateToQueryString(enddate)))
                }
                if (resource != null) {
                    put("resource", listOf(resource.toString()))
                }
                if (actionfilter != null) {
                    put("actionfilter", listOf(actionfilter.toString()))
                }
                if (argument != null) {
                    put("argument", listOf(argument.toString()))
                }
                put("from", listOf(from.toString()))
                put("count", listOf(count.toString()))
            }
        val localVariableHeaders: MutableMap<String, String> = mutableMapOf()
        val localVariableConfig = RequestConfig(
            RequestMethod.GET,
            "/actionlog/list",
            query = localVariableQuery,
            headers = localVariableHeaders
        )
        val localVarResponse = request<Any?>(
            localVariableConfig,
            localVariableBody
        )

        return when (localVarResponse.responseType) {
            ResponseType.Success -> Unit
            ResponseType.Informational -> throw UnsupportedOperationException("Client does not support Informational responses.")
            ResponseType.Redirection -> throw UnsupportedOperationException("Client does not support Redirection responses.")
            ResponseType.ClientError -> {
                val localVarError = localVarResponse as ClientError<*>
                throw ClientException("Client error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
            ResponseType.ServerError -> {
                val localVarError = localVarResponse as ServerError<*>
                throw ServerException("Server error : ${localVarError.statusCode} ${localVarError.message.orEmpty()}", localVarError.statusCode, localVarResponse)
            }
        }
    }

}
