/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Numbers.V2.RegulatoryCompliance.Bundle;

namespace Twilio.Tests.Rest.Numbers.V2.RegulatoryCompliance.Bundle
{

    [TestFixture]
    public class BundleCopyTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Bundles/BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Copies",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                BundleCopyResource.Create("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"regulation_sid\": \"RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"status\": \"draft\",\"valid_until\": \"2015-07-30T20:00:00Z\",\"email\": \"email\",\"status_callback\": \"http://www.example.com\",\"date_created\": \"2015-07-30T20:00:00Z\",\"date_updated\": \"2015-07-30T20:00:00Z\"}"
                                     ));

            var response = BundleCopyResource.Create("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Numbers,
                "/v2/RegulatoryCompliance/Bundles/BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Copies",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                BundleCopyResource.Read("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"results\": [],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://numbers.twilio.com/v2/RegulatoryCompliance/Bundles/BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Copies?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://numbers.twilio.com/v2/RegulatoryCompliance/Bundles/BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Copies?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"results\"}}"
                                     ));

            var response = BundleCopyResource.Read("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"results\": [{\"sid\": \"BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"regulation_sid\": \"RNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"friendly_name\": \"friendly_name\",\"status\": \"twilio-approved\",\"email\": \"email\",\"status_callback\": \"http://www.example.com\",\"valid_until\": \"2020-07-31T01:00:00Z\",\"date_created\": \"2019-07-30T22:29:24Z\",\"date_updated\": \"2019-07-31T01:09:00Z\"}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://numbers.twilio.com/v2/RegulatoryCompliance/Bundles/BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Copies?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://numbers.twilio.com/v2/RegulatoryCompliance/Bundles/BUaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Copies?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"results\"}}"
                                     ));

            var response = BundleCopyResource.Read("BUXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}