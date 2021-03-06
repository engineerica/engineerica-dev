=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class UserprofileApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a user profile
    # Allows the user to delete a profile from the list of profiles that they have permission to edit.
    # @param id [String] The id of the user profile to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def userprofile_delete(id, opts = {})
      userprofile_delete_with_http_info(id, opts)
      nil
    end

    # Delete a user profile
    # Allows the user to delete a profile from the list of profiles that they have permission to edit.
    # @param id [String] The id of the user profile to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling UserprofileApi.userprofile_delete"
      end
      # resource path
      local_var_path = '/userprofile/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'body']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a specific user profile
    # Allows the user to view individual user profiles and their details, provided they have permission to view that profile.
    # @param id [String] The id of the profile question set.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def userprofile_get(id, opts = {})
      userprofile_get_with_http_info(id, opts)
      nil
    end

    # View a specific user profile
    # Allows the user to view individual user profiles and their details, provided they have permission to view that profile.
    # @param id [String] The id of the profile question set.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling UserprofileApi.userprofile_get"
      end
      # resource path
      local_var_path = '/userprofile/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
    # Allows the user to view a profile for a user, provided they have permission to view that user and profile.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :id The id of the user to view, or empty for current user.
    # @return [nil]
    def userprofile_getallview(opts = {})
      userprofile_getallview_with_http_info(opts)
      nil
    end

    # Shows the profile for a specific (or current) user, based on each profile questionnaire questions.
    # Allows the user to view a profile for a user, provided they have permission to view that user and profile.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :id The id of the user to view, or empty for current user.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_getallview_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_getallview ...'
      end
      # resource path
      local_var_path = '/userprofile/getallview'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'id'] = opts[:'id'] if !opts[:'id'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_getallview\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View the list of user profiles
    # Allows the user to view the full list of profiles that they have permission to view.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :from The first record to return.
    # @option opts [Integer] :count The max number of records to return.
    # @return [nil]
    def userprofile_list(opts = {})
      userprofile_list_with_http_info(opts)
      nil
    end

    # View the list of user profiles
    # Allows the user to view the full list of profiles that they have permission to view.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :from The first record to return.
    # @option opts [Integer] :count The max number of records to return.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_list_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_list ...'
      end
      # resource path
      local_var_path = '/userprofile/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = opts[:'from'] if !opts[:'from'].nil?
      query_params[:'count'] = opts[:'count'] if !opts[:'count'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Gets the list of all the available user questions
    # Allows the user to view the list of questions in a profile that they have permission to view.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def userprofile_listquestions(opts = {})
      userprofile_listquestions_with_http_info(opts)
      nil
    end

    # Gets the list of all the available user questions
    # Allows the user to view the list of questions in a profile that they have permission to view.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_listquestions_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_listquestions ...'
      end
      # resource path
      local_var_path = '/userprofile/listquestions'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_listquestions\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Gets the statistics of a user group
    # Allows the user to view the demographic statistics of a user group.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :params The ID of the group, specified as &#39;group&#x3D;...&#39;
    # @return [nil]
    def userprofile_preparestats(opts = {})
      userprofile_preparestats_with_http_info(opts)
      nil
    end

    # Gets the statistics of a user group
    # Allows the user to view the demographic statistics of a user group.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :params The ID of the group, specified as &#39;group&#x3D;...&#39;
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_preparestats_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_preparestats ...'
      end
      # resource path
      local_var_path = '/userprofile/preparestats'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'params'] = opts[:'params'] if !opts[:'params'].nil?

      # header parameters
      header_params = opts[:header_params] || {}

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:GET, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_preparestats\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit user profile questions
    # Allows the user to create or edit a user profile.
    # @param id [String] The id of the profile question set.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def userprofile_save(id, opts = {})
      userprofile_save_with_http_info(id, opts)
      nil
    end

    # Create or edit user profile questions
    # Allows the user to create or edit a user profile.
    # @param id [String] The id of the profile question set.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling UserprofileApi.userprofile_save"
      end
      # resource path
      local_var_path = '/userprofile/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'unknown_base_type']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
    # Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def userprofile_saveanswers(opts = {})
      userprofile_saveanswers_with_http_info(opts)
      nil
    end

    # Saves the profile for a specific (or current) user. Additional security applies on a per profile basis.
    # Allows the user to edit a profile for a user, provided they have permission to edit that user and profile.
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def userprofile_saveanswers_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: UserprofileApi.userprofile_saveanswers ...'
      end
      # resource path
      local_var_path = '/userprofile/saveanswers'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(opts[:'unknown_base_type']) 

      # return_type
      return_type = opts[:return_type] 

      # auth_names
      auth_names = opts[:auth_names] || ['bearerAuth']

      new_options = opts.merge(
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type
      )

      data, status_code, headers = @api_client.call_api(:POST, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: UserprofileApi#userprofile_saveanswers\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
