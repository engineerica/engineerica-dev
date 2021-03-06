=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class SeminarApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete an event
    # Allows the user to delete an existing event.
    # @param id [String] The id of the seminar to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def seminar_delete(id, opts = {})
      seminar_delete_with_http_info(id, opts)
      nil
    end

    # Delete an event
    # Allows the user to delete an existing event.
    # @param id [String] The id of the seminar to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def seminar_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SeminarApi.seminar_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SeminarApi.seminar_delete"
      end
      # resource path
      local_var_path = '/seminar/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: SeminarApi#seminar_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Search and view details of a event
    # Allows the user to view a event and its details.
    # @param id [String] The id of the seminar to get.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def seminar_get(id, opts = {})
      seminar_get_with_http_info(id, opts)
      nil
    end

    # Search and view details of a event
    # Allows the user to view a event and its details.
    # @param id [String] The id of the seminar to get.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def seminar_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SeminarApi.seminar_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SeminarApi.seminar_get"
      end
      # resource path
      local_var_path = '/seminar/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: SeminarApi#seminar_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of events
    # Allows the user to view the full list of events in the past, present, and future.
    # @param from [String] The first record to return.
    # @param count [String] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [Boolean] :summaryonly True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
    # @option opts [String] :termid Id of the term to list the events. Null to list all events.
    # @return [nil]
    def seminar_list(from, count, opts = {})
      seminar_list_with_http_info(from, count, opts)
      nil
    end

    # View a list of events
    # Allows the user to view the full list of events in the past, present, and future.
    # @param from [String] The first record to return.
    # @param count [String] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @option opts [Boolean] :summaryonly True to return only the event information and not the associated schedule, dept, etc. Defaults to false.
    # @option opts [String] :termid Id of the term to list the events. Null to list all events.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def seminar_list_with_http_info(from, count, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SeminarApi.seminar_list ...'
      end
      # verify the required parameter 'from' is set
      if @api_client.config.client_side_validation && from.nil?
        fail ArgumentError, "Missing the required parameter 'from' when calling SeminarApi.seminar_list"
      end
      # verify the required parameter 'count' is set
      if @api_client.config.client_side_validation && count.nil?
        fail ArgumentError, "Missing the required parameter 'count' when calling SeminarApi.seminar_list"
      end
      # resource path
      local_var_path = '/seminar/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = from
      query_params[:'count'] = count
      query_params[:'summaryonly'] = opts[:'summaryonly'] if !opts[:'summaryonly'].nil?
      query_params[:'termid'] = opts[:'termid'] if !opts[:'termid'].nil?

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
        @api_client.config.logger.debug "API called: SeminarApi#seminar_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit a event
    # Allows the user to create or edit a event.
    # @param id [String] The id of the event to save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def seminar_save(id, opts = {})
      seminar_save_with_http_info(id, opts)
      nil
    end

    # Create or edit a event
    # Allows the user to create or edit a event.
    # @param id [String] The id of the event to save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def seminar_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SeminarApi.seminar_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SeminarApi.seminar_save"
      end
      # resource path
      local_var_path = '/seminar/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: SeminarApi#seminar_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
