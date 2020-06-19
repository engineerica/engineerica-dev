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
 * API tests for TermApi
 */
@Ignore
public class TermApiTest {

    private final TermApi api = new TermApi();

    
    /**
     * Delete a term
     *
     * Allows the user to delete a term from the existing list.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void termDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.termDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * Search and view details of a term
     *
     * Allows the user to view a term and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void termGetTest() throws ApiException {
        UUID id = null;
        api.termGet(id);

        // TODO: test validations
    }
    
    /**
     * Search and view details of all terms
     *
     * Allows the user to view the full list of existing term.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void termListTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        Boolean notpast = null;
        api.termList(from, count, notpast);

        // TODO: test validations
    }
    
    /**
     * Create and edit terms
     *
     * Allows the user to create and edit terms.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void termSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.termSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
}