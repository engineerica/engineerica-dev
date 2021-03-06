/*
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


package org.openapitools.client.api;

import org.openapitools.client.ApiException;
import org.openapitools.client.model.UNKNOWN_BASE_TYPE;
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AdhocqueryApi
 */
@Ignore
public class AdhocqueryApiTest {

    private final AdhocqueryApi api = new AdhocqueryApi();

    
    /**
     * Check the status of an ad hoc query execution
     *
     * Allows the user to check whether a query has executed, viewable on the query&#39;s execution page.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryCheckexecutionTest() throws ApiException {
        UUID id = null;
        api.adhocqueryCheckexecution(id);

        // TODO: test validations
    }
    
    /**
     * Delete an ad hoc query
     *
     * Allows the user to delete a previously created ad hoc query.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.adhocqueryDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * Execute an ad hoc query
     *
     * Allows the user to execute an ad hoc query.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryExecuteTest() throws ApiException {
        UUID id = null;
        String query = null;
        api.adhocqueryExecute(id, query);

        // TODO: test validations
    }
    
    /**
     * View details of an ad hoc query
     *
     * Allows the user to view an individual ad hoc query with its settings.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryGetTest() throws ApiException {
        UUID id = null;
        api.adhocqueryGet(id);

        // TODO: test validations
    }
    
    /**
     * View the database schema for making ad hoc queries
     *
     * Allows the user to view the list of schema for ad hoc queries.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryGetschemaTest() throws ApiException {
        api.adhocqueryGetschema();

        // TODO: test validations
    }
    
    /**
     * View a list of saved ad hoc queries
     *
     * Allows the user to view the full list of saved queries.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryListTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        api.adhocqueryList(from, count);

        // TODO: test validations
    }
    
    /**
     * View a list of ad hoc queries executions
     *
     * Allows the user to view the full list of past query executions.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryListexecutionsTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        UUID query = null;
        api.adhocqueryListexecutions(from, count, query);

        // TODO: test validations
    }
    
    /**
     * Create or edit an ad hoc query
     *
     * Allows the user to edit an ad hoc query.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocquerySaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.adhocquerySave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Stops the execution of an ad hoc query
     *
     * Allows the user to halt the execution of a query that is currently being executed.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void adhocqueryStopexecutionTest() throws ApiException {
        UUID id = null;
        api.adhocqueryStopexecution(id);

        // TODO: test validations
    }
    
}
