=begin
#AccuClub OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class SecurityApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Returns the list of users for a specific permission
    # @param commandname [String] Name of the action or command to get the roles.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def security_assesspermission(commandname, opts = {})
      security_assesspermission_with_http_info(commandname, opts)
      nil
    end

    # Returns the list of users for a specific permission
    # @param commandname [String] Name of the action or command to get the roles.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def security_assesspermission_with_http_info(commandname, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SecurityApi.security_assesspermission ...'
      end
      # verify the required parameter 'commandname' is set
      if @api_client.config.client_side_validation && commandname.nil?
        fail ArgumentError, "Missing the required parameter 'commandname' when calling SecurityApi.security_assesspermission"
      end
      # resource path
      local_var_path = '/security/assesspermission'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'commandname'] = commandname

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
        @api_client.config.logger.debug "API called: SecurityApi#security_assesspermission\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Returns the list of permissions for a specific role
    # @param roleid [String] Role ID to list the effective permissions.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def security_assessrole(roleid, opts = {})
      security_assessrole_with_http_info(roleid, opts)
      nil
    end

    # Returns the list of permissions for a specific role
    # @param roleid [String] Role ID to list the effective permissions.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def security_assessrole_with_http_info(roleid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SecurityApi.security_assessrole ...'
      end
      # verify the required parameter 'roleid' is set
      if @api_client.config.client_side_validation && roleid.nil?
        fail ArgumentError, "Missing the required parameter 'roleid' when calling SecurityApi.security_assessrole"
      end
      # resource path
      local_var_path = '/security/assessrole'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'roleid'] = roleid

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
        @api_client.config.logger.debug "API called: SecurityApi#security_assessrole\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Returns the list of users for a specific user
    # @param [Hash] opts the optional parameters
    # @option opts [String] :locationid Location ID to list the users with that scope.
    # @return [nil]
    def security_assessscope(opts = {})
      security_assessscope_with_http_info(opts)
      nil
    end

    # Returns the list of users for a specific user
    # @param [Hash] opts the optional parameters
    # @option opts [String] :locationid Location ID to list the users with that scope.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def security_assessscope_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SecurityApi.security_assessscope ...'
      end
      # resource path
      local_var_path = '/security/assessscope'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'locationid'] = opts[:'locationid'] if !opts[:'locationid'].nil?

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
        @api_client.config.logger.debug "API called: SecurityApi#security_assessscope\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Returns the list of permissions for a specific user
    # @param userid [String] User ID to list the effective permissions.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def security_assessuser(userid, opts = {})
      security_assessuser_with_http_info(userid, opts)
      nil
    end

    # Returns the list of permissions for a specific user
    # @param userid [String] User ID to list the effective permissions.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def security_assessuser_with_http_info(userid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SecurityApi.security_assessuser ...'
      end
      # verify the required parameter 'userid' is set
      if @api_client.config.client_side_validation && userid.nil?
        fail ArgumentError, "Missing the required parameter 'userid' when calling SecurityApi.security_assessuser"
      end
      # resource path
      local_var_path = '/security/assessuser'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'userid'] = userid

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
        @api_client.config.logger.debug "API called: SecurityApi#security_assessuser\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end