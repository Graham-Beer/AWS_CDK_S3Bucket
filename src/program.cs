using Amazon.CDK;

namespace MyCustomBucket
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App(null);

            new MyStack(app, "MyBucket", new StackProps
            {
                Env = new Environment
                {
                    Account = "", // Account Id
                    Region = "eu-west-2"
                }
            });

            app.Run();
        }
    }
}
