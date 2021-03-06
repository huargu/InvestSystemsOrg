// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace InvSys.Portfolios.Api.Client.Proxy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for PortfoliosAPI.
    /// </summary>
    public static partial class PortfoliosAPIExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            public static IList<Item> GetItems(this IPortfoliosAPI operations, Guid portfolioId)
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).GetItemsAsync(portfolioId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Item>> GetItemsAsync(this IPortfoliosAPI operations, Guid portfolioId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetItemsWithHttpMessagesAsync(portfolioId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            /// <param name='item'>
            /// </param>
            public static Item CreateItem(this IPortfoliosAPI operations, Guid portfolioId, Item item = default(Item))
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).CreateItemAsync(portfolioId, item), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            /// <param name='item'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Item> CreateItemAsync(this IPortfoliosAPI operations, Guid portfolioId, Item item = default(Item), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateItemWithHttpMessagesAsync(portfolioId, item, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void DeleteItem(this IPortfoliosAPI operations, Guid portfolioId, Guid id)
            {
                Task.Factory.StartNew(s => ((IPortfoliosAPI)s).DeleteItemAsync(portfolioId, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolioId'>
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteItemAsync(this IPortfoliosAPI operations, Guid portfolioId, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteItemWithHttpMessagesAsync(portfolioId, id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Portfolio> GetPortfolios(this IPortfoliosAPI operations)
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).GetPortfoliosAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Portfolio>> GetPortfoliosAsync(this IPortfoliosAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPortfoliosWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolio'>
            /// </param>
            public static Portfolio CreatePortfolio(this IPortfoliosAPI operations, Portfolio portfolio = default(Portfolio))
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).CreatePortfolioAsync(portfolio), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='portfolio'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Portfolio> CreatePortfolioAsync(this IPortfoliosAPI operations, Portfolio portfolio = default(Portfolio), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreatePortfolioWithHttpMessagesAsync(portfolio, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static Portfolio GetPortfolio(this IPortfoliosAPI operations, Guid id)
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).GetPortfolioAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Portfolio> GetPortfolioAsync(this IPortfoliosAPI operations, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPortfolioWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='portfolio'>
            /// </param>
            public static Portfolio UpdatePortfolio(this IPortfoliosAPI operations, Guid id, Portfolio portfolio = default(Portfolio))
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).UpdatePortfolioAsync(id, portfolio), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='portfolio'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Portfolio> UpdatePortfolioAsync(this IPortfoliosAPI operations, Guid id, Portfolio portfolio = default(Portfolio), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdatePortfolioWithHttpMessagesAsync(id, portfolio, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void DeletePortfolio(this IPortfoliosAPI operations, Guid id)
            {
                Task.Factory.StartNew(s => ((IPortfoliosAPI)s).DeletePortfolioAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeletePortfolioAsync(this IPortfoliosAPI operations, Guid id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeletePortfolioWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<string> ApiValuesGet(this IPortfoliosAPI operations)
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).ApiValuesGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<string>> ApiValuesGetAsync(this IPortfoliosAPI operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            public static void ApiValuesPost(this IPortfoliosAPI operations, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IPortfoliosAPI)s).ApiValuesPostAsync(value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='value'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesPostAsync(this IPortfoliosAPI operations, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesPostWithHttpMessagesAsync(value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static string ApiValuesByIdGet(this IPortfoliosAPI operations, int id)
            {
                return Task.Factory.StartNew(s => ((IPortfoliosAPI)s).ApiValuesByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<string> ApiValuesByIdGetAsync(this IPortfoliosAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiValuesByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
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
            public static void ApiValuesByIdPut(this IPortfoliosAPI operations, int id, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IPortfoliosAPI)s).ApiValuesByIdPutAsync(id, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
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
            public static async Task ApiValuesByIdPutAsync(this IPortfoliosAPI operations, int id, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdPutWithHttpMessagesAsync(id, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static void ApiValuesByIdDelete(this IPortfoliosAPI operations, int id)
            {
                Task.Factory.StartNew(s => ((IPortfoliosAPI)s).ApiValuesByIdDeleteAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiValuesByIdDeleteAsync(this IPortfoliosAPI operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiValuesByIdDeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
