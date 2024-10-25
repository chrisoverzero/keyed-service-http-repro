﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable

namespace System.Runtime.CompilerServices
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    file sealed class InterceptsLocationAttribute : Attribute
    {
        public InterceptsLocationAttribute(int version, string data)
        {
        }
    }
}

namespace Microsoft.AspNetCore.Http.Generated
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Text.Json;
    using System.Text.Json.Serialization.Metadata;
    using System.Threading.Tasks;
    using System.IO;
    using Microsoft.AspNetCore.Antiforgery;
    using Microsoft.AspNetCore.Routing;
    using Microsoft.AspNetCore.Routing.Patterns;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Http.Json;
    using Microsoft.AspNetCore.Http.Metadata;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.FileProviders;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Primitives;
    using Microsoft.Extensions.Options;

    using MetadataPopulator = System.Func<System.Reflection.MethodInfo, Microsoft.AspNetCore.Http.RequestDelegateFactoryOptions?, Microsoft.AspNetCore.Http.RequestDelegateMetadataResult>;
    using RequestDelegateFactoryFunc = System.Func<System.Delegate, Microsoft.AspNetCore.Http.RequestDelegateFactoryOptions, Microsoft.AspNetCore.Http.RequestDelegateMetadataResult?, Microsoft.AspNetCore.Http.RequestDelegateResult>;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0")]
    file static class GeneratedRouteBuilderExtensionsCore
    {
        private static readonly JsonOptions FallbackJsonOptions = new();
        private static readonly string[] GetVerb = new[] { global::Microsoft.AspNetCore.Http.HttpMethods.Get };

        [global::System.Runtime.CompilerServices.InterceptsLocationAttribute(1, "+kpqvn9twWVugsgy1MlcgEsCAABQcm9ncmFtLmNz")]
        internal static RouteHandlerBuilder MapGet0(
            this IEndpointRouteBuilder endpoints,
            [StringSyntax("Route")] string pattern,
            Delegate handler)
        {
            MetadataPopulator populateMetadata = (methodInfo, options) =>
            {
                Debug.Assert(options != null, "RequestDelegateFactoryOptions not found.");
                Debug.Assert(options.EndpointBuilder != null, "EndpointBuilder not found.");
                options.EndpointBuilder.Metadata.Add(new System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0"));
                var parameters = methodInfo.GetParameters();
                options.EndpointBuilder.Metadata.Add(new ParameterBindingMetadata("e", parameters[0], hasTryParse: false, hasBindAsync: false, isOptional: false));
                options.EndpointBuilder.Metadata.Add(new ProducesResponseTypeMetadata(statusCode: StatusCodes.Status200OK, type: typeof(global::WeatherForecast[]), contentTypes: GeneratedMetadataConstants.JsonContentType));
                return new RequestDelegateMetadataResult { EndpointMetadata = options.EndpointBuilder.Metadata.AsReadOnly() };
            };
            RequestDelegateFactoryFunc createRequestDelegate = (del, options, inferredMetadataResult) =>
            {
                Debug.Assert(options != null, "RequestDelegateFactoryOptions not found.");
                Debug.Assert(options.EndpointBuilder != null, "EndpointBuilder not found.");
                Debug.Assert(options.EndpointBuilder.ApplicationServices != null, "ApplicationServices not found.");
                Debug.Assert(options.EndpointBuilder.FilterFactories != null, "FilterFactories not found.");
                var handler = Cast(del, global::WeatherForecast[] (global::Http.ExampleService arg0) => throw null!);
                EndpointFilterDelegate? filteredInvocation = null;
                var serviceProvider = options.ServiceProvider ?? options.EndpointBuilder.ApplicationServices;
                var logOrThrowExceptionHelper = new LogOrThrowExceptionHelper(serviceProvider, options);
                var jsonOptions = serviceProvider?.GetService<IOptions<JsonOptions>>()?.Value ?? FallbackJsonOptions;
                var jsonSerializerOptions = jsonOptions.SerializerOptions;
                jsonSerializerOptions.MakeReadOnly();
                var objectJsonTypeInfo = (JsonTypeInfo<object?>)jsonSerializerOptions.GetTypeInfo(typeof(object));
                var responseJsonTypeInfo =  (JsonTypeInfo<global::WeatherForecast[]?>)jsonSerializerOptions.GetTypeInfo(typeof(global::WeatherForecast[]));

                if (options.EndpointBuilder.FilterFactories.Count > 0)
                {
                    filteredInvocation = GeneratedRouteBuilderExtensionsCore.BuildFilterDelegate(ic =>
                    {
                        if (ic.HttpContext.Response.StatusCode == 400)
                        {
                            return ValueTask.FromResult<object?>(Results.Empty);
                        }
                        return ValueTask.FromResult<object?>(handler(ic.GetArgument<global::Http.ExampleService>(0)!));
                    },
                    options.EndpointBuilder,
                    handler.Method);
                }

                Task RequestHandler(HttpContext httpContext)
                {
                    var wasParamCheckFailure = false;
                    // Endpoint Parameter: e (Type = Http.ExampleService, IsOptional = False, IsParsable = False, IsArray = False, Source = KeyedService)
                    if (httpContext.RequestServices.GetService<IServiceProviderIsService>() is not IServiceProviderIsKeyedService)
                    {
                        throw new InvalidOperationException($"Unable to resolve service referenced by {nameof(FromKeyedServicesAttribute)}. The service provider doesn't support keyed services.");
                    }
                    var e_local = httpContext.RequestServices.GetRequiredKeyedService<Http.ExampleService>("example");

                    if (wasParamCheckFailure)
                    {
                        httpContext.Response.StatusCode = 400;
                        return Task.CompletedTask;
                    }
                    var result = handler(e_local);
                    return GeneratedRouteBuilderExtensionsCore.WriteJsonResponseAsync(httpContext.Response, result, responseJsonTypeInfo);
                }

                async Task RequestHandlerFiltered(HttpContext httpContext)
                {
                    var wasParamCheckFailure = false;
                    // Endpoint Parameter: e (Type = Http.ExampleService, IsOptional = False, IsParsable = False, IsArray = False, Source = KeyedService)
                    if (httpContext.RequestServices.GetService<IServiceProviderIsService>() is not IServiceProviderIsKeyedService)
                    {
                        throw new InvalidOperationException($"Unable to resolve service referenced by {nameof(FromKeyedServicesAttribute)}. The service provider doesn't support keyed services.");
                    }
                    var e_local = httpContext.RequestServices.GetRequiredKeyedService<Http.ExampleService>("example");

                    if (wasParamCheckFailure)
                    {
                        httpContext.Response.StatusCode = 400;
                    }
                    var result = await filteredInvocation(EndpointFilterInvocationContext.Create<global::Http.ExampleService>(httpContext, e_local));
                    if (result is not null)
                    {
                        await GeneratedRouteBuilderExtensionsCore.ExecuteReturnAsync(result, httpContext, objectJsonTypeInfo);
                    }
                }

                RequestDelegate targetDelegate = filteredInvocation is null ? RequestHandler : RequestHandlerFiltered;
                var metadata = inferredMetadataResult?.EndpointMetadata ?? ReadOnlyCollection<object>.Empty;
                return new RequestDelegateResult(targetDelegate, metadata);
            };
            var castHandler = Cast(handler, global::WeatherForecast[] (global::Http.ExampleService arg0) => throw null!);
            return MapCore(
                endpoints,
                pattern,
                handler,
                GetVerb,
                populateMetadata,
                createRequestDelegate,
                castHandler.Method);
        }



        internal static RouteHandlerBuilder MapCore(
            this IEndpointRouteBuilder routes,
            string pattern,
            Delegate handler,
            IEnumerable<string>? httpMethods,
            MetadataPopulator populateMetadata,
            RequestDelegateFactoryFunc createRequestDelegate,
            MethodInfo methodInfo)
        {
            return RouteHandlerServices.Map(routes, pattern, handler, httpMethods, populateMetadata, createRequestDelegate, methodInfo);
        }

        private static T Cast<T>(Delegate d, T _) where T : Delegate
        {
            return (T)d;
        }

        private static EndpointFilterDelegate BuildFilterDelegate(EndpointFilterDelegate filteredInvocation, EndpointBuilder builder, MethodInfo mi)
        {
            var routeHandlerFilters =  builder.FilterFactories;
            var context0 = new EndpointFilterFactoryContext
            {
                MethodInfo = mi,
                ApplicationServices = builder.ApplicationServices,
            };
            var initialFilteredInvocation = filteredInvocation;
            for (var i = routeHandlerFilters.Count - 1; i >= 0; i--)
            {
                var filterFactory = routeHandlerFilters[i];
                filteredInvocation = filterFactory(context0, filteredInvocation);
            }
            return filteredInvocation;
        }

        private static Task ExecuteReturnAsync(object? obj, HttpContext httpContext, JsonTypeInfo<object?> jsonTypeInfo)
        {
            if (obj is IResult r)
            {
                return r.ExecuteAsync(httpContext);
            }
            else if (obj is string s)
            {
                return httpContext.Response.WriteAsync(s);
            }
            else
            {
                return WriteJsonResponseAsync(httpContext.Response, obj, jsonTypeInfo);
            }
        }

        [UnconditionalSuppressMessage("Trimming", "IL2026:RequiresUnreferencedCode",
            Justification = "The 'JsonSerializer.IsReflectionEnabledByDefault' feature switch, which is set to false by default for trimmed ASP.NET apps, ensures the JsonSerializer doesn't use Reflection.")]
        [UnconditionalSuppressMessage("AOT", "IL3050:RequiresDynamicCode", Justification = "See above.")]
        private static Task WriteJsonResponseAsync<T>(HttpResponse response, T? value, JsonTypeInfo<T?> jsonTypeInfo)
        {
            var runtimeType = value?.GetType();

            if (jsonTypeInfo.ShouldUseWith(runtimeType))
            {
                return HttpResponseJsonExtensions.WriteAsJsonAsync(response, value, jsonTypeInfo, default);
            }

            return response.WriteAsJsonAsync<object?>(value, jsonTypeInfo.Options);
        }

        private static bool HasKnownPolymorphism(this JsonTypeInfo jsonTypeInfo)
            => jsonTypeInfo.Type.IsSealed || jsonTypeInfo.Type.IsValueType || jsonTypeInfo.PolymorphismOptions is not null;

        private static bool ShouldUseWith(this JsonTypeInfo jsonTypeInfo, [NotNullWhen(false)] Type? runtimeType)
            => runtimeType is null || jsonTypeInfo.Type == runtimeType || jsonTypeInfo.HasKnownPolymorphism();


    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0")]
    file static class GeneratedMetadataConstants
    {
        public static readonly string[] JsonContentType = new [] { "application/json" };
        public static readonly string[] PlaintextContentType = new [] { "text/plain" };
        public static readonly string[] FormFileContentType = new[] { "multipart/form-data" };
        public static readonly string[] FormContentType = new[] { "multipart/form-data", "application/x-www-form-urlencoded" };
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0")]
    file sealed class ParameterBindingMetadata: IParameterBindingMetadata
    {
        internal ParameterBindingMetadata(
            string name,
            ParameterInfo parameterInfo,
            bool hasTryParse = false,
            bool hasBindAsync = false,
            bool isOptional = false)
        {
            Name = name;
            ParameterInfo = parameterInfo;
            HasTryParse = hasTryParse;
            HasBindAsync = hasBindAsync;
            IsOptional = isOptional;
        }

        public string Name { get; }

        public bool HasTryParse { get; }

        public bool HasBindAsync { get; }

        public ParameterInfo ParameterInfo { get; }

        public bool IsOptional { get; }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.AspNetCore.Http.RequestDelegateGenerator, Version=9.0.0.0, Culture=neutral, PublicKeyToken=adb9793829ddae60", "9.0.0.0")]
    file sealed class LogOrThrowExceptionHelper
    {
        private readonly ILogger? _rdgLogger;
        private readonly bool _shouldThrow;

        public LogOrThrowExceptionHelper(IServiceProvider? serviceProvider, RequestDelegateFactoryOptions? options)
        {
            var loggerFactory = serviceProvider?.GetRequiredService<ILoggerFactory>();
            _rdgLogger = loggerFactory?.CreateLogger("Microsoft.AspNetCore.Http.RequestDelegateGenerator.RequestDelegateGenerator");
            _shouldThrow = options?.ThrowOnBadRequest ?? false;
        }

        public void RequestBodyIOException(IOException exception)
        {
            if (_rdgLogger != null)
            {
                _requestBodyIOException(_rdgLogger, exception);
            }
        }

        private static readonly Action<ILogger, Exception?> _requestBodyIOException =
            LoggerMessage.Define(LogLevel.Debug, new EventId(1, "RequestBodyIOException"), "Reading the request body failed with an IOException.");

        public void InvalidJsonRequestBody(string parameterTypeName, string parameterName, Exception exception)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Failed to read parameter \"{0} {1}\" from the request body as JSON.", parameterTypeName, parameterName);
                throw new BadHttpRequestException(message, exception);
            }

            if (_rdgLogger != null)
            {
                _invalidJsonRequestBody(_rdgLogger, parameterTypeName, parameterName, exception);
            }
        }

        private static readonly Action<ILogger, string, string, Exception?> _invalidJsonRequestBody =
            LoggerMessage.Define<string, string>(LogLevel.Debug, new EventId(2, "InvalidJsonRequestBody"), "Failed to read parameter \"{ParameterType} {ParameterName}\" from the request body as JSON.");

        public void ParameterBindingFailed(string parameterTypeName, string parameterName, string sourceValue)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Failed to bind parameter \"{0} {1}\" from \"{2}\".", parameterTypeName, parameterName, sourceValue);
                throw new BadHttpRequestException(message);
            }

            if (_rdgLogger != null)
            {
                _parameterBindingFailed(_rdgLogger, parameterTypeName, parameterName, sourceValue, null);
            }
        }

        private static readonly Action<ILogger, string, string, string, Exception?> _parameterBindingFailed =
            LoggerMessage.Define<string, string, string>(LogLevel.Debug, new EventId(3, "ParameterBindingFailed"), "Failed to bind parameter \"{ParameterType} {ParameterName}\" from \"{SourceValue}\".");

        public void RequiredParameterNotProvided(string parameterTypeName, string parameterName, string source)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Required parameter \"{0} {1}\" was not provided from {2}.", parameterTypeName, parameterName, source);
                throw new BadHttpRequestException(message);
            }

            if (_rdgLogger != null)
            {
                _requiredParameterNotProvided(_rdgLogger, parameterTypeName, parameterName, source, null);
            }
        }

        private static readonly Action<ILogger, string, string, string, Exception?> _requiredParameterNotProvided =
            LoggerMessage.Define<string, string, string>(LogLevel.Debug, new EventId(4, "RequiredParameterNotProvided"), "Required parameter \"{ParameterType} {ParameterName}\" was not provided from {Source}.");

        public void ImplicitBodyNotProvided(string parameterName)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Implicit body inferred for parameter \"{0}\" but no body was provided. Did you mean to use a Service instead?", parameterName);
                throw new BadHttpRequestException(message);
            }

            if (_rdgLogger != null)
            {
                _implicitBodyNotProvided(_rdgLogger, parameterName, null);
            }
        }

        private static readonly Action<ILogger, string, Exception?> _implicitBodyNotProvided =
            LoggerMessage.Define<string>(LogLevel.Debug, new EventId(5, "ImplicitBodyNotProvided"), "Implicit body inferred for parameter \"{ParameterName}\" but no body was provided. Did you mean to use a Service instead?");

        public void UnexpectedJsonContentType(string? contentType)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Expected a supported JSON media type but got \"{0}\".", contentType);
                throw new BadHttpRequestException(message, StatusCodes.Status415UnsupportedMediaType);
            }

            if (_rdgLogger != null)
            {
                _unexpectedJsonContentType(_rdgLogger, contentType ?? "(none)", null);
            }
        }

        private static readonly Action<ILogger, string, Exception?> _unexpectedJsonContentType =
            LoggerMessage.Define<string>(LogLevel.Debug, new EventId(6, "UnexpectedContentType"), "Expected a supported JSON media type but got \"{ContentType}\".");

        public void UnexpectedNonFormContentType(string? contentType)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Expected a supported form media type but got \"{0}\".", contentType);
                throw new BadHttpRequestException(message, StatusCodes.Status415UnsupportedMediaType);
            }

            if (_rdgLogger != null)
            {
                _unexpectedNonFormContentType(_rdgLogger, contentType ?? "(none)", null);
            }
        }

        private static readonly Action<ILogger, string, Exception?> _unexpectedNonFormContentType =
            LoggerMessage.Define<string>(LogLevel.Debug, new EventId(7, "UnexpectedNonFormContentType"), "Expected a supported form media type but got \"{ContentType}\".");

        public void InvalidFormRequestBody(string parameterTypeName, string parameterName, Exception exception)
        {
            if (_shouldThrow)
            {
                var message = string.Format(CultureInfo.InvariantCulture, "Failed to read parameter \"{0} {1}\" from the request body as form.", parameterTypeName, parameterName);
                throw new BadHttpRequestException(message, exception);
            }

            if (_rdgLogger != null)
            {
                _invalidFormRequestBody(_rdgLogger, parameterTypeName, parameterName, exception);
            }
        }

        private static readonly Action<ILogger, string, string, Exception?> _invalidFormRequestBody =
            LoggerMessage.Define<string, string>(LogLevel.Debug, new EventId(8, "InvalidFormRequestBody"), "Failed to read parameter \"{ParameterType} {ParameterName}\" from the request body as form.");
    }
}