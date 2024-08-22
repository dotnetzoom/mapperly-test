﻿// <auto-generated />
#nullable enable
namespace Riok.Mapperly.IntegrationTests.Mapper
{
    public static partial class ProjectionMapper
    {
        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static partial global::System.Linq.IQueryable<global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjection> ProjectToDto(this global::System.Linq.IQueryable<global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjection> q)
        {
#nullable disable
            return System.Linq.Queryable.Select(
                q,
                x => new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjection(x.CtorValue)
                {
                    IntValue = x.IntValue,
                    IntInitOnlyValue = x.IntInitOnlyValue,
                    RequiredValue = x.RequiredValue,
                    StringValue = x.StringValue,
                    RenamedStringValue2 = x.RenamedStringValue,
                    FlatteningIdValue = x.Flattening.IdValue,
                    NullableFlatteningIdValue = x.NullableFlattening != null ? x.NullableFlattening.IdValue : default(int?),
                    NestedNullableIntValue = x.NestedNullable != null ? x.NestedNullable.IntValue : default,
                    NestedNullable = x.NestedNullable != null ? new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto()
                    {
                        IntValue = x.NestedNullable.IntValue,
                    } : default,
                    NestedNullableTargetNotNullable = x.NestedNullableTargetNotNullable != null ? new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto()
                    {
                        IntValue = x.NestedNullableTargetNotNullable.IntValue,
                    } : new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto(),
                    StringNullableTargetNotNullable = x.StringNullableTargetNotNullable ?? "",
                    SourceTargetSameObjectType = x.SourceTargetSameObjectType,
                    NullableReadOnlyObjectCollection = x.NullableReadOnlyObjectCollection != null ? global::System.Linq.Enumerable.ToArray(
                        global::System.Linq.Enumerable.Select(
                            x.NullableReadOnlyObjectCollection,
                            x1 => new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto()
                            {
                                IntValue = x1.IntValue,
                            }
                        )
                    ) : default,
                    EnumValue = (global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByValue)x.EnumValue,
                    EnumName = (global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName)x.EnumName,
                    EnumRawValue = (byte)x.EnumRawValue,
                    EnumStringValue = (string)x.EnumStringValue.ToString(),
                    EnumReverseStringValue = System.Enum.Parse<global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName>(x.EnumReverseStringValue, false),
                    SubObject = x.SubObject != null ? new global::Riok.Mapperly.IntegrationTests.Dto.InheritanceSubObjectDto()
                    {
                        SubIntValue = x.SubObject.SubIntValue,
                        BaseIntValue = x.SubObject.BaseIntValue,
                    } : default,
                    DateTimeValueTargetDateOnly = global::System.DateOnly.FromDateTime(x.DateTimeValueTargetDateOnly),
                    DateTimeValueTargetTimeOnly = global::System.TimeOnly.FromDateTime(x.DateTimeValueTargetTimeOnly),
                    ManuallyMapped = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoManuallyMappedProjection(100) { StringValue = x.ManuallyMapped },
                    ManuallyMappedModified = x.ManuallyMappedModified + 10,
                    ManuallyMappedList = global::System.Linq.Enumerable.ToList(
                        global::System.Linq.Enumerable.Select(x.ManuallyMappedList, x1 => x1.Value)
                    ),
                    IntegerValues = global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.OrderBy(x.IntegerValues, x => x.Value)),
                    DecimalValues = global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(global::System.Linq.Enumerable.OrderBy(x.DecimalValues, x => x.Value), x => new global::Riok.Mapperly.IntegrationTests.Dto.LongValueDto()
                    {
                        Value = x.Value,
                    })),
                }
            );
#nullable enable
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static partial global::System.Linq.IQueryable<global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionBaseType> ProjectToDto(this global::System.Linq.IQueryable<global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionBaseType> q)
        {
#nullable disable
            return System.Linq.Queryable.Select(
                q,
                x => (global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionBaseType)(x is global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA ? new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeA()
                {
                    ValueA = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA)x).ValueA,
                    Id = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA)x).Id,
                    BaseValue = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA)x).BaseValue,
                } : x is global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB ? new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeB()
                {
                    ValueB = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB)x).ValueB,
                    Id = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB)x).Id,
                    BaseValue = ((global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB)x).BaseValue,
                } : default)
            );
#nullable enable
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static partial global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjection ProjectToDto(this global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjection testObject)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjection(testObject.CtorValue)
            {
                IntInitOnlyValue = testObject.IntInitOnlyValue,
                RequiredValue = testObject.RequiredValue,
            };
            target.IntValue = testObject.IntValue;
            target.StringValue = testObject.StringValue;
            target.RenamedStringValue2 = testObject.RenamedStringValue;
            target.FlatteningIdValue = testObject.Flattening.IdValue;
            target.NullableFlatteningIdValue = testObject.NullableFlattening?.IdValue;
            if (testObject.NestedNullable != null)
            {
                target.NestedNullableIntValue = testObject.NestedNullable.IntValue;
                target.NestedNullable = MapToTestObjectNestedDto(testObject.NestedNullable);
            }
            else
            {
                target.NestedNullable = null;
            }
            if (testObject.NestedNullableTargetNotNullable != null)
            {
                target.NestedNullableTargetNotNullable = MapToTestObjectNestedDto(testObject.NestedNullableTargetNotNullable);
            }
            if (testObject.StringNullableTargetNotNullable != null)
            {
                target.StringNullableTargetNotNullable = testObject.StringNullableTargetNotNullable;
            }
            target.SourceTargetSameObjectType = testObject.SourceTargetSameObjectType;
            if (testObject.NullableReadOnlyObjectCollection != null)
            {
                target.NullableReadOnlyObjectCollection = MapToTestObjectNestedDtoArray(testObject.NullableReadOnlyObjectCollection);
            }
            else
            {
                target.NullableReadOnlyObjectCollection = null;
            }
            target.EnumValue = (global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByValue)testObject.EnumValue;
            target.EnumName = (global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName)testObject.EnumName;
            target.EnumRawValue = (byte)testObject.EnumRawValue;
            target.EnumStringValue = MapToString(testObject.EnumStringValue);
            target.EnumReverseStringValue = MapToTestEnumDtoByName(testObject.EnumReverseStringValue);
            if (testObject.SubObject != null)
            {
                target.SubObject = MapToInheritanceSubObjectDto(testObject.SubObject);
            }
            else
            {
                target.SubObject = null;
            }
            target.DateTimeValueTargetDateOnly = global::System.DateOnly.FromDateTime(testObject.DateTimeValueTargetDateOnly);
            target.DateTimeValueTargetTimeOnly = global::System.TimeOnly.FromDateTime(testObject.DateTimeValueTargetTimeOnly);
            target.ManuallyMapped = MapManual(testObject.ManuallyMapped);
            target.ManuallyMappedModified = ModifyInt(testObject.ManuallyMappedModified);
            target.ManuallyMappedList = MapToListOfTestEnum(testObject.ManuallyMappedList);
            target.IntegerValues = OrderIntegerValues(testObject.IntegerValues);
            target.DecimalValues = OrderAndMapLongValues(testObject.DecimalValues);
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static partial global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionBaseType MapDerived(global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionBaseType source)
        {
            return source switch
            {
                global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA x => MapToTestObjectDtoProjectionTypeA(x),
                global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB x => MapToTestObjectDtoProjectionTypeB(x),
                _ => throw new System.ArgumentException($"Cannot map {source.GetType()} to Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionBaseType as there is no known derived type mapping", nameof(source)),
            };
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static partial global::Riok.Mapperly.IntegrationTests.Dto.LongValueDto MapLongValue(global::Riok.Mapperly.IntegrationTests.Models.LongValue value)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.LongValueDto();
            target.Value = value.Value;
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeA MapToTestObjectDtoProjectionTypeA(global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeA source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeA();
            target.ValueA = source.ValueA;
            target.Id = source.Id;
            target.BaseValue = source.BaseValue;
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeB MapToTestObjectDtoProjectionTypeB(global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionTypeB source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectDtoProjectionTypeB();
            target.ValueB = source.ValueB;
            target.Id = source.Id;
            target.BaseValue = source.BaseValue;
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto MapToTestObjectNestedDto(global::Riok.Mapperly.IntegrationTests.Models.TestObjectNested source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto();
            target.IntValue = source.IntValue;
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto[] MapToTestObjectNestedDtoArray(global::System.Collections.Generic.IReadOnlyCollection<global::Riok.Mapperly.IntegrationTests.Models.TestObjectNested> source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.TestObjectNestedDto[source.Count];
            var i = 0;
            foreach (var item in source)
            {
                target[i] = MapToTestObjectNestedDto(item);
                i++;
            }
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        private static string MapToString(global::Riok.Mapperly.IntegrationTests.Models.TestEnum source)
        {
            return source switch
            {
                global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value10 => nameof(global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value10),
                global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value20 => nameof(global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value20),
                global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value30 => nameof(global::Riok.Mapperly.IntegrationTests.Models.TestEnum.Value30),
                _ => source.ToString(),
            };
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        private static global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName MapToTestEnumDtoByName(string source)
        {
            return source switch
            {
                nameof(global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value10) => global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value10,
                nameof(global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value20) => global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value20,
                nameof(global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value30) => global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName.Value30,
                _ => System.Enum.Parse<global::Riok.Mapperly.IntegrationTests.Dto.TestEnumDtoByName>(source, false),
            };
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::Riok.Mapperly.IntegrationTests.Dto.InheritanceSubObjectDto MapToInheritanceSubObjectDto(global::Riok.Mapperly.IntegrationTests.Models.InheritanceSubObject source)
        {
            var target = new global::Riok.Mapperly.IntegrationTests.Dto.InheritanceSubObjectDto();
            target.SubIntValue = source.SubIntValue;
            target.BaseIntValue = source.BaseIntValue;
            return target;
        }

        [global::System.CodeDom.Compiler.GeneratedCode("Riok.Mapperly", "0.0.1.0")]
        [global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static global::System.Collections.Generic.List<global::Riok.Mapperly.IntegrationTests.Models.TestEnum> MapToListOfTestEnum(global::System.Collections.Generic.IReadOnlyCollection<global::Riok.Mapperly.IntegrationTests.Models.TestObjectProjectionEnumValue> source)
        {
            var target = new global::System.Collections.Generic.List<global::Riok.Mapperly.IntegrationTests.Models.TestEnum>(source.Count);
            foreach (var item in source)
            {
                target.Add(MapManual(item));
            }
            return target;
        }
    }
}