#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Delete a notification
//
// Allows the user to delete an existing notification.
//
void
NotificationAPI_notificationDelete(apiClient_t *apiClient, char * id ,  body );


// View a notification
//
void
NotificationAPI_notificationGet(apiClient_t *apiClient, char * id );


// Gets all public (in station) notifications for the specific user
//
void
NotificationAPI_notificationGetforstation(apiClient_t *apiClient, char * station , char * user );


// Get the number of unread notifications
//
void
NotificationAPI_notificationGetunreadcount(apiClient_t *apiClient);


// View a list of all sent notifications
//
// Allows the user to view the list of all sent notifications.
//
void
NotificationAPI_notificationList(apiClient_t *apiClient, int from , int count , char * recipient , int status , char startdate , char enddate , int sentonscreen , int sentemail , int sentsms );


// View all the notifications sent to the current user
//
void
NotificationAPI_notificationListmine(apiClient_t *apiClient, int from , int count , int status , char startdate , char enddate );


// Mark a notification as read
//
void
NotificationAPI_notificationMarkasread(apiClient_t *apiClient, char * id , int status , char startdate , char enddate );


// Mark a notification as unread
//
void
NotificationAPI_notificationMarkasunread(apiClient_t *apiClient, char * id , int status , char startdate , char enddate );


// Send notifications on screen, via email or text to users
//
// Allows the user to send notifications to other users through the Send Message link.
//
void
NotificationAPI_notificationSend(apiClient_t *apiClient, int emailenabled , int onscreenenabled , int smsenabled , char * title , char * tousers , char * togroups , char * onscreenbody , char * onscreenclick , char * onscreenurl , char * onscreenclass , int onscreenduration , int showonstation , char * emailfromname , char * emailfrom , char * emailsubject , char * emailbody , char * textmessagebody );


// Send on-screen notifications
//
void
NotificationAPI_notificationSendonscreen(apiClient_t *apiClient, char * notification );


