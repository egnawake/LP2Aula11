using System;

namespace LazySingleFloat
{
    public sealed class FloatManager
    {
        private static readonly Lazy<FloatManager> instance =
            new Lazy<FloatManager>(() => new FloatManager());

        public static FloatManager Instance => instance.Value;

        public float Value { get; set; }

        private FloatManager()
        {}
    }
}