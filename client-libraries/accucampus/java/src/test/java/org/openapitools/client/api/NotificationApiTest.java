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
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for NotificationApi
 */
@Ignore
public class NotificationApiTest {

    private final NotificationApi api = new NotificationApi();

    
    /**
     * Delete a notification
     *
     * Allows the user to delete an existing notification.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationDeleteTest() throws ApiException {
        UUID id = null;
        oas_any_type_not_mapped body = null;
        api.notificationDelete(id, body);

        // TODO: test validations
    }
    
    /**
     * View a notification
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationGetTest() throws ApiException {
        UUID id = null;
        api.notificationGet(id);

        // TODO: test validations
    }
    
    /**
     * Gets all public (in station) notifications for the specific user
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationGetforstationTest() throws ApiException {
        UUID station = null;
        String user = null;
        api.notificationGetforstation(station, user);

        // TODO: test validations
    }
    
    /**
     * Get the number of unread notifications
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationGetunreadcountTest() throws ApiException {
        api.notificationGetunreadcount();

        // TODO: test validations
    }
    
    /**
     * View a list of all sent notifications
     *
     * Allows the user to view the list of all sent notifications.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationListTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        UUID recipient = null;
        Integer status = null;
        OffsetDateTime startdate = null;
        OffsetDateTime enddate = null;
        Boolean sentonscreen = null;
        Boolean sentemail = null;
        Boolean sentsms = null;
        api.notificationList(from, count, recipient, status, startdate, enddate, sentonscreen, sentemail, sentsms);

        // TODO: test validations
    }
    
    /**
     * View all the notifications sent to the current user
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationListmineTest() throws ApiException {
        Integer from = null;
        Integer count = null;
        Integer status = null;
        OffsetDateTime startdate = null;
        OffsetDateTime enddate = null;
        api.notificationListmine(from, count, status, startdate, enddate);

        // TODO: test validations
    }
    
    /**
     * Mark a notification as read
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationMarkasreadTest() throws ApiException {
        UUID id = null;
        Integer status = null;
        OffsetDateTime startdate = null;
        OffsetDateTime enddate = null;
        api.notificationMarkasread(id, status, startdate, enddate);

        // TODO: test validations
    }
    
    /**
     * Mark a notification as unread
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationMarkasunreadTest() throws ApiException {
        UUID id = null;
        Integer status = null;
        OffsetDateTime startdate = null;
        OffsetDateTime enddate = null;
        api.notificationMarkasunread(id, status, startdate, enddate);

        // TODO: test validations
    }
    
    /**
     * Send notifications on screen, via email or text to users
     *
     * Allows the user to send notifications to other users through the Send Message link.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationSendTest() throws ApiException {
        Boolean emailenabled = null;
        Boolean onscreenenabled = null;
        Boolean smsenabled = null;
        String title = null;
        String tousers = null;
        String togroups = null;
        String onscreenbody = null;
        String onscreenclick = null;
        String onscreenurl = null;
        String onscreenclass = null;
        Integer onscreenduration = null;
        Integer showonstation = null;
        String emailfromname = null;
        String emailfrom = null;
        String emailsubject = null;
        String emailbody = null;
        String textmessagebody = null;
        api.notificationSend(emailenabled, onscreenenabled, smsenabled, title, tousers, togroups, onscreenbody, onscreenclick, onscreenurl, onscreenclass, onscreenduration, showonstation, emailfromname, emailfrom, emailsubject, emailbody, textmessagebody);

        // TODO: test validations
    }
    
    /**
     * Send on-screen notifications
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void notificationSendonscreenTest() throws ApiException {
        UUID notification = null;
        api.notificationSendonscreen(notification);

        // TODO: test validations
    }
    
}