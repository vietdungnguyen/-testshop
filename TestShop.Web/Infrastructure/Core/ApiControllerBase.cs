using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestShop.Model.Models;
using TestShop.Service;

namespace TestShop.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorService;

        public ApiControllerBase(IErrorService errorService)
        {
            this._errorService = errorService;
        }

        protected HttpResponseMessage CreateHttpReponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage reponse = null;
            try
            {
                return function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\"has the following validation errors");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine($"- Property:\"{ve.PropertyName}\",Error: \"{ve.ErrorMessage}");
                    }
                    LogError(ex);
                    reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return reponse;
        }

        private void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.CreatedDate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorService.Create(error);
                _errorService.Save();
            }
            catch
            {
            }
        }
    }
}