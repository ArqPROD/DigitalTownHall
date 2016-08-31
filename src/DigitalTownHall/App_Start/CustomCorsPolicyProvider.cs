using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace DigitalTownHall.App_Start
{
    /// <summary>
    /// Source code in: https://github.com/domaindrivendev/Swashbuckle/issues/329 and https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
    /// </summary>
    public class CustomCorsPolicyProvider : ICorsPolicyProvider
    {
        /// <summary>
        /// Source code in: https://github.com/domaindrivendev/Swashbuckle/issues/329 and https://msdn.microsoft.com/en-us/magazine/dn532203.aspx
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsPolicy = new CorsPolicy();

            if (request.RequestUri.PathAndQuery.StartsWith("/swagger/docs"))
            {
                corsPolicy.AllowAnyHeader = true;
                corsPolicy.AllowAnyMethod = true;
                corsPolicy.AllowAnyOrigin = true;
            }

            var tsc = new TaskCompletionSource<CorsPolicy>();
            tsc.SetResult(corsPolicy);
            return tsc.Task;
        }
    }
}