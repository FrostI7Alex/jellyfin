﻿using System.Net;
using System.Net.Http;

namespace MediaBrowser.Common.Net
{
    /// <summary>
    /// Default http client handler.
    /// </summary>
    public class DefaultHttpClientHandler : HttpClientHandler
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultHttpClientHandler"/> class.
        /// </summary>
        public DefaultHttpClientHandler()
        {
            // TODO change to DecompressionMethods.All with .NET5
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        }
    }
}
