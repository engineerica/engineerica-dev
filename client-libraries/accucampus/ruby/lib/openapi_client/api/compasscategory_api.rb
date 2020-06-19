=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class CompasscategoryApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a compass category
    # Allows the user to delete an existing compass category.
    # @param id [String] The id of the category to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [nil]
    def compasscategory_delete(id, opts = {})
      compasscategory_delete_with_http_info(id, opts)
      nil
    end

    # Delete a compass category
    # Allows the user to delete an existing compass category.
    # @param id [String] The id of the category to delete.
    # @param [Hash] opts the optional parameters
    # @option opts [AnyType] :body 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def compasscategory_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CompasscategoryApi.compasscategory_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling CompasscategoryApi.compasscategory_delete"
      end
      # resource path
      local_var_path = '/compasscategory/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: CompasscategoryApi#compasscategory_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View details of a compass category
    # Allows the user to view an indvidiaul compass category and its details.
    # @param id [String] The id of the category to get.
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def compasscategory_get(id, opts = {})
      compasscategory_get_with_http_info(id, opts)
      nil
    end

    # View details of a compass category
    # Allows the user to view an indvidiaul compass category and its details.
    # @param id [String] The id of the category to get.
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def compasscategory_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CompasscategoryApi.compasscategory_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling CompasscategoryApi.compasscategory_get"
      end
      # resource path
      local_var_path = '/compasscategory/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: CompasscategoryApi#compasscategory_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View a list of compass categories
    # Allows the user to view the full list of compass categories.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :from The first record to return.
    # @option opts [Integer] :count The max number of records to return.
    # @option opts [Boolean] :onlywithservices Specified whether only categories with services are returned or all.
    # @return [nil]
    def compasscategory_list(opts = {})
      compasscategory_list_with_http_info(opts)
      nil
    end

    # View a list of compass categories
    # Allows the user to view the full list of compass categories.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :from The first record to return.
    # @option opts [Integer] :count The max number of records to return.
    # @option opts [Boolean] :onlywithservices Specified whether only categories with services are returned or all.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def compasscategory_list_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CompasscategoryApi.compasscategory_list ...'
      end
      # resource path
      local_var_path = '/compasscategory/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'from'] = opts[:'from'] if !opts[:'from'].nil?
      query_params[:'count'] = opts[:'count'] if !opts[:'count'].nil?
      query_params[:'onlywithservices'] = opts[:'onlywithservices'] if !opts[:'onlywithservices'].nil?

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
        @api_client.config.logger.debug "API called: CompasscategoryApi#compasscategory_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Create or edit a compass category
    # Allows the user to create or edit a compass category.
    # @param id [String] The id of the category save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def compasscategory_save(id, opts = {})
      compasscategory_save_with_http_info(id, opts)
      nil
    end

    # Create or edit a compass category
    # Allows the user to create or edit a compass category.
    # @param id [String] The id of the category save (leave empty to create a new one).
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def compasscategory_save_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: CompasscategoryApi.compasscategory_save ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling CompasscategoryApi.compasscategory_save"
      end
      # resource path
      local_var_path = '/compasscategory/{id}'.sub('{' + 'id' + '}', CGI.escape(id.to_s))

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
        @api_client.config.logger.debug "API called: CompasscategoryApi#compasscategory_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end