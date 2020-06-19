#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "MediaAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Check in media item
//
// Allows the user to check in a media item.
//
void
MediaAPI_mediaCheckin(apiClient_t *apiClient, char * media , char checkindate , char * notes )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/checkin")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/checkin");




    // query parameters
    char *keyQuery_media = NULL;
    char * valueQuery_media ;
    keyValuePair_t *keyPairQuery_media = 0;
    if (media)
    {
        keyQuery_media = strdup("media");
        valueQuery_media = (media);
        keyPairQuery_media = keyValuePair_create(keyQuery_media, &valueQuery_media);
        list_addElement(localVarQueryParameters,keyPairQuery_media);
    }

    // query parameters
    char *keyQuery_checkindate = NULL;
    char valueQuery_checkindate ;
    keyValuePair_t *keyPairQuery_checkindate = 0;
    if (checkindate)
    {
        keyQuery_checkindate = strdup("checkindate");
        valueQuery_checkindate = (checkindate);
        keyPairQuery_checkindate = keyValuePair_create(keyQuery_checkindate, &valueQuery_checkindate);
        list_addElement(localVarQueryParameters,keyPairQuery_checkindate);
    }

    // query parameters
    char *keyQuery_notes = NULL;
    char * valueQuery_notes = NULL;
    keyValuePair_t *keyPairQuery_notes = 0;
    if (notes)
    {
        keyQuery_notes = strdup("notes");
        valueQuery_notes = strdup((notes));
        keyPairQuery_notes = keyValuePair_create(keyQuery_notes, valueQuery_notes);
        list_addElement(localVarQueryParameters,keyPairQuery_notes);
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
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(valueQuery_notes){
        free(valueQuery_notes);
        valueQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }

}

// Check out media item
//
// Allows the user to check out a media item.
//
void
MediaAPI_mediaCheckout(apiClient_t *apiClient, char * media , char * user , char checkoutdate , char duedate , char * staff , char * event , char * notes )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/checkout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/checkout");




    // query parameters
    char *keyQuery_media = NULL;
    char * valueQuery_media ;
    keyValuePair_t *keyPairQuery_media = 0;
    if (media)
    {
        keyQuery_media = strdup("media");
        valueQuery_media = (media);
        keyPairQuery_media = keyValuePair_create(keyQuery_media, &valueQuery_media);
        list_addElement(localVarQueryParameters,keyPairQuery_media);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
    }

    // query parameters
    char *keyQuery_staff = NULL;
    char * valueQuery_staff ;
    keyValuePair_t *keyPairQuery_staff = 0;
    if (staff)
    {
        keyQuery_staff = strdup("staff");
        valueQuery_staff = (staff);
        keyPairQuery_staff = keyValuePair_create(keyQuery_staff, &valueQuery_staff);
        list_addElement(localVarQueryParameters,keyPairQuery_staff);
    }

    // query parameters
    char *keyQuery_event = NULL;
    char * valueQuery_event ;
    keyValuePair_t *keyPairQuery_event = 0;
    if (event)
    {
        keyQuery_event = strdup("event");
        valueQuery_event = (event);
        keyPairQuery_event = keyValuePair_create(keyQuery_event, &valueQuery_event);
        list_addElement(localVarQueryParameters,keyPairQuery_event);
    }

    // query parameters
    char *keyQuery_checkoutdate = NULL;
    char valueQuery_checkoutdate ;
    keyValuePair_t *keyPairQuery_checkoutdate = 0;
    if (checkoutdate)
    {
        keyQuery_checkoutdate = strdup("checkoutdate");
        valueQuery_checkoutdate = (checkoutdate);
        keyPairQuery_checkoutdate = keyValuePair_create(keyQuery_checkoutdate, &valueQuery_checkoutdate);
        list_addElement(localVarQueryParameters,keyPairQuery_checkoutdate);
    }

    // query parameters
    char *keyQuery_duedate = NULL;
    char valueQuery_duedate ;
    keyValuePair_t *keyPairQuery_duedate = 0;
    if (duedate)
    {
        keyQuery_duedate = strdup("duedate");
        valueQuery_duedate = (duedate);
        keyPairQuery_duedate = keyValuePair_create(keyQuery_duedate, &valueQuery_duedate);
        list_addElement(localVarQueryParameters,keyPairQuery_duedate);
    }

    // query parameters
    char *keyQuery_notes = NULL;
    char * valueQuery_notes = NULL;
    keyValuePair_t *keyPairQuery_notes = 0;
    if (notes)
    {
        keyQuery_notes = strdup("notes");
        valueQuery_notes = strdup((notes));
        keyPairQuery_notes = keyValuePair_create(keyQuery_notes, valueQuery_notes);
        list_addElement(localVarQueryParameters,keyPairQuery_notes);
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
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(valueQuery_notes){
        free(valueQuery_notes);
        valueQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }
    if(keyQuery_notes){
        free(keyQuery_notes);
        keyQuery_notes = NULL;
    }
    if(keyPairQuery_notes){
        keyValuePair_free(keyPairQuery_notes);
        keyPairQuery_notes = NULL;
    }

}

// View a list of past media checkouts
//
// Allows the user to view a list of all past checkouts
//
void
MediaAPI_mediaCheckoutlist(apiClient_t *apiClient, int from , int count , char * media , char * user , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/checkoutlist")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/checkoutlist");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_media = NULL;
    char * valueQuery_media ;
    keyValuePair_t *keyPairQuery_media = 0;
    if (media)
    {
        keyQuery_media = strdup("media");
        valueQuery_media = (media);
        keyPairQuery_media = keyValuePair_create(keyQuery_media, &valueQuery_media);
        list_addElement(localVarQueryParameters,keyPairQuery_media);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
    }

    // query parameters
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
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

// Delete a media item
//
// Allows the user to delete an existing media item.
//
void
MediaAPI_mediaDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_body;
    if (body != NULL)
    {
        //string
        localVarSingleItemJSON_body = any_type_convertToJSON(body);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_body);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "DELETE");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_body);
    free(localVarBodyParameters);

}

// Delete a media checkout log
//
// Allows the user to delete a media item's checkout log.
//
void
MediaAPI_mediaDeletecheckoutlog(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/deletecheckoutlog")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/deletecheckoutlog");




    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "DELETE");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

// Search and view details of a media item
//
// Allows the user to view an individual media item and its details.
//
void
MediaAPI_mediaGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);


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
    free(localVarToReplace_id);

}

// Search media item by unique code
//
// Allows the user to search for media items by their unique code.
//
void
MediaAPI_mediaGetbycode(apiClient_t *apiClient, char * code , char * location )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/getbycode")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/getbycode");




    // query parameters
    char *keyQuery_code = NULL;
    char * valueQuery_code = NULL;
    keyValuePair_t *keyPairQuery_code = 0;
    if (code)
    {
        keyQuery_code = strdup("code");
        valueQuery_code = strdup((code));
        keyPairQuery_code = keyValuePair_create(keyQuery_code, valueQuery_code);
        list_addElement(localVarQueryParameters,keyPairQuery_code);
    }

    // query parameters
    char *keyQuery_location = NULL;
    char * valueQuery_location ;
    keyValuePair_t *keyPairQuery_location = 0;
    if (location)
    {
        keyQuery_location = strdup("location");
        valueQuery_location = (location);
        keyPairQuery_location = keyValuePair_create(keyQuery_location, &valueQuery_location);
        list_addElement(localVarQueryParameters,keyPairQuery_location);
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
    if(keyQuery_code){
        free(keyQuery_code);
        keyQuery_code = NULL;
    }
    if(valueQuery_code){
        free(valueQuery_code);
        valueQuery_code = NULL;
    }
    if(keyPairQuery_code){
        keyValuePair_free(keyPairQuery_code);
        keyPairQuery_code = NULL;
    }
    if(keyQuery_code){
        free(keyQuery_code);
        keyQuery_code = NULL;
    }
    if(keyPairQuery_code){
        keyValuePair_free(keyPairQuery_code);
        keyPairQuery_code = NULL;
    }

}

// View details of a media item checkout information
//
// Allows the user to view a media item's checkout information.
//
void
MediaAPI_mediaGetcheckout(apiClient_t *apiClient, char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/getcheckout")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/getcheckout");




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
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
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

// View details of a media checkout log
//
// Allows the user to view a media item's checkout history.
//
void
MediaAPI_mediaGetcheckoutlog(apiClient_t *apiClient, char * id , int photosize )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/getcheckoutlog")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/getcheckoutlog");




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
    char *keyQuery_photosize = NULL;
    int valueQuery_photosize ;
    keyValuePair_t *keyPairQuery_photosize = 0;
    if (photosize)
    {
        keyQuery_photosize = strdup("photosize");
        valueQuery_photosize = (photosize);
        keyPairQuery_photosize = keyValuePair_create(keyQuery_photosize, &valueQuery_photosize);
        list_addElement(localVarQueryParameters,keyPairQuery_photosize);
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

// View a list of media items
//
// Allows the user to view the list of all media items tied to locations in which the user is scoped.
//
void
MediaAPI_mediaList(apiClient_t *apiClient, int from , int count , int status , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/list");




    // query parameters
    char *keyQuery_from = NULL;
    int valueQuery_from ;
    keyValuePair_t *keyPairQuery_from = 0;
    if (from)
    {
        keyQuery_from = strdup("from");
        valueQuery_from = (from);
        keyPairQuery_from = keyValuePair_create(keyQuery_from, &valueQuery_from);
        list_addElement(localVarQueryParameters,keyPairQuery_from);
    }

    // query parameters
    char *keyQuery_count = NULL;
    int valueQuery_count ;
    keyValuePair_t *keyPairQuery_count = 0;
    if (count)
    {
        keyQuery_count = strdup("count");
        valueQuery_count = (count);
        keyPairQuery_count = keyValuePair_create(keyQuery_count, &valueQuery_count);
        list_addElement(localVarQueryParameters,keyPairQuery_count);
    }

    // query parameters
    char *keyQuery_status = NULL;
    int valueQuery_status ;
    keyValuePair_t *keyPairQuery_status = 0;
    if (status)
    {
        keyQuery_status = strdup("status");
        valueQuery_status = (status);
        keyPairQuery_status = keyValuePair_create(keyQuery_status, &valueQuery_status);
        list_addElement(localVarQueryParameters,keyPairQuery_status);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user ;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = (user);
        keyPairQuery_user = keyValuePair_create(keyQuery_user, &valueQuery_user);
        list_addElement(localVarQueryParameters,keyPairQuery_user);
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

// Create or edit a media item
//
// Allows the user to create or edit a media item.
//
void
MediaAPI_mediaSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/media/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/media/{id}");


    // Path Params
    long sizeOfPathParams_id =  + strlen("{ id }");
    if(id == NULL) {
        goto end;
    }
    char* localVarToReplace_id = malloc(sizeOfPathParams_id);
    sprintf(localVarToReplace_id, "{%s}", "id");

    localVarPath = strReplace(localVarPath, localVarToReplace_id, id);



    // Body Param
    cJSON *localVarSingleItemJSON_UNKNOWN_BASE_TYPE;
    if (UNKNOWN_BASE_TYPE != NULL)
    {
        //string
        localVarSingleItemJSON_UNKNOWN_BASE_TYPE = UNKNOWN_BASE_TYPE_convertToJSON(UNKNOWN_BASE_TYPE);
        localVarBodyParameters = cJSON_Print(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    }
    list_addElement(localVarContentType,"application/json"); //consumes
    apiClient_invoke(apiClient,
                    localVarPath,
                    localVarQueryParameters,
                    localVarHeaderParameters,
                    localVarFormParameters,
                    localVarHeaderType,
                    localVarContentType,
                    localVarBodyParameters,
                    "POST");

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
    
    
    
    
    list_free(localVarContentType);
    free(localVarPath);
    free(localVarToReplace_id);
    cJSON_Delete(localVarSingleItemJSON_UNKNOWN_BASE_TYPE);
    free(localVarBodyParameters);

}

