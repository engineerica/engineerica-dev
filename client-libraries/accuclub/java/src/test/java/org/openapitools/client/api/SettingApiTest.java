/*
 * AccuClub OpenAPI 3
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
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for SettingApi
 */
@Ignore
public class SettingApiTest {

    private final SettingApi api = new SettingApi();

    
    /**
     * Add a logo to the account
     *
     * Allows the user to add the logo for the account, which appears on all pages on the AccuClub browser version.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void settingAddlogoTest() throws ApiException {
        String upload = null;
        String filename = null;
        api.settingAddlogo(upload, filename);

        // TODO: test validations
    }
    
    /**
     * Get settings for the account or the specified scope
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void settingGetTest() throws ApiException {
        String keys = null;
        String domain = null;
        String scope = null;
        api.settingGet(keys, domain, scope);

        // TODO: test validations
    }
    
    /**
     * Save settings for the account or the specified scope
     *
     * Allows the user to affect settings that are not specified elsewhere in permissions. This includes Attendance, Appointments, Compass, Media, and Social Activity.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void settingSaveTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.settingSave(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * View general settings for the account
     *
     * Allows the user to view the settings&#39; general section.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void settingViewgeneralTest() throws ApiException {
        api.settingViewgeneral();

        // TODO: test validations
    }
    
}
