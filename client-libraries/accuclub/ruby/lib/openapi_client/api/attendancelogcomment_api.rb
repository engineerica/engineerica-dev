=begin
#AccuClub OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class AttendancelogcommentApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a comment on an attendance log
    # @param id [String] The id of the attendance log comment to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def attendancelogcomment_delete(id, opts = {})
      attendancelogcomment_delete_with_http_info(id, opts)
      nil
    end

    # Delete a comment on an attendance log
    # @param id [String] The id of the attendance log comment to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancelogcomment_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancelogcommentApi.attendancelogcomment_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancelogcommentApi.attendancelogcomment_delete"
      end
      # resource path
      local_var_path = '/attendancelogcomment/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancelogcommentApi#attendancelogcomment_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a comment on an attendance log
    # @param id [String] The id of the comment to get.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def attendancelogcomment_get(id, opts = {})
      attendancelogcomment_get_with_http_info(id, opts)
      nil
    end

    # View a comment on an attendance log
    # @param id [String] The id of the comment to get.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancelogcomment_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancelogcommentApi.attendancelogcomment_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancelogcommentApi.attendancelogcomment_get"
      end
      # resource path
      local_var_path = '/attendancelogcomment/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancelogcommentApi#attendancelogcomment_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View all the comments on a specific attendance log
    # @param attendancelog [String] The id of the attendance log whose comments have to be retrieved.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def attendancelogcomment_list(attendancelog, opts = {})
      attendancelogcomment_list_with_http_info(attendancelog, opts)
      nil
    end

    # View all the comments on a specific attendance log
    # @param attendancelog [String] The id of the attendance log whose comments have to be retrieved.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancelogcomment_list_with_http_info(attendancelog, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancelogcommentApi.attendancelogcomment_list ...'
      end
      # verify the required parameter 'attendancelog' is set
      if @api_client.config.client_side_validation && attendancelog.nil?
        fail ArgumentError, "Missing the required parameter 'attendancelog' when calling AttendancelogcommentApi.attendancelogcomment_list"
      end
      # resource path
      local_var_path = '/attendancelogcomment/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'attendancelog'] = attendancelog

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
        @api_client.config.logger.debug "API called: AttendancelogcommentApi#attendancelogcomment_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Save a comment on an attendance log
    # @param id [String] The id of the comment to edit (leave empty to create a new one)
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def attendancelogcomment_save(id, opts = {})
      attendancelogcomment_save_with_http_info(id, opts)
      nil
    end

    # Save a comment on an attendance log
    # @param id [String] The id of the comment to edit (leave empty to create a new one)
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def attendancelogcomment_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: AttendancelogcommentApi.attendancelogcomment_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling AttendancelogcommentApi.attendancelogcomment_save"
      end
      # resource path
      local_var_path = '/attendancelogcomment/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: AttendancelogcommentApi#attendancelogcomment_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
