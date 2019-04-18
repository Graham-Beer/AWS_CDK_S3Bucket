using Amazon.CDK;
using Amazon.CDK.AWS.S3;

namespace MyCustomBucket
{
    public class MyStack : Stack
    {
        private const string bn = "grahamb";
        private const string ruleName = "customrule";

        public MyStack(App scope, string id) : base(scope, id, null)
        {
            Bucket bucket = new Bucket(
                this, "MyFirstBucket", new BucketProps
                {
                    Versioned = true,
                    BucketName = bn,
                    Encryption = BucketEncryption.KmsManaged
                });

            var lifecycleRule = new LifecycleRule
            {
                Id = ruleName,
                ExpirationInDays = 30
            };

           bucket.AddLifecycleRule(rule: lifecycleRule);
        }
    }
}
