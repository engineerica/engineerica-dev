=begin
#AccuCampus OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::TextcreditApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'TextcreditApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::TextcreditApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of TextcreditApi' do
    it 'should create an instance of TextcreditApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::TextcreditApi)
    end
  end

  # unit tests for textcredit_remaining
  # Gets the remaining text credits for the account
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'textcredit_remaining test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end