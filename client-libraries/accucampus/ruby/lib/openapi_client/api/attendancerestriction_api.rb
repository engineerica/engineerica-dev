=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class AttendancerestrictionApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete an attendance restriction
    # Allows the user to delete an existing attendance restriction.
    # @param id [String] The id of the restriction to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def attendancerestriction_delete(id, opts = {})
      attendancerestriction_delete_with_http_info(id, opts)
      nil
    end

    # Delete an attendance restriction
    # Allows the user to delete an existing attendance restriction.
    # @param id [String] The id of the restriction to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancerestriction_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancerestrictionApi.attendancerestriction_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancerestrictionApi.attendancerestriction_delete"
      end
      # resource path
      local_var_path = '/attendancerestriction/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancerestrictionApi#attendancerestriction_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View details of an attendance restriction
    # Allows the user to view an individual attendance restriction and its details.
    # @param id [String] The id of the restriction to get.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def attendancerestriction_get(id, opts = {})
      attendancerestriction_get_with_http_info(id, opts)
      nil
    end

    # View details of an attendance restriction
    # Allows the user to view an individual attendance restriction and its details.
    # @param id [String] The id of the restriction to get.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancerestriction_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancerestrictionApi.attendancerestriction_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancerestrictionApi.attendancerestriction_get"
      end
      # resource path
      local_var_path = '/attendancerestriction/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancerestrictionApi#attendancerestriction_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of attendance restrictions
    # Allows the user to view the list of all attendance restrictions.
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def attendancerestriction_list(from, count, opts = {})
      attendancerestriction_list_with_http_info(from, count, opts)
      nil
    end

    # View a list of attendance restrictions
    # Allows the user to view the list of all attendance restrictions.
    # @param from [Integer] The first record to return.
    # @param count [Integer] The max number of records to return.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancerestriction_list_with_http_info(from, count, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancerestrictionApi.attendancerestriction_list ...'
      end
      # verify the required parameter 'from' is set
      if @api_client.config.client_side_validation && from.nil?
        fail ArgumentError, "Missing the required parameter 'from' when calling AttendancerestrictionApi.attendancerestriction_list"
      end
      # verify the required parameter 'count' is set
      if @api_client.config.client_side_validation && count.nil?
        fail ArgumentError, "Missing the required parameter 'count' when calling AttendancerestrictionApi.attendancerestriction_list"
      end
      # resource path
      local_var_path = '/attendancerestriction/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = from
      query_params[:'count'] = count

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
        @api_client.config.logger.debug "API called: AttendancerestrictionApi#attendancerestriction_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit an attendance restriction
    # Allows the user to create or edit an attendance restriction.
    # @param id [String] The id of the restriction save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def attendancerestriction_save(id, opts = {})
      attendancerestriction_save_with_http_info(id, opts)
      nil
    end

    # Create or edit an attendance restriction
    # Allows the user to create or edit an attendance restriction.
    # @param id [String] The id of the restriction save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancerestriction_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancerestrictionApi.attendancerestriction_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancerestrictionApi.attendancerestriction_save"
      end
      # resource path
      local_var_path = '/attendancerestriction/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancerestrictionApi#attendancerestriction_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end