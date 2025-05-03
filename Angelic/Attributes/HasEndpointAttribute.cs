namespace Angelic.Attributes;

[AttributeUsage(AttributeTargets.Class)]
internal class HasEndpointAttribute(string endpointName) : Attribute
{
    internal string EndpointName { get; } = endpointName;
}