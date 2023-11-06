namespace MyNamespace
{
    public class MyControllers
    {
        public Func<int> Add(int a, int b)
        {
            var callback = () => {
                //
                return ((a + b) % 2);
            };
            
            return callback;
        }
    }
}
