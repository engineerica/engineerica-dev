#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Delete a notification topic
//
// Allows the user to delete an existing notification topic.
//
void
NotificationtopicAPI_notificationtopicDelete(apiClient_t *apiClient, char * id ,  body );


// Search and view details of a notification topic
//
// Allows the user to view an individual notification topic and its details.
//
void
NotificationtopicAPI_notificationtopicGet(apiClient_t *apiClient, char * id );


// List all the notification topics
//
// Allows the user to view the list of all notification topics.
//
void
NotificationtopicAPI_notificationtopicList(apiClient_t *apiClient, int from , int count );


// List all the notification topics available to subscribe
//
void
NotificationtopicAPI_notificationtopicListsubscribe(apiClient_t *apiClient);


// Create or edit a notification topic
//
// Allows the user to create and edit a notification topic.
//
void
NotificationtopicAPI_notificationtopicSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


