namespace Angelic.Attributes;

[AttributeUsage(AttributeTargets.Class)]
internal class ListVariantOfAttribute(Type className) : Attribute
{
    internal Type ClassName { get; } = className;
}