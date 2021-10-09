﻿using HekaLojisticsApp.UI.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlTypes;

namespace HekaLojisticsApp.UI.Web.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _environment;
        private readonly IModelMetadataProvider _metadataProvider;
        private readonly ILogger _logger;


        public ExceptionFilter(IHostEnvironment environment, IModelMetadataProvider metadataProvider, ILogger<ExceptionFilter> logger)
        {
            _environment = environment;
            _metadataProvider = metadataProvider;
            _logger = logger;
        }


        public void OnException(ExceptionContext context)
        {
            if (_environment.IsDevelopment())
            {
                context.ExceptionHandled = true;
                var mvcErrorModel = new ErrorViewModel();
                ViewResult result;
                switch (context.Exception)
                {
                    case SqlNullValueException:
                        mvcErrorModel.Message =
                            $"İşleminiz sırasında beklenmedik bir veritabanı hatası oluştu. Sorunu en kısa sürede çözeceğiz.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    case NullReferenceException:
                        mvcErrorModel.Message =
                            $"İşleminiz sırasında beklenmedik bir null veriye rastlandı. Sorunu en kısa sürede çözeceğiz.";
                        mvcErrorModel.Detail = context.Exception.Message;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 403;
                        _logger.LogError(context.Exception, context.Exception.Message);
                        break;
                    default:
                        mvcErrorModel.Message =
                            $"İşleminiz sırasında beklenmedik bir hata oluştu. Sorunu en kısa sürede çözeceğiz." + context.Exception;
                        result = new ViewResult { ViewName = "Error" };
                        result.StatusCode = 500;
                        _logger.LogError(context.Exception, "Bu benim log hata mesajım!");
                        break;
                }
                result.ViewData = new ViewDataDictionary(_metadataProvider, context.ModelState);
                result.ViewData.Add("ErrorViewModel", mvcErrorModel);
                context.Result = result;
            }
        }
    }
}