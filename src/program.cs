using Amazon.CDK;

namespace MyCustomBucket
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new App(null);

            // A CDK app can contain multiple stacks. You can view a list of all the stacks in your
            // app by typing `cdk list`.

            new MyStack(app, "MyBucket", new StackProps
            {
                Env = new Amazon.CDK.Environment()
                {
                    Account = "AKIA347OXPEBCIIT4XY2",
                    Region = "eu-west-2"
                }
            });

            app.Run();
        }
    }
}
