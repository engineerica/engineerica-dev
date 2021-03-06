/**
 * AccuTraining OpenAPI 3
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', process.cwd()+'/src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require(process.cwd()+'/src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.AccuTrainingOpenApi3);
  }
}(this, function(expect, AccuTrainingOpenApi3) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new AccuTrainingOpenApi3.UsertaskApi();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('UsertaskApi', function() {
    describe('usertaskDeleteplan', function() {
      it('should call usertaskDeleteplan successfully', function(done) {
        //uncomment below and update the code to test usertaskDeleteplan
        //instance.usertaskDeleteplan(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('usertaskGetmine', function() {
      it('should call usertaskGetmine successfully', function(done) {
        //uncomment below and update the code to test usertaskGetmine
        //instance.usertaskGetmine(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('usertaskGetplan', function() {
      it('should call usertaskGetplan successfully', function(done) {
        //uncomment below and update the code to test usertaskGetplan
        //instance.usertaskGetplan(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('usertaskListdefs', function() {
      it('should call usertaskListdefs successfully', function(done) {
        //uncomment below and update the code to test usertaskListdefs
        //instance.usertaskListdefs(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('usertaskListplan', function() {
      it('should call usertaskListplan successfully', function(done) {
        //uncomment below and update the code to test usertaskListplan
        //instance.usertaskListplan(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
    describe('usertaskSaveplan', function() {
      it('should call usertaskSaveplan successfully', function(done) {
        //uncomment below and update the code to test usertaskSaveplan
        //instance.usertaskSaveplan(function(error) {
        //  if (error) throw error;
        //expect().to.be();
        //});
        done();
      });
    });
  });

}));
