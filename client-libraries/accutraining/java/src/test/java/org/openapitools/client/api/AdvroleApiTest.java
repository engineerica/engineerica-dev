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
 * API tests for AdvroleApi
 */
@Ignore
public class AdvroleApiTest {

    private final AdvroleApi api = new AdvroleApi();

    
    /**
     * Adds the missing permissions to a role. Requires access to advrole.save
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleAddmissingTest() throws ApiException {
        String roles = null;
        String permissions = null;
        api.advroleAddmissing(roles, permissions);

        // TODO: test validations
    }
    
    /**
     * Checks the permissions are assigned for the given roles
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleCheckpermTest() throws ApiException {
        String roles = null;
        String permissions = null;
        api.advroleCheckperm(roles, permissions);

        // TODO: test validations
    }
    
    /**
     * Delete a role
     *
     * Allows the user to delete a role from the list of available roles.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.advroleDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * Delete a role mapping
     *
     * Allows the user to delete a role from its mapped categories on the &#39;Role Mapping&#39; page.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleDeletemappingTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.advroleDeletemapping(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * View details of a role
     *
     * Allows the user to view a role and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleGetTest() throws ApiException {
        UUID id = null;
        api.advroleGet(id);

        // TODO: test validations
    }
    
    /**
     * Lists the roles for the current account
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleListTest() throws ApiException {
        Boolean includepolicies = null;
        Boolean includeinternal = null;
        String name = null;
        api.advroleList(includepolicies, includeinternal, name);

        // TODO: test validations
    }
    
    /**
     * Lists the maps a roles is mapped to
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleListmapsTest() throws ApiException {
        UUID roleid = null;
        api.advroleListmaps(roleid);

        // TODO: test validations
    }
    
    /**
     * Lists the roles mappings
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleListrolesmappedTest() throws ApiException {
        String map = null;
        api.advroleListrolesmapped(map);

        // TODO: test validations
    }
    
    /**
     * View a list of role templates
     *
     * Allows the user to view the full list of available role templates.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleListtemplatesTest() throws ApiException {
        api.advroleListtemplates();

        // TODO: test validations
    }
    
    /**
     * Create or edit a role
     *
     * Allows the user to create or edit a role&#39;s permissions.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.advroleSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Saves a role mapping
     *
     * Allows the user to add a role to a mapped category on the &#39;Role Mapping&#39; page.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleSavemappingTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.advroleSavemapping(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Upgrade a user to another role (requires permission to edit those roles)
     *
     * Allow the user to add a role to another user, given that he has access to view that other user and edit people with that new role.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void advroleUserupgradeTest() throws ApiException {
        UUID userid = null;
        UUID roleid = null;
        api.advroleUserupgrade(userid, roleid);

        // TODO: test validations
    }
    
}
