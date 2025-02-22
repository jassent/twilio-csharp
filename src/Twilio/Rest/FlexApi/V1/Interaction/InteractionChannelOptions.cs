/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.FlexApi.V1.Interaction
{

    /// <summary>
    /// Fetch a Channel for an Interaction.
    /// </summary>
    public class FetchInteractionChannelOptions : IOptions<InteractionChannelResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathInteractionSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchInteractionChannelOptions
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        public FetchInteractionChannelOptions(string pathInteractionSid, string pathSid)
        {
            PathInteractionSid = pathInteractionSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// List all Channels for an Interaction.
    /// </summary>
    public class ReadInteractionChannelOptions : ReadOptions<InteractionChannelResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathInteractionSid { get; }

        /// <summary>
        /// Construct a new ReadInteractionChannelOptions
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        public ReadInteractionChannelOptions(string pathInteractionSid)
        {
            PathInteractionSid = pathInteractionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Update an existing Interaction Channel.
    /// </summary>
    public class UpdateInteractionChannelOptions : IOptions<InteractionChannelResource>
    {
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathInteractionSid { get; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// Required. The Interaction channels's status
        /// </summary>
        public InteractionChannelResource.StatusEnum Status { get; }
        /// <summary>
        /// Optional. The state of associated tasks.
        /// </summary>
        public object Routing { get; set; }

        /// <summary>
        /// Construct a new UpdateInteractionChannelOptions
        /// </summary>
        /// <param name="pathInteractionSid"> The unique string that identifies the resource </param>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="status"> Required. The Interaction channels's status </param>
        public UpdateInteractionChannelOptions(string pathInteractionSid,
                                               string pathSid,
                                               InteractionChannelResource.StatusEnum status)
        {
            PathInteractionSid = pathInteractionSid;
            PathSid = pathSid;
            Status = status;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (Routing != null)
            {
                p.Add(new KeyValuePair<string, string>("Routing", Serializers.JsonObject(Routing)));
            }

            return p;
        }
    }

}