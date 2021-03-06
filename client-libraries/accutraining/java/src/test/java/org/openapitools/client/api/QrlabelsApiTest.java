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
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for QrlabelsApi
 */
@Ignore
public class QrlabelsApiTest {

    private final QrlabelsApi api = new QrlabelsApi();

    
    /**
     * Print and email QR labels
     *
     * Allows the user to generate a printable PDF of QR labels containing user Card Numbers to be emailed to users and used as attendance tracking for events.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void qrlabelsPrintTest() throws ApiException {
        UUID user = null;
        UUID group = null;
        api.qrlabelsPrint(user, group);

        // TODO: test validations
    }
    
}
