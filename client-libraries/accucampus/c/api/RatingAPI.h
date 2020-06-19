#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"


// Flags one rating for moderation
//
void
RatingAPI_ratingFlag(apiClient_t *apiClient, char * id , char * comment );


// Flags one comment for moderation
//
void
RatingAPI_ratingFlagcomment(apiClient_t *apiClient, char * id , char * comment );


// Get rating for one or more entities
//
void
RatingAPI_ratingGet(apiClient_t *apiClient, char * type , char * entityids );


// Gets the full ratings and comments for a specific entity
//
void
RatingAPI_ratingGetall(apiClient_t *apiClient, char * type , char * entityid , int mostrecentfirst );


// Gets all the comments for a rating
//
void
RatingAPI_ratingGetcomments(apiClient_t *apiClient, char * ratingid );


// Gets info of pre-saved and pre-approved ratings
//
void
RatingAPI_ratingGetpending(apiClient_t *apiClient, char * getgroup , char * rateid , int rateval );


// Shows a list of the ratings and comments that are pending for moderation
//
// Allows the user to view the list of pending ratings and comments.
//
void
RatingAPI_ratingGetpendingmoderation(apiClient_t *apiClient);


// Allows the user to accept or reject a comment
//
// Allows the user to approve or reject a comment or rating.
//
void
RatingAPI_ratingModerate(apiClient_t *apiClient, char * type , char * id , int approve );


// Posts a comments for in a rating
//
void
RatingAPI_ratingPostcomment(apiClient_t *apiClient, char * ratingid , char * comment , int annonymous );


// Rates one entity
//
void
RatingAPI_ratingRate(apiClient_t *apiClient, char * type , char * entityid , int annonymous , int value , char * comment , int updatecomment );


// Rates a pre-saved and pre-approved entity
//
void
RatingAPI_ratingRatepending(apiClient_t *apiClient, char * group , int annonymous , char * rateid , int value , char * comment , int updatecomment );


// Votes up or down a rating
//
void
RatingAPI_ratingVote(apiClient_t *apiClient, char * ratingid , int vote );


