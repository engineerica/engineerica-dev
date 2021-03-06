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
 * API tests for AttendancelogcommentApi
 */
@Ignore
public class AttendancelogcommentApiTest {

    private final AttendancelogcommentApi api = new AttendancelogcommentApi();

    
    /**
     * Delete a comment on an attendance log
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void attendancelogcommentDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.attendancelogcommentDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * View a comment on an attendance log
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void attendancelogcommentGetTest() throws ApiException {
        UUID id = null;
        api.attendancelogcommentGet(id);

        // TODO: test validations
    }
    
    /**
     * View all the comments on a specific attendance log
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void attendancelogcommentListTest() throws ApiException {
        UUID attendancelog = null;
        api.attendancelogcommentList(attendancelog);

        // TODO: test validations
    }
    
    /**
     * Save a comment on an attendance log
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void attendancelogcommentSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.attendancelogcommentSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
}
