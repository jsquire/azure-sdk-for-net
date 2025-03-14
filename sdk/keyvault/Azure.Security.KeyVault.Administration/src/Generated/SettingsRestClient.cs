// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    internal partial class SettingsRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of SettingsRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public SettingsRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string apiVersion = "7.5")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateUpdateSettingRequest(string vaultBaseUrl, string settingName, string value)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/settings/", false);
            uri.AppendPath(settingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new UpdateSettingRequest(value);
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(model);
            request.Content = content;
            return message;
        }

        /// <summary> Updates key vault account setting, stores it, then returns the setting name and value to the client. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="settingName"> The name of the account setting. Must be a valid settings option. </param>
        /// <param name="value"> The value of the pool setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="settingName"/> or <paramref name="value"/> is null. </exception>
        /// <remarks> Description of the pool setting to be updated. </remarks>
        public async Task<Response<KeyVaultSetting>> UpdateSettingAsync(string vaultBaseUrl, string settingName, string value, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateUpdateSettingRequest(vaultBaseUrl, settingName, value);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultSetting value0 = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value0 = KeyVaultSetting.DeserializeKeyVaultSetting(document.RootElement);
                        return Response.FromValue(value0, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Updates key vault account setting, stores it, then returns the setting name and value to the client. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="settingName"> The name of the account setting. Must be a valid settings option. </param>
        /// <param name="value"> The value of the pool setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/>, <paramref name="settingName"/> or <paramref name="value"/> is null. </exception>
        /// <remarks> Description of the pool setting to be updated. </remarks>
        public Response<KeyVaultSetting> UpdateSetting(string vaultBaseUrl, string settingName, string value, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            using var message = CreateUpdateSettingRequest(vaultBaseUrl, settingName, value);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultSetting value0 = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value0 = KeyVaultSetting.DeserializeKeyVaultSetting(document.RootElement);
                        return Response.FromValue(value0, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSettingRequest(string vaultBaseUrl, string settingName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/settings/", false);
            uri.AppendPath(settingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Get specified account setting object. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="settingName"> The name of the account setting. Must be a valid settings option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="settingName"/> is null. </exception>
        /// <remarks> Retrieves the setting object of a specified setting name. </remarks>
        public async Task<Response<KeyVaultSetting>> GetSettingAsync(string vaultBaseUrl, string settingName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }

            using var message = CreateGetSettingRequest(vaultBaseUrl, settingName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultSetting value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = KeyVaultSetting.DeserializeKeyVaultSetting(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get specified account setting object. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="settingName"> The name of the account setting. Must be a valid settings option. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> or <paramref name="settingName"/> is null. </exception>
        /// <remarks> Retrieves the setting object of a specified setting name. </remarks>
        public Response<KeyVaultSetting> GetSetting(string vaultBaseUrl, string settingName, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }
            if (settingName == null)
            {
                throw new ArgumentNullException(nameof(settingName));
            }

            using var message = CreateGetSettingRequest(vaultBaseUrl, settingName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        KeyVaultSetting value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = KeyVaultSetting.DeserializeKeyVaultSetting(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetSettingsRequest(string vaultBaseUrl)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(vaultBaseUrl, false);
            uri.AppendPath("/settings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> List account settings. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        /// <remarks> Retrieves a list of all the available account settings that can be configured. </remarks>
        public async Task<Response<GetSettingsResult>> GetSettingsAsync(string vaultBaseUrl, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateGetSettingsRequest(vaultBaseUrl);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetSettingsResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = GetSettingsResult.DeserializeGetSettingsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List account settings. </summary>
        /// <param name="vaultBaseUrl"> The vault name, for example https://myvault.vault.azure.net. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vaultBaseUrl"/> is null. </exception>
        /// <remarks> Retrieves a list of all the available account settings that can be configured. </remarks>
        public Response<GetSettingsResult> GetSettings(string vaultBaseUrl, CancellationToken cancellationToken = default)
        {
            if (vaultBaseUrl == null)
            {
                throw new ArgumentNullException(nameof(vaultBaseUrl));
            }

            using var message = CreateGetSettingsRequest(vaultBaseUrl);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        GetSettingsResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = GetSettingsResult.DeserializeGetSettingsResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
