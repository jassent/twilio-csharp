/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// ConfigurationResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.FlexApi.V1
{

    public class ConfigurationResource : Resource
    {
        public sealed class StatusEnum : StringEnum
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
            public static implicit operator StatusEnum(string value)
            {
                return new StatusEnum(value);
            }

            public static readonly StatusEnum Ok = new StatusEnum("ok");
            public static readonly StatusEnum Inprogress = new StatusEnum("inprogress");
            public static readonly StatusEnum Notstarted = new StatusEnum("notstarted");
        }

        private static Request BuildFetchRequest(FetchConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.FlexApi,
                "/v1/Configuration",
                queryParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(FetchConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(FetchConfigurationOptions options,
                                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="uiVersion"> The Pinned UI version of the Configuration resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Fetch(string uiVersion = null, ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(){UiVersion = uiVersion};
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="uiVersion"> The Pinned UI version of the Configuration resource to fetch </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> FetchAsync(string uiVersion = null,
                                                                                          ITwilioRestClient client = null)
        {
            var options = new FetchConfigurationOptions(){UiVersion = uiVersion};
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildCreateRequest(CreateConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/Configuration",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Create(CreateConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> CreateAsync(CreateConfigurationOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Create(ITwilioRestClient client = null)
        {
            var options = new CreateConfigurationOptions();
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> CreateAsync(ITwilioRestClient client = null)
        {
            var options = new CreateConfigurationOptions();
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateConfigurationOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.FlexApi,
                "/v1/Configuration",
                postParams: options.GetParams(),
                headerParams: null
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Update(UpdateConfigurationOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Configuration parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> UpdateAsync(UpdateConfigurationOptions options,
                                                                                           ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Configuration </returns>
        public static ConfigurationResource Update(ITwilioRestClient client = null)
        {
            var options = new UpdateConfigurationOptions();
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Configuration </returns>
        public static async System.Threading.Tasks.Task<ConfigurationResource> UpdateAsync(ITwilioRestClient client = null)
        {
            var options = new UpdateConfigurationOptions();
            return await UpdateAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ConfigurationResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ConfigurationResource object represented by the provided JSON </returns>
        public static ConfigurationResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ConfigurationResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the Configuration resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The ISO 8601 date and time in GMT when the Configuration resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// An object that contains application-specific data
        /// </summary>
        [JsonProperty("attributes")]
        public object Attributes { get; private set; }
        /// <summary>
        /// The status of the Flex onboarding
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ConfigurationResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The SID of the TaskRouter Workspace
        /// </summary>
        [JsonProperty("taskrouter_workspace_sid")]
        public string TaskrouterWorkspaceSid { get; private set; }
        /// <summary>
        /// The SID of the TaskRouter target Workflow
        /// </summary>
        [JsonProperty("taskrouter_target_workflow_sid")]
        public string TaskrouterTargetWorkflowSid { get; private set; }
        /// <summary>
        /// The SID of the TaskRouter Target TaskQueue
        /// </summary>
        [JsonProperty("taskrouter_target_taskqueue_sid")]
        public string TaskrouterTargetTaskqueueSid { get; private set; }
        /// <summary>
        /// The list of TaskRouter TaskQueues
        /// </summary>
        [JsonProperty("taskrouter_taskqueues")]
        public List<object> TaskrouterTaskqueues { get; private set; }
        /// <summary>
        /// The Skill description for TaskRouter workers
        /// </summary>
        [JsonProperty("taskrouter_skills")]
        public List<object> TaskrouterSkills { get; private set; }
        /// <summary>
        /// The TaskRouter default channel capacities and availability for workers
        /// </summary>
        [JsonProperty("taskrouter_worker_channels")]
        public object TaskrouterWorkerChannels { get; private set; }
        /// <summary>
        /// The TaskRouter Worker attributes
        /// </summary>
        [JsonProperty("taskrouter_worker_attributes")]
        public object TaskrouterWorkerAttributes { get; private set; }
        /// <summary>
        /// The TaskRouter SID of the offline activity
        /// </summary>
        [JsonProperty("taskrouter_offline_activity_sid")]
        public string TaskrouterOfflineActivitySid { get; private set; }
        /// <summary>
        /// The URL where the Flex instance is hosted
        /// </summary>
        [JsonProperty("runtime_domain")]
        public Uri RuntimeDomain { get; private set; }
        /// <summary>
        /// The SID of the Messaging service instance
        /// </summary>
        [JsonProperty("messaging_service_instance_sid")]
        public string MessagingServiceInstanceSid { get; private set; }
        /// <summary>
        /// The SID of the chat service this user belongs to
        /// </summary>
        [JsonProperty("chat_service_instance_sid")]
        public string ChatServiceInstanceSid { get; private set; }
        /// <summary>
        /// The SID of the Flex service instance
        /// </summary>
        [JsonProperty("flex_service_instance_sid")]
        public string FlexServiceInstanceSid { get; private set; }
        /// <summary>
        /// The primary language of the Flex UI
        /// </summary>
        [JsonProperty("ui_language")]
        public string UiLanguage { get; private set; }
        /// <summary>
        /// The object that describes Flex UI characteristics and settings
        /// </summary>
        [JsonProperty("ui_attributes")]
        public object UiAttributes { get; private set; }
        /// <summary>
        /// The object that defines the NPM packages and versions to be used in Hosted Flex
        /// </summary>
        [JsonProperty("ui_dependencies")]
        public object UiDependencies { get; private set; }
        /// <summary>
        /// The Pinned UI version
        /// </summary>
        [JsonProperty("ui_version")]
        public string UiVersion { get; private set; }
        /// <summary>
        /// The Flex Service version
        /// </summary>
        [JsonProperty("service_version")]
        public string ServiceVersion { get; private set; }
        /// <summary>
        /// Whether call recording is enabled
        /// </summary>
        [JsonProperty("call_recording_enabled")]
        public bool? CallRecordingEnabled { get; private set; }
        /// <summary>
        /// The call recording webhook URL
        /// </summary>
        [JsonProperty("call_recording_webhook_url")]
        public Uri CallRecordingWebhookUrl { get; private set; }
        /// <summary>
        /// Whether CRM is present for Flex
        /// </summary>
        [JsonProperty("crm_enabled")]
        public bool? CrmEnabled { get; private set; }
        /// <summary>
        /// The CRM Type
        /// </summary>
        [JsonProperty("crm_type")]
        public string CrmType { get; private set; }
        /// <summary>
        /// The CRM Callback URL
        /// </summary>
        [JsonProperty("crm_callback_url")]
        public Uri CrmCallbackUrl { get; private set; }
        /// <summary>
        /// The CRM Fallback URL
        /// </summary>
        [JsonProperty("crm_fallback_url")]
        public Uri CrmFallbackUrl { get; private set; }
        /// <summary>
        /// An object that contains the CRM attributes
        /// </summary>
        [JsonProperty("crm_attributes")]
        public object CrmAttributes { get; private set; }
        /// <summary>
        /// The list of public attributes
        /// </summary>
        [JsonProperty("public_attributes")]
        public object PublicAttributes { get; private set; }
        /// <summary>
        /// Whether the plugin service enabled
        /// </summary>
        [JsonProperty("plugin_service_enabled")]
        public bool? PluginServiceEnabled { get; private set; }
        /// <summary>
        /// The plugin service attributes
        /// </summary>
        [JsonProperty("plugin_service_attributes")]
        public object PluginServiceAttributes { get; private set; }
        /// <summary>
        /// A list of objects that contain the configurations for the Integrations supported in this configuration
        /// </summary>
        [JsonProperty("integrations")]
        public List<object> Integrations { get; private set; }
        /// <summary>
        /// The list of outbound call flows
        /// </summary>
        [JsonProperty("outbound_call_flows")]
        public object OutboundCallFlows { get; private set; }
        /// <summary>
        /// The list of serverless service SIDs
        /// </summary>
        [JsonProperty("serverless_service_sids")]
        public List<string> ServerlessServiceSids { get; private set; }
        /// <summary>
        /// Configurable parameters for Queues Statistics
        /// </summary>
        [JsonProperty("queue_stats_configuration")]
        public object QueueStatsConfiguration { get; private set; }
        /// <summary>
        /// Configurable parameters for Notifications
        /// </summary>
        [JsonProperty("notifications")]
        public object Notifications { get; private set; }
        /// <summary>
        /// Configurable parameters for Markdown
        /// </summary>
        [JsonProperty("markdown")]
        public object Markdown { get; private set; }
        /// <summary>
        /// The absolute URL of the Configuration resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Object that controls workspace reporting
        /// </summary>
        [JsonProperty("flex_insights_hr")]
        public object FlexInsightsHr { get; private set; }
        /// <summary>
        /// Setting to enable Flex UI redirection
        /// </summary>
        [JsonProperty("flex_insights_drilldown")]
        public bool? FlexInsightsDrilldown { get; private set; }
        /// <summary>
        /// URL to redirect to in case drilldown is enabled.
        /// </summary>
        [JsonProperty("flex_url")]
        public Uri FlexUrl { get; private set; }
        /// <summary>
        /// Flex Conversations channels' attachments configurations
        /// </summary>
        [JsonProperty("channel_configs")]
        public List<object> ChannelConfigs { get; private set; }
        /// <summary>
        /// Configurable parameters for Debugger Integration
        /// </summary>
        [JsonProperty("debugger_integration")]
        public object DebuggerIntegration { get; private set; }
        /// <summary>
        /// Configurable parameters for Flex UI Status report
        /// </summary>
        [JsonProperty("flex_ui_status_report")]
        public object FlexUiStatusReport { get; private set; }

        private ConfigurationResource()
        {

        }
    }

}