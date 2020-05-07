#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#include "error_action_result.h"



error_action_result_t *error_action_result_create(
    int success,
    char *message,
    char *error_flag,
    char *domain,
    char *redirect_url
    ) {
    error_action_result_t *error_action_result_local_var = malloc(sizeof(error_action_result_t));
    if (!error_action_result_local_var) {
        return NULL;
    }
    error_action_result_local_var->success = success;
    error_action_result_local_var->message = message;
    error_action_result_local_var->error_flag = error_flag;
    error_action_result_local_var->domain = domain;
    error_action_result_local_var->redirect_url = redirect_url;

    return error_action_result_local_var;
}


void error_action_result_free(error_action_result_t *error_action_result) {
    if(NULL == error_action_result){
        return ;
    }
    listEntry_t *listEntry;
    free(error_action_result->message);
    free(error_action_result->error_flag);
    free(error_action_result->domain);
    free(error_action_result->redirect_url);
    free(error_action_result);
}

cJSON *error_action_result_convertToJSON(error_action_result_t *error_action_result) {
    cJSON *item = cJSON_CreateObject();

    // error_action_result->success
    if(error_action_result->success) { 
    if(cJSON_AddBoolToObject(item, "success", error_action_result->success) == NULL) {
    goto fail; //Bool
    }
     } 


    // error_action_result->message
    if(error_action_result->message) { 
    if(cJSON_AddStringToObject(item, "message", error_action_result->message) == NULL) {
    goto fail; //String
    }
     } 


    // error_action_result->error_flag
    if(error_action_result->error_flag) { 
    if(cJSON_AddStringToObject(item, "error_flag", error_action_result->error_flag) == NULL) {
    goto fail; //String
    }
     } 


    // error_action_result->domain
    if(error_action_result->domain) { 
    if(cJSON_AddStringToObject(item, "domain", error_action_result->domain) == NULL) {
    goto fail; //String
    }
     } 


    // error_action_result->redirect_url
    if(error_action_result->redirect_url) { 
    if(cJSON_AddStringToObject(item, "redirect_url", error_action_result->redirect_url) == NULL) {
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

error_action_result_t *error_action_result_parseFromJSON(cJSON *error_action_resultJSON){

    error_action_result_t *error_action_result_local_var = NULL;

    // error_action_result->success
    cJSON *success = cJSON_GetObjectItemCaseSensitive(error_action_resultJSON, "success");
    if (success) { 
    if(!cJSON_IsBool(success))
    {
    goto end; //Bool
    }
    }

    // error_action_result->message
    cJSON *message = cJSON_GetObjectItemCaseSensitive(error_action_resultJSON, "message");
    if (message) { 
    if(!cJSON_IsString(message))
    {
    goto end; //String
    }
    }

    // error_action_result->error_flag
    cJSON *error_flag = cJSON_GetObjectItemCaseSensitive(error_action_resultJSON, "error_flag");
    if (error_flag) { 
    if(!cJSON_IsString(error_flag))
    {
    goto end; //String
    }
    }

    // error_action_result->domain
    cJSON *domain = cJSON_GetObjectItemCaseSensitive(error_action_resultJSON, "domain");
    if (domain) { 
    if(!cJSON_IsString(domain))
    {
    goto end; //String
    }
    }

    // error_action_result->redirect_url
    cJSON *redirect_url = cJSON_GetObjectItemCaseSensitive(error_action_resultJSON, "redirect_url");
    if (redirect_url) { 
    if(!cJSON_IsString(redirect_url))
    {
    goto end; //String
    }
    }


    error_action_result_local_var = error_action_result_create (
        success ? success->valueint : 0,
        message ? strdup(message->valuestring) : NULL,
        error_flag ? strdup(error_flag->valuestring) : NULL,
        domain ? strdup(domain->valuestring) : NULL,
        redirect_url ? strdup(redirect_url->valuestring) : NULL
        );

    return error_action_result_local_var;
end:
    return NULL;

}
