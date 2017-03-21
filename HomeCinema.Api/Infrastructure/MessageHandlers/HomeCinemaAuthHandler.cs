using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;
using System.Text;
using HomeCinema.Api.Infrastructure.Extensions;
using System.Web;

namespace HomeCinema.Api.Infrastructure.MessageHandlers
{
    public class HomeCinemaAuthHandler : DelegatingHandler
    {
        IEnumerable<string> authHeaderValues = null;

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            try
            {
                request.Headers.TryGetValues("Authorization", out authHeaderValues);
                if (authHeaderValues == null)
                {
                    return base.SendAsync(request, cancellationToken);
                }

                var tokens = authHeaderValues.FirstOrDefault();
                tokens = tokens.Replace("Basic", "").Trim();
                if (!string.IsNullOrEmpty(tokens))
                {
                    var data = Convert.FromBase64String(tokens);
                    var decodedString = Encoding.UTF8.GetString(data);
                    var tokenValues = decodedString.Split(':');
                    var membershipService = request.GetMembershipService();

                    var membershipContext = membershipService.ValidateUser(tokenValues[0], tokenValues[1]);
                    if (membershipContext.User != null)
                    {
                        var principal = membershipContext.Principal;
                        Thread.CurrentPrincipal = principal;
                        HttpContext.Current.User = principal;
                    }
                    else
                    {
                        var response = new HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
                        var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                        taskCompletionSource.SetResult(response);
                        return taskCompletionSource.Task;
                    }
                }
                else
                {
                    var response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                    var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                    taskCompletionSource.SetResult(response);
                    return taskCompletionSource.Task;
                }
                return base.SendAsync(request, cancellationToken);
            }
            catch
            {
                var response = new HttpResponseMessage(System.Net.HttpStatusCode.Forbidden);
                var taskCompletionSource = new TaskCompletionSource<HttpResponseMessage>();
                taskCompletionSource.SetResult(response);
                return taskCompletionSource.Task;
            }
        }
    }
}