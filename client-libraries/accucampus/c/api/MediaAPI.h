#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/UNKNOWN_BASE_TYPE.h"
#include "../model/object.h"


// Check in media item
//
// Allows the user to check in a media item.
//
void
MediaAPI_mediaCheckin(apiClient_t *apiClient, char * media , char checkindate , char * notes );


// Check out media item
//
// Allows the user to check out a media item.
//
void
MediaAPI_mediaCheckout(apiClient_t *apiClient, char * media , char * user , char checkoutdate , char duedate , char * staff , char * event , char * notes );


// View a list of past media checkouts
//
// Allows the user to view a list of all past checkouts
//
void
MediaAPI_mediaCheckoutlist(apiClient_t *apiClient, int from , int count , char * media , char * user , int photosize );


// Delete a media item
//
// Allows the user to delete an existing media item.
//
void
MediaAPI_mediaDelete(apiClient_t *apiClient, char * id ,  body );


// Delete a media checkout log
//
// Allows the user to delete a media item's checkout log.
//
void
MediaAPI_mediaDeletecheckoutlog(apiClient_t *apiClient, UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


// Search and view details of a media item
//
// Allows the user to view an individual media item and its details.
//
void
MediaAPI_mediaGet(apiClient_t *apiClient, char * id );


// Search media item by unique code
//
// Allows the user to search for media items by their unique code.
//
void
MediaAPI_mediaGetbycode(apiClient_t *apiClient, char * code , char * location );


// View details of a media item checkout information
//
// Allows the user to view a media item's checkout information.
//
void
MediaAPI_mediaGetcheckout(apiClient_t *apiClient, char * id , int photosize );


// View details of a media checkout log
//
// Allows the user to view a media item's checkout history.
//
void
MediaAPI_mediaGetcheckoutlog(apiClient_t *apiClient, char * id , int photosize );


// View a list of media items
//
// Allows the user to view the list of all media items tied to locations in which the user is scoped.
//
void
MediaAPI_mediaList(apiClient_t *apiClient, int from , int count , int status , char * user );


// Create or edit a media item
//
// Allows the user to create or edit a media item.
//
void
MediaAPI_mediaSave(apiClient_t *apiClient, char * id , UNKNOWN_BASE_TYPE_t * UNKNOWN_BASE_TYPE );


