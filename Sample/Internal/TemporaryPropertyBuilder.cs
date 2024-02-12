using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.EntityFrameworkCore.ValueGeneration;

namespace Sample.Internal;

public sealed class TemporaryPropertyBuilder : PropertyBuilder
{
    private readonly PropertyBuilder _propertyBuilder;
    
#pragma warning disable EF1001
    public TemporaryPropertyBuilder(PropertyBuilder propertyBuilder) : base(propertyBuilder.Metadata)
#pragma warning restore EF1001
    {
        _propertyBuilder = propertyBuilder;
    }

    public override IMutableProperty Metadata => _propertyBuilder.Metadata;

    public override bool Equals(object? obj)
    {
        return _propertyBuilder.Equals(obj);
    }

    public override PropertyBuilder HasAnnotation(string annotation, object? value)
    {
        return _propertyBuilder.HasAnnotation(annotation, value);
    }

    public override string? ToString()
    {
        return _propertyBuilder.ToString();
    }

    public override PropertyBuilder UsePropertyAccessMode(PropertyAccessMode propertyAccessMode)
    {
        return _propertyBuilder.UsePropertyAccessMode(propertyAccessMode);
    }

    public override int GetHashCode()
    {
        return _propertyBuilder.GetHashCode();
    }

    public override PropertyBuilder HasConversion(Type? conversionType)
    {
        return _propertyBuilder.HasConversion(conversionType);
    }

    public override PropertyBuilder HasConversion(ValueConverter? converter)
    {
        return _propertyBuilder.HasConversion(converter);
    }

    public override PropertyBuilder HasConversion<TConversion>(ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion<TConversion>(valueComparer);
    }

    public override PropertyBuilder HasConversion(Type conversionType, Type? comparerType)
    {
        return _propertyBuilder.HasConversion(conversionType, comparerType);
    }

    public override PropertyBuilder HasConversion<TConversion, TComparer, TProviderComparer>()
    {
        return _propertyBuilder.HasConversion<TConversion, TComparer, TProviderComparer>();
    }

    public override PropertyBuilder HasConversion(ValueConverter? converter, ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer, providerComparer);
    }

    public override PropertyBuilder HasConversion<TConversion, TComparer>()
    {
        return _propertyBuilder.HasConversion<TConversion, TComparer>();
    }

    public override PropertyBuilder HasConversion(Type conversionType, Type? comparerType, Type? providerComparerType)
    {
        return _propertyBuilder.HasConversion(conversionType, comparerType, providerComparerType);
    }

    public override PropertyBuilder HasConversion<TConversion>()
    {
        return _propertyBuilder.HasConversion<TConversion>();
    }

    public override PropertyBuilder HasConversion<TConversion>(ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion<TConversion>(valueComparer, providerComparer);
    }

    public override PropertyBuilder HasConversion(Type conversionType, ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(conversionType, valueComparer, providerComparer);
    }

    public override PropertyBuilder HasConversion(ValueConverter? converter, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer);
    }

    public override PropertyBuilder HasConversion(Type conversionType, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(conversionType, valueComparer);
    }

    public override PropertyBuilder HasField(string fieldName)
    {
        return _propertyBuilder.HasField(fieldName);
    }

    public override PropertyBuilder HasPrecision(int precision, int scale)
    {
        return _propertyBuilder.HasPrecision(precision, scale);
    }

    public override PropertyBuilder HasPrecision(int precision)
    {
        return _propertyBuilder.HasPrecision(precision);
    }

    public override PropertyBuilder IsRequired(bool required = true)
    {
        return _propertyBuilder.IsRequired(required);
    }

    public override PropertyBuilder IsUnicode(bool unicode = true)
    {
        return _propertyBuilder.IsUnicode(unicode);
    }

    public override PropertyBuilder HasMaxLength(int maxLength)
    {
        return _propertyBuilder.HasMaxLength(maxLength);
    }

    public override PropertyBuilder HasValueGenerator<TGenerator>()
    {
        return _propertyBuilder.HasValueGenerator<TGenerator>();
    }

    public override PropertyBuilder HasValueGenerator(Type? valueGeneratorType)
    {
        return _propertyBuilder.HasValueGenerator(valueGeneratorType);
    }

    public override PropertyBuilder HasValueGenerator(Func<IProperty, IEntityType, ValueGenerator> factory)
    {
        return _propertyBuilder.HasValueGenerator(factory);
    }

    public override PropertyBuilder IsConcurrencyToken(bool concurrencyToken = true)
    {
        return _propertyBuilder.IsConcurrencyToken(concurrencyToken);
    }

    public override PropertyBuilder IsRowVersion()
    {
        return _propertyBuilder.IsRowVersion();
    }

    public override PropertyBuilder ValueGeneratedNever()
    {
        return _propertyBuilder.ValueGeneratedNever();
    }

    public override PropertyBuilder HasValueGeneratorFactory<TFactory>()
    {
        return _propertyBuilder.HasValueGeneratorFactory<TFactory>();
    }

    public override PropertyBuilder HasValueGeneratorFactory(Type? valueGeneratorFactoryType)
    {
        return _propertyBuilder.HasValueGeneratorFactory(valueGeneratorFactoryType);
    }

    public override PropertyBuilder ValueGeneratedOnAdd()
    {
        return _propertyBuilder.ValueGeneratedOnAdd();
    }

    public override PropertyBuilder ValueGeneratedOnUpdate()
    {
        return _propertyBuilder.ValueGeneratedOnUpdate();
    }

    public override PropertyBuilder ValueGeneratedOnUpdateSometimes()
    {
        return _propertyBuilder.ValueGeneratedOnUpdateSometimes();
    }

    public override PropertyBuilder ValueGeneratedOnAddOrUpdate()
    {
        return _propertyBuilder.ValueGeneratedOnAddOrUpdate();
    }
}

public sealed class TemporaryPropertyBuilder<TProperty> : PropertyBuilder<TProperty>
{
    private readonly PropertyBuilder<TProperty> _propertyBuilder;
    
#pragma warning disable EF1001
    public TemporaryPropertyBuilder(PropertyBuilder<TProperty> propertyBuilder) : base(propertyBuilder.Metadata)
#pragma warning restore EF1001
    {
        _propertyBuilder = propertyBuilder;
    }

    public override IMutableProperty Metadata => _propertyBuilder.Metadata;

    public override bool Equals(object? obj)
    {
        return _propertyBuilder.Equals(obj);
    }

    public override PropertyBuilder<TProperty> HasAnnotation(string annotation, object? value)
    {
        return _propertyBuilder.HasAnnotation(annotation, value);
    }

    public override string? ToString()
    {
        return _propertyBuilder.ToString();
    }

    public override PropertyBuilder<TProperty> UsePropertyAccessMode(PropertyAccessMode propertyAccessMode)
    {
        return _propertyBuilder.UsePropertyAccessMode(propertyAccessMode);
    }

    public override int GetHashCode()
    {
        return _propertyBuilder.GetHashCode();
    }

    public override PropertyBuilder<TProperty> HasConversion(Type? conversionType)
    {
        return _propertyBuilder.HasConversion(conversionType);
    }

    public override PropertyBuilder<TProperty> HasConversion(ValueConverter? converter)
    {
        return _propertyBuilder.HasConversion(converter);
    }

    public override PropertyBuilder<TProperty> HasConversion<TConversion>(ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion<TConversion>(valueComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion(Type conversionType, Type? comparerType)
    {
        return _propertyBuilder.HasConversion(conversionType, comparerType);
    }

    public override PropertyBuilder<TProperty> HasConversion<TConversion, TComparer, TProviderComparer>()
    {
        return _propertyBuilder.HasConversion<TConversion, TComparer, TProviderComparer>();
    }

    public override PropertyBuilder<TProperty> HasConversion(ValueConverter? converter, ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer, providerComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion<TConversion, TComparer>()
    {
        return _propertyBuilder.HasConversion<TConversion, TComparer>();
    }

    public override PropertyBuilder<TProperty> HasConversion(Type conversionType, Type? comparerType, Type? providerComparerType)
    {
        return _propertyBuilder.HasConversion(conversionType, comparerType, providerComparerType);
    }

    public override PropertyBuilder<TProperty> HasConversion<TConversion>()
    {
        return _propertyBuilder.HasConversion<TConversion>();
    }

    public override PropertyBuilder<TProperty> HasConversion<TConversion>(ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion<TConversion>(valueComparer, providerComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion(Type conversionType, ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(conversionType, valueComparer, providerComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion(ValueConverter? converter, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion(Type conversionType, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(conversionType, valueComparer);
    }

    public override PropertyBuilder<TProperty> HasField(string fieldName)
    {
        return _propertyBuilder.HasField(fieldName);
    }

    public override PropertyBuilder<TProperty> HasPrecision(int precision, int scale)
    {
        return _propertyBuilder.HasPrecision(precision, scale);
    }

    public override PropertyBuilder<TProperty> HasPrecision(int precision)
    {
        return _propertyBuilder.HasPrecision(precision);
    }

    public override PropertyBuilder<TProperty> IsRequired(bool required = true)
    {
        return _propertyBuilder.IsRequired(required);
    }

    public override PropertyBuilder<TProperty> IsUnicode(bool unicode = true)
    {
        return _propertyBuilder.IsUnicode(unicode);
    }

    public override PropertyBuilder<TProperty> HasMaxLength(int maxLength)
    {
        return _propertyBuilder.HasMaxLength(maxLength);
    }

    public override PropertyBuilder<TProperty> HasValueGenerator<TGenerator>()
    {
        return _propertyBuilder.HasValueGenerator<TGenerator>();
    }

    public override PropertyBuilder<TProperty> HasValueGenerator(Type? valueGeneratorType)
    {
        return _propertyBuilder.HasValueGenerator(valueGeneratorType);
    }

    public override PropertyBuilder<TProperty> HasValueGenerator(Func<IProperty, IEntityType, ValueGenerator> factory)
    {
        return _propertyBuilder.HasValueGenerator(factory);
    }

    public override PropertyBuilder<TProperty> IsConcurrencyToken(bool concurrencyToken = true)
    {
        return _propertyBuilder.IsConcurrencyToken(concurrencyToken);
    }

    public override PropertyBuilder<TProperty> IsRowVersion()
    {
        return _propertyBuilder.IsRowVersion();
    }

    public override PropertyBuilder<TProperty> ValueGeneratedNever()
    {
        return _propertyBuilder.ValueGeneratedNever();
    }

    public override PropertyBuilder<TProperty> HasValueGeneratorFactory<TFactory>()
    {
        return _propertyBuilder.HasValueGeneratorFactory<TFactory>();
    }

    public override PropertyBuilder<TProperty> HasValueGeneratorFactory(Type? valueGeneratorFactoryType)
    {
        return _propertyBuilder.HasValueGeneratorFactory(valueGeneratorFactoryType);
    }

    public override PropertyBuilder<TProperty> ValueGeneratedOnAdd()
    {
        return _propertyBuilder.ValueGeneratedOnAdd();
    }

    public override PropertyBuilder<TProperty> ValueGeneratedOnUpdate()
    {
        return _propertyBuilder.ValueGeneratedOnUpdate();
    }

    public override PropertyBuilder<TProperty> ValueGeneratedOnUpdateSometimes()
    {
        return _propertyBuilder.ValueGeneratedOnUpdateSometimes();
    }

    public override PropertyBuilder<TProperty> ValueGeneratedOnAddOrUpdate()
    {
        return _propertyBuilder.ValueGeneratedOnAddOrUpdate();
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(Expression<Func<TProperty, TProvider>> convertToProviderExpression,
        Expression<Func<TProvider, TProperty>> convertFromProviderExpression)
    {
        return _propertyBuilder.HasConversion(convertToProviderExpression, convertFromProviderExpression);
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(Expression<Func<TProperty, TProvider>> convertToProviderExpression,
        Expression<Func<TProvider, TProperty>> convertFromProviderExpression, ValueComparer? valueComparer, ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(convertToProviderExpression, convertFromProviderExpression, valueComparer, providerComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(ValueConverter<TProperty, TProvider>? converter, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(ValueConverter<TProperty, TProvider>? converter, ValueComparer? valueComparer,
        ValueComparer? providerComparer)
    {
        return _propertyBuilder.HasConversion(converter, valueComparer, providerComparer);
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(ValueConverter<TProperty, TProvider>? converter)
    {
        return _propertyBuilder.HasConversion(converter);
    }

    public override PropertyBuilder<TProperty> HasConversion<TProvider>(Expression<Func<TProperty, TProvider>> convertToProviderExpression,
        Expression<Func<TProvider, TProperty>> convertFromProviderExpression, ValueComparer? valueComparer)
    {
        return _propertyBuilder.HasConversion(convertToProviderExpression, convertFromProviderExpression, valueComparer);
    }
}