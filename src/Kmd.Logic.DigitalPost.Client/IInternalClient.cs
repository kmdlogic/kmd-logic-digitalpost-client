// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Logic.DigitalPost.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    internal partial interface IInternalClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Sends a single text message to a citizen/company.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='request'>
        /// Request body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SendMessageWithHttpMessagesAsync(System.Guid subscriptionId, SendMessageRequest request = default(SendMessageRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Sends a single document to a citizen/company.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='request'>
        /// Request body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> SendDocumentWithHttpMessagesAsync(System.Guid subscriptionId, SendDocumentRequest request = default(SendDocumentRequest), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Uploads a single file that could be add as an attachment to the
        /// message later.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='attachment'>
        /// File added to message
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<UploadAttachmentResponse>> UploadAttachmentWithHttpMessagesAsync(System.Guid subscriptionId, Stream attachment, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the consent to send a single document to a citizen/company.
        /// </summary>
        /// <param name='digitalPostConfigurationId'>
        /// DigitalPost provider configuration Id
        /// </param>
        /// <param name='subscriptionId'>
        /// </param>
        /// <param name='request'>
        /// Request body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IDictionary<string, IList<string>>>> GetConsentWithHttpMessagesAsync(System.Guid digitalPostConfigurationId, string subscriptionId, SendConsentPayloadRequest request, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves digital post configuration provider assigned to the logic
        /// subscription
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='configurationId'>
        /// Id of Digital Post configuration provider
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> GetDigitalPostConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, System.Guid configurationId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieves digital post configuration providers assigned to the
        /// logic subscription
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<DigitalPostProviderConfigurationModel>>> GetAllDigitalPostConfigurationsWithHttpMessagesAsync(System.Guid subscriptionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates existing Doc2Mail configuration and upload certificate
        /// files.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='systemId'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='environment'>
        /// Possible values include: 'Production', 'Test'
        /// </param>
        /// <param name='callbackUrl'>
        /// </param>
        /// <param name='certificate'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateDoc2MailConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, string id = default(string), int? systemId = default(int?), string name = default(string), string environment = default(string), string callbackUrl = default(string), Stream certificate = default(Stream), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds Doc2Mail configuration and upload certificate files.
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='systemId'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='environment'>
        /// Possible values include: 'Production', 'Test'
        /// </param>
        /// <param name='callbackUrl'>
        /// </param>
        /// <param name='certificate'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateDoc2MailConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, string id = default(string), int? systemId = default(int?), string name = default(string), string environment = default(string), string callbackUrl = default(string), Stream certificate = default(Stream), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds fake provider configuration
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='callbackUrl'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> UpdateFakeConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, string id = default(string), string callbackUrl = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds fake provider configuration
        /// </summary>
        /// <param name='subscriptionId'>
        /// Id of LoGIC subscription
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='callbackUrl'>
        /// </param>
        /// <param name='name'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<object>> CreateFakeConfigurationWithHttpMessagesAsync(System.Guid subscriptionId, string id = default(string), string callbackUrl = default(string), string name = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
