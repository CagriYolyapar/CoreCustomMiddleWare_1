namespace CoreCustomMiddleWare_1.CustomMiddleWares
{
    public class CustomResponseMiddleware
    {
        RequestDelegate _requestDelegate;

        public CustomResponseMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context)
        {
            await _requestDelegate.Invoke(context);
            if(context.Response.StatusCode == StatusCodes.Status404NotFound)
            {
                await context.Response.WriteAsync("Hata yok işte kandırdım");
            }
        }
    }
}
