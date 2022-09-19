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
using Twilio.Rest.Messaging.V1;

namespace Twilio.Tests.Rest.Messaging.V1
{

    [TestFixture]
    public class TollfreeVerificationTest : TwilioTest
    {
        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications/HHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                TollfreeVerificationResource.Fetch("HHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"customer_profile_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"trust_product_sid\": \"BU3344409f7e067e279523808d267e2d88\",\"regulated_item_sid\": \"RA3344409f7e067e279523808d267e2d89\",\"date_created\": \"2021-01-27T14:18:35Z\",\"date_updated\": \"2021-01-27T14:18:36Z\",\"business_name\": \"Agent\",\"business_street_address\": \"927 Terrace St\",\"business_street_address2\": \"Unit 4\",\"business_city\": \"Tempe\",\"business_state_province_region\": \"AZ\",\"business_postal_code\": \"85281\",\"business_country\": \"USA\",\"business_website\": \"www.ghost.com\",\"business_contact_first_name\": \"Vikram\",\"business_contact_last_name\": \"Amar\",\"business_contact_email\": \"vikram@gmail.com\",\"business_contact_phone\": \"+16504988765\",\"notification_email\": \"vikram@gmail.com\",\"use_case_categories\": [\"2FA\",\"MARKETING\"],\"use_case_summary\": \"test\",\"production_message_sample\": \"test1\",\"opt_in_image_urls\": [\"https://zipwhiptestbusiness.com/images/image1.jpg\",\"https://zipwhiptestbusiness.com/images/image2.jpg\"],\"opt_in_type\": \"VERBAL\",\"message_volume\": \"1,000\",\"additional_information\": \"info\",\"tollfree_phone_number_sid\": \"PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"TWILIO_APPROVED\",\"url\": \"https://messaging.twilio.com/v1/Tollfree/Verifications/HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"resource_links\": {\"customer_profile\": \"https://trusthub.twilio.com/v1/CustomerProfiles/BU3344409f7e067e279523808d267e2d85\",\"trust_product\": \"https://trusthub.twilio.com/v1/TrustProducts/BU3344409f7e067e279523808d267e2d88\",\"channel_endpoint_assignment\": \"https://trusthub.twilio.com/v1/TrustProducts/BU3344409f7e067e279523808d267e2d88/ChannelEndpointAssignments/RA3344409f7e067e279523808d267e2d89\"}}"
                                     ));

            var response = TollfreeVerificationResource.Fetch("HHXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                TollfreeVerificationResource.Read(client: twilioRestClient);
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
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://messaging.twilio.com/v1/Tollfree/Verifications?Status=TWILIO_APPROVED&TollfreePhoneNumberSid=PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\",\"previous_page_url\": null,\"next_page_url\": null,\"key\": \"verifications\",\"url\": \"https://messaging.twilio.com/v1/Tollfree/Verifications?Status=TWILIO_APPROVED&TollfreePhoneNumberSid=PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&PageSize=50&Page=0\"},\"verifications\": [{\"sid\": \"HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"customer_profile_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"trust_product_sid\": \"BU3344409f7e067e279523808d267e2d88\",\"regulated_item_sid\": \"RA3344409f7e067e279523808d267e2d89\",\"date_created\": \"2021-01-27T14:18:35Z\",\"date_updated\": \"2021-01-27T14:18:36Z\",\"business_name\": \"Agent\",\"business_street_address\": \"927 Terrace St\",\"business_street_address2\": \"Unit 4\",\"business_city\": \"Tempe\",\"business_state_province_region\": \"AZ\",\"business_postal_code\": \"85281\",\"business_country\": \"USA\",\"business_website\": \"www.ghost.com\",\"business_contact_first_name\": \"Vikram\",\"business_contact_last_name\": \"Amar\",\"business_contact_email\": \"vikram@gmail.com\",\"business_contact_phone\": \"+16504988765\",\"notification_email\": \"vikram@gmail.com\",\"use_case_categories\": [\"2FA\",\"MARKETING\"],\"use_case_summary\": \"test\",\"production_message_sample\": \"test1\",\"opt_in_image_urls\": [\"https://zipwhiptestbusiness.com/images/image1.jpg\",\"https://zipwhiptestbusiness.com/images/image2.jpg\"],\"opt_in_type\": \"VERBAL\",\"message_volume\": \"1,000\",\"additional_information\": \"info\",\"tollfree_phone_number_sid\": \"PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"status\": \"TWILIO_APPROVED\",\"url\": \"https://messaging.twilio.com/v1/Tollfree/Verifications/HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"resource_links\": {\"customer_profile\": \"https://trusthub.twilio.com/v1/CustomerProfiles/BU3344409f7e067e279523808d267e2d85\",\"trust_product\": \"https://trusthub.twilio.com/v1/TrustProducts/BU3344409f7e067e279523808d267e2d88\",\"channel_endpoint_assignment\": \"https://trusthub.twilio.com/v1/TrustProducts/BU3344409f7e067e279523808d267e2d88/ChannelEndpointAssignments/RA3344409f7e067e279523808d267e2d89\"}}]}"
                                     ));

            var response = TollfreeVerificationResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Messaging,
                "/v1/Tollfree/Verifications",
                ""
            );
            request.AddPostParam("BusinessName", Serialize("business_name"));
            request.AddPostParam("BusinessWebsite", Serialize("business_website"));
            request.AddPostParam("NotificationEmail", Serialize("notification_email"));
            request.AddPostParam("UseCaseCategories", Serialize("use_case_categories"));
            request.AddPostParam("UseCaseSummary", Serialize("use_case_summary"));
            request.AddPostParam("ProductionMessageSample", Serialize("production_message_sample"));
            request.AddPostParam("OptInImageUrls", Serialize("opt_in_image_urls"));
            request.AddPostParam("OptInType", Serialize(TollfreeVerificationResource.OptInTypeEnum.Verbal));
            request.AddPostParam("MessageVolume", Serialize("message_volume"));
            request.AddPostParam("TollfreePhoneNumberSid", Serialize("PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                TollfreeVerificationResource.Create("business_name", "business_website", "notification_email", Promoter.ListOfOne("use_case_categories"), "use_case_summary", "production_message_sample", Promoter.ListOfOne("opt_in_image_urls"), TollfreeVerificationResource.OptInTypeEnum.Verbal, "message_volume", "PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
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
                                         "{\"sid\": \"HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"account_sid\": \"ACaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"regulated_item_sid\": null,\"customer_profile_sid\": \"BU3344409f7e067e279523808d267e2d85\",\"trust_product_sid\": null,\"status\": \"PENDING_REVIEW\",\"date_created\": \"2021-01-27T14:18:35Z\",\"date_updated\": \"2021-01-27T14:18:36Z\",\"business_name\": \"Agent\",\"business_street_address\": \"927 Terrace St\",\"business_street_address2\": \"Unit 4\",\"business_city\": \"Tempe\",\"business_state_province_region\": \"AZ\",\"business_postal_code\": \"85281\",\"business_country\": \"USA\",\"business_website\": \"www.ghost.com\",\"business_contact_first_name\": \"Vikram\",\"business_contact_last_name\": \"Amar\",\"business_contact_email\": \"vikram@gmail.com\",\"business_contact_phone\": \"+16504988765\",\"notification_email\": \"vikram@gmail.com\",\"use_case_categories\": [\"2FA\",\"MARKETING\"],\"use_case_summary\": \"test\",\"production_message_sample\": \"test1\",\"opt_in_image_urls\": [\"https://zipwhiptestbusiness.com/images/image1.jpg\",\"https://zipwhiptestbusiness.com/images/image2.jpg\"],\"opt_in_type\": \"VERBAL\",\"message_volume\": \"1,000\",\"additional_information\": \"info\",\"tollfree_phone_number_sid\": \"PNaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"resource_links\": {},\"url\": \"https://messaging.twilio.com/v1/Tollfree/Verifications/HHaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = TollfreeVerificationResource.Create("business_name", "business_website", "notification_email", Promoter.ListOfOne("use_case_categories"), "use_case_summary", "production_message_sample", Promoter.ListOfOne("opt_in_image_urls"), TollfreeVerificationResource.OptInTypeEnum.Verbal, "message_volume", "PNXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}