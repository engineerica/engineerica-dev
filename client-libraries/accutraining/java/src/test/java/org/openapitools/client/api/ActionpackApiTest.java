/*
 * AccuTraining OpenAPI 3
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
 * API tests for ActionpackApi
 */
@Ignore
public class ActionpackApiTest {

    private final ActionpackApi api = new ActionpackApi();

    
    /**
     * Assign an action item pack to a user
     *
     * Allows the user to assign an action pack to a user or group of users.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void actionpackAssignTest() throws ApiException {
        UUID pack = null;
        Boolean itemsdata = null;
        UUID assignee = null;
        UUID group = null;
        String notes = null;
        api.actionpackAssign(pack, itemsdata, assignee, group, notes);

        // TODO: test validations
    }
    
    /**
     * Delete an action item pack
     *
     * Allows the user to delete an action item pack.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void actionpackDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.actionpackDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * View details of an action item pack
     *
     * Allows the user to view an individual action pack and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void actionpackGetTest() throws ApiException {
        UUID id = null;
        api.actionpackGet(id);

        // TODO: test validations
    }
    
    /**
     * View a list of action item packs
     *
     * Allows the user to view the full list of action item packs.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void actionpackListTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        api.actionpackList(from, count);

        // TODO: test validations
    }
    
    /**
     * Create or edit an action item pack
     *
     * Allows the user to edit an action item pack.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void actionpackSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.actionpackSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
}