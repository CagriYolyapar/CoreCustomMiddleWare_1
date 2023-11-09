namespace CoreCustomMiddleWare_1.CustomMiddleWares
{
    public class CustomRequestMiddleware
    {

        RequestDelegate _requestDelegate;

        public CustomRequestMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        //Metot isminin Invoke olmasına ve HttpContext tipinde parametre almasına dikkat ediniz...
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/Deneme")
                await context.Response.WriteAsync("Deneme path'i tespit edildi");
            else
                await _requestDelegate.Invoke(context);
        }

    }
}
