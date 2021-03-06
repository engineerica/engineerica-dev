=begin
#AccuTraining OpenAPI 3

#No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)

The version of the OpenAPI document: 1.0.0

Generated by: https://openapi-generator.tech
OpenAPI Generator version: 4.3.1

=end

require 'spec_helper'
require 'json'

# Unit tests for OpenapiClient::LicenseApi
# Automatically generated by openapi-generator (https://openapi-generator.tech)
# Please update as you see appropriate
describe 'LicenseApi' do
  before do
    # run before each test
    @api_instance = OpenapiClient::LicenseApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of LicenseApi' do
    it 'should create an instance of LicenseApi' do
      expect(@api_instance).to be_instance_of(OpenapiClient::LicenseApi)
    end
  end

  # unit tests for license_acceptagreement
  # Accept the license agreement
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'license_acceptagreement test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for license_getagreementstatus
  # Check if license agreement has been accepted
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'license_getagreementstatus test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for license_getcurrent
  # Gets the current license information
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'license_getcurrent test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for license_renew
  # Contact Engineerica in order to renew the AccuTraining subscription
  # Allows the user to select the option to contact Engineerica when the AccuTraining account is nearing its renewal date.
  # @param email The e-mail of the user sending the request.
  # @param phonenumber The phone number of the user sending the request.
  # @param [Hash] opts the optional parameters
  # @option opts [String] :jobtitle The job title of the user sending the request.
  # @option opts [String] :institution The institution of the user sending the request.
  # @option opts [String] :comments Comments entered by the user sending the request.
  # @return [nil]
  describe 'license_renew test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
