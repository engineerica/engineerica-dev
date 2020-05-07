#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include "action_result.h"



action_result_t *action_result_create(
    int success,
    list_t *results,
    char *message
    ) {
    action_result_t *action_result_local_var = malloc(sizeof(action_result_t));
    if (!action_result_local_var) {
        return NULL;
    }
    action_result_local_var->success = success;
    action_result_local_var->results = results;
    action_result_local_var->message = message;

    return action_result_local_var;
}


void action_result_free(action_result_t *action_result) {
    if(NULL == action_result){
        return ;
    }
    listEntry_t *listEntry;
    list_ForEach(listEntry, action_result->results) {
        object_free(listEntry->data);
    }
    list_free(action_result->results);
    free(action_result->message);
    free(action_result);
}

cJSON *action_result_convertToJSON(action_result_t *action_result) {
    cJSON *item = cJSON_CreateObject();

    // action_result->success
    if(action_result->success) { 
    if(cJSON_AddBoolToObject(item, "success", action_result->success) == NULL) {
    goto fail; //Bool
    }
     } 


    // action_result->results
    if(action_result->results) { 
    cJSON *results = cJSON_AddArrayToObject(item, "results");
    if(results == NULL) {
    goto fail; //nonprimitive container
    }

    listEntry_t *resultsListEntry;
    if (action_result->results) {
    list_ForEach(resultsListEntry, action_result->results) {
    cJSON *itemLocal = object_convertToJSON(resultsListEntry->data);
    if(itemLocal == NULL) {
    goto fail;
    }
    cJSON_AddItemToArray(results, itemLocal);
    }
    }
     } 


    // action_result->message
    if(action_result->message) { 
    if(cJSON_AddStringToObject(item, "message", action_result->message) == NULL) {
    goto fail; //String
    }
     } 

    return item;
fail:
    if (item) {
        cJSON_Delete(item);
    }
    return NULL;
}

action_result_t *action_result_parseFromJSON(cJSON *action_resultJSON){

    action_result_t *action_result_local_var = NULL;

    // action_result->success
    cJSON *success = cJSON_GetObjectItemCaseSensitive(action_resultJSON, "success");
    if (success) { 
    if(!cJSON_IsBool(success))
    {
    goto end; //Bool
    }
    }

    // action_result->results
    cJSON *results = cJSON_GetObjectItemCaseSensitive(action_resultJSON, "results");
    list_t *resultsList;
    if (results) { 
    cJSON *results_local_nonprimitive;
    if(!cJSON_IsArray(results)){
        goto end; //nonprimitive container
    }

    resultsList = list_create();

    cJSON_ArrayForEach(results_local_nonprimitive,results )
    {
        if(!cJSON_IsObject(results_local_nonprimitive)){
            goto end;
        }
        object_t *resultsItem = object_parseFromJSON(results_local_nonprimitive);

        list_addElement(resultsList, resultsItem);
    }
    }

    // action_result->message
    cJSON *message = cJSON_GetObjectItemCaseSensitive(action_resultJSON, "message");
    if (message) { 
    if(!cJSON_IsString(message))
    {
    goto end; //String
    }
    }


    action_result_local_var = action_result_create (
        success ? success->valueint : 0,
        results ? resultsList : NULL,
        message ? strdup(message->valuestring) : NULL
        );

    return action_result_local_var;
end:
    return NULL;

}
