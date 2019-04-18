using Amazon.CDK;

namespace MyCustomBucket
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App(null);
            new MyStack(app, "MyBucket");
            app.Run();
        }
    }
}
