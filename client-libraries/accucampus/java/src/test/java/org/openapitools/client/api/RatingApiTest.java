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
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for RatingApi
 */
@Ignore
public class RatingApiTest {

    private final RatingApi api = new RatingApi();

    
    /**
     * Flags one rating for moderation
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingFlagTest() throws ApiException {
        UUID id = null;
        String comment = null;
        api.ratingFlag(id, comment);

        // TODO: test validations
    }
    
    /**
     * Flags one comment for moderation
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingFlagcommentTest() throws ApiException {
        UUID id = null;
        String comment = null;
        api.ratingFlagcomment(id, comment);

        // TODO: test validations
    }
    
    /**
     * Get rating for one or more entities
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingGetTest() throws ApiException {
        String type = null;
        String entityids = null;
        api.ratingGet(type, entityids);

        // TODO: test validations
    }
    
    /**
     * Gets the full ratings and comments for a specific entity
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingGetallTest() throws ApiException {
        String type = null;
        String entityid = null;
        Boolean mostrecentfirst = null;
        api.ratingGetall(type, entityid, mostrecentfirst);

        // TODO: test validations
    }
    
    /**
     * Gets all the comments for a rating
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingGetcommentsTest() throws ApiException {
        UUID ratingid = null;
        api.ratingGetcomments(ratingid);

        // TODO: test validations
    }
    
    /**
     * Gets info of pre-saved and pre-approved ratings
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingGetpendingTest() throws ApiException {
        UUID getgroup = null;
        UUID rateid = null;
        Integer rateval = null;
        api.ratingGetpending(getgroup, rateid, rateval);

        // TODO: test validations
    }
    
    /**
     * Shows a list of the ratings and comments that are pending for moderation
     *
     * Allows the user to view the list of pending ratings and comments.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingGetpendingmoderationTest() throws ApiException {
        api.ratingGetpendingmoderation();

        // TODO: test validations
    }
    
    /**
     * Allows the user to accept or reject a comment
     *
     * Allows the user to approve or reject a comment or rating.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingModerateTest() throws ApiException {
        String type = null;
        UUID id = null;
        Boolean approve = null;
        api.ratingModerate(type, id, approve);

        // TODO: test validations
    }
    
    /**
     * Posts a comments for in a rating
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingPostcommentTest() throws ApiException {
        UUID ratingid = null;
        String comment = null;
        Boolean annonymous = null;
        api.ratingPostcomment(ratingid, comment, annonymous);

        // TODO: test validations
    }
    
    /**
     * Rates one entity
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingRateTest() throws ApiException {
        String type = null;
        String entityid = null;
        Boolean annonymous = null;
        Integer value = null;
        String comment = null;
        Boolean updatecomment = null;
        api.ratingRate(type, entityid, annonymous, value, comment, updatecomment);

        // TODO: test validations
    }
    
    /**
     * Rates a pre-saved and pre-approved entity
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingRatependingTest() throws ApiException {
        UUID group = null;
        Boolean annonymous = null;
        UUID rateid = null;
        Integer value = null;
        String comment = null;
        Boolean updatecomment = null;
        api.ratingRatepending(group, annonymous, rateid, value, comment, updatecomment);

        // TODO: test validations
    }
    
    /**
     * Votes up or down a rating
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void ratingVoteTest() throws ApiException {
        UUID ratingid = null;
        Integer vote = null;
        api.ratingVote(ratingid, vote);

        // TODO: test validations
    }
    
}