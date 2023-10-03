namespace WebApiAutores.Middlewares
{
    public class LoguearRespuestaHTTPMiddleware    
    {
        private readonly RequestDelegate siguiente;
        public LoguearRespuestaHTTPMiddleware(RequestDelegate siguiente)
        {
            this.siguiente = siguiente;
        }
        //Invoke o InvokeAsync
        public async Task InvokeAsync(HttpContext context)
        {
            
        }
    }
}
