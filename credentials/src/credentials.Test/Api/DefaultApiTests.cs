/*
 * Credentials API
 *
 * Azion Orchestration
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using credentials.Client;
using credentials.Api;
// uncomment below to import models
//using credentials.Model;

namespace credentials.Test.Api
{
    /// <summary>
    ///  Class for testing DefaultApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DefaultApiTests : IDisposable
    {
        private DefaultApi instance;

        public DefaultApiTests()
        {
            instance = new DefaultApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DefaultApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DefaultApi
            //Assert.IsType<DefaultApi>(instance);
        }

        /// <summary>
        /// Test CreateCredential
        /// </summary>
        [Fact]
        public void CreateCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateCredentialRequest createCredentialRequest = null;
            //var response = instance.CreateCredential(createCredentialRequest);
            //Assert.IsType<AuthToken>(response);
        }

        /// <summary>
        /// Test DeleteCredential
        /// </summary>
        [Fact]
        public void DeleteCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long credentialId = null;
            //instance.DeleteCredential(credentialId);
        }

        /// <summary>
        /// Test FindAll
        /// </summary>
        [Fact]
        public void FindAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string filter = null;
            //long? page = null;
            //long? pageSize = null;
            //string sort = null;
            //string orderBy = null;
            //var response = instance.FindAll(filter, page, pageSize, sort, orderBy);
            //Assert.IsType<ResponseWithTotal>(response);
        }

        /// <summary>
        /// Test LoadCredential
        /// </summary>
        [Fact]
        public void LoadCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long credentialId = null;
            //var response = instance.LoadCredential(credentialId);
            //Assert.IsType<Response>(response);
        }

        /// <summary>
        /// Test UpdateCredential
        /// </summary>
        [Fact]
        public void UpdateCredentialTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long credentialId = null;
            //UpdateCredentialRequest updateCredentialRequest = null;
            //var response = instance.UpdateCredential(credentialId, updateCredentialRequest);
            //Assert.IsType<Response>(response);
        }
    }
}
