﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using ShareFile.Api.Client.Exceptions;
using ShareFile.Api.Client.FileSystem;

namespace ShareFile.Api.Client.Transfers.Uploaders
{
#if Async
    public class AsyncStandardFileUploader : AsyncUploaderBase
    {
        public AsyncStandardFileUploader(ShareFileClient client, UploadSpecificationRequest uploadSpecificationRequest, IPlatformFile file, FileUploaderConfig config = null, int? expirationDays = null) 
            : base(client, uploadSpecificationRequest, file, config, expirationDays)
        {
        }

        public override async Task PrepareAsync()
        {
            if (!Prepared)
            {
                if (UploadSpecification == null)
                {
                    UploadSpecification = await CreateUpload(UploadSpecificationRequest);
                }

                await CheckResumeAsync();

                Prepared = true;
            }
        }

        protected override async Task<UploadResponse> InternalUploadAsync()
        {
            int tryCount = 0;
            Exception lastException = null;

            while (tryCount < 3)
            {
                try
                {
                    var httpClient = GetHttpClient();
                    var boundaryGuid = "upload-" + Guid.NewGuid().ToString("N");
                    var requestMessage = new HttpRequestMessage(HttpMethod.Post, UploadSpecification.ChunkUri);
                    var multipartFormContent = new MultipartFormDataContent(boundaryGuid);

                    multipartFormContent.Add(new StreamContent(File.OpenRead(), MaxBufferLength), "File1", File.Name);
                    requestMessage.Content = multipartFormContent;

                    var responseMessage = await httpClient.SendAsync(requestMessage, CancellationToken ?? System.Threading.CancellationToken.None);

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var responseString = await responseMessage.Content.ReadAsStringAsync();
                        if (responseString == "OK")
                        {
                            return UploadResponse.SuccessWithoutInformation;
                        }
                    }
                }
                catch (Exception exception)
                {
                    lastException = exception;
                    tryCount++;
                }   
            }
            
            throw new ApplicationException("Upload failed after 3 tries", lastException);
        }
    }
#endif
}
