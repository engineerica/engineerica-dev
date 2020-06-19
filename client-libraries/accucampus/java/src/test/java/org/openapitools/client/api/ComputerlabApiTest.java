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
 * API tests for ComputerlabApi
 */
@Ignore
public class ComputerlabApiTest {

    private final ComputerlabApi api = new ComputerlabApi();

    
    /**
     * Delete a computer
     *
     * Allows the user to delete an existing computer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabDeletecomputerTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.computerlabDeletecomputer(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Search and view details of a computer
     *
     * Allows the user to search and view an individual computer and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabGetcomputerTest() throws ApiException {
        String id = null;
        api.computerlabGetcomputer(id);

        // TODO: test validations
    }
    
    /**
     * Loads the settings for a computer lab
     *
     * Loads the settings for a computer lab.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabGetsettingsTest() throws ApiException {
        UUID id = null;
        api.computerlabGetsettings(id);

        // TODO: test validations
    }
    
    /**
     * Gets whether a user is signed-in or not.
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabIssignedinTest() throws ApiException {
        UUID station = null;
        String user = null;
        api.computerlabIssignedin(station, user);

        // TODO: test validations
    }
    
    /**
     * View a list of computers
     *
     * Allows the user to view the list of all computers.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabListcomputersTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        UUID location = null;
        Boolean freeonly = null;
        api.computerlabListcomputers(from, count, location, freeonly);

        // TODO: test validations
    }
    
    /**
     * View a list of the locations that use the Computer Lab add-on
     *
     * Allows the user to view the list of all labs.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabListlabsTest() throws ApiException {
        api.computerlabListlabs();

        // TODO: test validations
    }
    
    /**
     * View a list of sign-in stations available for computer labs.
     *
     * Allows the user to view the list of sign-in stations that are available for computer labs.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabListstationsTest() throws ApiException {
        api.computerlabListstations();

        // TODO: test validations
    }
    
    /**
     * Create or edit a computer
     *
     * Allows the user to create or edit a computer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabSavecomputerTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.computerlabSavecomputer(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Saves the settings for a computer lab
     *
     * Saves the settings for a computer lab.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabSavesettingsTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.computerlabSavesettings(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Save a new swipe from a computer in a computer lab.
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void computerlabSaveswipeTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.computerlabSaveswipe(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
}