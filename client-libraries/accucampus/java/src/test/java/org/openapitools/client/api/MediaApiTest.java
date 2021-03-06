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
 * API tests for MediaApi
 */
@Ignore
public class MediaApiTest {

    private final MediaApi api = new MediaApi();

    
    /**
     * Check in media item
     *
     * Allows the user to check in a media item.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaCheckinTest() throws ApiException {
        UUID media = null;
        OffsetDateTime checkindate = null;
        String notes = null;
        api.mediaCheckin(media, checkindate, notes);

        // TODO: test validations
    }
    
    /**
     * Check out media item
     *
     * Allows the user to check out a media item.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaCheckoutTest() throws ApiException {
        UUID media = null;
        UUID user = null;
        OffsetDateTime checkoutdate = null;
        OffsetDateTime duedate = null;
        UUID staff = null;
        UUID event = null;
        String notes = null;
        api.mediaCheckout(media, user, checkoutdate, duedate, staff, event, notes);

        // TODO: test validations
    }
    
    /**
     * View a list of past media checkouts
     *
     * Allows the user to view a list of all past checkouts
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaCheckoutlistTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        UUID media = null;
        UUID user = null;
        Integer photosize = null;
        api.mediaCheckoutlist(from, count, media, user, photosize);

        // TODO: test validations
    }
    
    /**
     * Delete a media item
     *
     * Allows the user to delete an existing media item.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.mediaDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * Delete a media checkout log
     *
     * Allows the user to delete a media item&#39;s checkout log.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaDeletecheckoutlogTest() throws ApiException {
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.mediaDeletecheckoutlog(UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
    /**
     * Search and view details of a media item
     *
     * Allows the user to view an individual media item and its details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaGetTest() throws ApiException {
        UUID id = null;
        api.mediaGet(id);

        // TODO: test validations
    }
    
    /**
     * Search media item by unique code
     *
     * Allows the user to search for media items by their unique code.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaGetbycodeTest() throws ApiException {
        String code = null;
        UUID location = null;
        api.mediaGetbycode(code, location);

        // TODO: test validations
    }
    
    /**
     * View details of a media item checkout information
     *
     * Allows the user to view a media item&#39;s checkout information.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaGetcheckoutTest() throws ApiException {
        UUID id = null;
        Integer photosize = null;
        api.mediaGetcheckout(id, photosize);

        // TODO: test validations
    }
    
    /**
     * View details of a media checkout log
     *
     * Allows the user to view a media item&#39;s checkout history.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaGetcheckoutlogTest() throws ApiException {
        UUID id = null;
        Integer photosize = null;
        api.mediaGetcheckoutlog(id, photosize);

        // TODO: test validations
    }
    
    /**
     * View a list of media items
     *
     * Allows the user to view the list of all media items tied to locations in which the user is scoped.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaListTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        Integer status = null;
        UUID user = null;
        api.mediaList(from, count, status, user);

        // TODO: test validations
    }
    
    /**
     * Create or edit a media item
     *
     * Allows the user to create or edit a media item.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void mediaSaveTest() throws ApiException {
        UUID id = null;
        UNKNOWN_BASE_TYPE UNKNOWN_BASE_TYPE = null;
        api.mediaSave(id, UNKNOWN_BASE_TYPE);

        // TODO: test validations
    }
    
}
