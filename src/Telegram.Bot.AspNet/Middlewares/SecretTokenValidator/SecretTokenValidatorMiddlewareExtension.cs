﻿using Microsoft.AspNetCore.Builder;

namespace Telegram.Bot.AspNet.Middlewares.SecretTokenValidator;

public static class SecretTokenValidatorMiddlewareExtension
{
    public static IApplicationBuilder UseSecretTokenValidator(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<SecretTokenValidatorMiddleware>();
    }
}