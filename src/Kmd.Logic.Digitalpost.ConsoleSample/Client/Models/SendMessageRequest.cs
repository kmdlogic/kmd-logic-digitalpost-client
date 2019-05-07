// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.Digitalpost.ConsoleSample.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Single text message request
    /// </summary>
    public partial class SendMessageRequest
    {
        /// <summary>
        /// Initializes a new instance of the SendMessageRequest class.
        /// </summary>
        public SendMessageRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SendMessageRequest class.
        /// </summary>
        /// <param name="message">Message content</param>
        /// <param name="configurationId">Id of provider configuration to
        /// use</param>
        /// <param name="identifierType">Type of identifier - CPR for a
        /// citizen, CVR for a company. Possible values include: 'cpr',
        /// 'cvr'</param>
        /// <param name="identifier">Identifier value (CPR/CVR)</param>
        /// <param name="materialId">Id of the material defined in eBoks /
        /// Document Type defined by Doc2Mail</param>
        /// <param name="pNumber">The PNumber (dk. "P-nummer") is the
        /// Production Unit Identifier agreed between the sender and receiver
        /// to distribute a message to a particular department, production
        /// site, etc. within an organisation (CVR).</param>
        /// <param name="title">Title of the message</param>
        /// <param name="metadata">Message metadata</param>
        /// <param name="attachments">Array of attachments - max 10 (9 if
        /// metadata exist)</param>
        public SendMessageRequest(string message = default(string), System.Guid? configurationId = default(System.Guid?), string identifierType = default(string), string identifier = default(string), string materialId = default(string), string pNumber = default(string), string title = default(string), string metadata = default(string), IList<MessageAttachment> attachments = default(IList<MessageAttachment>))
        {
            Message = message;
            ConfigurationId = configurationId;
            IdentifierType = identifierType;
            Identifier = identifier;
            MaterialId = materialId;
            PNumber = pNumber;
            Title = title;
            Metadata = metadata;
            Attachments = attachments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets message content
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets id of provider configuration to use
        /// </summary>
        [JsonProperty(PropertyName = "configurationId")]
        public System.Guid? ConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets type of identifier - CPR for a citizen, CVR for a
        /// company. Possible values include: 'cpr', 'cvr'
        /// </summary>
        [JsonProperty(PropertyName = "identifierType")]
        public string IdentifierType { get; set; }

        /// <summary>
        /// Gets or sets identifier value (CPR/CVR)
        /// </summary>
        [JsonProperty(PropertyName = "identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or sets id of the material defined in eBoks / Document Type
        /// defined by Doc2Mail
        /// </summary>
        [JsonProperty(PropertyName = "materialId")]
        public string MaterialId { get; set; }

        /// <summary>
        /// Gets or sets the PNumber (dk. "P-nummer") is the Production Unit
        /// Identifier agreed between the sender and receiver
        /// to distribute a message to a particular department, production
        /// site, etc. within an organisation (CVR).
        /// </summary>
        [JsonProperty(PropertyName = "pNumber")]
        public string PNumber { get; set; }

        /// <summary>
        /// Gets or sets title of the message
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets message metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or sets array of attachments - max 10 (9 if metadata exist)
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<MessageAttachment> Attachments { get; set; }

    }
}
