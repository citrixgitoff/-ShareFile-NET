﻿using System.Collections.Generic;
using System.IO;
using System.Threading;
using ShareFile.Api.Models;

namespace ShareFile.Api.Client.Transfers.Downloaders
{
    public class FileDownloader : SyncDownloaderBase
    {
        public FileDownloader(Item item, IShareFileClient client, DownloaderConfig config = null)
            : base(item, client, config)
        {

        }

        public override void DownloadTo(Stream fileStream, Dictionary<string, object> transferMetadata = null)
        {
            var downloadQuery = CreateDownloadQuery();

            using (var stream = downloadQuery.Execute())
            {
                if (stream != null)
                {
                    var totalBytesToDownload = Item.FileSizeBytes.GetValueOrDefault();

                    var progress = new TransferProgress(totalBytesToDownload, transferMetadata);

                    int bytesRead;
                    var buffer = new byte[Config.BufferSize];

                    do
                    {
                        TryPause();

                        bytesRead = stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            fileStream.Write(buffer, 0, bytesRead);

                            progress.DecrementBytesRemaining(bytesRead);
                            progress.IncrementBytesTransferred(bytesRead);

                            NotifyProgress(progress);
                        }
                        else
                        {
                            progress.MarkComplete();
                            NotifyProgress(progress);
                        }

                    } while (bytesRead > 0);
                }
            }
        }
    }
}
