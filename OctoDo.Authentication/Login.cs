using System.Net;
using System.Text;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using OctoDo.Authentication.Api.Business.Authentication;
using OctoDo.Server.Contracts.Authentication;

namespace OctoDo.Authentication.Api;

public class Login
{
    private readonly IAuthenticationService _authenticationService;
    private readonly ILogger _logger;

    public Login(IAuthenticationService authenticationService, ILoggerFactory loggerFactory)
    {
        _authenticationService = authenticationService;
        _logger = loggerFactory.CreateLogger<Login>();
    }

    [Function(nameof(Login))]
    public async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequestData req)
    {
        _logger.LogInformation($"{nameof(Login)} received request.");
        var request = JsonSerializer.Deserialize<AuthenticationRequest>(req.Body);

        if (request is null || string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        var response = await _authenticationService.LoginAsync(request.Email, request.Password);

        if (!response.Succeeded)
        {
            return new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent(response.Error ?? string.Empty)
            };
        }
            
        var responseJson = JsonSerializer.Serialize(response);
        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(responseJson, Encoding.UTF8, "application/json")
        };

    }
}