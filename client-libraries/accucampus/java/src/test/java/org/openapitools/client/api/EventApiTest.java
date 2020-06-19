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
import org.threeten.bp.OffsetDateTime;
import org.openapitools.client.model.UNKNOWN_BASE_TYPE;
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for EventApi
 */
@Ignore
public class EventApiTest {

    private final EventApi api = new EventApi();

    
    /**
     * Edit an event&#39;s sessions according to their schedule
     *
     * Allows the user to edit event sessions.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventChecksessionsTest() throws ApiException {
        UUID eventid = null;
        Boolean autorepair = null;
        api.eventChecksessions(eventid, autorepair);

        // TODO: test validations
    }
    
    /**
     * Delete a course
     *
     * Allows the user to delete an existing course.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.eventDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * Search and view details of a course
     *
     * Allows the user to view an individual course and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventGetTest() throws ApiException {
        UUID id = null;
        api.eventGet(id);

        // TODO: test validations
    }
    
    /**
     * View a list of courses by date
     *
     * Allows the user to view a list of courses by date.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventGetsessionsbydateTest() throws ApiException {
        UUID location = null;
        OffsetDateTime date = null;
        String type = null;
        api.eventGetsessionsbydate(location, date, type);

        // TODO: test validations
    }
    
    /**
     * View a list of courses
     *
     * Allows the user to view the full list of courses.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventListTest() throws ApiException {
        String from = null;
        String count = null;
        Boolean summaryonly = null;
        UUID termid = null;
        api.eventList(from, count, summaryonly, termid);

        // TODO: test validations
    }
    
    /**
     * View a list of courses I am registered to
     *
     * Allows the user to view the courses they are registered to.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventListregisteredTest() throws ApiException {
        String from = null;
        String count = null;
        Boolean summaryonly = null;
        UUID termid = null;
        api.eventListregistered(from, count, summaryonly, termid);

        // TODO: test validations
    }
    
    /**
     * Create or edit a course
     *
     * Allows the user to create or edit a course.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.eventSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Searches for the available event groups
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void eventSearchgroupTest() throws ApiException {
        UUID query = null;
        api.eventSearchgroup(query);

        // TODO: test validations
    }
    
}