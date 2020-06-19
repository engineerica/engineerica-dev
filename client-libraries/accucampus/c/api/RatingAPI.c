#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "RatingAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Flags one rating for moderation
//
void
RatingAPI_ratingFlag(apiClient_t *apiClient, char * id , char * comment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/flag")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/flag");




    // query parameters
    char *keyQuery_id = NULL;
    char * valueQuery_id ;
    keyValuePair_t *keyPairQuery_id = 0;
    if (id)
    {
        keyQuery_id = strdup("id");
        valueQuery_id = (id);
        keyPairQuery_id = keyValuePair_create(keyQuery_id, &valueQuery_id);
        list_addElement(localVarQueryParameters,keyPairQuery_id);
    }

    // query parameters
    char *keyQuery_comment = NULL;
    char * valueQuery_comment = NULL;
    keyValuePair_t *keyPairQuery_comment = 0;
    if (comment)
    {
        keyQuery_comment = strdup("comment");
        valueQuery_comment = strdup((comment));
        keyPairQuery_comment = keyValuePair_create(keyQuery_comment, valueQuery_comment);
        list_addElement(localVarQueryParameters,keyPairQuery_comment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(valueQuery_comment){
        free(valueQuery_comment);
        valueQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }

}

// Flags one comment for moderation
//
void
RatingAPI_ratingFlagcomment(apiClient_t *apiClient, char * id , char * comment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/flagcomment")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/flagcomment");




    // query parameters
    char *keyQuery_id = NULL;
    char * valueQuery_id ;
    keyValuePair_t *keyPairQuery_id = 0;
    if (id)
    {
        keyQuery_id = strdup("id");
        valueQuery_id = (id);
        keyPairQuery_id = keyValuePair_create(keyQuery_id, &valueQuery_id);
        list_addElement(localVarQueryParameters,keyPairQuery_id);
    }

    // query parameters
    char *keyQuery_comment = NULL;
    char * valueQuery_comment = NULL;
    keyValuePair_t *keyPairQuery_comment = 0;
    if (comment)
    {
        keyQuery_comment = strdup("comment");
        valueQuery_comment = strdup((comment));
        keyPairQuery_comment = keyValuePair_create(keyQuery_comment, valueQuery_comment);
        list_addElement(localVarQueryParameters,keyPairQuery_comment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(valueQuery_comment){
        free(valueQuery_comment);
        valueQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }

}

// Get rating for one or more entities
//
void
RatingAPI_ratingGet(apiClient_t *apiClient, char * type , char * entityids )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/get")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/get");




    // query parameters
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
    }

    // query parameters
    char *keyQuery_entityids = NULL;
    char * valueQuery_entityids = NULL;
    keyValuePair_t *keyPairQuery_entityids = 0;
    if (entityids)
    {
        keyQuery_entityids = strdup("entityids");
        valueQuery_entityids = strdup((entityids));
        keyPairQuery_entityids = keyValuePair_create(keyQuery_entityids, valueQuery_entityids);
        list_addElement(localVarQueryParameters,keyPairQuery_entityids);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_entityids){
        free(keyQuery_entityids);
        keyQuery_entityids = NULL;
    }
    if(valueQuery_entityids){
        free(valueQuery_entityids);
        valueQuery_entityids = NULL;
    }
    if(keyPairQuery_entityids){
        keyValuePair_free(keyPairQuery_entityids);
        keyPairQuery_entityids = NULL;
    }
    if(keyQuery_entityids){
        free(keyQuery_entityids);
        keyQuery_entityids = NULL;
    }
    if(keyPairQuery_entityids){
        keyValuePair_free(keyPairQuery_entityids);
        keyPairQuery_entityids = NULL;
    }

}

// Gets the full ratings and comments for a specific entity
//
void
RatingAPI_ratingGetall(apiClient_t *apiClient, char * type , char * entityid , int mostrecentfirst )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/getall")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/getall");




    // query parameters
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
    }

    // query parameters
    char *keyQuery_entityid = NULL;
    char * valueQuery_entityid = NULL;
    keyValuePair_t *keyPairQuery_entityid = 0;
    if (entityid)
    {
        keyQuery_entityid = strdup("entityid");
        valueQuery_entityid = strdup((entityid));
        keyPairQuery_entityid = keyValuePair_create(keyQuery_entityid, valueQuery_entityid);
        list_addElement(localVarQueryParameters,keyPairQuery_entityid);
    }

    // query parameters
    char *keyQuery_mostrecentfirst = NULL;
    int valueQuery_mostrecentfirst ;
    keyValuePair_t *keyPairQuery_mostrecentfirst = 0;
    if (mostrecentfirst)
    {
        keyQuery_mostrecentfirst = strdup("mostrecentfirst");
        valueQuery_mostrecentfirst = (mostrecentfirst);
        keyPairQuery_mostrecentfirst = keyValuePair_create(keyQuery_mostrecentfirst, &valueQuery_mostrecentfirst);
        list_addElement(localVarQueryParameters,keyPairQuery_mostrecentfirst);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_entityid){
        free(keyQuery_entityid);
        keyQuery_entityid = NULL;
    }
    if(valueQuery_entityid){
        free(valueQuery_entityid);
        valueQuery_entityid = NULL;
    }
    if(keyPairQuery_entityid){
        keyValuePair_free(keyPairQuery_entityid);
        keyPairQuery_entityid = NULL;
    }
    if(keyQuery_entityid){
        free(keyQuery_entityid);
        keyQuery_entityid = NULL;
    }
    if(keyPairQuery_entityid){
        keyValuePair_free(keyPairQuery_entityid);
        keyPairQuery_entityid = NULL;
    }

}

// Gets all the comments for a rating
//
void
RatingAPI_ratingGetcomments(apiClient_t *apiClient, char * ratingid )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/getcomments")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/getcomments");




    // query parameters
    char *keyQuery_ratingid = NULL;
    char * valueQuery_ratingid ;
    keyValuePair_t *keyPairQuery_ratingid = 0;
    if (ratingid)
    {
        keyQuery_ratingid = strdup("ratingid");
        valueQuery_ratingid = (ratingid);
        keyPairQuery_ratingid = keyValuePair_create(keyQuery_ratingid, &valueQuery_ratingid);
        list_addElement(localVarQueryParameters,keyPairQuery_ratingid);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// Gets info of pre-saved and pre-approved ratings
//
void
RatingAPI_ratingGetpending(apiClient_t *apiClient, char * getgroup , char * rateid , int rateval )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/getpending")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/getpending");




    // query parameters
    char *keyQuery_getgroup = NULL;
    char * valueQuery_getgroup ;
    keyValuePair_t *keyPairQuery_getgroup = 0;
    if (getgroup)
    {
        keyQuery_getgroup = strdup("getgroup");
        valueQuery_getgroup = (getgroup);
        keyPairQuery_getgroup = keyValuePair_create(keyQuery_getgroup, &valueQuery_getgroup);
        list_addElement(localVarQueryParameters,keyPairQuery_getgroup);
    }

    // query parameters
    char *keyQuery_rateid = NULL;
    char * valueQuery_rateid ;
    keyValuePair_t *keyPairQuery_rateid = 0;
    if (rateid)
    {
        keyQuery_rateid = strdup("rateid");
        valueQuery_rateid = (rateid);
        keyPairQuery_rateid = keyValuePair_create(keyQuery_rateid, &valueQuery_rateid);
        list_addElement(localVarQueryParameters,keyPairQuery_rateid);
    }

    // query parameters
    char *keyQuery_rateval = NULL;
    int valueQuery_rateval ;
    keyValuePair_t *keyPairQuery_rateval = 0;
    if (rateval)
    {
        keyQuery_rateval = strdup("rateval");
        valueQuery_rateval = (rateval);
        keyPairQuery_rateval = keyValuePair_create(keyQuery_rateval, &valueQuery_rateval);
        list_addElement(localVarQueryParameters,keyPairQuery_rateval);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

// Shows a list of the ratings and comments that are pending for moderation
//
// Allows the user to view the list of pending ratings and comments.
//
void
RatingAPI_ratingGetpendingmoderation(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/getpendingmoderation")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/getpendingmoderation");



    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    
    
    
    
    
    free(localVarPath);

}

// Allows the user to accept or reject a comment
//
// Allows the user to approve or reject a comment or rating.
//
void
RatingAPI_ratingModerate(apiClient_t *apiClient, char * type , char * id , int approve )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/moderate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/moderate");




    // query parameters
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
    }

    // query parameters
    char *keyQuery_id = NULL;
    char * valueQuery_id ;
    keyValuePair_t *keyPairQuery_id = 0;
    if (id)
    {
        keyQuery_id = strdup("id");
        valueQuery_id = (id);
        keyPairQuery_id = keyValuePair_create(keyQuery_id, &valueQuery_id);
        list_addElement(localVarQueryParameters,keyPairQuery_id);
    }

    // query parameters
    char *keyQuery_approve = NULL;
    int valueQuery_approve ;
    keyValuePair_t *keyPairQuery_approve = 0;
    if (approve)
    {
        keyQuery_approve = strdup("approve");
        valueQuery_approve = (approve);
        keyPairQuery_approve = keyValuePair_create(keyQuery_approve, &valueQuery_approve);
        list_addElement(localVarQueryParameters,keyPairQuery_approve);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }

}

// Posts a comments for in a rating
//
void
RatingAPI_ratingPostcomment(apiClient_t *apiClient, char * ratingid , char * comment , int annonymous )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/postcomment")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/postcomment");




    // query parameters
    char *keyQuery_ratingid = NULL;
    char * valueQuery_ratingid ;
    keyValuePair_t *keyPairQuery_ratingid = 0;
    if (ratingid)
    {
        keyQuery_ratingid = strdup("ratingid");
        valueQuery_ratingid = (ratingid);
        keyPairQuery_ratingid = keyValuePair_create(keyQuery_ratingid, &valueQuery_ratingid);
        list_addElement(localVarQueryParameters,keyPairQuery_ratingid);
    }

    // query parameters
    char *keyQuery_comment = NULL;
    char * valueQuery_comment = NULL;
    keyValuePair_t *keyPairQuery_comment = 0;
    if (comment)
    {
        keyQuery_comment = strdup("comment");
        valueQuery_comment = strdup((comment));
        keyPairQuery_comment = keyValuePair_create(keyQuery_comment, valueQuery_comment);
        list_addElement(localVarQueryParameters,keyPairQuery_comment);
    }

    // query parameters
    char *keyQuery_annonymous = NULL;
    int valueQuery_annonymous ;
    keyValuePair_t *keyPairQuery_annonymous = 0;
    if (annonymous)
    {
        keyQuery_annonymous = strdup("annonymous");
        valueQuery_annonymous = (annonymous);
        keyPairQuery_annonymous = keyValuePair_create(keyQuery_annonymous, &valueQuery_annonymous);
        list_addElement(localVarQueryParameters,keyPairQuery_annonymous);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(valueQuery_comment){
        free(valueQuery_comment);
        valueQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }

}

// Rates one entity
//
void
RatingAPI_ratingRate(apiClient_t *apiClient, char * type , char * entityid , int annonymous , int value , char * comment , int updatecomment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/rate")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/rate");




    // query parameters
    char *keyQuery_type = NULL;
    char * valueQuery_type = NULL;
    keyValuePair_t *keyPairQuery_type = 0;
    if (type)
    {
        keyQuery_type = strdup("type");
        valueQuery_type = strdup((type));
        keyPairQuery_type = keyValuePair_create(keyQuery_type, valueQuery_type);
        list_addElement(localVarQueryParameters,keyPairQuery_type);
    }

    // query parameters
    char *keyQuery_entityid = NULL;
    char * valueQuery_entityid = NULL;
    keyValuePair_t *keyPairQuery_entityid = 0;
    if (entityid)
    {
        keyQuery_entityid = strdup("entityid");
        valueQuery_entityid = strdup((entityid));
        keyPairQuery_entityid = keyValuePair_create(keyQuery_entityid, valueQuery_entityid);
        list_addElement(localVarQueryParameters,keyPairQuery_entityid);
    }

    // query parameters
    char *keyQuery_value = NULL;
    int valueQuery_value ;
    keyValuePair_t *keyPairQuery_value = 0;
    if (value)
    {
        keyQuery_value = strdup("value");
        valueQuery_value = (value);
        keyPairQuery_value = keyValuePair_create(keyQuery_value, &valueQuery_value);
        list_addElement(localVarQueryParameters,keyPairQuery_value);
    }

    // query parameters
    char *keyQuery_annonymous = NULL;
    int valueQuery_annonymous ;
    keyValuePair_t *keyPairQuery_annonymous = 0;
    if (annonymous)
    {
        keyQuery_annonymous = strdup("annonymous");
        valueQuery_annonymous = (annonymous);
        keyPairQuery_annonymous = keyValuePair_create(keyQuery_annonymous, &valueQuery_annonymous);
        list_addElement(localVarQueryParameters,keyPairQuery_annonymous);
    }

    // query parameters
    char *keyQuery_comment = NULL;
    char * valueQuery_comment = NULL;
    keyValuePair_t *keyPairQuery_comment = 0;
    if (comment)
    {
        keyQuery_comment = strdup("comment");
        valueQuery_comment = strdup((comment));
        keyPairQuery_comment = keyValuePair_create(keyQuery_comment, valueQuery_comment);
        list_addElement(localVarQueryParameters,keyPairQuery_comment);
    }

    // query parameters
    char *keyQuery_updatecomment = NULL;
    int valueQuery_updatecomment ;
    keyValuePair_t *keyPairQuery_updatecomment = 0;
    if (updatecomment)
    {
        keyQuery_updatecomment = strdup("updatecomment");
        valueQuery_updatecomment = (updatecomment);
        keyPairQuery_updatecomment = keyValuePair_create(keyQuery_updatecomment, &valueQuery_updatecomment);
        list_addElement(localVarQueryParameters,keyPairQuery_updatecomment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(valueQuery_type){
        free(valueQuery_type);
        valueQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_type){
        free(keyQuery_type);
        keyQuery_type = NULL;
    }
    if(keyPairQuery_type){
        keyValuePair_free(keyPairQuery_type);
        keyPairQuery_type = NULL;
    }
    if(keyQuery_entityid){
        free(keyQuery_entityid);
        keyQuery_entityid = NULL;
    }
    if(valueQuery_entityid){
        free(valueQuery_entityid);
        valueQuery_entityid = NULL;
    }
    if(keyPairQuery_entityid){
        keyValuePair_free(keyPairQuery_entityid);
        keyPairQuery_entityid = NULL;
    }
    if(keyQuery_entityid){
        free(keyQuery_entityid);
        keyQuery_entityid = NULL;
    }
    if(keyPairQuery_entityid){
        keyValuePair_free(keyPairQuery_entityid);
        keyPairQuery_entityid = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(valueQuery_comment){
        free(valueQuery_comment);
        valueQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }

}

// Rates a pre-saved and pre-approved entity
//
void
RatingAPI_ratingRatepending(apiClient_t *apiClient, char * group , int annonymous , char * rateid , int value , char * comment , int updatecomment )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/ratepending")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/ratepending");




    // query parameters
    char *keyQuery_group = NULL;
    char * valueQuery_group ;
    keyValuePair_t *keyPairQuery_group = 0;
    if (group)
    {
        keyQuery_group = strdup("group");
        valueQuery_group = (group);
        keyPairQuery_group = keyValuePair_create(keyQuery_group, &valueQuery_group);
        list_addElement(localVarQueryParameters,keyPairQuery_group);
    }

    // query parameters
    char *keyQuery_rateid = NULL;
    char * valueQuery_rateid ;
    keyValuePair_t *keyPairQuery_rateid = 0;
    if (rateid)
    {
        keyQuery_rateid = strdup("rateid");
        valueQuery_rateid = (rateid);
        keyPairQuery_rateid = keyValuePair_create(keyQuery_rateid, &valueQuery_rateid);
        list_addElement(localVarQueryParameters,keyPairQuery_rateid);
    }

    // query parameters
    char *keyQuery_value = NULL;
    int valueQuery_value ;
    keyValuePair_t *keyPairQuery_value = 0;
    if (value)
    {
        keyQuery_value = strdup("value");
        valueQuery_value = (value);
        keyPairQuery_value = keyValuePair_create(keyQuery_value, &valueQuery_value);
        list_addElement(localVarQueryParameters,keyPairQuery_value);
    }

    // query parameters
    char *keyQuery_annonymous = NULL;
    int valueQuery_annonymous ;
    keyValuePair_t *keyPairQuery_annonymous = 0;
    if (annonymous)
    {
        keyQuery_annonymous = strdup("annonymous");
        valueQuery_annonymous = (annonymous);
        keyPairQuery_annonymous = keyValuePair_create(keyQuery_annonymous, &valueQuery_annonymous);
        list_addElement(localVarQueryParameters,keyPairQuery_annonymous);
    }

    // query parameters
    char *keyQuery_comment = NULL;
    char * valueQuery_comment = NULL;
    keyValuePair_t *keyPairQuery_comment = 0;
    if (comment)
    {
        keyQuery_comment = strdup("comment");
        valueQuery_comment = strdup((comment));
        keyPairQuery_comment = keyValuePair_create(keyQuery_comment, valueQuery_comment);
        list_addElement(localVarQueryParameters,keyPairQuery_comment);
    }

    // query parameters
    char *keyQuery_updatecomment = NULL;
    int valueQuery_updatecomment ;
    keyValuePair_t *keyPairQuery_updatecomment = 0;
    if (updatecomment)
    {
        keyQuery_updatecomment = strdup("updatecomment");
        valueQuery_updatecomment = (updatecomment);
        keyPairQuery_updatecomment = keyValuePair_create(keyQuery_updatecomment, &valueQuery_updatecomment);
        list_addElement(localVarQueryParameters,keyPairQuery_updatecomment);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(valueQuery_comment){
        free(valueQuery_comment);
        valueQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }
    if(keyQuery_comment){
        free(keyQuery_comment);
        keyQuery_comment = NULL;
    }
    if(keyPairQuery_comment){
        keyValuePair_free(keyPairQuery_comment);
        keyPairQuery_comment = NULL;
    }

}

// Votes up or down a rating
//
void
RatingAPI_ratingVote(apiClient_t *apiClient, char * ratingid , int vote )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/rating/vote")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/rating/vote");




    // query parameters
    char *keyQuery_ratingid = NULL;
    char * valueQuery_ratingid ;
    keyValuePair_t *keyPairQuery_ratingid = 0;
    if (ratingid)
    {
        keyQuery_ratingid = strdup("ratingid");
        valueQuery_ratingid = (ratingid);
        keyPairQuery_ratingid = keyValuePair_create(keyQuery_ratingid, &valueQuery_ratingid);
        list_addElement(localVarQueryParameters,keyPairQuery_ratingid);
    }

    // query parameters
    char *keyQuery_vote = NULL;
    int valueQuery_vote ;
    keyValuePair_t *keyPairQuery_vote = 0;
    if (vote)
    {
        keyQuery_vote = strdup("vote");
        valueQuery_vote = (vote);
        keyPairQuery_vote = keyValuePair_create(keyQuery_vote, &valueQuery_vote);
        list_addElement(localVarQueryParameters,keyPairQuery_vote);
    }
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "GET");

    if (apiClient->response_code == 200) {
        printf("%s\n","");
    }
    //No return type
end:
    if (apiClient->dataReceived) {
        free(apiClient->dataReceived);
        apiClient->dataReceived = NULL;
        apiClient->dataReceivedLen = 0;
    }
    list_free(localVarQueryParameters);
    
    
    
    
    free(localVarPath);

}

