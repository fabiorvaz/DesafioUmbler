using DesafioUmbler.Shared;
using DnsClient;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Whois;
using Whois.NET;

namespace DesafioUmbler.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DomainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<Domain> GetAsync(string domainName)
        {
            Domain domain = new Domain();
            var response = WhoisClient.QueryAsync(domainName);

            domain.Name = domainName;

            var lookup = new LookupClient();
            try
            {
                var result = await lookup.QueryAsync(domainName, QueryType.ANY);
                var record = result.Answers.ARecords().FirstOrDefault();

                var address = record?.Address;
                var ip = address?.ToString();

                var hostResponse = await WhoisClient.QueryAsync(ip);

                domain.Ip = ip;
                domain.WhoIs = response.Result.Raw;
                domain.HostedAt = hostResponse.OrganizationName;
            }
            catch
            {
                string msg = "Dominio não encontrado";

                domain.Ip = msg;
                domain.WhoIs = msg;
                domain.HostedAt = msg;
            }
            return domain;
        }
    }
}
