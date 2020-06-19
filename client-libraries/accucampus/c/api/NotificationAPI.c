#include <stdlib.h>
#include <stdio.h>
#include <ctype.h>
#include "NotificationAPI.h"


#define MAX_BUFFER_LENGTH 4096
#define intToStr(dst, src) \
    do {\
    char dst[256];\
    snprintf(dst, 256, "%ld", (long int)(src));\
}while(0)


// Delete a notification
//
// Allows the user to delete an existing notification.
//
void
NotificationAPI_notificationDelete(apiClient_t *apiClient, char * id ,  body )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = list_create();
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/{id}");


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

// View a notification
//
void
NotificationAPI_notificationGet(apiClient_t *apiClient, char * id )
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/{id}")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/{id}");


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

// Gets all public (in station) notifications for the specific user
//
void
NotificationAPI_notificationGetforstation(apiClient_t *apiClient, char * station , char * user )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/getforstation")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/getforstation");




    // query parameters
    char *keyQuery_station = NULL;
    char * valueQuery_station ;
    keyValuePair_t *keyPairQuery_station = 0;
    if (station)
    {
        keyQuery_station = strdup("station");
        valueQuery_station = (station);
        keyPairQuery_station = keyValuePair_create(keyQuery_station, &valueQuery_station);
        list_addElement(localVarQueryParameters,keyPairQuery_station);
    }

    // query parameters
    char *keyQuery_user = NULL;
    char * valueQuery_user = NULL;
    keyValuePair_t *keyPairQuery_user = 0;
    if (user)
    {
        keyQuery_user = strdup("user");
        valueQuery_user = strdup((user));
        keyPairQuery_user = keyValuePair_create(keyQuery_user, valueQuery_user);
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
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(valueQuery_user){
        free(valueQuery_user);
        valueQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }
    if(keyQuery_user){
        free(keyQuery_user);
        keyQuery_user = NULL;
    }
    if(keyPairQuery_user){
        keyValuePair_free(keyPairQuery_user);
        keyPairQuery_user = NULL;
    }

}

// Get the number of unread notifications
//
void
NotificationAPI_notificationGetunreadcount(apiClient_t *apiClient)
{
    list_t    *localVarQueryParameters = NULL;
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/getunreadcount")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/getunreadcount");



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

// View a list of all sent notifications
//
// Allows the user to view the list of all sent notifications.
//
void
NotificationAPI_notificationList(apiClient_t *apiClient, int from , int count , char * recipient , int status , char startdate , char enddate , int sentonscreen , int sentemail , int sentsms )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/list")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/list");




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
    char *keyQuery_recipient = NULL;
    char * valueQuery_recipient ;
    keyValuePair_t *keyPairQuery_recipient = 0;
    if (recipient)
    {
        keyQuery_recipient = strdup("recipient");
        valueQuery_recipient = (recipient);
        keyPairQuery_recipient = keyValuePair_create(keyQuery_recipient, &valueQuery_recipient);
        list_addElement(localVarQueryParameters,keyPairQuery_recipient);
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
    char *keyQuery_startdate = NULL;
    char valueQuery_startdate ;
    keyValuePair_t *keyPairQuery_startdate = 0;
    if (startdate)
    {
        keyQuery_startdate = strdup("startdate");
        valueQuery_startdate = (startdate);
        keyPairQuery_startdate = keyValuePair_create(keyQuery_startdate, &valueQuery_startdate);
        list_addElement(localVarQueryParameters,keyPairQuery_startdate);
    }

    // query parameters
    char *keyQuery_enddate = NULL;
    char valueQuery_enddate ;
    keyValuePair_t *keyPairQuery_enddate = 0;
    if (enddate)
    {
        keyQuery_enddate = strdup("enddate");
        valueQuery_enddate = (enddate);
        keyPairQuery_enddate = keyValuePair_create(keyQuery_enddate, &valueQuery_enddate);
        list_addElement(localVarQueryParameters,keyPairQuery_enddate);
    }

    // query parameters
    char *keyQuery_sentonscreen = NULL;
    int valueQuery_sentonscreen ;
    keyValuePair_t *keyPairQuery_sentonscreen = 0;
    if (sentonscreen)
    {
        keyQuery_sentonscreen = strdup("sentonscreen");
        valueQuery_sentonscreen = (sentonscreen);
        keyPairQuery_sentonscreen = keyValuePair_create(keyQuery_sentonscreen, &valueQuery_sentonscreen);
        list_addElement(localVarQueryParameters,keyPairQuery_sentonscreen);
    }

    // query parameters
    char *keyQuery_sentemail = NULL;
    int valueQuery_sentemail ;
    keyValuePair_t *keyPairQuery_sentemail = 0;
    if (sentemail)
    {
        keyQuery_sentemail = strdup("sentemail");
        valueQuery_sentemail = (sentemail);
        keyPairQuery_sentemail = keyValuePair_create(keyQuery_sentemail, &valueQuery_sentemail);
        list_addElement(localVarQueryParameters,keyPairQuery_sentemail);
    }

    // query parameters
    char *keyQuery_sentsms = NULL;
    int valueQuery_sentsms ;
    keyValuePair_t *keyPairQuery_sentsms = 0;
    if (sentsms)
    {
        keyQuery_sentsms = strdup("sentsms");
        valueQuery_sentsms = (sentsms);
        keyPairQuery_sentsms = keyValuePair_create(keyQuery_sentsms, &valueQuery_sentsms);
        list_addElement(localVarQueryParameters,keyPairQuery_sentsms);
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

// View all the notifications sent to the current user
//
void
NotificationAPI_notificationListmine(apiClient_t *apiClient, int from , int count , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/listmine")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/listmine");




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
    char *keyQuery_startdate = NULL;
    char valueQuery_startdate ;
    keyValuePair_t *keyPairQuery_startdate = 0;
    if (startdate)
    {
        keyQuery_startdate = strdup("startdate");
        valueQuery_startdate = (startdate);
        keyPairQuery_startdate = keyValuePair_create(keyQuery_startdate, &valueQuery_startdate);
        list_addElement(localVarQueryParameters,keyPairQuery_startdate);
    }

    // query parameters
    char *keyQuery_enddate = NULL;
    char valueQuery_enddate ;
    keyValuePair_t *keyPairQuery_enddate = 0;
    if (enddate)
    {
        keyQuery_enddate = strdup("enddate");
        valueQuery_enddate = (enddate);
        keyPairQuery_enddate = keyValuePair_create(keyQuery_enddate, &valueQuery_enddate);
        list_addElement(localVarQueryParameters,keyPairQuery_enddate);
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

// Mark a notification as read
//
void
NotificationAPI_notificationMarkasread(apiClient_t *apiClient, char * id , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/markasread")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/markasread");




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
    char *keyQuery_startdate = NULL;
    char valueQuery_startdate ;
    keyValuePair_t *keyPairQuery_startdate = 0;
    if (startdate)
    {
        keyQuery_startdate = strdup("startdate");
        valueQuery_startdate = (startdate);
        keyPairQuery_startdate = keyValuePair_create(keyQuery_startdate, &valueQuery_startdate);
        list_addElement(localVarQueryParameters,keyPairQuery_startdate);
    }

    // query parameters
    char *keyQuery_enddate = NULL;
    char valueQuery_enddate ;
    keyValuePair_t *keyPairQuery_enddate = 0;
    if (enddate)
    {
        keyQuery_enddate = strdup("enddate");
        valueQuery_enddate = (enddate);
        keyPairQuery_enddate = keyValuePair_create(keyQuery_enddate, &valueQuery_enddate);
        list_addElement(localVarQueryParameters,keyPairQuery_enddate);
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

// Mark a notification as unread
//
void
NotificationAPI_notificationMarkasunread(apiClient_t *apiClient, char * id , int status , char startdate , char enddate )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/markasunread")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/markasunread");




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
    char *keyQuery_startdate = NULL;
    char valueQuery_startdate ;
    keyValuePair_t *keyPairQuery_startdate = 0;
    if (startdate)
    {
        keyQuery_startdate = strdup("startdate");
        valueQuery_startdate = (startdate);
        keyPairQuery_startdate = keyValuePair_create(keyQuery_startdate, &valueQuery_startdate);
        list_addElement(localVarQueryParameters,keyPairQuery_startdate);
    }

    // query parameters
    char *keyQuery_enddate = NULL;
    char valueQuery_enddate ;
    keyValuePair_t *keyPairQuery_enddate = 0;
    if (enddate)
    {
        keyQuery_enddate = strdup("enddate");
        valueQuery_enddate = (enddate);
        keyPairQuery_enddate = keyValuePair_create(keyQuery_enddate, &valueQuery_enddate);
        list_addElement(localVarQueryParameters,keyPairQuery_enddate);
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

// Send notifications on screen, via email or text to users
//
// Allows the user to send notifications to other users through the Send Message link.
//
void
NotificationAPI_notificationSend(apiClient_t *apiClient, int emailenabled , int onscreenenabled , int smsenabled , char * title , char * tousers , char * togroups , char * onscreenbody , char * onscreenclick , char * onscreenurl , char * onscreenclass , int onscreenduration , int showonstation , char * emailfromname , char * emailfrom , char * emailsubject , char * emailbody , char * textmessagebody )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/send")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/send");




    // query parameters
    char *keyQuery_tousers = NULL;
    char * valueQuery_tousers = NULL;
    keyValuePair_t *keyPairQuery_tousers = 0;
    if (tousers)
    {
        keyQuery_tousers = strdup("tousers");
        valueQuery_tousers = strdup((tousers));
        keyPairQuery_tousers = keyValuePair_create(keyQuery_tousers, valueQuery_tousers);
        list_addElement(localVarQueryParameters,keyPairQuery_tousers);
    }

    // query parameters
    char *keyQuery_togroups = NULL;
    char * valueQuery_togroups = NULL;
    keyValuePair_t *keyPairQuery_togroups = 0;
    if (togroups)
    {
        keyQuery_togroups = strdup("togroups");
        valueQuery_togroups = strdup((togroups));
        keyPairQuery_togroups = keyValuePair_create(keyQuery_togroups, valueQuery_togroups);
        list_addElement(localVarQueryParameters,keyPairQuery_togroups);
    }

    // query parameters
    char *keyQuery_emailenabled = NULL;
    int valueQuery_emailenabled ;
    keyValuePair_t *keyPairQuery_emailenabled = 0;
    if (emailenabled)
    {
        keyQuery_emailenabled = strdup("emailenabled");
        valueQuery_emailenabled = (emailenabled);
        keyPairQuery_emailenabled = keyValuePair_create(keyQuery_emailenabled, &valueQuery_emailenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_emailenabled);
    }

    // query parameters
    char *keyQuery_onscreenenabled = NULL;
    int valueQuery_onscreenenabled ;
    keyValuePair_t *keyPairQuery_onscreenenabled = 0;
    if (onscreenenabled)
    {
        keyQuery_onscreenenabled = strdup("onscreenenabled");
        valueQuery_onscreenenabled = (onscreenenabled);
        keyPairQuery_onscreenenabled = keyValuePair_create(keyQuery_onscreenenabled, &valueQuery_onscreenenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenenabled);
    }

    // query parameters
    char *keyQuery_smsenabled = NULL;
    int valueQuery_smsenabled ;
    keyValuePair_t *keyPairQuery_smsenabled = 0;
    if (smsenabled)
    {
        keyQuery_smsenabled = strdup("smsenabled");
        valueQuery_smsenabled = (smsenabled);
        keyPairQuery_smsenabled = keyValuePair_create(keyQuery_smsenabled, &valueQuery_smsenabled);
        list_addElement(localVarQueryParameters,keyPairQuery_smsenabled);
    }

    // query parameters
    char *keyQuery_title = NULL;
    char * valueQuery_title = NULL;
    keyValuePair_t *keyPairQuery_title = 0;
    if (title)
    {
        keyQuery_title = strdup("title");
        valueQuery_title = strdup((title));
        keyPairQuery_title = keyValuePair_create(keyQuery_title, valueQuery_title);
        list_addElement(localVarQueryParameters,keyPairQuery_title);
    }

    // query parameters
    char *keyQuery_onscreenbody = NULL;
    char * valueQuery_onscreenbody = NULL;
    keyValuePair_t *keyPairQuery_onscreenbody = 0;
    if (onscreenbody)
    {
        keyQuery_onscreenbody = strdup("onscreenbody");
        valueQuery_onscreenbody = strdup((onscreenbody));
        keyPairQuery_onscreenbody = keyValuePair_create(keyQuery_onscreenbody, valueQuery_onscreenbody);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenbody);
    }

    // query parameters
    char *keyQuery_onscreenclick = NULL;
    char * valueQuery_onscreenclick = NULL;
    keyValuePair_t *keyPairQuery_onscreenclick = 0;
    if (onscreenclick)
    {
        keyQuery_onscreenclick = strdup("onscreenclick");
        valueQuery_onscreenclick = strdup((onscreenclick));
        keyPairQuery_onscreenclick = keyValuePair_create(keyQuery_onscreenclick, valueQuery_onscreenclick);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenclick);
    }

    // query parameters
    char *keyQuery_onscreenurl = NULL;
    char * valueQuery_onscreenurl = NULL;
    keyValuePair_t *keyPairQuery_onscreenurl = 0;
    if (onscreenurl)
    {
        keyQuery_onscreenurl = strdup("onscreenurl");
        valueQuery_onscreenurl = strdup((onscreenurl));
        keyPairQuery_onscreenurl = keyValuePair_create(keyQuery_onscreenurl, valueQuery_onscreenurl);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenurl);
    }

    // query parameters
    char *keyQuery_onscreenclass = NULL;
    char * valueQuery_onscreenclass = NULL;
    keyValuePair_t *keyPairQuery_onscreenclass = 0;
    if (onscreenclass)
    {
        keyQuery_onscreenclass = strdup("onscreenclass");
        valueQuery_onscreenclass = strdup((onscreenclass));
        keyPairQuery_onscreenclass = keyValuePair_create(keyQuery_onscreenclass, valueQuery_onscreenclass);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenclass);
    }

    // query parameters
    char *keyQuery_onscreenduration = NULL;
    int valueQuery_onscreenduration ;
    keyValuePair_t *keyPairQuery_onscreenduration = 0;
    if (onscreenduration)
    {
        keyQuery_onscreenduration = strdup("onscreenduration");
        valueQuery_onscreenduration = (onscreenduration);
        keyPairQuery_onscreenduration = keyValuePair_create(keyQuery_onscreenduration, &valueQuery_onscreenduration);
        list_addElement(localVarQueryParameters,keyPairQuery_onscreenduration);
    }

    // query parameters
    char *keyQuery_showonstation = NULL;
    int valueQuery_showonstation ;
    keyValuePair_t *keyPairQuery_showonstation = 0;
    if (showonstation)
    {
        keyQuery_showonstation = strdup("showonstation");
        valueQuery_showonstation = (showonstation);
        keyPairQuery_showonstation = keyValuePair_create(keyQuery_showonstation, &valueQuery_showonstation);
        list_addElement(localVarQueryParameters,keyPairQuery_showonstation);
    }

    // query parameters
    char *keyQuery_emailfromname = NULL;
    char * valueQuery_emailfromname = NULL;
    keyValuePair_t *keyPairQuery_emailfromname = 0;
    if (emailfromname)
    {
        keyQuery_emailfromname = strdup("emailfromname");
        valueQuery_emailfromname = strdup((emailfromname));
        keyPairQuery_emailfromname = keyValuePair_create(keyQuery_emailfromname, valueQuery_emailfromname);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfromname);
    }

    // query parameters
    char *keyQuery_emailfrom = NULL;
    char * valueQuery_emailfrom = NULL;
    keyValuePair_t *keyPairQuery_emailfrom = 0;
    if (emailfrom)
    {
        keyQuery_emailfrom = strdup("emailfrom");
        valueQuery_emailfrom = strdup((emailfrom));
        keyPairQuery_emailfrom = keyValuePair_create(keyQuery_emailfrom, valueQuery_emailfrom);
        list_addElement(localVarQueryParameters,keyPairQuery_emailfrom);
    }

    // query parameters
    char *keyQuery_emailsubject = NULL;
    char * valueQuery_emailsubject = NULL;
    keyValuePair_t *keyPairQuery_emailsubject = 0;
    if (emailsubject)
    {
        keyQuery_emailsubject = strdup("emailsubject");
        valueQuery_emailsubject = strdup((emailsubject));
        keyPairQuery_emailsubject = keyValuePair_create(keyQuery_emailsubject, valueQuery_emailsubject);
        list_addElement(localVarQueryParameters,keyPairQuery_emailsubject);
    }

    // query parameters
    char *keyQuery_emailbody = NULL;
    char * valueQuery_emailbody = NULL;
    keyValuePair_t *keyPairQuery_emailbody = 0;
    if (emailbody)
    {
        keyQuery_emailbody = strdup("emailbody");
        valueQuery_emailbody = strdup((emailbody));
        keyPairQuery_emailbody = keyValuePair_create(keyQuery_emailbody, valueQuery_emailbody);
        list_addElement(localVarQueryParameters,keyPairQuery_emailbody);
    }

    // query parameters
    char *keyQuery_textmessagebody = NULL;
    char * valueQuery_textmessagebody = NULL;
    keyValuePair_t *keyPairQuery_textmessagebody = 0;
    if (textmessagebody)
    {
        keyQuery_textmessagebody = strdup("textmessagebody");
        valueQuery_textmessagebody = strdup((textmessagebody));
        keyPairQuery_textmessagebody = keyValuePair_create(keyQuery_textmessagebody, valueQuery_textmessagebody);
        list_addElement(localVarQueryParameters,keyPairQuery_textmessagebody);
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
    if(keyQuery_tousers){
        free(keyQuery_tousers);
        keyQuery_tousers = NULL;
    }
    if(valueQuery_tousers){
        free(valueQuery_tousers);
        valueQuery_tousers = NULL;
    }
    if(keyPairQuery_tousers){
        keyValuePair_free(keyPairQuery_tousers);
        keyPairQuery_tousers = NULL;
    }
    if(keyQuery_tousers){
        free(keyQuery_tousers);
        keyQuery_tousers = NULL;
    }
    if(keyPairQuery_tousers){
        keyValuePair_free(keyPairQuery_tousers);
        keyPairQuery_tousers = NULL;
    }
    if(keyQuery_togroups){
        free(keyQuery_togroups);
        keyQuery_togroups = NULL;
    }
    if(valueQuery_togroups){
        free(valueQuery_togroups);
        valueQuery_togroups = NULL;
    }
    if(keyPairQuery_togroups){
        keyValuePair_free(keyPairQuery_togroups);
        keyPairQuery_togroups = NULL;
    }
    if(keyQuery_togroups){
        free(keyQuery_togroups);
        keyQuery_togroups = NULL;
    }
    if(keyPairQuery_togroups){
        keyValuePair_free(keyPairQuery_togroups);
        keyPairQuery_togroups = NULL;
    }
    if(keyQuery_title){
        free(keyQuery_title);
        keyQuery_title = NULL;
    }
    if(valueQuery_title){
        free(valueQuery_title);
        valueQuery_title = NULL;
    }
    if(keyPairQuery_title){
        keyValuePair_free(keyPairQuery_title);
        keyPairQuery_title = NULL;
    }
    if(keyQuery_title){
        free(keyQuery_title);
        keyQuery_title = NULL;
    }
    if(keyPairQuery_title){
        keyValuePair_free(keyPairQuery_title);
        keyPairQuery_title = NULL;
    }
    if(keyQuery_onscreenbody){
        free(keyQuery_onscreenbody);
        keyQuery_onscreenbody = NULL;
    }
    if(valueQuery_onscreenbody){
        free(valueQuery_onscreenbody);
        valueQuery_onscreenbody = NULL;
    }
    if(keyPairQuery_onscreenbody){
        keyValuePair_free(keyPairQuery_onscreenbody);
        keyPairQuery_onscreenbody = NULL;
    }
    if(keyQuery_onscreenbody){
        free(keyQuery_onscreenbody);
        keyQuery_onscreenbody = NULL;
    }
    if(keyPairQuery_onscreenbody){
        keyValuePair_free(keyPairQuery_onscreenbody);
        keyPairQuery_onscreenbody = NULL;
    }
    if(keyQuery_onscreenclick){
        free(keyQuery_onscreenclick);
        keyQuery_onscreenclick = NULL;
    }
    if(valueQuery_onscreenclick){
        free(valueQuery_onscreenclick);
        valueQuery_onscreenclick = NULL;
    }
    if(keyPairQuery_onscreenclick){
        keyValuePair_free(keyPairQuery_onscreenclick);
        keyPairQuery_onscreenclick = NULL;
    }
    if(keyQuery_onscreenclick){
        free(keyQuery_onscreenclick);
        keyQuery_onscreenclick = NULL;
    }
    if(keyPairQuery_onscreenclick){
        keyValuePair_free(keyPairQuery_onscreenclick);
        keyPairQuery_onscreenclick = NULL;
    }
    if(keyQuery_onscreenurl){
        free(keyQuery_onscreenurl);
        keyQuery_onscreenurl = NULL;
    }
    if(valueQuery_onscreenurl){
        free(valueQuery_onscreenurl);
        valueQuery_onscreenurl = NULL;
    }
    if(keyPairQuery_onscreenurl){
        keyValuePair_free(keyPairQuery_onscreenurl);
        keyPairQuery_onscreenurl = NULL;
    }
    if(keyQuery_onscreenurl){
        free(keyQuery_onscreenurl);
        keyQuery_onscreenurl = NULL;
    }
    if(keyPairQuery_onscreenurl){
        keyValuePair_free(keyPairQuery_onscreenurl);
        keyPairQuery_onscreenurl = NULL;
    }
    if(keyQuery_onscreenclass){
        free(keyQuery_onscreenclass);
        keyQuery_onscreenclass = NULL;
    }
    if(valueQuery_onscreenclass){
        free(valueQuery_onscreenclass);
        valueQuery_onscreenclass = NULL;
    }
    if(keyPairQuery_onscreenclass){
        keyValuePair_free(keyPairQuery_onscreenclass);
        keyPairQuery_onscreenclass = NULL;
    }
    if(keyQuery_onscreenclass){
        free(keyQuery_onscreenclass);
        keyQuery_onscreenclass = NULL;
    }
    if(keyPairQuery_onscreenclass){
        keyValuePair_free(keyPairQuery_onscreenclass);
        keyPairQuery_onscreenclass = NULL;
    }
    if(keyQuery_emailfromname){
        free(keyQuery_emailfromname);
        keyQuery_emailfromname = NULL;
    }
    if(valueQuery_emailfromname){
        free(valueQuery_emailfromname);
        valueQuery_emailfromname = NULL;
    }
    if(keyPairQuery_emailfromname){
        keyValuePair_free(keyPairQuery_emailfromname);
        keyPairQuery_emailfromname = NULL;
    }
    if(keyQuery_emailfromname){
        free(keyQuery_emailfromname);
        keyQuery_emailfromname = NULL;
    }
    if(keyPairQuery_emailfromname){
        keyValuePair_free(keyPairQuery_emailfromname);
        keyPairQuery_emailfromname = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(valueQuery_emailfrom){
        free(valueQuery_emailfrom);
        valueQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailfrom){
        free(keyQuery_emailfrom);
        keyQuery_emailfrom = NULL;
    }
    if(keyPairQuery_emailfrom){
        keyValuePair_free(keyPairQuery_emailfrom);
        keyPairQuery_emailfrom = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(valueQuery_emailsubject){
        free(valueQuery_emailsubject);
        valueQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailsubject){
        free(keyQuery_emailsubject);
        keyQuery_emailsubject = NULL;
    }
    if(keyPairQuery_emailsubject){
        keyValuePair_free(keyPairQuery_emailsubject);
        keyPairQuery_emailsubject = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(valueQuery_emailbody){
        free(valueQuery_emailbody);
        valueQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_emailbody){
        free(keyQuery_emailbody);
        keyQuery_emailbody = NULL;
    }
    if(keyPairQuery_emailbody){
        keyValuePair_free(keyPairQuery_emailbody);
        keyPairQuery_emailbody = NULL;
    }
    if(keyQuery_textmessagebody){
        free(keyQuery_textmessagebody);
        keyQuery_textmessagebody = NULL;
    }
    if(valueQuery_textmessagebody){
        free(valueQuery_textmessagebody);
        valueQuery_textmessagebody = NULL;
    }
    if(keyPairQuery_textmessagebody){
        keyValuePair_free(keyPairQuery_textmessagebody);
        keyPairQuery_textmessagebody = NULL;
    }
    if(keyQuery_textmessagebody){
        free(keyQuery_textmessagebody);
        keyQuery_textmessagebody = NULL;
    }
    if(keyPairQuery_textmessagebody){
        keyValuePair_free(keyPairQuery_textmessagebody);
        keyPairQuery_textmessagebody = NULL;
    }

}

// Send on-screen notifications
//
void
NotificationAPI_notificationSendonscreen(apiClient_t *apiClient, char * notification )
{
    list_t    *localVarQueryParameters = list_create();
    list_t    *localVarHeaderParameters = NULL;
    list_t    *localVarFormParameters = NULL;
    list_t *localVarHeaderType = NULL;
    list_t *localVarContentType = NULL;
    char      *localVarBodyParameters = NULL;

    // create the path
    long sizeOfPath = strlen("/notification/sendonscreen")+1;
    char *localVarPath = malloc(sizeOfPath);
    snprintf(localVarPath, sizeOfPath, "/notification/sendonscreen");




    // query parameters
    char *keyQuery_notification = NULL;
    char * valueQuery_notification ;
    keyValuePair_t *keyPairQuery_notification = 0;
    if (notification)
    {
        keyQuery_notification = strdup("notification");
        valueQuery_notification = (notification);
        keyPairQuery_notification = keyValuePair_create(keyQuery_notification, &valueQuery_notification);
        list_addElement(localVarQueryParameters,keyPairQuery_notification);
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

