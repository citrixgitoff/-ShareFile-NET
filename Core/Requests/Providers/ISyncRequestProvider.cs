﻿using System.IO;

namespace ShareFile.Api.Client.Requests.Providers
{
    public interface ISyncRequestProvider : IRequestProvider
    {
        void Execute(IQuery query);
        T Execute<T>(IQuery<T> query);
        Stream Execute(IStreamQuery query);
    }

    public interface IRequestProvider
    {
        ShareFileClient ShareFileClient { get; }
    }
}
