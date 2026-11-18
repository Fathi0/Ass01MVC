using System.Diagnostics;

namespace WebApplication1.Middlewares
{
    public class RequstTime
    {
        private readonly RequestDelegate _next;

        public RequstTime(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var stop = Stopwatch.StartNew();
          await  _next.Invoke(context);
            stop.Stop();
            Console.WriteLine($"{context.Request.Path}-->{stop.ElapsedMilliseconds}ms");
        }
    }
}
