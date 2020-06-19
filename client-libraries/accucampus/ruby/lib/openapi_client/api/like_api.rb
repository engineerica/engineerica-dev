=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'cgi'

module OpenapiClient
  class LikeApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Delete a like
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def like_delete(opts = {})
      like_delete_with_http_info(opts)
      nil
    end

    # Delete a like
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def like_delete_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LikeApi.like_delete ...'
      end
      # resource path
      local_var_path = '/like/delete'

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

      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path, new_options)
      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LikeApi#like_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # View all the likes associated to a target
    # @param interactionid [String] The id of the interaction to unlike.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [nil]
    def like_list(interactionid, opts = {})
      like_list_with_http_info(interactionid, opts)
      nil
    end

    # View all the likes associated to a target
    # @param interactionid [String] The id of the interaction to unlike.
    # @param [Hash] opts the optional parameters
    # @option opts [Integer] :photosize The size in pixels of the photo URLs returned. Defaults to 40. If the size specified is not available, a similar one will be returned.
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def like_list_with_http_info(interactionid, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LikeApi.like_list ...'
      end
      # verify the required parameter 'interactionid' is set
      if @api_client.config.client_side_validation && interactionid.nil?
        fail ArgumentError, "Missing the required parameter 'interactionid' when calling LikeApi.like_list"
      end
      # resource path
      local_var_path = '/like/list'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'interactionid'] = interactionid
      query_params[:'photosize'] = opts[:'photosize'] if !opts[:'photosize'].nil?

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
        @api_client.config.logger.debug "API called: LikeApi#like_list\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end

    # Save a like
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [nil]
    def like_save(opts = {})
      like_save_with_http_info(opts)
      nil
    end

    # Save a like
    # @param [Hash] opts the optional parameters
    # @option opts [UNKNOWN_BASE_TYPE] :unknown_base_type 
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def like_save_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LikeApi.like_save ...'
      end
      # resource path
      local_var_path = '/like/save'

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
        @api_client.config.logger.debug "API called: LikeApi#like_save\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end