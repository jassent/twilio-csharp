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
using Twilio.Rest.FlexApi.V1.Interaction.InteractionChannel;

namespace Twilio.Tests.Rest.FlexApi.V1.Interaction.InteractionChannel
{

    [TestFixture]
    public class InteractionChannelParticipantTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Interactions/KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Channels/UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            request.AddPostParam("Type", Serialize(InteractionChannelParticipantResource.TypeEnum.Supervisor));
            request.AddPostParam("MediaProperties", Serialize("{}"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                InteractionChannelParticipantResource.Create("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", InteractionChannelParticipantResource.TypeEnum.Supervisor, "{}", client: twilioRestClient);
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
                                         "{\"sid\": \"UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"channel_sid\": \"UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"interaction_sid\": \"KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"customer\",\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants/UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\"}"
                                     ));

            var response = InteractionChannelParticipantResource.Create("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", InteractionChannelParticipantResource.TypeEnum.Supervisor, "{}", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Interactions/KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Channels/UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                InteractionChannelParticipantResource.Read("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"participants\": [{\"sid\": \"UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"channel_sid\": \"UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"interaction_sid\": \"KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"customer\",\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants/UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\"},{\"sid\": \"UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa2\",\"channel_sid\": \"UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"interaction_sid\": \"KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"agent\",\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants/UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa2\"}],\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"participants\"}}"
                                     ));

            var response = InteractionChannelParticipantResource.Read("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.FlexApi,
                "/v1/Interactions/KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Channels/UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX/Participants/UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddPostParam("Status", Serialize(InteractionChannelParticipantResource.StatusEnum.Closed));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                InteractionChannelParticipantResource.Update("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", InteractionChannelParticipantResource.StatusEnum.Closed, client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"channel_sid\": \"UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"interaction_sid\": \"KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"agent\",\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants/UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\"}"
                                     ));

            var response = InteractionChannelParticipantResource.Update("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", InteractionChannelParticipantResource.StatusEnum.Closed, client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateStatusClosedResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"channel_sid\": \"UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\",\"interaction_sid\": \"KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"type\": \"agent\",\"url\": \"https://flex-api.twilio.com/v1/Interactions/KDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa/Channels/UOaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1/Participants/UTaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa1\"}"
                                     ));

            var response = InteractionChannelParticipantResource.Update("KDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "UOXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", InteractionChannelParticipantResource.StatusEnum.Closed, client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}