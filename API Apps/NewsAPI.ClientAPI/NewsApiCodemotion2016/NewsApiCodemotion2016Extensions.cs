﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace SampleApiClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for NewsApiCodemotion2016.
    /// </summary>
    public static partial class NewsApiCodemotion2016Extensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<FeedItem> ApiNewsGet(this INewsApiCodemotion2016 operations)
            {
                return Task.Factory.StartNew(s => ((INewsApiCodemotion2016)s).ApiNewsGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<FeedItem>> ApiNewsGetAsync(this INewsApiCodemotion2016 operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiNewsGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiNewsPost(this INewsApiCodemotion2016 operations, string value = default(string))
            {
                Task.Factory.StartNew(s => ((INewsApiCodemotion2016)s).ApiNewsPostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiNewsPostAsync(this INewsApiCodemotion2016 operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiNewsPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiNewsByIdGet(this INewsApiCodemotion2016 operations, int id)
            {
                return Task.Factory.StartNew(s => ((INewsApiCodemotion2016)s).ApiNewsByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiNewsByIdGetAsync(this INewsApiCodemotion2016 operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiNewsByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiNewsByIdPut(this INewsApiCodemotion2016 operations, int id, string value = default(string))
            {
                Task.Factory.StartNew(s => ((INewsApiCodemotion2016)s).ApiNewsByIdPutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiNewsByIdPutAsync(this INewsApiCodemotion2016 operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiNewsByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiNewsByIdDelete(this INewsApiCodemotion2016 operations, int id)
            {
                Task.Factory.StartNew(s => ((INewsApiCodemotion2016)s).ApiNewsByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiNewsByIdDeleteAsync(this INewsApiCodemotion2016 operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiNewsByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
